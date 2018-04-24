using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace OOAD_PROJECT_SERVER
{
    [DataContract]
    public class classdbAdmin
    {
        [DataMember]
        public static List<classAdmin> db = new List<classAdmin>();

        public static void add_admin(classAdmin adm)
        {
            if (db.Count == 0)
            {
                db.Add(adm);
            }

        }
      
    }
}