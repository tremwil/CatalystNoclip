namespace CatalystNoclip
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.LinkLabel();
            this.XButton = new System.Windows.Forms.LinkLabel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SpeedCheckbox = new System.Windows.Forms.CheckBox();
            this.NCStateCheckbox = new System.Windows.Forms.CheckBox();
            this.OverlayCheckbox = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CamRightInputBox = new System.Windows.Forms.Label();
            this.CamLeftInputBox = new System.Windows.Forms.Label();
            this.UseMouseCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.NoclipSettimgs = new System.Windows.Forms.Panel();
            this.FTInputBox = new System.Windows.Forms.Label();
            this.MSInputBox = new System.Windows.Forms.Label();
            this.MFInputBox = new System.Windows.Forms.Label();
            this.RTInputBox = new System.Windows.Forms.Label();
            this.AutoNoclipCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameRunningLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpacingPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.NoclipSettimgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.ActiveLinkColor = System.Drawing.Color.Red;
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Minimize.LinkColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(229, -3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 25);
            this.Minimize.TabIndex = 2;
            this.Minimize.TabStop = true;
            this.Minimize.Text = "-";
            this.Minimize.VisitedLinkColor = System.Drawing.Color.White;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // XButton
            // 
            this.XButton.ActiveLinkColor = System.Drawing.Color.Red;
            this.XButton.AutoSize = true;
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.XButton.LinkColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(252, 2);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(21, 20);
            this.XButton.TabIndex = 1;
            this.XButton.TabStop = true;
            this.XButton.Text = "X";
            this.XButton.VisitedLinkColor = System.Drawing.Color.White;
            this.XButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.XButton_LinkClicked);
            this.XButton.MouseEnter += new System.EventHandler(this.XButton_MouseEnter);
            this.XButton.MouseLeave += new System.EventHandler(this.XButton_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(216, 13);
            this.title.TabIndex = 0;
            this.title.Text = "ME: Catalyst Noclip Tool - By tremwil";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.NoclipSettimgs);
            this.panel2.Controls.Add(this.GameRunningLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 342);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(140, 292);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(124, 31);
            this.ResetBtn.TabIndex = 13;
            this.ResetBtn.Text = "Reset Settings";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.SpeedCheckbox);
            this.panel6.Controls.Add(this.NCStateCheckbox);
            this.panel6.Controls.Add(this.OverlayCheckbox);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(142, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 109);
            this.panel6.TabIndex = 12;
            // 
            // SpeedCheckbox
            // 
            this.SpeedCheckbox.AutoSize = true;
            this.SpeedCheckbox.Checked = true;
            this.SpeedCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeedCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedCheckbox.Location = new System.Drawing.Point(6, 83);
            this.SpeedCheckbox.Name = "SpeedCheckbox";
            this.SpeedCheckbox.Size = new System.Drawing.Size(95, 19);
            this.SpeedCheckbox.TabIndex = 5;
            this.SpeedCheckbox.Text = "Show Speed";
            this.SpeedCheckbox.UseVisualStyleBackColor = true;
            this.SpeedCheckbox.CheckedChanged += new System.EventHandler(this.SpeedCheckbox_CheckedChanged);
            // 
            // NCStateCheckbox
            // 
            this.NCStateCheckbox.AutoSize = true;
            this.NCStateCheckbox.Checked = true;
            this.NCStateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NCStateCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCStateCheckbox.Location = new System.Drawing.Point(6, 58);
            this.NCStateCheckbox.Name = "NCStateCheckbox";
            this.NCStateCheckbox.Size = new System.Drawing.Size(109, 19);
            this.NCStateCheckbox.TabIndex = 4;
            this.NCStateCheckbox.Text = "Show NC State";
            this.NCStateCheckbox.UseVisualStyleBackColor = true;
            this.NCStateCheckbox.CheckedChanged += new System.EventHandler(this.NCStateCheckbox_CheckedChanged);
            // 
            // OverlayCheckbox
            // 
            this.OverlayCheckbox.AutoSize = true;
            this.OverlayCheckbox.Checked = true;
            this.OverlayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OverlayCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OverlayCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.OverlayCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverlayCheckbox.Location = new System.Drawing.Point(7, 33);
            this.OverlayCheckbox.Name = "OverlayCheckbox";
            this.OverlayCheckbox.Size = new System.Drawing.Size(108, 19);
            this.OverlayCheckbox.TabIndex = 3;
            this.OverlayCheckbox.Text = "Overlay Visible";
            this.OverlayCheckbox.UseVisualStyleBackColor = true;
            this.OverlayCheckbox.CheckedChanged += new System.EventHandler(this.OverlayCheckbox_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(-1, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 2);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(-1, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Overlay Settings";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CamRightInputBox);
            this.panel4.Controls.Add(this.CamLeftInputBox);
            this.panel4.Controls.Add(this.UseMouseCheckbox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(11, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 146);
            this.panel4.TabIndex = 11;
            // 
            // CamRightInputBox
            // 
            this.CamRightInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CamRightInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamRightInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CamRightInputBox.ForeColor = System.Drawing.Color.White;
            this.CamRightInputBox.Location = new System.Drawing.Point(6, 88);
            this.CamRightInputBox.Name = "CamRightInputBox";
            this.CamRightInputBox.Size = new System.Drawing.Size(100, 20);
            this.CamRightInputBox.TabIndex = 13;
            // 
            // CamLeftInputBox
            // 
            this.CamLeftInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CamLeftInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamLeftInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CamLeftInputBox.ForeColor = System.Drawing.Color.White;
            this.CamLeftInputBox.Location = new System.Drawing.Point(6, 47);
            this.CamLeftInputBox.Name = "CamLeftInputBox";
            this.CamLeftInputBox.Size = new System.Drawing.Size(100, 20);
            this.CamLeftInputBox.TabIndex = 11;
            // 
            // UseMouseCheckbox
            // 
            this.UseMouseCheckbox.AutoCheck = false;
            this.UseMouseCheckbox.AutoSize = true;
            this.UseMouseCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseMouseCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.UseMouseCheckbox.Location = new System.Drawing.Point(3, 114);
            this.UseMouseCheckbox.Name = "UseMouseCheckbox";
            this.UseMouseCheckbox.Size = new System.Drawing.Size(121, 19);
            this.UseMouseCheckbox.TabIndex = 6;
            this.UseMouseCheckbox.Text = "Use Mouse (WIP)";
            this.UseMouseCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Camera Right (WIP)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Camera Left (WIP)";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(-1, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 2);
            this.panel5.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(-1, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "FT Noclip Hotkeys";
            // 
            // NoclipSettimgs
            // 
            this.NoclipSettimgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NoclipSettimgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoclipSettimgs.Controls.Add(this.FTInputBox);
            this.NoclipSettimgs.Controls.Add(this.MSInputBox);
            this.NoclipSettimgs.Controls.Add(this.MFInputBox);
            this.NoclipSettimgs.Controls.Add(this.RTInputBox);
            this.NoclipSettimgs.Controls.Add(this.AutoNoclipCheckbox);
            this.NoclipSettimgs.Controls.Add(this.label6);
            this.NoclipSettimgs.Controls.Add(this.label5);
            this.NoclipSettimgs.Controls.Add(this.label4);
            this.NoclipSettimgs.Controls.Add(this.panel3);
            this.NoclipSettimgs.Controls.Add(this.label3);
            this.NoclipSettimgs.Controls.Add(this.label2);
            this.NoclipSettimgs.Location = new System.Drawing.Point(11, 39);
            this.NoclipSettimgs.Name = "NoclipSettimgs";
            this.NoclipSettimgs.Size = new System.Drawing.Size(253, 132);
            this.NoclipSettimgs.TabIndex = 2;
            // 
            // FTInputBox
            // 
            this.FTInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FTInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FTInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FTInputBox.ForeColor = System.Drawing.Color.White;
            this.FTInputBox.Location = new System.Drawing.Point(8, 82);
            this.FTInputBox.Name = "FTInputBox";
            this.FTInputBox.Size = new System.Drawing.Size(100, 20);
            this.FTInputBox.TabIndex = 10;
            // 
            // MSInputBox
            // 
            this.MSInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MSInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MSInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSInputBox.ForeColor = System.Drawing.Color.White;
            this.MSInputBox.Location = new System.Drawing.Point(137, 82);
            this.MSInputBox.Name = "MSInputBox";
            this.MSInputBox.Size = new System.Drawing.Size(100, 20);
            this.MSInputBox.TabIndex = 9;
            // 
            // MFInputBox
            // 
            this.MFInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MFInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MFInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MFInputBox.ForeColor = System.Drawing.Color.White;
            this.MFInputBox.Location = new System.Drawing.Point(137, 43);
            this.MFInputBox.Name = "MFInputBox";
            this.MFInputBox.Size = new System.Drawing.Size(100, 20);
            this.MFInputBox.TabIndex = 8;
            // 
            // RTInputBox
            // 
            this.RTInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RTInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RTInputBox.ForeColor = System.Drawing.Color.White;
            this.RTInputBox.Location = new System.Drawing.Point(7, 43);
            this.RTInputBox.Name = "RTInputBox";
            this.RTInputBox.Size = new System.Drawing.Size(100, 20);
            this.RTInputBox.TabIndex = 7;
            // 
            // AutoNoclipCheckbox
            // 
            this.AutoNoclipCheckbox.AutoSize = true;
            this.AutoNoclipCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoNoclipCheckbox.ForeColor = System.Drawing.Color.White;
            this.AutoNoclipCheckbox.Location = new System.Drawing.Point(8, 108);
            this.AutoNoclipCheckbox.Name = "AutoNoclipCheckbox";
            this.AutoNoclipCheckbox.Size = new System.Drawing.Size(199, 19);
            this.AutoNoclipCheckbox.TabIndex = 6;
            this.AutoNoclipCheckbox.Text = "Enable RT Noclip on glide glitch";
            this.AutoNoclipCheckbox.UseVisualStyleBackColor = true;
            this.AutoNoclipCheckbox.CheckedChanged += new System.EventHandler(this.AutoNoclipCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Move Slower";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Move Faster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frozen-Time Noclip";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-1, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 2);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Real-Time Noclip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "General Hotkeys";
            // 
            // GameRunningLabel
            // 
            this.GameRunningLabel.AutoSize = true;
            this.GameRunningLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameRunningLabel.ForeColor = System.Drawing.Color.Red;
            this.GameRunningLabel.Location = new System.Drawing.Point(100, 10);
            this.GameRunningLabel.Name = "GameRunningLabel";
            this.GameRunningLabel.Size = new System.Drawing.Size(99, 17);
            this.GameRunningLabel.TabIndex = 1;
            this.GameRunningLabel.Text = "NOT RUNNING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mirror\'s Edge: ";
            // 
            // SpacingPanel
            // 
            this.SpacingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpacingPanel.Location = new System.Drawing.Point(0, 23);
            this.SpacingPanel.Name = "SpacingPanel";
            this.SpacingPanel.Size = new System.Drawing.Size(280, 5);
            this.SpacingPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(280, 369);
            this.Controls.Add(this.SpacingPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MEC: Noclip";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.NoclipSettimgs.ResumeLayout(false);
            this.NoclipSettimgs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel XButton;
        private System.Windows.Forms.LinkLabel Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SpacingPanel;
        private System.Windows.Forms.Label GameRunningLabel;
        private System.Windows.Forms.Panel NoclipSettimgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AutoNoclipCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RTInputBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FTInputBox;
        private System.Windows.Forms.Label MSInputBox;
        private System.Windows.Forms.Label MFInputBox;
        private System.Windows.Forms.CheckBox OverlayCheckbox;
        private System.Windows.Forms.CheckBox SpeedCheckbox;
        private System.Windows.Forms.CheckBox NCStateCheckbox;
        private System.Windows.Forms.CheckBox UseMouseCheckbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CamRightInputBox;
        private System.Windows.Forms.Label CamLeftInputBox;
        private System.Windows.Forms.Button ResetBtn;
    }
}

