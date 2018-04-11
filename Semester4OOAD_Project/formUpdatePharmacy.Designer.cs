﻿namespace Semester4OOAD_Project
{
    partial class formUpdatePharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdatePharmacy));
            this.textBoxAdress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModify = new Bunifu.Framework.UI.BunifuTileButton();
            this.modifydp = new PictureBoxAbouAmmar.صورة_دائرة();
            this.dropDrownSecretQ = new Bunifu.Framework.UI.BunifuDropdown();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxSec = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxConfirmPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifydp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAdress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAdress.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxAdress.HintText = "Enter adress";
            this.textBoxAdress.isPassword = false;
            this.textBoxAdress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxAdress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAdress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAdress.LineThickness = 1;
            this.textBoxAdress.Location = new System.Drawing.Point(53, 292);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(290, 33);
            this.textBoxAdress.TabIndex = 4;
            this.textBoxAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Grab Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(614, 43);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(308, 378);
            this.gMapControl1.TabIndex = 53;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(515, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 52;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(230)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Choose Image";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(385, 292);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(156, 41);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnModify.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnModify.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Image = null;
            this.btnModify.ImagePosition = 20;
            this.btnModify.ImageZoom = 50;
            this.btnModify.LabelPosition = 41;
            this.btnModify.LabelText = "Update Profile";
            this.btnModify.Location = new System.Drawing.Point(53, 406);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(488, 55);
            this.btnModify.TabIndex = 8;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // modifydp
            // 
            this.modifydp.BackColor = System.Drawing.Color.DarkGray;
            this.modifydp.Location = new System.Drawing.Point(385, 131);
            this.modifydp.Name = "modifydp";
            this.modifydp.Size = new System.Drawing.Size(156, 145);
            this.modifydp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifydp.TabIndex = 49;
            this.modifydp.TabStop = false;
            // 
            // dropDrownSecretQ
            // 
            this.dropDrownSecretQ.AutoSize = true;
            this.dropDrownSecretQ.BackColor = System.Drawing.Color.White;
            this.dropDrownSecretQ.BorderRadius = 3;
            this.dropDrownSecretQ.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropDrownSecretQ.ForeColor = System.Drawing.Color.White;
            this.dropDrownSecretQ.Items = new string[] {
        "Birth place",
        "Favourite color",
        "Mother birth place",
        "Name of first pet"};
            this.dropDrownSecretQ.Location = new System.Drawing.Point(53, 349);
            this.dropDrownSecretQ.Name = "dropDrownSecretQ";
            this.dropDrownSecretQ.NomalColor = System.Drawing.Color.Silver;
            this.dropDrownSecretQ.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropDrownSecretQ.selectedIndex = -1;
            this.dropDrownSecretQ.Size = new System.Drawing.Size(154, 33);
            this.dropDrownSecretQ.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxName.HintText = "Enter your name";
            this.textBoxName.isPassword = false;
            this.textBoxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxName.LineThickness = 1;
            this.textBoxName.Location = new System.Drawing.Point(53, 116);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(290, 33);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.OnValueChanged += new System.EventHandler(this.textBoxName_OnValueChanged);
            // 
            // textBoxSec
            // 
            this.textBoxSec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSec.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSec.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxSec.HintText = "Secret answer";
            this.textBoxSec.isPassword = false;
            this.textBoxSec.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxSec.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxSec.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxSec.LineThickness = 1;
            this.textBoxSec.Location = new System.Drawing.Point(214, 349);
            this.textBoxSec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(129, 33);
            this.textBoxSec.TabIndex = 6;
            this.textBoxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxNumber.HintText = "Enter your mobile number";
            this.textBoxNumber.isPassword = false;
            this.textBoxNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxNumber.LineThickness = 1;
            this.textBoxNumber.Location = new System.Drawing.Point(53, 243);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(290, 33);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConfirmPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxConfirmPass.HintText = "Confirm pass";
            this.textBoxConfirmPass.isPassword = true;
            this.textBoxConfirmPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxConfirmPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxConfirmPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxConfirmPass.LineThickness = 1;
            this.textBoxConfirmPass.Location = new System.Drawing.Point(53, 202);
            this.textBoxConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(290, 33);
            this.textBoxConfirmPass.TabIndex = 2;
            this.textBoxConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxPassword.HintText = "Password";
            this.textBoxPassword.isPassword = true;
            this.textBoxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxPassword.LineThickness = 1;
            this.textBoxPassword.Location = new System.Drawing.Point(53, 161);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(290, 33);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // formUpdatePharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 593);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.modifydp);
            this.Controls.Add(this.dropDrownSecretQ);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSec);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUpdatePharmacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formUpdatePharmacy";
            this.Load += new System.EventHandler(this.formUpdatePharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifydp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxAdress;
        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuTileButton btnModify;
        private PictureBoxAbouAmmar.صورة_دائرة modifydp;
        private Bunifu.Framework.UI.BunifuDropdown dropDrownSecretQ;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxSec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxConfirmPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}