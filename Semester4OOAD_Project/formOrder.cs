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
    public partial class formOrder : Form
    {
        string b_name;
        string b_email;
        string b_number;
        string b_adress;
        string b_longi;
        string b_lati;
        string p_name;
        string p_amount;
        string email;

        public formOrder(string buyer_name, string buyer_email, string buyer_number, string adress, string logitude, string latitude, string product_name, string seller_email)
        {
            b_name = buyer_name;
            b_email = buyer_email;
            b_number = buyer_number;
            b_adress = adress;
            b_longi = logitude;
            b_lati = latitude;
            p_name = product_name;
            email = seller_email;
            InitializeComponent();
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formOrder_Load(object sender, EventArgs e)
        {
            lblproductName.Text = p_name;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                p_amount = Convert.ToString(dropamout.selectedValue);
                
            }catch(Exception)
            {
                p_amount = "1";
            }

            network.Service1 ser = new network.Service1();
            ser.order_product(b_name, b_email, b_number, b_adress, b_longi, b_lati, p_name, p_amount, email);
            MessageBox.Show("Product Ordered");

        }

        private void dropamout_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
