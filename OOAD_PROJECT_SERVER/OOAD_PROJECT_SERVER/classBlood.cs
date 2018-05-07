using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classBlood
    {
        private string blood_group;
        private double amount_in_units;
        
        [DataMember]
        public string Blood_group
        {
            get
            {
                return blood_group;
            }

            set
            {
                blood_group = value;
            }
        }
        [DataMember]
        public double Amount_in_units
        {
            get
            {
                return amount_in_units;
            }

            set
            {
                amount_in_units = value;
            }
        }
    }
}