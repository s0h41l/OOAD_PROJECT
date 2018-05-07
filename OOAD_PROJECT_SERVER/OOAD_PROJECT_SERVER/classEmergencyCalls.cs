using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classEmergencyCalls
    {
        private string caller_name;
        private string caller_email;
        private string caller_number;
        private string caller_Adress;
        private double caller_longitude;
        private double caller_latitude;
        [DataMember]
        public string Caller_email
        {
            get
            {
                return caller_email;
            }

            set
            {
                caller_email = value;
            }
        }
        [DataMember]
        public string Caller_number
        {
            get
            {
                return caller_number;
            }

            set
            {
                caller_number = value;
            }
        }
        [DataMember]
        public string Caller_Adress
        {
            get
            {
                return caller_Adress;
            }

            set
            {
                caller_Adress = value;
            }
        }

        [DataMember]
        public double Caller_longitude
        {
            get
            {
                return caller_longitude;
            }

            set
            {
                caller_longitude = value;
            }
        }
        [DataMember]
        public double Caller_latitude
        {
            get
            {
                return caller_latitude;
            }

            set
            {
                caller_latitude = value;
            }
        }
        [DataMember]
        public string Caller_name
        {
            get
            {
                return caller_name;
            }

            set
            {
                caller_name = value;
            }
        }
    }
}