using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classCartItem
    {
        private string buyer_name;
        private string buyer_email;
        private string buyer_number;
        private string product_ordered;
        private string proudct_amout;
        private string buyar_longitude;
        private string buyer_latitude;
        private string buyer_adress;

        [DataMember]
        public string Buyer_name
        {
            get
            {
                return buyer_name;
            }

            set
            {
                buyer_name = value;
            }
        }
        [DataMember]
        public string Buyer_email
        {
            get
            {
                return buyer_email;
            }

            set
            {
                buyer_email = value;
            }
        }
        [DataMember]
        public string Buyer_number
        {
            get
            {
                return buyer_number;
            }

            set
            {
                buyer_number = value;
            }
        }
        [DataMember]
        public string Product_ordered
        {
            get
            {
                return product_ordered;
            }

            set
            {
                product_ordered = value;
            }
        }
        [DataMember]
        public string Proudct_amout
        {
            get
            {
                return proudct_amout;
            }

            set
            {
                proudct_amout = value;
            }
        }
        [DataMember]
        public string Buyar_longitude
        {
            get
            {
                return buyar_longitude;
            }

            set
            {
                buyar_longitude = value;
            }
        }
        [DataMember]
        public string Buyer_latitude
        {
            get
            {
                return buyer_latitude;
            }

            set
            {
                buyer_latitude = value;
            }
        }
        [DataMember]
        public string Buyer_adress
        {
            get
            {
                return buyer_adress;
            }

            set
            {
                buyer_adress = value;
            }
        }
    }
}