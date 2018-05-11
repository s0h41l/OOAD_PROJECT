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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private void btnHospitalRegistered_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            userControlDoctor doc = new userControlDoctor();
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(doc);
            panelAdmin.Dock = DockStyle.Fill;
        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            userControlPharmacy usr = new userControlPharmacy();
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(usr);
            panelAdmin.Dock = DockStyle.Fill;

        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            userControlHospital hosp = new userControlHospital();
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(hosp);
            panelAdmin.Dock = DockStyle.Fill;

        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            loginSessionClient.session = null;
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateClient up = new updateClient();
            up.Show();
        }
    }
}
