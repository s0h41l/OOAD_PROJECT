using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester4OOAD_Project
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbClient.db;
            dataGridadminpanel.DataSource = src;
           
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbDoctor.db;
            dataGridadminpanel.DataSource = src;

        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbPharmacy.db;
            dataGridadminpanel.DataSource = src;
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbHospital.db;
            dataGridadminpanel.DataSource = src;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregisteredusers_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbClient.db;
            dataGridadminpanel.DataSource = src;
            btnregisteredusers.LabelText = Convert.ToString(classDbClient.db.Count());

        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            classAdmin a=new classAdmin();
            adminDp.Image = a.Dp;
            labelAdminName.Text = a.Name;
       
            btnregisteredusers.LabelText = Convert.ToString(classDbClient.db.Count());
            btnDoctorRegistered.LabelText = Convert.ToString(classDbDoctor.db.Count());
            btnPharmacyRegistered.LabelText = Convert.ToString(classDbPharmacy.db.Count());
            btnHospitalRegistered.LabelText = Convert.ToString(classDbHospital.db.Count());

        }

        private void btnDoctorRegistered_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbDoctor.db;
            dataGridadminpanel.DataSource = src;
            btnDoctorRegistered.LabelText = Convert.ToString(classDbDoctor.db.Count());
        }

        private void btnPharmacyRegistered_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbPharmacy.db;
            dataGridadminpanel.DataSource = src;
            btnPharmacyRegistered.LabelText = Convert.ToString(classDbPharmacy.db.Count());
        }

        private void btnHospitalRegistered_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = classDbHospital.db;
            dataGridadminpanel.DataSource = src;
            btnHospitalRegistered.LabelText = Convert.ToString(classDbHospital.db.Count());
        }

        private void labelAdminName_Click(object sender, EventArgs e)
        {
            labelAdminName.Text = classAdmin.name;
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdateProfile up = new formUpdateProfile();
            up.Show();
        }

        private void adminDp_Click(object sender, EventArgs e)
        {
            adminDp.Image = classAdmin.dp;
        }

        private void dataGridadminpanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
