using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester4OOAD_Project
{
    public partial class userControlLogin : UserControl
    {
        Form1 frm;
        public userControlLogin(Form1 i)
        {
            InitializeComponent();
            this.frm=i;
        }

        private void userControlLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnFpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.load_recover();
        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.load_register();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool filled = true;
            bool client = false;          //to check whethere the user trying to login exist in client DB
            bool doctor = false;        //to check whethere the user trying to login exist in doctor DB
            bool pharmacy = false;      //to check whethere the user trying to login exist in pharmacy DB
            bool hospital = false;       //to check whethere the user trying to login exist in hospial DB
            bool admin = false;
            classAdmin a = new classAdmin();
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                filled = false;

            }
            network.Service1 ser = new network.Service1();
            network.classAdmin adm = ser.get_admin_obj();

            if (textBoxUsername.Text == adm.Email && textBoxPassword.Text == adm.Password && filled == true)
            {

                admin = true;
                MessageBox.Show("admin loged in");
                formAdmin frm = new formAdmin();
                frm.Show();

            }
            bool is_exist_c;
            bool is_exist_passed_c;
            ser.is_exist_cleint(textBoxUsername.Text, out is_exist_c, out is_exist_passed_c);
            if (is_exist_c)
            {
                client = true;
            }

            bool is_exist_d;
            bool is_exist_passed_d;
            ser.is_exist_doctor(textBoxUsername.Text, out is_exist_d, out is_exist_passed_d);
            if (is_exist_d)
            {
                doctor = true;
            }


            bool is_exist_p;
            bool is_exist_passed_p;
            ser.is_exist_Pharmacy(textBoxUsername.Text, out is_exist_p, out is_exist_passed_p);
            if (is_exist_p)
            {
                pharmacy = true;
            }


            bool is_exist_h;
            bool is_exist_passed_h;
            ser.is_exist_Pharmacy(textBoxUsername.Text, out is_exist_h, out is_exist_passed_h);
            if (is_exist_h)
            {
                hospital = true;
            }


            if (client && filled)
            {
                MessageBox.Show("Client Loged In");
            }

            if (doctor && filled)
            {
                bool exist = false;
                bool is_valid;
                bool is_valid_passed;
                ser.is_valid_doctor(textBoxUsername.Text, textBoxPassword.Text, out is_valid, out is_valid_passed);

                if(is_valid)
                {
                   
                        exist = true;
                        loginSessionDoctor.session = ser.get_doctor(textBoxUsername.Text,textBoxPassword.Text);   

                }
                if (exist)
                {
                    formDoctor frm = new formDoctor();
                    frm.Show();
                }
            }


            if (hospital && filled)
            {
                MessageBox.Show("hospital Loged In");
            }


            if (pharmacy && filled)
            {
                bool exist = false;
                bool is_valid;
                bool is_valid_passed;
                ser.is_valid_pharmacy(textBoxUsername.Text, textBoxPassword.Text, out is_valid, out is_valid_passed);

                if (is_valid)
                {

                    exist = true;
                    loginSessionPharmacy.session = ser.get_pharmacy(textBoxUsername.Text, textBoxPassword.Text);

                }
                if (exist)
                {
                    pharmacyForm frm = new pharmacyForm();
                    frm.Show();
                }
            }


            if(!client && !doctor && !hospital && !pharmacy && !admin)
            {
                MessageBox.Show("User Doesn't Exist");
            }

        }
    }
}
