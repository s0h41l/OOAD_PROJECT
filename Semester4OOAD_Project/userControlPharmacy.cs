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
    public partial class userControlPharmacy : UserControl
    {
        public userControlPharmacy()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classPharmacy> ph = ser.search_pharmacy(textBoxmedison.Text).ToList<network.classPharmacy>();
            BindingSource src = new BindingSource();
            src.DataSource = ph;
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
            List<network.classPharmacy> ph = ser.search_pharmacy(textBoxmedison.Text).ToList<network.classPharmacy>();
            BindingSource src = new BindingSource();
            src.DataSource = ph;
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

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            formOrder or = new formOrder(loginSessionClient.session.Name, loginSessionClient.session.Email, loginSessionClient.session.Mobile,loginSessionClient.session.Adress,Convert.ToString(loginSessionClient.session.Longitude),Convert.ToString(loginSessionClient.session.Latitude), textBoxmedison.Text, Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[2].Value));
            or.Show();
            
            //delete del = new delete(Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[2].Value));
            //del.Show();

        }
    }
}
