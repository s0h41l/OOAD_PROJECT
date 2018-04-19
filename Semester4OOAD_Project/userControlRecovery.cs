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
    public partial class userControlRecovery : UserControl
    {
        Form1 frm;
        public userControlRecovery(Form1 i)
        {
            
            InitializeComponent();
            this.frm = i;
        }

        private void userControlRecovery_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.load_login();
        }
    }
}
