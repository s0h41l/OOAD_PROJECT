using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classDbDoctor
    {

        private static List<classDoctor> db = new List<classDoctor>();

        [DataMember]
        public static List<classDoctor> Db
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

        public void add_doctor(classDoctor doc)
        {
            db.Add(doc);
        }
        public static bool is_valid_doctor(string email, string pass)
        {
            foreach (classDoctor i in db)
            {
                if (i.Email == email && i.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public static classDoctor get_doctor(string email, string pass)
        {
            foreach (classDoctor i in db)
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
            foreach (classDoctor i in db)
            {
                if (i.Email == email)
                {
                    i.Longitude = longi;
                    i.Latitude = lati;
                }
            }



        }

       
        public static void update(string email,string name, string password, string number, string adress, string sq, string sa)
        {

            foreach (classDoctor i in db)
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
                    if(sq!="" && sa != "")
                    {
                        i.Secretq = sq;
                        i.Secreta = sa;
                    }
                }

            }
        }

        public static void set_spec(string email,string spec)
        {
            foreach(classDoctor i in db)
            {
                if (i.Email == email)
                {
                    i.Specializtion = spec;

                }
            }
        }


    }
}
