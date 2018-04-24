﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;
namespace OOAD_PROJECT_SERVER
{
    [DataContract]
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
        private List<classPharmacyProducts> productdb = new List<classPharmacyProducts>();
        private List<classCartItem> order = new List<classCartItem>();

        private string adress;

        public classPharmacy()
        {
            count++;
        }
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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


        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public List<classPharmacyProducts> Productdb
        {
            get
            {
                return productdb;
            }

            set
            {
                productdb = value;
            }
        }
        [DataMember]
        public List<classCartItem> Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }
    }
}