﻿using System;
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
    public partial class delete : Form
    {
        private string email;
        public delete(string em)
        {
            email = em;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            

        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            network.Service1 ser = new network.Service1();
            ser.delete_user(email);
            MessageBox.Show("Request Completed");
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
