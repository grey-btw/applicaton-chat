namespace Application_Chat
{
    partial class ClientForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.landing = new System.Windows.Forms.Panel();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSubMenu = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnChat = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.landing.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1348, 721);
            this.panelMain.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(82, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1266, 721);
            this.panel3.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.landing);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1266, 721);
            this.mainPanel.TabIndex = 1;
            // 
            // landing
            // 
            this.landing.Controls.Add(this.btnRight);
            this.landing.Controls.Add(this.btnLeft);
            this.landing.Controls.Add(this.radioButton3);
            this.landing.Controls.Add(this.radioButton2);
            this.landing.Controls.Add(this.radioButton1);
            this.landing.Controls.Add(this.guna2Button1);
            this.landing.Controls.Add(this.panel5);
            this.landing.Controls.Add(this.guna2GradientButton1);
            this.landing.Controls.Add(this.panel4);
            this.landing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.landing.Location = new System.Drawing.Point(0, 0);
            this.landing.Name = "landing";
            this.landing.Size = new System.Drawing.Size(1266, 721);
            this.landing.TabIndex = 2;
            // 
            // btnRight
            // 
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnRight.IconColor = System.Drawing.Color.Black;
            this.btnRight.IconSize = 16;
            this.btnRight.Location = new System.Drawing.Point(953, 651);
            this.btnRight.Name = "btnRight";
            this.btnRight.Rotation = 0D;
            this.btnRight.Size = new System.Drawing.Size(20, 20);
            this.btnRight.TabIndex = 22;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnLeft.IconColor = System.Drawing.Color.Black;
            this.btnLeft.IconSize = 16;
            this.btnLeft.Location = new System.Drawing.Point(858, 651);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Rotation = 0D;
            this.btnLeft.Size = new System.Drawing.Size(20, 20);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(930, 651);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(907, 651);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(884, 651);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(254, 529);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(149, 46);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Contact";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Application_Chat.Properties.Resources.brush;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(24, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 312);
            this.panel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 156);
            this.label2.TabIndex = 14;
            this.label2.Text = "We built an app to help you have an excellent experience and convenient connect t" +
    "o your friend, your family...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Box Box";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(150)))), ((int)(((byte)(157)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(54, 529);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(158, 46);
            this.guna2GradientButton1.TabIndex = 15;
            this.guna2GradientButton1.Text = "Chat now";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Application_Chat.Properties.Resources.slide_1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(541, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 583);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2GradientPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 721);
            this.panel2.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnSubMenu);
            this.guna2GradientPanel1.Controls.Add(this.btnProfile);
            this.guna2GradientPanel1.Controls.Add(this.btnChat);
            this.guna2GradientPanel1.Controls.Add(this.btnLogOut);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(127)))), ((int)(((byte)(123)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(82, 721);
            this.guna2GradientPanel1.TabIndex = 23;
            // 
            // btnSubMenu
            // 
            this.btnSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSubMenu.FillColor = System.Drawing.Color.Black;
            this.btnSubMenu.Location = new System.Drawing.Point(6, 17);
            this.btnSubMenu.Name = "btnSubMenu";
            this.btnSubMenu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSubMenu.ShadowDecoration.Parent = this.btnSubMenu;
            this.btnSubMenu.Size = new System.Drawing.Size(70, 70);
            this.btnSubMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubMenu.TabIndex = 10;
            this.btnSubMenu.TabStop = false;
            this.btnSubMenu.UseTransparentBackground = true;
            this.btnSubMenu.Click += new System.EventHandler(this.landing_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconSize = 50;
            this.btnProfile.Location = new System.Drawing.Point(0, 132);
            this.btnProfile.MaximumSize = new System.Drawing.Size(82, 82);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Rotation = 0D;
            this.btnProfile.Size = new System.Drawing.Size(82, 82);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.TabStop = false;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.forAllButtons_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.forAllButtons_MouseLeave);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChat.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.btnChat.IconColor = System.Drawing.Color.White;
            this.btnChat.IconSize = 50;
            this.btnChat.Location = new System.Drawing.Point(0, 214);
            this.btnChat.Name = "btnChat";
            this.btnChat.Rotation = 0D;
            this.btnChat.Size = new System.Drawing.Size(82, 82);
            this.btnChat.TabIndex = 7;
            this.btnChat.TabStop = false;
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            this.btnChat.MouseEnter += new System.EventHandler(this.forAllButtons_MouseEnter);
            this.btnChat.MouseLeave += new System.EventHandler(this.forAllButtons_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconSize = 50;
            this.btnLogOut.Location = new System.Drawing.Point(0, 296);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Rotation = 0D;
            this.btnLogOut.Size = new System.Drawing.Size(82, 82);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.forAllButtons_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.forAllButtons_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.landing.ResumeLayout(false);
            this.landing.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel landing;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.RadioButton radioButton1;
        private FontAwesome.Sharp.IconButton btnRight;
        private FontAwesome.Sharp.IconButton btnLeft;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnSubMenu;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnChat;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}