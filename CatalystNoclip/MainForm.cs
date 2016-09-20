using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Catalyst;
using Catalyst.Memory;
using Catalyst.Input;
using Catalyst.Display;

namespace CatalystNoclip
{
    public partial class MainForm : Form
    {
        // Enable drop shadows
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        Label boxToUpdate;
        string updateParamName;

        System.Windows.Forms.Timer mainNoclipLoop;
        Action noclipMoveLoop;
        bool gameIsRunning;
        bool gameIsLoading;
        MemoryManager memory;
        PlayerInfo pinfo;
        GameInfo ginfo;
        string noclipDisplayState;
        string speedDisplayState;

        bool noclipOn;
        bool noclipFT;
        bool allowAutoNC;

        Vec3 pos;
        Vec3 lastpos;
        Vec3 velocity;
        int speed;

        public MainForm()
        {
            boxToUpdate = null;

            noclipOn = false;
            noclipFT = false;
            allowAutoNC = false;

            lastpos = Vec3.Zero;
            velocity = Vec3.Zero;
            pos = Vec3.Zero;
            speed = 50;

            gameIsRunning = Process.GetProcessesByName("MirrorsEdgeCatalyst").Length == 0;
            gameIsLoading = false;

            noclipMoveLoop = new Action(NoclipMovementTask);
            mainNoclipLoop = new System.Windows.Forms.Timer();
            mainNoclipLoop.Interval = 50;
            mainNoclipLoop.Tick += NonCriticalLoop;

            memory = new MemoryManager();
            pinfo = new PlayerInfo(memory);
            ginfo = new GameInfo(memory);

            noclipDisplayState = "NOCLIP OFF";
            speedDisplayState = "SPEED: 50";
            Overlay.AddAutoField("ncstate", () => Properties.Settings.Default.ShowNCState ? noclipDisplayState : "");
            Overlay.AddAutoField("speed", () => Properties.Settings.Default.ShowSpeed ? speedDisplayState : "");

            InitializeComponent();
        }

        private void UpdateSettings()
        {
            RTInputBox.Text = ((DIKCode)Properties.Settings.Default.ToggleNC).ToString();
            FTInputBox.Text = ((DIKCode)Properties.Settings.Default.SwitchNCMode).ToString();
            MFInputBox.Text = ((DIKCode)Properties.Settings.Default.FasterHotkey).ToString();
            MSInputBox.Text = ((DIKCode)Properties.Settings.Default.SlowerHotkey).ToString();
            AutoNoclipCheckbox.Checked = Properties.Settings.Default.AutoNoclip;

            OverlayCheckbox.Checked = Properties.Settings.Default.ShowOverlay;
            NCStateCheckbox.Checked = Properties.Settings.Default.ShowNCState;
            SpeedCheckbox.Checked = Properties.Settings.Default.ShowSpeed;

            CamLeftInputBox.Text = ((DIKCode)Properties.Settings.Default.FTCamLeft).ToString();
            CamRightInputBox.Text = ((DIKCode)Properties.Settings.Default.FTCamRight).ToString();
            UseMouseCheckbox.Checked = Properties.Settings.Default.UseMouseForFT;
        }

        private void NonCriticalLoop(object sender, EventArgs e)
        {
            if (boxToUpdate != null)
            {
                var keys = InputController.GetPressedKeys();
                if (keys.Length == 0) return;

                var key = keys[0];
                if (key == DIKCode.ESCAPE) // ESC to cancel
                    key = (DIKCode)Properties.Settings.Default[updateParamName];

                Properties.Settings.Default[updateParamName] = (int)key;
                Properties.Settings.Default.Save();
                boxToUpdate.Text = key.ToString();
                boxToUpdate = null;

                InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
                return;
            }

            var p = Process.GetProcessesByName("MirrorsEdgeCatalyst");
            if (p.Length == 0 && gameIsRunning)
            {
                gameIsRunning = false;
                Overlay.Displaying = false;
                memory.ReleaseProcess();

                GameRunningLabel.Text = "NOT RUNNING";
                GameRunningLabel.ForeColor = Color.Red;
            }
            else if (p.Length != 0)
            {
                bool lastIter = false;

                if (!gameIsRunning)
                {
                    gameIsRunning = true;
                    memory.OpenProcess("MirrorsEdgeCatalyst");
                    Overlay.Displaying = true;
                    lastIter = true;
                }

                bool loading = false;
                try
                {
                    loading = ginfo.IsLoading();
                }
                catch (Exception)
                {
                    loading = true;
                }

                if (loading && (!gameIsLoading || lastIter))
                {
                    ginfo.SetTimescale(1); // Lets not get stuck in a loading screen
                    gameIsLoading = true;
                    GameRunningLabel.ForeColor = Color.Goldenrod;
                    GameRunningLabel.Text = "LOADING";

                    noclipOn = false;
                    noclipFT = false;

                    noclipDisplayState = "NOCLIP OFF";
                }
                else if (!loading && (gameIsLoading || lastIter))
                {
                    gameIsLoading = false;
                    GameRunningLabel.ForeColor = Color.Green;
                    GameRunningLabel.Text = "RUNNING";
                }

                if (!gameIsLoading)
                {
                    NoclipToggleLoop();
                }
            }
        }

