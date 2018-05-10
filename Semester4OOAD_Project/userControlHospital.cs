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
    public partial class userControlHospital : UserControl
    {
        public userControlHospital()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classHospital> hosp = ser.search_hospital(dropDownGroups.selectedValue).ToList<network.classHospital>();
            BindingSource src = new BindingSource();
            src.DataSource = hosp;
            dataGrid.DataSource = src;
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[3].Visible = false;
            dataGrid.Columns[4].Visible = false;
            dataGrid.Columns[5].Visible = false;
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[11].Visible = false;
            dataGrid.Columns[12].Visible = false;
            dataGrid.Columns[13].Visible = false;
            dataGrid.Columns[14].Visible = false;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classHospital> hosp = ser.search_hospital(dropDownGroups.selectedValue).ToList<network.classHospital>();
            BindingSource src = new BindingSource();
            src.DataSource = hosp;
            dataGrid.DataSource = src;
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[3].Visible = false;
            dataGrid.Columns[4].Visible = false;
            dataGrid.Columns[5].Visible = false;
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[11].Visible = false;
            dataGrid.Columns[12].Visible = false;
            dataGrid.Columns[13].Visible = false;
            dataGrid.Columns[14].Visible = false;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1(); 
            ser.call_ambulance(loginSessionClient.session.Name, loginSessionClient.session.Email, loginSessionClient.session.Adress, Convert.ToString(loginSessionClient.session.Longitude), Convert.ToString(loginSessionClient.session.Latitude));
            MessageBox.Show("Emergency Message sent.");
        }
    }
}
