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
    public partial class pharmacyForm : Form
    {
        public pharmacyForm()
        {
            InitializeComponent();
        }

        private void btnregisteredusers_Click(object sender, EventArgs e)
        {
            btnregisteredusers.LabelText = Convert.ToString(loginSessionPharmacy.session.productdb.Count());
        }

        private void pharmacyForm_Load(object sender, EventArgs e)
        {
            btnregisteredusers.LabelText = Convert.ToString(loginSessionPharmacy.session.productdb.Count());
            btnPharmacyRegistered.LabelText = Convert.ToString(loginSessionPharmacy.session.order.Count());
            userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
            

        }

        private void btnPharmacyRegistered_Click(object sender, EventArgs e)
        {
            btnPharmacyRegistered.LabelText = Convert.ToString(loginSessionPharmacy.session.order.Count());
        }

        private void dataGridadminpanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = loginSessionPharmacy.session.productdb;
            dataGridadminpanel.DataSource = src;
            btnregisteredusers.LabelText = Convert.ToString(loginSessionPharmacy.session.productdb.Count());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = loginSessionPharmacy.session.productdb;
            dataGridadminpanel.DataSource = src;
            btnregisteredusers.LabelText = Convert.ToString(loginSessionPharmacy.session.productdb.Count());

        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = loginSessionPharmacy.session.order;
            dataGridadminpanel.DataSource = src;
            btnregisteredusers.LabelText = Convert.ToString(loginSessionPharmacy.session.order.Count());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            formAddproduct frm = new formAddproduct();
            frm.Show();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdatePharmacy frm = new formUpdatePharmacy();
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginSessionPharmacy.session = null;
            this.Close();
        }
    }
}
