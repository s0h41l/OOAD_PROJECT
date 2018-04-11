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
    public partial class formUpdatePharmacy : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        private string longitude;
        private string latitude;
        public formUpdatePharmacy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_OnValueChanged(object sender, EventArgs e)
        {

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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == textBoxPassword.Text && textBoxPassword.Text != "")
            {
                loginSessionPharmacy.session.Password = textBoxPassword.Text;
            }
            else if(textBoxPassword.Text!="")
            {
                MessageBox.Show("Password and confirm password must be same");
            }
            if (textBoxName.Text != "")
            {
                loginSessionPharmacy.session.Name = textBoxName.Text;
                MessageBox.Show("Profile Updated!");

            }
            if (textBoxAdress.Text != "")
            {
                loginSessionPharmacy.session.Adress = textBoxAdress.Text;
            }
            {

            }

            try
            {
                if (dropDrownSecretQ.selectedValue != "")
                {

                    loginSessionPharmacy.session.Secretq = dropDrownSecretQ.selectedValue;
                    loginSessionPharmacy.session.Secreta = textBoxSec.Text;

                }
            }
            catch (Exception)
            {

            }
            if (modifydp.Image != loginSessionPharmacy.session.Dp)
            {
                loginSessionPharmacy.session.Dp = modifydp.Image;
            }

        }

        private void formUpdatePharmacy_Load(object sender, EventArgs e)
        {
            textBoxAdress.Text = loginSessionPharmacy.session.Adress;
            textBoxName.Text = loginSessionPharmacy.session.Name;
            textBoxNumber.Text = loginSessionPharmacy.session.Mobile;
            modifydp.Image = loginSessionPharmacy.session.Dp;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(loginSessionPharmacy.session.Longitude, loginSessionPharmacy.session.Latitude);

            gMapControl1.MaxZoom = 100;
            gMapControl1.MinZoom = 1;
            gMapControl1.Zoom = 15;
        }


        
       

        private void gMapControl1_Load_1(object sender, EventArgs e)
        {
            watcher.StatusChanged += Watcher_StatusChanged;
            watcher.Start();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            double latt = Convert.ToDouble(latitude);
            double lon = Convert.ToDouble(longitude);
            gMapControl1.Position = new GMap.NET.PointLatLng(latt, lon);
            gMapControl1.MaxZoom = 100;
            gMapControl1.MinZoom = 1;
            gMapControl1.Zoom = 15;

            loginSessionPharmacy.session.Latitude = Convert.ToDouble(latitude);

            loginSessionPharmacy.session.Longitude = Convert.ToDouble(longitude);

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

            modifydp.Image = Image.FromStream(openFileDialog1.OpenFile());
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
