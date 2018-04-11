namespace Semester4OOAD_Project
{
    partial class formDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDoctor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.DoctorDp = new PictureBoxAbouAmmar.صورة_دائرة();
            this.dropDownSpecialization = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDocProfile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(887, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(903, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(161, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.panel1.Controls.Add(this.labelDoctorName);
            this.panel1.Controls.Add(this.DoctorDp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 572);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblAdminPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 59);
            this.panel2.TabIndex = 0;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Abel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(12, 9);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(183, 44);
            this.lblAdminPanel.TabIndex = 1;
            this.lblAdminPanel.Text = "DoctorPanel";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.labelDoctorName.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDoctorName.Location = new System.Drawing.Point(31, 210);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(140, 42);
            this.labelDoctorName.TabIndex = 4;
            this.labelDoctorName.Text = "Sohail Khn";
            // 
            // DoctorDp
            // 
            this.DoctorDp.BackColor = System.Drawing.Color.White;
            this.DoctorDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorDp.Image = ((System.Drawing.Image)(resources.GetObject("DoctorDp.Image")));
            this.DoctorDp.Location = new System.Drawing.Point(33, 76);
            this.DoctorDp.Name = "DoctorDp";
            this.DoctorDp.Size = new System.Drawing.Size(137, 122);
            this.DoctorDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorDp.TabIndex = 3;
            this.DoctorDp.TabStop = false;
            this.DoctorDp.Click += new System.EventHandler(this.DoctorDp_Click);
            // 
            // dropDownSpecialization
            // 
            this.dropDownSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.dropDownSpecialization.BorderRadius = 3;
            this.dropDownSpecialization.DisabledColor = System.Drawing.Color.Gray;
            this.dropDownSpecialization.ForeColor = System.Drawing.Color.White;
            this.dropDownSpecialization.Items = new string[] {
        "Anesthesiologist",
        "Cardiologist",
        "Dermatologist",
        "Gastroenterologist",
        "Hematologist/Oncologist",
        "Internal Medicine Physician",
        "Nephrologist",
        "Neurologist",
        "Neurosurgeon",
        "Obstetrician",
        "Gynecologist",
        "Nurse-Midwifery",
        "Occupational Medicine Physician",
        "Ophthalmologist",
        "Plastic Surgeon",
        "Podiatrist",
        "Psychiatrist",
        "Pulmonary Medicine Physician",
        "Radiation Onconlogist",
        "Diagnostic Radiologist",
        "Rheumatologist",
        "Urologist"};
            this.dropDownSpecialization.Location = new System.Drawing.Point(423, 163);
            this.dropDownSpecialization.Name = "dropDownSpecialization";
            this.dropDownSpecialization.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dropDownSpecialization.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.dropDownSpecialization.selectedIndex = -1;
            this.dropDownSpecialization.Size = new System.Drawing.Size(549, 35);
            this.dropDownSpecialization.TabIndex = 6;
            this.dropDownSpecialization.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Specializtion";
            // 
            // dataGridDocProfile
            // 
            this.dataGridDocProfile.AllowUserToOrderColumns = true;
            this.dataGridDocProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocProfile.Location = new System.Drawing.Point(276, 256);
            this.dataGridDocProfile.Name = "dataGridDocProfile";
            this.dataGridDocProfile.Size = new System.Drawing.Size(696, 304);
            this.dataGridDocProfile.TabIndex = 8;
            // 
            // formDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 572);
            this.Controls.Add(this.dataGridDocProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownSpecialization);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "formDoctor";
            this.Text = "formDoctor";
            this.Load += new System.EventHandler(this.formDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Label labelDoctorName;
        private PictureBoxAbouAmmar.صورة_دائرة DoctorDp;
        private Bunifu.Framework.UI.BunifuDropdown dropDownSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDocProfile;
    }
}