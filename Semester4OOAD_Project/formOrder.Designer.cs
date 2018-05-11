namespace Semester4OOAD_Project
{
    partial class formOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrder));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblproductName = new System.Windows.Forms.Label();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuTileButton();
            this.dropamout = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(478, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 36;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblproductName
            // 
            this.lblproductName.AutoSize = true;
            this.lblproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblproductName.Location = new System.Drawing.Point(71, 130);
            this.lblproductName.Name = "lblproductName";
            this.lblproductName.Size = new System.Drawing.Size(121, 17);
            this.lblproductName.TabIndex = 37;
            this.lblproductName.Text = "labelproductname";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnSignIn.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnSignIn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImagePosition = 18;
            this.btnSignIn.ImageZoom = 50;
            this.btnSignIn.LabelPosition = 30;
            this.btnSignIn.LabelText = "Order Now";
            this.btnSignIn.Location = new System.Drawing.Point(163, 182);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(305, 38);
            this.btnSignIn.TabIndex = 41;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // dropamout
            // 
            this.dropamout.AutoSize = true;
            this.dropamout.BackColor = System.Drawing.Color.White;
            this.dropamout.BorderRadius = 3;
            this.dropamout.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropamout.ForeColor = System.Drawing.Color.White;
            this.dropamout.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30"};
            this.dropamout.Location = new System.Drawing.Point(74, 182);
            this.dropamout.Name = "dropamout";
            this.dropamout.NomalColor = System.Drawing.Color.Silver;
            this.dropamout.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropamout.selectedIndex = -1;
            this.dropamout.Size = new System.Drawing.Size(81, 38);
            this.dropamout.TabIndex = 42;
            this.dropamout.onItemSelected += new System.EventHandler(this.dropamout_onItemSelected);
            // 
            // formOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 344);
            this.Controls.Add(this.dropamout);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblproductName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOrder";
            this.Text = "formOrder";
            this.Load += new System.EventHandler(this.formOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblproductName;
        private Bunifu.Framework.UI.BunifuTileButton btnSignIn;
        private Bunifu.Framework.UI.BunifuDropdown dropamout;
    }
}