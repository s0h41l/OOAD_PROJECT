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
    public partial class userControlDoctor : UserControl
    {
        public userControlDoctor()
        {
            InitializeComponent();
        }

        private void userControlDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classDoctor> doc = ser.search_doc(dropDownSpecialization.selectedValue).ToList<network.classDoctor>();
            BindingSource src = new BindingSource(); 
            src.DataSource = doc;
            datagrid.DataSource = src;
            datagrid.Columns[1].Visible = false;
            datagrid.Columns[3].Visible = false;
            datagrid.Columns[4].Visible = false;
            datagrid.Columns[5].Visible = false;
            datagrid.Columns[6].Visible = false;
            datagrid.Columns[7].Visible = false;
            datagrid.Columns[8].Visible = false;
            datagrid.Columns[11].Visible = false;
            datagrid.Columns[12].Visible = false;
            datagrid.Columns[13].Visible = false;
            datagrid.Columns[15].Visible = false;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            List<network.classDoctor> doc = ser.search_doc(dropDownSpecialization.selectedValue).ToList<network.classDoctor>();
            BindingSource src = new BindingSource();
            src.DataSource = doc;
            datagrid.DataSource = src;
            datagrid.Columns[1].Visible = false;
            datagrid.Columns[3].Visible = false;
            datagrid.Columns[4].Visible = false;
            datagrid.Columns[5].Visible = false;
            datagrid.Columns[6].Visible = false;
            datagrid.Columns[7].Visible = false;
            datagrid.Columns[8].Visible = false;
            datagrid.Columns[11].Visible = false;
            datagrid.Columns[12].Visible = false;
            datagrid.Columns[13].Visible = false;
            datagrid.Columns[15].Visible = false;

        }
    }
}
