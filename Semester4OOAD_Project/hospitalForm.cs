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
    public partial class hospitalForm : Form
    {
        public hospitalForm()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            addBlood bld = new addBlood();
            bld.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            BindingSource sr = new BindingSource();
            sr.DataSource = ser.get_blood(loginSessionHospital.session.Email,loginSessionHospital.session.Password).ToList<network.classBlood>(); 
            dataGrid.DataSource = sr;



        }

        private void btnregisteredusers_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            BindingSource sr = new BindingSource();
            sr.DataSource = ser.get_blood(loginSessionHospital.session.Email, loginSessionHospital.session.Password).ToList<network.classBlood>();
            dataGrid.DataSource = sr;
        }

        private void btnPharma_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            BindingSource sr = new BindingSource();
            sr.DataSource = ser.get_emergency_calls(loginSessionHospital.session.Email,loginSessionHospital.session.Password).ToList<network.classEmergencyCalls>();
            dataGrid.DataSource = sr;
            dataGrid.Columns[3].Visible = false;
            dataGrid.Columns[5].Visible = false;

        }

        private void btnPharmacyRegistered_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            BindingSource sr = new BindingSource();
            sr.DataSource = ser.get_emergency_calls(loginSessionHospital.session.Email, loginSessionHospital.session.Password).ToList<network.classEmergencyCalls>();
            dataGrid.DataSource = sr;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            loginSessionHospital.session = null;
            this.Close();
        }

        private void hospitalForm_Load(object sender, EventArgs e)
        {
            labelNameUser.Text = loginSessionHospital.session.Name;
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatehospital up = new updatehospital();
            up.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGrid.Columns[2].Name== "Blood_group")
            {
                deletepharmacycontent del = new deletepharmacycontent(loginSessionHospital.session.Email, Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[2].Value));
                del.Show();

            }
            if (dataGrid.Columns[1].Name == "Caller_email")
            {
                deletepharmacycontent del = new deletepharmacycontent(loginSessionHospital.session.Email, Convert.ToString(dataGrid.Rows[e.RowIndex].Cells[1].Value));
                del.Show();

            }
            
        }
    }
}
