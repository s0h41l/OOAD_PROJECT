namespace Semester4OOAD_Project
{
    partial class hospitalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalForm));
            this.btnregisteredusers = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.userDp = new PictureBoxAbouAmmar.صورة_دائرة();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPharma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDoctors = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPharmacyRegistered = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregisteredusers
            // 
            this.btnregisteredusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnregisteredusers.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.btnregisteredusers.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(90)))));
            this.btnregisteredusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregisteredusers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnregisteredusers.ForeColor = System.Drawing.Color.White;
            this.btnregisteredusers.Image = ((System.Drawing.Image)(resources.GetObject("btnregisteredusers.Image")));
            this.btnregisteredusers.ImagePosition = 20;
            this.btnregisteredusers.ImageZoom = 50;
            this.btnregisteredusers.LabelPosition = 41;
            this.btnregisteredusers.LabelText = "Blood bank";
            this.btnregisteredusers.Location = new System.Drawing.Point(270, 11);
            this.btnregisteredusers.Margin = new System.Windows.Forms.Padding(6);
            this.btnregisteredusers.Name = "btnregisteredusers";
            this.btnregisteredusers.Size = new System.Drawing.Size(170, 171);
            this.btnregisteredusers.TabIndex = 12;
            this.btnregisteredusers.Click += new System.EventHandler(this.btnregisteredusers_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.dataGrid);
            this.panelAdmin.Location = new System.Drawing.Point(267, 191);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1090, 488);
            this.panelAdmin.TabIndex = 17;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1090, 488);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.labelNameUser);
            this.panel2.Controls.Add(this.userDp);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 246);
            this.panel2.TabIndex = 0;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNameUser.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNameUser.Location = new System.Drawing.Point(40, 192);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(140, 42);
            this.labelNameUser.TabIndex = 2;
            this.labelNameUser.Text = "Sohail Khn";
            // 
            // userDp
            // 
            this.userDp.BackColor = System.Drawing.Color.White;
            this.userDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userDp.Image = ((System.Drawing.Image)(resources.GetObject("userDp.Image")));
            this.userDp.Location = new System.Drawing.Point(37, 64);
            this.userDp.Name = "userDp";
            this.userDp.Size = new System.Drawing.Size(137, 122);
            this.userDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDp.TabIndex = 1;
            this.userDp.TabStop = false;
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
            this.lblAdminPanel.Location = new System.Drawing.Point(28, 6);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(131, 44);
            this.lblAdminPanel.TabIndex = 0;
            this.lblAdminPanel.Text = "Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnPharma
            // 
            this.btnPharma.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnPharma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnPharma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPharma.BorderRadius = 0;
            this.btnPharma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPharma.ButtonText = "Ambulance call";
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
            this.btnPharma.Location = new System.Drawing.Point(0, 342);
            this.btnPharma.Name = "btnPharma";
            this.btnPharma.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnPharma.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnPharma.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPharma.selected = false;
            this.btnPharma.Size = new System.Drawing.Size(217, 48);
            this.btnPharma.TabIndex = 2;
            this.btnPharma.Text = "Ambulance call";
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
            this.btnDoctors.ButtonText = "Add Blood Group";
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
            this.btnDoctors.Location = new System.Drawing.Point(0, 294);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnDoctors.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDoctors.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoctors.selected = false;
            this.btnDoctors.Size = new System.Drawing.Size(217, 48);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Add Blood Group";
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctors.Textcolor = System.Drawing.Color.White;
            this.btnDoctors.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnClient
            // 
            this.btnClient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClient.BorderRadius = 0;
            this.btnClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClient.ButtonText = "Blood bank";
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.DisabledColor = System.Drawing.Color.Gray;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClient.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClient.Iconimage")));
            this.btnClient.Iconimage_right = null;
            this.btnClient.Iconimage_right_Selected = null;
            this.btnClient.Iconimage_Selected = null;
            this.btnClient.IconMarginLeft = 0;
            this.btnClient.IconMarginRight = 0;
            this.btnClient.IconRightVisible = true;
            this.btnClient.IconRightZoom = 0D;
            this.btnClient.IconVisible = true;
            this.btnClient.IconZoom = 90D;
            this.btnClient.IsTab = false;
            this.btnClient.Location = new System.Drawing.Point(0, 246);
            this.btnClient.Name = "btnClient";
            this.btnClient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnClient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClient.selected = false;
            this.btnClient.Size = new System.Drawing.Size(217, 48);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Blood bank";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Textcolor = System.Drawing.Color.White;
            this.btnClient.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnPharmacyRegistered
            // 
            this.btnPharmacyRegistered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnPharmacyRegistered.color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.btnPharmacyRegistered.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.btnPharmacyRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharmacyRegistered.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPharmacyRegistered.ForeColor = System.Drawing.Color.White;
            this.btnPharmacyRegistered.Image = ((System.Drawing.Image)(resources.GetObject("btnPharmacyRegistered.Image")));
            this.btnPharmacyRegistered.ImagePosition = 20;
            this.btnPharmacyRegistered.ImageZoom = 50;
            this.btnPharmacyRegistered.LabelPosition = 41;
            this.btnPharmacyRegistered.LabelText = "Emergency ";
            this.btnPharmacyRegistered.Location = new System.Drawing.Point(452, 11);
            this.btnPharmacyRegistered.Margin = new System.Windows.Forms.Padding(6);
            this.btnPharmacyRegistered.Name = "btnPharmacyRegistered";
            this.btnPharmacyRegistered.Size = new System.Drawing.Size(170, 171);
            this.btnPharmacyRegistered.TabIndex = 13;
            this.btnPharmacyRegistered.Click += new System.EventHandler(this.btnPharmacyRegistered_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1230, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(69, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
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
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnPharma);
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 709);
            this.panel1.TabIndex = 15;
            // 
            // hospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 709);
            this.Controls.Add(this.btnregisteredusers);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPharmacyRegistered);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "hospitalForm";
            this.Text = "hospitalForm";
            this.Load += new System.EventHandler(this.hospitalForm_Load);
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnregisteredusers;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNameUser;
        private PictureBoxAbouAmmar.صورة_دائرة userDp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPharma;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoctors;
        private Bunifu.Framework.UI.BunifuFlatButton btnClient;
        private Bunifu.Framework.UI.BunifuTileButton btnPharmacyRegistered;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}