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
            ///network.Service1 server = new network.Service1();

         //   network.classClient[] clients = server.getAllClients();

            ///List<network.classClient> clients = server.getAllClients().ToList<network.classClient>();

            
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

            bool is_exist_c;
            bool is_exist_passed_c;
            bool is_exist_d;
            bool is_exist_passed_d;
            bool is_exist_h;
            bool is_exist_passed_h;
            bool is_exist_p;
            bool is_exist_passed_p;
            network.Service1 ser = new network.Service1();

            ser.is_exist_cleint(textBoxEmail.Text, out is_exist_c, out is_exist_passed_c);
            ser.is_exist_doctor(textBoxEmail.Text, out is_exist_d, out is_exist_passed_d);
            ser.is_exist_hospital(textBoxEmail.Text, out is_exist_h, out is_exist_passed_h);
            ser.is_exist_Pharmacy(textBoxEmail.Text, out is_exist_p, out is_exist_passed_p);
            
            if (is_exist_c || is_exist_d || is_exist_h || is_exist_p || textBoxEmail.Text == "admin")
            {
                exist = true;

            }

            if (dropDownRegAs.selectedValue== "Client")
            {
                
                if (exist == false && filled==true && pass==true)
                {
                    ser.register_client(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNumber.Text, dropDownRegAs.selectedValue,dropDrownSecretQ.selectedValue,textBoxSec.Text);
  
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
                    ser.register_doctor(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNumber.Text, dropDownRegAs.selectedValue, dropDrownSecretQ.selectedValue, textBoxSec.Text);
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
                    ser.register_hospital(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNumber.Text, dropDownRegAs.selectedValue, dropDrownSecretQ.selectedValue, textBoxSec.Text);
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
                    ser.register_Pharmacy(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNumber.Text, dropDownRegAs.selectedValue, dropDrownSecretQ.selectedValue, textBoxSec.Text);
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

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
