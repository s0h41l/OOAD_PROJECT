namespace Semester4OOAD_Project
{
    partial class addBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBlood));
            this.btnModify = new Bunifu.Framework.UI.BunifuTileButton();
            this.textBoxAmout = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.dropDownGroups = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.btnModify.LabelText = "Add product";
            this.btnModify.Location = new System.Drawing.Point(45, 161);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(603, 55);
            this.btnModify.TabIndex = 34;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // textBoxAmout
            // 
            this.textBoxAmout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAmout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxAmout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAmout.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxAmout.HintText = "Enter Quantity(units)";
            this.textBoxAmout.isPassword = false;
            this.textBoxAmout.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxAmout.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAmout.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAmout.LineThickness = 1;
            this.textBoxAmout.Location = new System.Drawing.Point(318, 85);
            this.textBoxAmout.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmout.Name = "textBoxAmout";
            this.textBoxAmout.Size = new System.Drawing.Size(330, 33);
            this.textBoxAmout.TabIndex = 33;
            this.textBoxAmout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(671, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 35;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dropDownGroups
            // 
            this.dropDownGroups.BackColor = System.Drawing.Color.Transparent;
            this.dropDownGroups.BorderRadius = 3;
            this.dropDownGroups.DisabledColor = System.Drawing.Color.Gray;
            this.dropDownGroups.ForeColor = System.Drawing.Color.White;
            this.dropDownGroups.Items = new string[] {
        "A+",
        "O+",
        "B+",
        "AB+",
        "A-",
        "O-",
        "B-",
        "AB-"};
            this.dropDownGroups.Location = new System.Drawing.Point(45, 85);
            this.dropDownGroups.Name = "dropDownGroups";
            this.dropDownGroups.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropDownGroups.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.dropDownGroups.selectedIndex = -1;
            this.dropDownGroups.Size = new System.Drawing.Size(251, 33);
            this.dropDownGroups.TabIndex = 37;
            // 
            // addBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 252);
            this.Controls.Add(this.dropDownGroups);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.textBoxAmout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addBlood";
            this.Text = "addBlood";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnModify;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxAmout;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDropdown dropDownGroups;
    }
}