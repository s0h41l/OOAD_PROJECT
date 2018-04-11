using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester4OOAD_Project
{
    class classProduct
    {
        private static long count=0;
        private string product_name;
        private long product_id;
        private long product_amout;

        public classProduct()
        {
            count++;
            Product_id = count;
        }

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
