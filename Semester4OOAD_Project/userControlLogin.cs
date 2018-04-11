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
            classAdmin a = new classAdmin();
            if(textBoxUsername.Text=="" || textBoxPassword.Text == "")
            {
                filled = false;

            }


    

            if (textBoxUsername.Text==a.Email && textBoxPassword.Text == a.Password && filled==true)
            {

                
                MessageBox.Show("admin loged in");
                formAdmin frm = new formAdmin();
                frm.Show();
                
            }
            foreach(classClient i in classDbClient.db)
            {
                if (i.Email == textBoxUsername.Text)
                {
                    client = true;
                }
            }




            foreach (classDoctor i in classDbDoctor.db)
            {
                if (i.Email == textBoxUsername.Text)
                {
                    doctor = true;
                }
            }



            foreach (classPharmacy i in classDbPharmacy.db)
            {
                if (i.Email == textBoxUsername.Text)
                {
                    pharmacy = true;
                }
            }



            foreach (classHospital i in classDbHospital.db)
            {
                if (i.Email == textBoxUsername.Text)
                {
                    hospital = true;
                }
            }



            if (client && filled)
            {
                MessageBox.Show("Client Loged In");
            }


            if (doctor && filled)
            {
                bool exist = false;
                foreach(classDoctor i in classDbDoctor.db)
                {
                    if(i.Email==textBoxUsername.Text && i.Password == textBoxPassword.Text)
                    {
                        exist = true;
                        loginSessionDoctor.session = i;
                    }

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
                foreach (classPharmacy i in classDbPharmacy.db)
                {
                    if (i.Email == textBoxUsername.Text && i.Password == textBoxPassword.Text)
                    {
                        exist = true;
                        loginSessionPharmacy.session = i;
                    }

                }
                if (exist)
                {
                    pharmacyForm frm = new pharmacyForm();
                    frm.Show();
                }
            }


            if(!client && !doctor && !hospital && !pharmacy)
            {
                MessageBox.Show("User Doesn't Exist");
            }

        }
    }
}
