namespace Semester4OOAD_Project
{
    partial class formAddproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddproduct));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxAmout = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnModify = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(690, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 30;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxName.HintText = "Enter product name";
            this.textBoxName.isPassword = false;
            this.textBoxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxName.LineThickness = 1;
            this.textBoxName.Location = new System.Drawing.Point(118, 85);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 33);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxAmout
            // 
            this.textBoxAmout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAmout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxAmout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAmout.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.textBoxAmout.HintText = "Enter Amount";
            this.textBoxAmout.isPassword = false;
            this.textBoxAmout.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.textBoxAmout.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAmout.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.textBoxAmout.LineThickness = 1;
            this.textBoxAmout.Location = new System.Drawing.Point(433, 85);
            this.textBoxAmout.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmout.Name = "textBoxAmout";
            this.textBoxAmout.Size = new System.Drawing.Size(161, 33);
            this.textBoxAmout.TabIndex = 1;
            this.textBoxAmout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnModify.Location = new System.Drawing.Point(118, 161);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(476, 55);
            this.btnModify.TabIndex = 2;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // formAddproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 301);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAmout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAddproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxAmout;
        private Bunifu.Framework.UI.BunifuTileButton btnModify;
    }
}