        private void NoclipToggleLoop()
        {
            DIKCode rtoggle = (DIKCode)Properties.Settings.Default.ToggleNC;
            DIKCode ftoggle = (DIKCode)Properties.Settings.Default.SwitchNCMode;
            DIKCode speedu = (DIKCode)Properties.Settings.Default.FasterHotkey;
            DIKCode speedd = (DIKCode)Properties.Settings.Default.SlowerHotkey;

            if (!noclipOn)
            {
                pos = pinfo.GetPosition();
                velocity = (pos - lastpos) * 15;
                lastpos = pos;

                var mstate = pinfo.GetMovementState();
                if (mstate != MovementState.Crouching)
                    allowAutoNC = true;

                else if (
                    Properties.Settings.Default.AutoNoclip && 
                    allowAutoNC && 
                    Math.Abs(velocity.y + 2.45) < 0.1)
                {
                    allowAutoNC = false;
                    InputController.SetToggledFlag(rtoggle, true);
                }
            }

            if (InputController.IsKeyToggled(rtoggle) && !noclipOn) 
            {
                noclipOn = true;
                noclipDisplayState = "NOCLIP ON [RT]";
            }
            if (!InputController.IsKeyToggled(rtoggle) && noclipOn)
            {
                if (noclipFT)
                {
                    ginfo.SetTimescale(1);
                    noclipFT = false;
                }
                noclipOn = false;
                noclipDisplayState = "NOCLIP OFF";
            }
            if (InputController.OnKeyDown(ftoggle))
            {
                if (!noclipOn)
                {
                    noclipOn = true;
                    InputController.SetToggledFlag(rtoggle, true);
                }

                if (noclipFT)
                {
                    ginfo.SetTimescale(1);
                    noclipFT = false;
                    noclipDisplayState = "NOCLIP ON [RT]";
                }
                else
                {
                    ginfo.SetTimescale(0);
                    noclipFT = true;
                    noclipDisplayState = "NOCLIP ON [FT]";
                }
            }

            if (InputController.OnKeyDown(speedu))
            {
                speed += 25;
                speedDisplayState = "SPEED:" + speed.ToString();
            }
            if (InputController.OnKeyDown(speedd))
            {
                if (speed > 25) speed -= 25;
                speedDisplayState = "SPEED:" + speed.ToString();
            }
        }

