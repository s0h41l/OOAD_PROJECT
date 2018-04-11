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

    public partial class formUpdateProfile : Form
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        private string longitude;
        private string latitude;
        public formUpdateProfile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == textBoxPassword.Text && textBoxPassword.Text!=""){
                classAdmin.password = textBoxPassword.Text;
            }
            else
            {
                MessageBox.Show("Password and confirm password must be same");
            }
            if (textBoxName.Text != "")
            {
                classAdmin.name = textBoxName.Text;

            }
            if (textBoxNumber.Text != "")
            {
                classAdmin.mobile = textBoxNumber.Text;

            }
            if (modifydp.Image != loginSessionDoctor.session.Dp)
            {
                classAdmin.dp = modifydp.Image;

            }
            try { 
            classAdmin.secretq = dropDrownSecretQ.selectedValue;
            classAdmin.secreta = textBoxSec.Text;
            }catch(Exception)
            {
                
            }
            textBoxName.Text = classAdmin.name;
            textBoxNumber.Text = classAdmin.mobile;
            modifydp.Image = classAdmin.dp;

        }

        private void formUpdateProfile_Load(object sender, EventArgs e)
        {
            textBoxName.Text = classAdmin.name;
            textBoxNumber.Text = classAdmin.mobile;
            modifydp.Image = classAdmin.dp;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            gMapControl1.Position = new GMap.NET.PointLatLng(classAdmin.Longitude,classAdmin.Latitude);
            
            gMapControl1.MaxZoom = 100;
            gMapControl1.MinZoom = 1;
            gMapControl1.Zoom = 15;



        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            modifydp.Image = Image.FromStream(openFileDialog1.OpenFile());

            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
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

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            watcher.StatusChanged += Watcher_StatusChanged;
            watcher.Start();
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleTerrainMapProvider.Instance;
            double latt = Convert.ToDouble(latitude);
            double lon = Convert.ToDouble(longitude);
            gMapControl1.Position = new GMap.NET.PointLatLng(latt, lon);
            gMapControl1.MaxZoom = 100;
            gMapControl1.MinZoom = 1;
            gMapControl1.Zoom = 15;
            classAdmin.Longitude = Convert.ToDouble(latitude);
            classAdmin.Latitude = Convert.ToDouble(longitude);
            
            
        }
    }
}
