using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace OOAD_PROJECT_SERVER
{
    public class classAdmin
    {
        public static string name = "Sohail Khn";
        public static string email = "admin@sehat.pk";
        public static string password = "1234";
        public static string mobile;
        public static string type;
        public static Image dp;
        public static string secretq;
        public static string secreta;
        private static double longitude = 0;
        private static double latitude = 0;
        public static string adress;



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

        public static double Longitude
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

        public static double Latitude
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