using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
   
    [DataContract]
    public class classProduct
    {
        private static long count = 0;
        private string product_name;
        private long product_id;
        private long product_amout;

        public classProduct()
        {
            count++;
            Product_id = count;
        }
        [DataMember]
        public static long Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
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
        public long Product_id
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
        public long Product_amout
        {
            get
            {
                return product_amout;
            }

            set
            {
                product_amout = value;
            }
        }
    }
}