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
    public partial class deletepharmacycontent : Form
    {
        private string email;
        private string eee;
        public deletepharmacycontent(string em,string ee)
        {
            email = em;
            eee= ee;
            InitializeComponent();

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            
            
            try
            {
                ser.delete_blood(email, eee);
                this.Close();
            }catch(Exception)
            {

            }
            try
            {
                ser.delete_order(email, eee);
                this.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                ser.delete_product(email, eee);
                this.Close();
            }
            catch (Exception)
            {

            }

            try
            {
                ser.delete_ambulance(email, eee);
                
                this.Close();
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Request Completed");
            

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletepharmacycontent_Load(object sender, EventArgs e)
        {

        }
    }
}
