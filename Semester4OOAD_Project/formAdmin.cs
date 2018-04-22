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
            network.Service1 ser = new network.Service1();
            network.classAdmin adm = ser.get_admin_obj();
            List<network.classClient> clients = ser.getAllClients().ToList<network.classClient>();
            btnregisteredusers.LabelText = Convert.ToString(clients.Count());
            BindingSource src = new BindingSource();
            src.DataSource = clients;
            dataGridadminpanel.DataSource = src;

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classDoctor> dr = ser.getAllDoctors().ToList<network.classDoctor>();
            BindingSource src = new BindingSource();
            src.DataSource = dr;
            dataGridadminpanel.DataSource = src;
            btnDoctorRegistered.LabelText = Convert.ToString(dr.Count());

        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacy> pharma = ser.getAllPharmacy().ToList<network.classPharmacy>();
            BindingSource src = new BindingSource();
            src.DataSource = pharma;
            dataGridadminpanel.DataSource = src;
            btnPharmacyRegistered.LabelText = Convert.ToString(pharma.Count());
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classHospital> hospitals = ser.getAllHospital().ToList<network.classHospital>();
            BindingSource src = new BindingSource();
            src.DataSource = hospitals;
            dataGridadminpanel.DataSource = src;
            btnHospitalRegistered.LabelText = Convert.ToString(hospitals.Count());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregisteredusers_Click(object sender, EventArgs e)
        {
            
           
            network.Service1 ser = new network.Service1();
            network.classAdmin adm = ser.get_admin_obj();
            List<network.classClient> clients = ser.getAllClients().ToList<network.classClient>();
            btnregisteredusers.LabelText = Convert.ToString(clients.Count());
            BindingSource src = new BindingSource();
            src.DataSource = clients;
            dataGridadminpanel.DataSource = src;


        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            network.classAdmin adm = ser.get_admin_obj();
            labelAdminName.Text = adm.Name;
            //network.classClient[] clients = ser.getAllClients();

            List<network.classClient> clients = ser.getAllClients().ToList<network.classClient>();
            btnregisteredusers.LabelText = Convert.ToString(clients.Count());
            btnDoctorRegistered.LabelText = Convert.ToString(classDbDoctor.db.Count());
            btnPharmacyRegistered.LabelText = Convert.ToString(classDbPharmacy.db.Count());
            btnHospitalRegistered.LabelText = Convert.ToString(classDbHospital.db.Count());

        }

        private void btnDoctorRegistered_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classDoctor> dr = ser.getAllDoctors().ToList<network.classDoctor>();
            BindingSource src = new BindingSource();
            src.DataSource = dr;
            dataGridadminpanel.DataSource = src;
            btnDoctorRegistered.LabelText = Convert.ToString(dr.Count());
        }

        private void btnPharmacyRegistered_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacy> pharma = ser.getAllPharmacy().ToList<network.classPharmacy>();
            BindingSource src = new BindingSource();
            src.DataSource = pharma;
            dataGridadminpanel.DataSource = src;
            btnPharmacyRegistered.LabelText = Convert.ToString(pharma.Count());
        }

        private void btnHospitalRegistered_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classHospital> hospitals = ser.getAllHospital().ToList<network.classHospital>();
            BindingSource src = new BindingSource();
            src.DataSource = hospitals;
            dataGridadminpanel.DataSource = src;
            btnHospitalRegistered.LabelText = Convert.ToString(hospitals.Count());
        }

        private void labelAdminName_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            network.classAdmin adm = new network.classAdmin();
            labelAdminName.Text = adm.Name;
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