        public void NoclipMovementTask()
        {
            Stopwatch w = new Stopwatch();
            w.Start();

            long ct;
            long lt = 0;
            long dt;
            long freq = Stopwatch.Frequency;

            while (true)
            {
                ct = w.ElapsedTicks;
                dt = ct - lt;
                lt = ct;

                if (noclipOn)
                {
                    Vec3 dpos = Vec3.Zero;
                    Vec3 yawv = pinfo.GetCameraYawVector();

                    if (InputController.IsGameActionPressed(GameAction.MoveForward))
                        dpos += yawv;
                    if (InputController.IsGameActionPressed(GameAction.MoveBackward))
                        dpos -= yawv;
                    if (InputController.IsGameActionPressed(GameAction.MoveLeft))
                        dpos += yawv.Left;
                    if (InputController.IsGameActionPressed(GameAction.MoveRight))
                        dpos += yawv.Right;
                    if (InputController.IsGameActionPressed(GameAction.Jump))
                        dpos += Vec3.AxisY;
                    if (InputController.IsGameActionPressed(GameAction.DownActions))
                        dpos -= Vec3.AxisY;

                    pos += dpos * speed * dt / freq;
                    pinfo.SetPosition(pos);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RTInputBox.Click += (o, s) => SetHotkey(RTInputBox, "ToggleNC");
            FTInputBox.Click += (o, s) => SetHotkey(FTInputBox, "SwitchNCMode");
            MFInputBox.Click += (o, s) => SetHotkey(MFInputBox, "FasterHotkey");
            MSInputBox.Click += (o, s) => SetHotkey(MSInputBox, "SlowerHotkey");
            CamLeftInputBox.Click += (o, s) => SetHotkey(CamLeftInputBox, "FTCamLeft");
            CamRightInputBox.Click += (o, s) => SetHotkey(CamRightInputBox, "FTCamRight");

            Task.Run(noclipMoveLoop);
            mainNoclipLoop.Start();
            UpdateSettings();
            InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
            InputController.EnableInputHook();

            Overlay.Enable(true);
        }

        private void XButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* For some reason the process refuses to close unless I force quit */
            ForceClose();
        }

        private void ForceClose()
        {
            mainNoclipLoop.Stop();

            Overlay.Disable();
            InputController.DisableInputHook();
            memory.ReleaseProcess();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C taskkill /F /IM CatalystNoclip.exe";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void XButton_MouseEnter(object sender, EventArgs e)
        {
            XButton.LinkColor = Color.Red;
        }

        private void XButton_MouseLeave(object sender, EventArgs e)
        {
            XButton.LinkColor = Color.White;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.LinkColor = ForeColor;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.LinkColor = Color.White;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region enable dragging on borderless form

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        #region settings & hotkeys

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.ToggleNC = 59;
            Properties.Settings.Default.SwitchNCMode = 60;
            Properties.Settings.Default.FasterHotkey = 200;
            Properties.Settings.Default.SlowerHotkey = 208;
            Properties.Settings.Default.AutoNoclip = false;
            Properties.Settings.Default.FTCamLeft = 203;
            Properties.Settings.Default.FTCamRight = 205;
            Properties.Settings.Default.ShowOverlay = true;
            Properties.Settings.Default.ShowNCState = true;
            Properties.Settings.Default.ShowSpeed = true;
            Properties.Settings.Default.UseMouseForFT = false;
            Properties.Settings.Default.Save();

            UpdateSettings();
        }

        private void SetHotkey(Label box, string paramName)
        {
            if (boxToUpdate != null)
            {
                if (boxToUpdate == box) { return; }
                boxToUpdate.Text = ((DIKCode)Properties.Settings.Default[updateParamName]).ToString();
            }

            InputController.MakeProcessSpecific("CatalystNoclip");

            box.Text = "Press a key...";
            boxToUpdate = box;
            updateParamName = paramName;
        }

        private void CancelSetHotkey()
        {
            if (boxToUpdate == null) return;

            boxToUpdate.Text = ((DIKCode)Properties.Settings.Default[updateParamName]).ToString();
            boxToUpdate = null;

            InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            CancelSetHotkey();
        }

        #endregion

        #region checkboxes

        private void AutoNoclipCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.AutoNoclip = AutoNoclipCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void OverlayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CancelSetHotkey();

            SpeedCheckbox.Checked = OverlayCheckbox.Checked;
            SpeedCheckbox.AutoCheck = OverlayCheckbox.Checked;
            SpeedCheckbox.ForeColor = OverlayCheckbox.Checked ? Color.White : Color.DimGray;
            NCStateCheckbox.Checked = OverlayCheckbox.Checked;
            NCStateCheckbox.AutoCheck = OverlayCheckbox.Checked;
            NCStateCheckbox.ForeColor = OverlayCheckbox.Checked ? Color.White : Color.DimGray;

            Properties.Settings.Default.ShowNCState = OverlayCheckbox.Checked;
            Properties.Settings.Default.ShowSpeed = OverlayCheckbox.Checked;
            Properties.Settings.Default.ShowOverlay = OverlayCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void NCStateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.ShowNCState = NCStateCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void SpeedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.ShowSpeed = SpeedCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
