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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.title.Size = new System.Drawing.Size(220, 13);
            this.title.TabIndex = 0;
            this.title.Text = "ME: Catalyst Noclip Tool - By Tremwil";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 355);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(280, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MEC: Noclip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel XButton;
        private System.Windows.Forms.LinkLabel Minimize;
        private System.Windows.Forms.Panel panel2;
    }
}

