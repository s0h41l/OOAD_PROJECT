using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classDbHospital
    {
        [DataMember]
        private static List<classHospital> db = new List<classHospital>();

        [DataMember]
        public static List<classHospital> Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public static bool is_valid_hospital(string email, string pass)
        {
            foreach (classHospital i in db)
            {
                if (i.Email == email && i.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }
        public static classHospital get_hospital(string email, string pass)
        {
            foreach (classHospital i in db)
            {
                if (i.Email == email && i.Password == pass)
                {
                    return i;
                }
            }
            return null;

        }

        public static void location_set(string email, double longi, double lati)
        {
            foreach (classHospital i in db)
            {
                if (i.Email == email)
                {
                    i.Longitude = longi;
                    i.Latitude = lati;
                }
            }

        }

        public static void update(string email, string name, string password, string number, string adress, string sq, string sa)
        {

            foreach (classHospital i in db)
            {
                if (i.Email == email)
                {
                    if (name != "")
                    {
                        i.Name = name;

                    }
                    if (password != "")
                    {
                        i.Password = password;
                    }
                    if (number != "")
                    {
                        i.Mobile = number;
                    }
                    if (adress != "")
                    {
                        i.Adress = adress;
                    }
                    if (sq != "" && sa != "")
                    {
                        i.Secretq = sq;
                        i.Secreta = sa;
                    }
                }

            }
        }

    }
}