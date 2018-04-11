using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace Semester4OOAD_Project
{
    public partial class userControlRegister : UserControl
    {
        Form1 frm;
        public userControlRegister(Form1 i)
        {
            InitializeComponent();
            this.frm = i;
        }
        

        private void userControlRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.load_login();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            labelemailexist.Visible = false;
            bool exist = false;
            bool filled = true;
            bool pass = true;
            if (textBoxName.Text=="" || textBoxEmail.Text=="" || textBoxPassword.Text=="" || textBoxNumber.Text=="" || dropDownRegAs.selectedValue=="" || dropDrownSecretQ.selectedValue=="" || textBoxSec.Text=="") {
                filled =false;
            }
            if (textBoxPassword.Text != textBoxConfirmPass.Text)
            {
                pass = false;
                MessageBox.Show("Comfirm password must be same as password");

            }

            foreach (classClient i in classDbClient.db)
            {
                if (i.Email == textBoxEmail.Text)
                {
                    exist = true;
                }

            }


            foreach (classDoctor i in classDbDoctor.db)
            {
                if (i.Email == textBoxEmail.Text)
                {
                    exist = true;
                }

            }


            foreach (classHospital i in classDbHospital.db)
            {
                if (i.Email == textBoxEmail.Text)
                {
                    exist = true;
                }

            }

            foreach (classPharmacy i in classDbPharmacy.db)
            {
                if (i.Email == textBoxEmail.Text)
                {
                    exist = true;
                }

            }


            

            if (dropDownRegAs.selectedValue== "Client")
            {
                
                if (exist == false && filled==true && pass==true)
                {
                    classClient client = new classClient();
                    client.Id = classClient.count;
                    client.Name = textBoxName.Text;
                    client.Email = textBoxEmail.Text;
                    client.Password = textBoxPassword.Text;
                    client.Mobile = textBoxNumber.Text;
                    client.Type = "Client";
                    client.Secretq = dropDrownSecretQ.selectedValue;
                    client.Secreta = textBoxSec.Text;
                    classDbClient.db.Add(client);
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxNumber.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPass.Text = "";
                    MessageBox.Show("Registered");
            

                }
                



                   
            }
            if (dropDownRegAs.selectedValue == "Doctor")
            {
                
                if (exist == false && filled == true && pass == true)
                {
                    classDoctor usr = new classDoctor();
                    usr.Id = classDoctor.count;
                    usr.Name = textBoxName.Text;
                    usr.Email = textBoxEmail.Text;
                    usr.Password = textBoxPassword.Text;
                    usr.Mobile = textBoxNumber.Text;
                    usr.Type = "Doctor";
                    usr.Secretq = dropDrownSecretQ.selectedValue;
                    usr.Secreta = textBoxSec.Text;
                    classDbDoctor.db.Add(usr);
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxNumber.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPass.Text = "";
                    MessageBox.Show("Registered");




                }
                




            }

            if (dropDownRegAs.selectedValue == "Hospital")
            {
                
                if (exist == false && filled == true && pass == true)
                {
                    classHospital usr = new classHospital();
                    usr.Id = classHospital.count;
                    usr.Name = textBoxName.Text;
                    usr.Email = textBoxEmail.Text;
                    usr.Password = textBoxPassword.Text;
                    usr.Mobile = textBoxNumber.Text;
                    usr.Type = "Doctor";
                    usr.Secretq = dropDrownSecretQ.selectedValue;
                    usr.Secreta = textBoxSec.Text;
                    classDbHospital.db.Add(usr);
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxNumber.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPass.Text = "";
                    MessageBox.Show("Registered");




                }
                




            }

            if (dropDownRegAs.selectedValue == "Pharmacy")
            {
                
                if (exist == false && filled == true && pass == true)
                {
                    classPharmacy usr = new classPharmacy();
                    usr.Id = classPharmacy.count;
                    usr.Name = textBoxName.Text;
                    usr.Email = textBoxEmail.Text;
                    usr.Password = textBoxPassword.Text;
                    usr.Mobile = textBoxNumber.Text;
                    usr.Type = "Doctor";
                    usr.Secretq = dropDrownSecretQ.selectedValue;
                    usr.Secreta = textBoxSec.Text;
                    classDbPharmacy.db.Add(usr);
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxNumber.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPass.Text = "";
                    MessageBox.Show("Registered");




                }
                



            }

            if (exist == true)
            {
                labelemailexist.Visible = true;
            }
            if (filled == false)
            {
                MessageBox.Show("Filled must be filled");
            }





        }
        

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_OnValueChanged(object sender, EventArgs e)
        {
            labelemailexist.Visible = false;
        }

        private void textBoxName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dropDownRegAs_onItemSelected(object sender, EventArgs e)
        {

        }

        private void dropDrownSecretQ_onItemSelected(object sender, EventArgs e)
        {

        }

        private void textBoxSec_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
