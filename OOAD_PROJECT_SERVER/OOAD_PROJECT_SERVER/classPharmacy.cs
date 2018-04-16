using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOAD_PROJECT_SERVER
{
    public class classPharmacy
    {
        public static long count;
        private long id;
        private string name;
        private string email;
        private string password;
        private string mobile;
        private string type;
        private Image dp;
        private string secretq;
        private string secreta;
        private double longitude = 0;
        private double latitude = 0;
        public List<classProduct> productdb = new List<classProduct>();
        public List<classCartItem> order = new List<classCartItem>();

        private string adress;

        public classPharmacy()
        {
            count++;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Image Dp
        {
            get
            {
                return dp;
            }

            set
            {
                dp = value;
            }
        }

        public string Secretq
        {
            get
            {
                return secretq;
            }

            set
            {
                secretq = value;
            }
        }

        public string Secreta
        {
            get
            {
                return secreta;
            }

            set
            {
                secreta = value;
            }
        }



        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public double Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
            }
        }
    }
}