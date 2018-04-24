using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classPharmacyProducts
    {
        public static int count = 0;
        private int product_id;
        private string product_name;
        private long product_price;
        private long product_quantity;
        public classPharmacyProducts()
        {
            product_id = count;
            count++;
            
        }
        [DataMember]
        public int Product_id
        {
            get
            {
                return product_id;
            }

            set
            {
                product_id = value;
            }
        }
        [DataMember]
        public string Product_name
        {
            get
            {
                return product_name;
            }

            set
            {
                product_name = value;
            }
        }
        [DataMember]
        public long Product_price
        {
            get
            {
                return product_price;
            }

            set
            {
                product_price = value;
            }
        }
        [DataMember]
        public long Product_quantity
        {
            get
            {
                return product_quantity;
            }

            set
            {
                product_quantity = value;
            }
        }
    }
}