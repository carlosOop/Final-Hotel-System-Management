namespace WindowsFormsApp1
{
    partial class DASHBOARD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTItle = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.BtnManage = new Guna.UI2.WinForms.Guna2Button();
            this.movingpanel = new System.Windows.Forms.Panel();
            this.BtnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControl11 = new WindowsFormsApp1.User_Control.UserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 858);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.movingpanel);
            this.panel2.Controls.Add(this.BtnManage);
            this.panel2.Controls.Add(this.BtnCheckout);
            this.panel2.Controls.Add(this.BtnRegistration);
            this.panel2.Controls.Add(this.BtnHistory);
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Controls.Add(this.BtnTItle);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1656, 130);
            this.panel2.TabIndex = 1;
            // 
            // BtnTItle
            // 
            this.BtnTItle.BorderColor = System.Drawing.Color.Transparent;
            this.BtnTItle.BorderRadius = 26;
            this.BtnTItle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnTItle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnTItle.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnTItle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTItle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTItle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTItle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTItle.FillColor = System.Drawing.Color.Empty;
            this.BtnTItle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTItle.ForeColor = System.Drawing.Color.Black;
            this.BtnTItle.Location = new System.Drawing.Point(22, 26);
            this.BtnTItle.Name = "BtnTItle";
            this.BtnTItle.PressedColor = System.Drawing.Color.Azure;
            this.BtnTItle.Size = new System.Drawing.Size(411, 73);
            this.BtnTItle.TabIndex = 0;
            this.BtnTItle.Text = "EASY HOTEL BOOKING SYSTEM";
            this.BtnTItle.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BorderRadius = 26;
            this.BtnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHome.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.BtnHome.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHome.FillColor = System.Drawing.Color.Empty;
            this.BtnHome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Location = new System.Drawing.Point(678, 26);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(120, 73);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.BorderRadius = 26;
            this.BtnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnHistory.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnHistory.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHistory.FillColor = System.Drawing.Color.Empty;
            this.BtnHistory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistory.ForeColor = System.Drawing.Color.Black;
            this.BtnHistory.Location = new System.Drawing.Point(825, 26);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(121, 73);
            this.BtnHistory.TabIndex = 2;
            this.BtnHistory.Text = "History";
            this.BtnHistory.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.BorderRadius = 26;
            this.BtnRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnRegistration.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRegistration.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegistration.FillColor = System.Drawing.Color.Empty;
            this.BtnRegistration.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistration.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistration.Location = new System.Drawing.Point(1158, 26);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(232, 73);
            this.BtnRegistration.TabIndex = 2;
            this.BtnRegistration.Text = "Custumer Registration";
            this.BtnRegistration.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.BorderColor = System.Drawing.Color.Empty;
            this.BtnCheckout.BorderRadius = 26;
            this.BtnCheckout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BtnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCheckout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCheckout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCheckout.FillColor = System.Drawing.Color.Empty;
            this.BtnCheckout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckout.Location = new System.Drawing.Point(1420, 26);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(143, 73);
            this.BtnCheckout.TabIndex = 4;
            this.BtnCheckout.Text = "Check out";
            this.BtnCheckout.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // BtnManage
            // 
            this.BtnManage.BorderRadius = 26;
            this.BtnManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnManage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnManage.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.BtnManage.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnManage.FillColor = System.Drawing.Color.Empty;
            this.BtnManage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManage.ForeColor = System.Drawing.Color.Black;
            this.BtnManage.Location = new System.Drawing.Point(969, 26);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(154, 73);
            this.BtnManage.TabIndex = 5;
            this.BtnManage.Text = "Manage";
            this.BtnManage.Click += new System.EventHandler(this.guna2Button4_Click_1);
            // 
            // movingpanel
            // 
            this.movingpanel.BackColor = System.Drawing.Color.White;
            this.movingpanel.Location = new System.Drawing.Point(165, 105);
            this.movingpanel.Name = "movingpanel";
            this.movingpanel.Size = new System.Drawing.Size(100, 5);
            this.movingpanel.TabIndex = 5;
            this.movingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.movingpanel_Paint);
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.Empty;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnExit.Location = new System.Drawing.Point(1584, -2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(70, 49);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinimize.FillColor = System.Drawing.Color.Empty;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMinimize.Location = new System.Drawing.Point(1584, 50);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnMinimize.Size = new System.Drawing.Size(70, 49);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.Window;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.userControl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1700, 862);
            this.userControl11.TabIndex = 0;
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DASHBOARD_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnTItle;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2Button BtnHistory;
        private Guna.UI2.WinForms.Guna2Button BtnCheckout;
        private Guna.UI2.WinForms.Guna2Button BtnRegistration;
        private Guna.UI2.WinForms.Guna2Button BtnManage;
        private System.Windows.Forms.Panel movingpanel;
        private Guna.UI2.WinForms.Guna2CircleButton BtnExit;
        private Guna.UI2.WinForms.Guna2CircleButton BtnMinimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private User_Control.UserControl1 userControl11;
    }
}