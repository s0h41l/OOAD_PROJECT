using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classHospital
    {
        private long id;
        public static long count;
        private string name;
        private string email;
        private string password;
        private string mobile;
        private string type;
        private Image dp;
        private string secretq;
        private string secreta;
        private string adress;
        private List<classBlood> blood = new List<classBlood>();
        private List<classEmergencyCalls> emergency_calls = new List<classEmergencyCalls>();
        private double longitude = 0;
        private double latitude = 0;

        public classHospital()
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
        public List<classBlood> Blood
        {
            get
            {
                return blood;
            }

            set
            {
                blood = value;
            }
        }
        [DataMember]
        public List<classEmergencyCalls> Emergency_calls
        {
            get
            {
                return emergency_calls;
            }

            set
            {
                emergency_calls = value;
            }
        }
    }
}