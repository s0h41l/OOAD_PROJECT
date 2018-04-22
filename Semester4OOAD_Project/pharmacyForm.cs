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
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr = ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
        }

        private void pharmacyForm_Load(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr=ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
            

        }

        private void btnPharmacyRegistered_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr = ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
        }

        private void dataGridadminpanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr = ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;

            BindingSource src = new BindingSource();
            src.DataSource = pr;
            dataGridadminpanel.DataSource = src;
      
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr = ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
            
            BindingSource src = new BindingSource();
            src.DataSource = pr;
            dataGridadminpanel.DataSource = src;
      

        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacyProducts> pr = ser.get_Ppharmacy_products_db(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classPharmacyProducts>();
            btnregisteredusers.LabelText = Convert.ToString(pr.Count());
            List<network.classCartItem> cr = ser.get_orders(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password).ToList<network.classCartItem>();
            btnPharmacyRegistered.LabelText = Convert.ToString(cr.Count());
            //userDp.Image = loginSessionPharmacy.session.Dp;
            labelNameUser.Text = loginSessionPharmacy.session.Name;
            BindingSource src = new BindingSource();
            src.DataSource = cr;
            dataGridadminpanel.DataSource = src;
          
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
