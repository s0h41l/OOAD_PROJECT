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
    public partial class formAddproduct : Form
    {
        public formAddproduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            network.Service1 ser = new network.Service1();
            ser.add_pharmacy_product(loginSessionPharmacy.session.Email, loginSessionPharmacy.session.Password,textBoxName.Text, textBoxAmout.Text, textBoxPrice.Text);
            MessageBox.Show("Product Updated");
            textBoxAmout.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";

            
        }
    }
}
