using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOAD_PROJECT_SERVER
{
    public class classPharmacyProducts
    {
        public static int count = 0;
        private string product_id;
        private string product_name;
        private string product_price;
        private long product_quantity;
        classPharmacyProducts()
        {
            count++;
        }

        public string Product_id
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

        public string Product_price
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