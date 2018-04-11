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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
          
            userControlLogin login = new userControlLogin(this);
            panelEnterMian.Controls.Add(login);
            login.Dock = DockStyle.Fill;
         
        
    }

        public void load_login()
        {
            
            
            userControlLogin login = new userControlLogin(this);
            panelEnterMian.Controls.Clear();
            panelEnterMian.Controls.Add(login);
            login.Dock = DockStyle.Fill;


        }
        public void load_register()
        {
            
            userControlRegister reg = new userControlRegister(this);
            panelEnterMian.Controls.Clear();
            panelEnterMian.Controls.Add(reg);
            reg.Dock = DockStyle.Fill;


        }
        public void load_recover()
        {
            
            userControlRecovery rec = new userControlRecovery(this);
            panelEnterMian.Controls.Clear();
            panelEnterMian.Controls.Add(rec);
            rec.Dock = DockStyle.Fill;
        }
    }
}
