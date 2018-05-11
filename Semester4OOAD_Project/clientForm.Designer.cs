namespace Semester4OOAD_Project
{
    partial class clientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHospital = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPharma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDoctors = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.adminDp = new PictureBoxAbouAmmar.صورة_دائرة();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Location = new System.Drawing.Point(234, 6);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.panelAdmin.Size = new System.Drawing.Size(933, 684);
            this.panelAdmin.TabIndex = 11;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnHospital);
            this.panel1.Controls.Add(this.btnPharma);
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 695);
            this.panel1.TabIndex = 8;
            // 
            // btnHospital
            // 
            this.btnHospital.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHospital.BorderRadius = 0;
            this.btnHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHospital.ButtonText = "Hospitals";
            this.btnHospital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHospital.DisabledColor = System.Drawing.Color.Gray;
            this.btnHospital.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospital.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHospital.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHospital.Iconimage")));
            this.btnHospital.Iconimage_right = null;
            this.btnHospital.Iconimage_right_Selected = null;
            this.btnHospital.Iconimage_Selected = null;
            this.btnHospital.IconMarginLeft = 0;
            this.btnHospital.IconMarginRight = 0;
            this.btnHospital.IconRightVisible = true;
            this.btnHospital.IconRightZoom = 0D;
            this.btnHospital.IconVisible = true;
            this.btnHospital.IconZoom = 90D;
            this.btnHospital.IsTab = false;
            this.btnHospital.Location = new System.Drawing.Point(0, 342);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnHospital.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnHospital.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHospital.selected = false;
            this.btnHospital.Size = new System.Drawing.Size(217, 48);
            this.btnHospital.TabIndex = 4;
            this.btnHospital.Text = "Hospitals";
            this.btnHospital.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospital.Textcolor = System.Drawing.Color.White;
            this.btnHospital.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // btnPharma
            // 
            this.btnPharma.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnPharma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnPharma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPharma.BorderRadius = 0;
            this.btnPharma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPharma.ButtonText = "Pharmacies";
            this.btnPharma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharma.DisabledColor = System.Drawing.Color.Gray;
            this.btnPharma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPharma.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPharma.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPharma.Iconimage")));
            this.btnPharma.Iconimage_right = null;
            this.btnPharma.Iconimage_right_Selected = null;
            this.btnPharma.Iconimage_Selected = null;
            this.btnPharma.IconMarginLeft = 0;
            this.btnPharma.IconMarginRight = 0;
            this.btnPharma.IconRightVisible = true;
            this.btnPharma.IconRightZoom = 0D;
            this.btnPharma.IconVisible = true;
            this.btnPharma.IconZoom = 90D;
            this.btnPharma.IsTab = false;
            this.btnPharma.Location = new System.Drawing.Point(0, 294);
            this.btnPharma.Name = "btnPharma";
            this.btnPharma.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnPharma.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnPharma.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPharma.selected = false;
            this.btnPharma.Size = new System.Drawing.Size(217, 48);
            this.btnPharma.TabIndex = 3;
            this.btnPharma.Text = "Pharmacies";
            this.btnPharma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPharma.Textcolor = System.Drawing.Color.White;
            this.btnPharma.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharma.Click += new System.EventHandler(this.btnPharma_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctors.BorderRadius = 0;
            this.btnDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDoctors.ButtonText = "Doctors";
            this.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctors.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctors.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoctors.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Iconimage")));
            this.btnDoctors.Iconimage_right = null;
            this.btnDoctors.Iconimage_right_Selected = null;
            this.btnDoctors.Iconimage_Selected = null;
            this.btnDoctors.IconMarginLeft = 0;
            this.btnDoctors.IconMarginRight = 0;
            this.btnDoctors.IconRightVisible = true;
            this.btnDoctors.IconRightZoom = 0D;
            this.btnDoctors.IconVisible = true;
            this.btnDoctors.IconZoom = 90D;
            this.btnDoctors.IsTab = false;
            this.btnDoctors.Location = new System.Drawing.Point(0, 246);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnDoctors.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDoctors.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoctors.selected = false;
            this.btnDoctors.Size = new System.Drawing.Size(217, 48);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctors.Textcolor = System.Drawing.Color.White;
            this.btnDoctors.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.labelAdminName);
            this.panel2.Controls.Add(this.adminDp);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 246);
            this.panel2.TabIndex = 0;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminName.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdminName.Location = new System.Drawing.Point(40, 192);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(140, 42);
            this.labelAdminName.TabIndex = 2;
            this.labelAdminName.Text = "Sohail Khn";
            // 
            // adminDp
            // 
            this.adminDp.BackColor = System.Drawing.Color.White;
            this.adminDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminDp.Image = ((System.Drawing.Image)(resources.GetObject("adminDp.Image")));
            this.adminDp.Location = new System.Drawing.Point(37, 64);
            this.adminDp.Name = "adminDp";
            this.adminDp.Size = new System.Drawing.Size(137, 122);
            this.adminDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminDp.TabIndex = 1;
            this.adminDp.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblAdminPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 54);
            this.panel3.TabIndex = 0;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Abel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(18, 6);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(185, 44);
            this.lblAdminPanel.TabIndex = 0;
            this.lblAdminPanel.Text = "User Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1271, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(1289, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(69, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem2.Text = "Update Profile";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem3.Text = "LogOut";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1423, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "clientForm";
            this.Text = "clientForm";
            this.Load += new System.EventHandler(this.clientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHospital;
        private Bunifu.Framework.UI.BunifuFlatButton btnPharma;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoctors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAdminName;
        private PictureBoxAbouAmmar.صورة_دائرة adminDp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}