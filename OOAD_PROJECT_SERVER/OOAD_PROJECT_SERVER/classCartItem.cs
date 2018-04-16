using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOAD_PROJECT_SERVER
{
    public class classCartItem
    {
        private string buyer_name;
        private string buyer_email;
        private string buyer_number;
        private string product_ordered;
        private int proudct_amout;
        private string buyar_longitude;
        private string buyer_latitude;

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

        public int Proudct_amout
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
    }
}