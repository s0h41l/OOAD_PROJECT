using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classDbClient
    {
        private static List<classClient> db = new List<classClient>();

        [DataMember]
        public static List<classClient> Db
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
        public void add_client(classClient c)
        {
            db.Add(c);
        }
        public static bool is_valid_client(string email,string pass)
        {
            foreach(classClient i in db)
            {
                if(i.Email==email && i.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }
        public static classClient get_client(string email,string pass)
        {
            foreach(classClient i in db)
            {
                if(i.Email==email && i.Password == pass)
                {
                    return i;
                }
            }
            return null;

        }

        public static void location_set(string email, double longi, double lati)
        {
            foreach (classClient i in db)
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

            foreach (classClient i in db)
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