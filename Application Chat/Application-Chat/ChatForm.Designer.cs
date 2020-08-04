namespace Application_Chat
{
    partial class ChatForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.subpanel = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnOption = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textJoin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnJoin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDescriptionSend = new System.Windows.Forms.Label();
            this.labelDescriptionAddFile = new System.Windows.Forms.Label();
            this.btnAddFile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textboxMessage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCall = new FontAwesome.Sharp.IconButton();
            this.btnVideo = new FontAwesome.Sharp.IconButton();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.roomIdHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeader = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.nameRoomHeader = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCreateJoin = new FontAwesome.Sharp.IconButton();
            this.btnLeave = new FontAwesome.Sharp.IconButton();
            this.subSetting = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            this.panel5.SuspendLayout();
            this.subSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelMain);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(325, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(903, 507);
            this.panel6.TabIndex = 19;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panelMain.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.subpanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(903, 507);
            this.panelMain.TabIndex = 15;
            // 
            // subpanel
            // 
            this.subpanel.AutoSize = true;
            this.subpanel.Location = new System.Drawing.Point(0, 0);
            this.subpanel.Name = "subpanel";
            this.subpanel.Size = new System.Drawing.Size(868, 507);
            this.subpanel.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnOption);
            this.panelTop.Controls.Add(this.textJoin);
            this.panelTop.Controls.Add(this.btnJoin);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(325, 124);
            this.panelTop.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.Image = global::Application_Chat.Properties.Resources.settings;
            this.btnOption.InitialImage = null;
            this.btnOption.Location = new System.Drawing.Point(234, 7);
            this.btnOption.Name = "btnOption";
            this.btnOption.ShadowDecoration.Parent = this.btnOption;
            this.btnOption.Size = new System.Drawing.Size(50, 54);
            this.btnOption.TabIndex = 1;
            this.btnOption.TabStop = false;
            this.btnOption.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // textJoin
            // 
            this.textJoin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textJoin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textJoin.HintForeColor = System.Drawing.Color.Empty;
            this.textJoin.HintText = "";
            this.textJoin.isPassword = false;
            this.textJoin.LineFocusedColor = System.Drawing.Color.Red;
            this.textJoin.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textJoin.LineMouseHoverColor = System.Drawing.Color.Red;
            this.textJoin.LineThickness = 3;
            this.textJoin.Location = new System.Drawing.Point(13, 73);
            this.textJoin.Margin = new System.Windows.Forms.Padding(4);
            this.textJoin.Name = "textJoin";
            this.textJoin.Size = new System.Drawing.Size(183, 44);
            this.textJoin.TabIndex = 2;
            this.textJoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textJoin.Click += new System.EventHandler(this.textJoin_Click);
            this.textJoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textJoin_KeyDown);
            // 
            // btnJoin
            // 
            this.btnJoin.BorderColor = System.Drawing.Color.Transparent;
            this.btnJoin.BorderRadius = 5;
            this.btnJoin.BorderThickness = 1;
            this.btnJoin.CheckedState.Parent = this.btnJoin;
            this.btnJoin.CustomImages.Parent = this.btnJoin;
            this.btnJoin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.HoverState.Parent = this.btnJoin;
            this.btnJoin.Location = new System.Drawing.Point(219, 73);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.ShadowDecoration.Parent = this.btnJoin;
            this.btnJoin.Size = new System.Drawing.Size(83, 44);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join";
            this.btnJoin.Click += new System.EventHandler(this.btnCreateJoinRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 674);
            this.panel1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSidebar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 550);
            this.panel4.TabIndex = 1;
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.subSetting);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(325, 550);
            this.panelSidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelDescriptionSend);
            this.panel2.Controls.Add(this.labelDescriptionAddFile);
            this.panel2.Controls.Add(this.btnAddFile);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.textboxMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 100);
            this.panel2.TabIndex = 2;
            // 
            // labelDescriptionSend
            // 
            this.labelDescriptionSend.AutoSize = true;
            this.labelDescriptionSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescriptionSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescriptionSend.Location = new System.Drawing.Point(830, 63);
            this.labelDescriptionSend.Name = "labelDescriptionSend";
            this.labelDescriptionSend.Padding = new System.Windows.Forms.Padding(3);
            this.labelDescriptionSend.Size = new System.Drawing.Size(50, 28);
            this.labelDescriptionSend.TabIndex = 7;
            this.labelDescriptionSend.Text = "Send";
            this.labelDescriptionSend.Visible = false;
            // 
            // labelDescriptionAddFile
            // 
            this.labelDescriptionAddFile.AutoSize = true;
            this.labelDescriptionAddFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescriptionAddFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescriptionAddFile.Location = new System.Drawing.Point(758, 63);
            this.labelDescriptionAddFile.Name = "labelDescriptionAddFile";
            this.labelDescriptionAddFile.Padding = new System.Windows.Forms.Padding(3);
            this.labelDescriptionAddFile.Size = new System.Drawing.Size(70, 28);
            this.labelDescriptionAddFile.TabIndex = 0;
            this.labelDescriptionAddFile.Text = "Add file";
            this.labelDescriptionAddFile.Visible = false;
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFile.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddFile.CheckedState.Parent = this.btnAddFile;
            this.btnAddFile.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddFile.HoverState.Parent = this.btnAddFile;
            this.btnAddFile.Image = global::Application_Chat.Properties.Resources.export;
            this.btnAddFile.ImageRotate = 0F;
            this.btnAddFile.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddFile.Location = new System.Drawing.Point(737, 31);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddFile.PressedState.Parent = this.btnAddFile;
            this.btnAddFile.Size = new System.Drawing.Size(40, 40);
            this.btnAddFile.TabIndex = 6;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            this.btnAddFile.MouseLeave += new System.EventHandler(this.btnAddFile_MouseLeave);
            this.btnAddFile.MouseHover += new System.EventHandler(this.btnAddFile_MouseHover);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.CheckedState.Parent = this.btnSend;
            this.btnSend.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.HoverState.Parent = this.btnSend;
            this.btnSend.Image = global::Application_Chat.Properties.Resources.send1;
            this.btnSend.ImageRotate = 0F;
            this.btnSend.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.Location = new System.Drawing.Point(811, 33);
            this.btnSend.Name = "btnSend";
            this.btnSend.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.PressedState.Parent = this.btnSend;
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Click += new System.EventHandler(this.sendMessage);
            this.btnSend.MouseLeave += new System.EventHandler(this.btnSend_MouseLeave);
            this.btnSend.MouseHover += new System.EventHandler(this.btnSend_MouseHover);
            // 
            // textboxMessage
            // 
            this.textboxMessage.AutoSize = true;
            this.textboxMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textboxMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textboxMessage.ForeColor = System.Drawing.Color.Black;
            this.textboxMessage.HintForeColor = System.Drawing.Color.Empty;
            this.textboxMessage.HintText = "";
            this.textboxMessage.isPassword = false;
            this.textboxMessage.LineFocusedColor = System.Drawing.Color.Red;
            this.textboxMessage.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textboxMessage.LineMouseHoverColor = System.Drawing.Color.Red;
            this.textboxMessage.LineThickness = 3;
            this.textboxMessage.Location = new System.Drawing.Point(30, 33);
            this.textboxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxMessage.Name = "textboxMessage";
            this.textboxMessage.Size = new System.Drawing.Size(673, 38);
            this.textboxMessage.TabIndex = 4;
            this.textboxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxMessage_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(325, 574);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 100);
            this.panel3.TabIndex = 17;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnCall);
            this.panelHeader.Controls.Add(this.btnVideo);
            this.panelHeader.Controls.Add(this.btnInformation);
            this.panelHeader.Controls.Add(this.roomIdHeader);
            this.panelHeader.Controls.Add(this.pictureBoxHeader);
            this.panelHeader.Controls.Add(this.nameRoomHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(903, 67);
            this.panelHeader.TabIndex = 13;
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.FlatAppearance.BorderSize = 0;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCall.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.btnCall.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCall.IconSize = 50;
            this.btnCall.Location = new System.Drawing.Point(727, 10);
            this.btnCall.Name = "btnCall";
            this.btnCall.Rotation = 0D;
            this.btnCall.Size = new System.Drawing.Size(50, 50);
            this.btnCall.TabIndex = 6;
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVideo.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnVideo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVideo.IconSize = 50;
            this.btnVideo.Location = new System.Drawing.Point(785, 10);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Rotation = 0D;
            this.btnVideo.Size = new System.Drawing.Size(50, 50);
            this.btnVideo.TabIndex = 5;
            this.btnVideo.UseVisualStyleBackColor = false;
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInformation.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInformation.IconSize = 50;
            this.btnInformation.Location = new System.Drawing.Point(841, 10);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Rotation = 0D;
            this.btnInformation.Size = new System.Drawing.Size(50, 50);
            this.btnInformation.TabIndex = 4;
            this.btnInformation.UseVisualStyleBackColor = true;
            // 
            // roomIdHeader
            // 
            this.roomIdHeader.AutoSize = true;
            this.roomIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomIdHeader.Location = new System.Drawing.Point(93, 38);
            this.roomIdHeader.Name = "roomIdHeader";
            this.roomIdHeader.Size = new System.Drawing.Size(74, 23);
            this.roomIdHeader.TabIndex = 3;
            this.roomIdHeader.Text = "[000000]";
            // 
            // pictureBoxHeader
            // 
            this.pictureBoxHeader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeader.Location = new System.Drawing.Point(30, 6);
            this.pictureBoxHeader.Name = "pictureBoxHeader";
            this.pictureBoxHeader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxHeader.ShadowDecoration.Parent = this.pictureBoxHeader;
            this.pictureBoxHeader.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxHeader.TabIndex = 2;
            this.pictureBoxHeader.TabStop = false;
            // 
            // nameRoomHeader
            // 
            this.nameRoomHeader.AutoSize = true;
            this.nameRoomHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nameRoomHeader.Location = new System.Drawing.Point(91, 6);
            this.nameRoomHeader.Name = "nameRoomHeader";
            this.nameRoomHeader.Size = new System.Drawing.Size(114, 32);
            this.nameRoomHeader.TabIndex = 1;
            this.nameRoomHeader.Text = "Welcome";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelHeader);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(325, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(903, 67);
            this.panel5.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(325, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 507);
            this.panel7.TabIndex = 20;
            // 
            // btnCreateJoin
            // 
            this.btnCreateJoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateJoin.FlatAppearance.BorderSize = 0;
            this.btnCreateJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateJoin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreateJoin.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnCreateJoin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateJoin.IconSize = 50;
            this.btnCreateJoin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateJoin.Location = new System.Drawing.Point(0, 0);
            this.btnCreateJoin.Name = "btnCreateJoin";
            this.btnCreateJoin.Rotation = 0D;
            this.btnCreateJoin.Size = new System.Drawing.Size(249, 70);
            this.btnCreateJoin.TabIndex = 0;
            this.btnCreateJoin.Text = "Create/join room";
            this.btnCreateJoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateJoin.UseVisualStyleBackColor = true;
            this.btnCreateJoin.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLeave.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.btnLeave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeave.IconSize = 50;
            this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.Location = new System.Drawing.Point(0, 70);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Rotation = 0D;
            this.btnLeave.Size = new System.Drawing.Size(249, 70);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "Leave room";
            this.btnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // subSetting
            // 
            this.subSetting.BackColor = System.Drawing.Color.Transparent;
            this.subSetting.Controls.Add(this.btnLeave);
            this.subSetting.Controls.Add(this.btnCreateJoin);
            this.subSetting.Location = new System.Drawing.Point(76, 0);
            this.subSetting.Name = "subSetting";
            this.subSetting.Size = new System.Drawing.Size(249, 151);
            this.subSetting.TabIndex = 0;
            this.subSetting.Visible = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 674);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatForm";
            this.Opacity = 0.5D;
            this.Text = "ChatForm";
            this.panel6.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            this.panel5.ResumeLayout(false);
            this.subSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel subpanel;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2PictureBox btnOption;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textJoin;
        private Guna.UI2.WinForms.Guna2Button btnJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDescriptionSend;
        private System.Windows.Forms.Label labelDescriptionAddFile;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddFile;
        private Guna.UI2.WinForms.Guna2ImageButton btnSend;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label roomIdHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxHeader;
        private System.Windows.Forms.Label nameRoomHeader;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnCall;
        private FontAwesome.Sharp.IconButton btnVideo;
        private FontAwesome.Sharp.IconButton btnInformation;
        private System.Windows.Forms.Panel subSetting;
        private FontAwesome.Sharp.IconButton btnLeave;
        private FontAwesome.Sharp.IconButton btnCreateJoin;
    }
}

