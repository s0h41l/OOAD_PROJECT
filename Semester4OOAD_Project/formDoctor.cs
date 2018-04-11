using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using System.Net;
using GMap.NET;

namespace Semester4OOAD_Project
{
    public partial class formDoctor : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        private string longitude;
        private string latitude;
        public formDoctor()
        {
            InitializeComponent();
        }

        private void DoctorDp_Click(object sender, EventArgs e)
        {
            DoctorDp.Image = loginSessionDoctor.session.Dp;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            loginSessionDoctor.session.Specializtion = dropDownSpecialization.selectedValue;
        }

        private void formDoctor_Load(object sender, EventArgs e)
        {
            DoctorDp.Image = loginSessionDoctor.session.Dp;
            List<classDoctor> d = new List<classDoctor>();
            d.Add(loginSessionDoctor.session);
            BindingSource src = new BindingSource();
            src.DataSource = d;
            dataGridDocProfile.DataSource = src;
            labelDoctorName.Text = loginSessionDoctor.session.Name;




        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    if (watcher.Position.Location.IsUnknown)
                    {
                        latitude = "0";
                        longitude = "0";

                    }
                    else
                    {
                        latitude = watcher.Position.Location.Latitude.ToString();
                        longitude = watcher.Position.Location.Longitude.ToString();
                    }
                }
                else
                {
                    longitude = "0";
                    latitude = "0";
                }

            }
            catch (Exception)
            {
                longitude = "0";
                latitude = "0";

            }
        }


        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdateDoctor frm = new formUpdateDoctor();
            frm.Show();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginSessionDoctor.session = null;
            this.Close();
        }
    }
}
