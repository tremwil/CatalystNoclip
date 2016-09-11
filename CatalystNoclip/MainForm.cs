using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        Timer mainNoclipLoop;
        bool gameIsRunning;
        bool gameIsLoading;
        MemoryManager memory;
        PlayerInfo pinfo;
        GameInfo ginfo;
        string overlayDisplayState;
        string speedDisplayState;

        public MainForm()
        {
            boxToUpdate = null;

            gameIsRunning = Process.GetProcessesByName("MirrorsEdgeCatalyst").Length == 0;
            gameIsLoading = false;

            mainNoclipLoop = new Timer();
            mainNoclipLoop.Interval = 10;
            mainNoclipLoop.Tick += GameIndicatorUpdate_Tick;

            memory = new MemoryManager();
            pinfo = new PlayerInfo(memory);
            ginfo = new GameInfo(memory);

            overlayDisplayState = "";
            speedDisplayState = "";
            Overlay.AddAutoField("ostate", () => overlayDisplayState);
            Overlay.AddAutoField("speed", () => speedDisplayState);

            InitializeComponent();
        }

        private void UpdateSettings()
        {
            RTInputBox.Text = ((DIKCode)Properties.Settings.Default.RTHotkey).ToString();
            FTInputBox.Text = ((DIKCode)Properties.Settings.Default.FTHotkey).ToString();
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

        private void GameIndicatorUpdate_Tick(object sender, EventArgs e)
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
                Overlay.Disable();
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
                    Overlay.Enable(true);
                    lastIter = true;
                }

                bool loading;
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
                    gameIsLoading = true;
                    GameRunningLabel.ForeColor = Color.Goldenrod;
                    GameRunningLabel.Text = "LOADING";
                }
                else if (!loading && (gameIsLoading || lastIter))
                {
                    gameIsLoading = false;
                    GameRunningLabel.ForeColor = Color.Green;
                    GameRunningLabel.Text = "RUNNING";
                }

                if (!gameIsLoading)
                {
                    Properties.Settings.Default.ShowNCState = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RTInputBox.Click += (o, s) => SetHotkey(RTInputBox, "RTHotkey");
            FTInputBox.Click += (o, s) => SetHotkey(FTInputBox, "FTHotkey");
            MFInputBox.Click += (o, s) => SetHotkey(MFInputBox, "FasterHotkey");
            MSInputBox.Click += (o, s) => SetHotkey(MSInputBox, "SlowerHotkey");
            CamLeftInputBox.Click += (o, s) => SetHotkey(CamLeftInputBox, "FTCamLeft");
            CamRightInputBox.Click += (o, s) => SetHotkey(CamRightInputBox, "FTCamRight");

            mainNoclipLoop.Start();
            UpdateSettings();
            InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
            InputController.EnableInputHook();
        }

        private void XButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* For some reason the process refuses to close unless I force quit */
            ForceClose();
        }

        private void ForceClose()
        {
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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RTHotkey = 59;
            Properties.Settings.Default.FTHotkey = 60;
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
    }
}
