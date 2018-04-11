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
            bool exist = false;
            foreach(classProduct i in loginSessionPharmacy.session.productdb)
            {
                if (textBoxName.Text == i.Product_name)
                {
                    try
                    {
                        i.Product_amout += Convert.ToInt32(textBoxAmout.Text);

                    }catch(Exception)
                    {
                        i.Product_amout += 1;

                    }
                    
                    exist = true;
                    MessageBox.Show("Product Updated");
                }
            }
            if (!exist)
            {
                classProduct pr = new classProduct();
                pr.Product_name = textBoxName.Text;
                try
                {
                    pr.Product_amout = Convert.ToInt32(textBoxAmout.Text);

                }catch(Exception)
                {
                    pr.Product_amout = 1;

                }

                
                loginSessionPharmacy.session.productdb.Add(pr);
                MessageBox.Show("Product Added");

            }
            textBoxAmout.Text = "";
            textBoxName.Text = "";

            
        }
    }
}
