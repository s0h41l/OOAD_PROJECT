namespace Semester4OOAD_Project
{
    partial class userControlRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignIn = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuTileButton();
            this.textBoxEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxSec = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropDrownSecretQ = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDownRegAs = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelemailexist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSignIn.AutoSize = true;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnSignIn.Location = new System.Drawing.Point(254, 470);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(48, 16);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.TabStop = true;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSignIn_LinkClicked);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 468);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 16);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Already have an account?";
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
            this.textBoxPassword.Location = new System.Drawing.Point(40, 137);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(290, 33);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.OnValueChanged += new System.EventHandler(this.textBoxPassword_OnValueChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnSignUp.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnSignUp.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = null;
            this.btnSignUp.ImagePosition = 20;
            this.btnSignUp.ImageZoom = 50;
            this.btnSignUp.LabelPosition = 41;
            this.btnSignUp.LabelText = "Sign up";
            this.btnSignUp.Location = new System.Drawing.Point(40, 375);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(290, 55);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxEmail.HintText = "Enter your email";
            this.textBoxEmail.isPassword = false;
            this.textBoxEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxEmail.LineThickness = 1;
            this.textBoxEmail.Location = new System.Drawing.Point(40, 96);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 33);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEmail.OnValueChanged += new System.EventHandler(this.textBoxEmail_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.textBoxConfirmPass.Location = new System.Drawing.Point(40, 178);
            this.textBoxConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(290, 33);
            this.textBoxConfirmPass.TabIndex = 4;
            this.textBoxConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxConfirmPass.OnValueChanged += new System.EventHandler(this.textBoxConfirmPass_OnValueChanged);
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
            this.textBoxNumber.Location = new System.Drawing.Point(40, 219);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(290, 33);
            this.textBoxNumber.TabIndex = 5;
            this.textBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxNumber.OnValueChanged += new System.EventHandler(this.textBoxNumber_OnValueChanged);
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
            this.textBoxSec.Location = new System.Drawing.Point(201, 317);
            this.textBoxSec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(129, 33);
            this.textBoxSec.TabIndex = 7;
            this.textBoxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSec.OnValueChanged += new System.EventHandler(this.textBoxSec_OnValueChanged);
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
            this.textBoxName.Location = new System.Drawing.Point(40, 55);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(290, 33);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.OnValueChanged += new System.EventHandler(this.textBoxName_OnValueChanged);
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
            this.dropDrownSecretQ.Location = new System.Drawing.Point(40, 317);
            this.dropDrownSecretQ.Name = "dropDrownSecretQ";
            this.dropDrownSecretQ.NomalColor = System.Drawing.Color.Silver;
            this.dropDrownSecretQ.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropDrownSecretQ.selectedIndex = -1;
            this.dropDrownSecretQ.Size = new System.Drawing.Size(154, 33);
            this.dropDrownSecretQ.TabIndex = 6;
            this.dropDrownSecretQ.onItemSelected += new System.EventHandler(this.dropDrownSecretQ_onItemSelected);
            // 
            // dropDownRegAs
            // 
            this.dropDownRegAs.AutoSize = true;
            this.dropDownRegAs.BackColor = System.Drawing.Color.White;
            this.dropDownRegAs.BorderRadius = 3;
            this.dropDownRegAs.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropDownRegAs.ForeColor = System.Drawing.Color.White;
            this.dropDownRegAs.Items = new string[] {
        "Client",
        "Doctor",
        "Pharmacy",
        "Hospital"};
            this.dropDownRegAs.Location = new System.Drawing.Point(201, 268);
            this.dropDownRegAs.Name = "dropDownRegAs";
            this.dropDownRegAs.NomalColor = System.Drawing.Color.Silver;
            this.dropDownRegAs.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropDownRegAs.selectedIndex = -1;
            this.dropDownRegAs.Size = new System.Drawing.Size(129, 33);
            this.dropDownRegAs.TabIndex = 13;
            this.dropDownRegAs.onItemSelected += new System.EventHandler(this.dropDownRegAs_onItemSelected);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.bunifuMaterialTextbox1.HintText = "Register As";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.bunifuMaterialTextbox1.LineThickness = 1;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(40, 268);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 33);
            this.bunifuMaterialTextbox1.TabIndex = 14;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // labelemailexist
            // 
            this.labelemailexist.AutoSize = true;
            this.labelemailexist.BackColor = System.Drawing.Color.Transparent;
            this.labelemailexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemailexist.ForeColor = System.Drawing.Color.Red;
            this.labelemailexist.Location = new System.Drawing.Point(173, 133);
            this.labelemailexist.Name = "labelemailexist";
            this.labelemailexist.Size = new System.Drawing.Size(178, 20);
            this.labelemailexist.TabIndex = 15;
            this.labelemailexist.Text = "Email already registered";
            this.labelemailexist.Visible = false;
            // 
            // userControlRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelemailexist);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.dropDownRegAs);
            this.Controls.Add(this.dropDrownSecretQ);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSec);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Name = "userControlRegister";
            this.Size = new System.Drawing.Size(363, 541);
            this.Load += new System.EventHandler(this.userControlRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel btnSignIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
        private Bunifu.Framework.UI.BunifuTileButton btnSignUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxConfirmPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxSec;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxName;
        private Bunifu.Framework.UI.BunifuDropdown dropDrownSecretQ;
        private Bunifu.Framework.UI.BunifuDropdown dropDownRegAs;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label labelemailexist;
    }
}
