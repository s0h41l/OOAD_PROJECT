using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OOAD_PROJECT_SERVER
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool clientExist(string email)
        {
            
        
                foreach (classClient i in classDbClient.Db)
                {
                    if (i.Email == email)
                    {
                        return true;
                    }
                }
                return false;

         
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       public List<classClient> getAllClients() {
          return  classDbClient.Db;

        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void initiate()
        {
            classAdmin adm = new classAdmin();
            adm.Name = "Team Xploiter";
            adm.Email = "admin";
            adm.Password = "1234";
            adm.Adress = "7A Block R3 MA Johar Town Lahore";
            classdbAdmin.db.Add(adm);
        }

        public classAdmin get_admin_obj()
        {
            foreach(classAdmin i in classdbAdmin.db)
            {
                return i;
            }
            return null;
        }

        public void update_admin(string name, string password, string number, string adress)
        {
            
            foreach(classAdmin i in classdbAdmin.db)
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
                    
              
            }
        }

        public bool is_exist_cleint(string email)
        {
            foreach(classClient i in classDbClient.Db)
            {
                if (i.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void register_client(string name, string email, string password, string number, string type, string sq, string sa)
        {
            classClient cli = new classClient();
            cli.Name = name;
            cli.Email = email;
            cli.Password = password;
            cli.Mobile = number;
            cli.Type = type;
            cli.Secretq = sq;
            cli.Secreta = sa;
            classDbClient.Db.Add(cli);
        }

        public bool is_exist_doctor(string email)
        {
            foreach(classDoctor i in classDbDoctor.Db)
            {
                if (i.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void register_doctor(string name, string email, string password, string number, string type, string sq, string sa)
        {
            classDoctor doc = new classDoctor();
            doc.Name = name;
            doc.Email = email;
            doc.Password = password;
            doc.Mobile = number;
            doc.Type = type;
            doc.Secretq = sq;
            doc.Secreta = sa;
            classDbDoctor.Db.Add(doc);


        }

        public bool is_exist_hospital(string email)
        {
            foreach(classHospital h in classDbHospital.Db)
            {
                if (h.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void register_hospital(string name, string email, string password, string number, string type, string sq, string sa)
        {
            classHospital doc = new classHospital();
            doc.Name = name;
            doc.Email = email;
            doc.Password = password;
            doc.Mobile = number;
            doc.Type = type;
            doc.Secretq = sq;
            doc.Secreta = sa;
            classDbHospital.Db.Add(doc);
        }

        public bool is_exist_Pharmacy(string email)
        {
            foreach (classPharmacy h in classDbPharmacy.Db)
            {
                if (h.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void register_Pharmacy(string name, string email, string password, string number, string type, string sq, string sa)
        {
            classPharmacy doc = new classPharmacy();
            doc.Name = name;
            doc.Email = email;
            doc.Password = password;
            doc.Mobile = number;
            doc.Type = type;
            doc.Secretq = sq;
            doc.Secreta = sa;
            classDbPharmacy.Db.Add(doc);
        }

        public List<classDoctor> getAllDoctors()
        {
            return classDbDoctor.Db;
        }

        public List<classHospital> getAllHospital()
        {
            return classDbHospital.Db;
        }

        public List<classPharmacy> getAllPharmacy()
        {
            return classDbPharmacy.Db;
        }

        public bool is_valid_client(string email, string pass)
        {
            return classDbClient.is_valid_client(email, pass);
            
        }

        public bool is_valid_doctor(string email, string pass)
        {
            return classDbDoctor.is_valid_doctor(email, pass);
        }

        public bool is_valid_hospital(string email, string pass)
        {
            return classDbHospital.is_valid_hospital(email, pass);
        }

        public bool is_valid_pharmacy(string email, string pass)
        {
            return classDbPharmacy.is_valid_pharmacy(email, pass);
        }

        public classDoctor get_doctor(string email, string pass)
        {
            return classDbDoctor.get_doctor(email, pass);
        }

        public classHospital get_hospital(string email, string pass)
        {
            return classDbHospital.get_hospital(email, pass);
        }

        public classClient get_client(string email, string pass)
        {
            return classDbClient.get_client(email, pass);
        }

        public classPharmacy get_pharmacy(string email, string pass)
        {
            return classDbPharmacy.get_pharmacy(email, pass);
        }

        public void set_client_location(string email)
        {
            throw new NotImplementedException();
        }

        public void set_doctor_location(string email,string longi,string lati)
        {
            
            classDbDoctor.location_set(email, Convert.ToDouble(longi), Convert.ToDouble(lati));
        }

        public void set_pharmacy_location(string email, string longi, string lati)
        {
            classDbPharmacy.location_set(email, Convert.ToDouble(longi), Convert.ToDouble(lati));
        }

        public void set_hospital_location(string email, string longi, string lati)
        {
            classDbHospital.location_set(email, Convert.ToDouble(longi), Convert.ToDouble(lati));
        }

        public void update_doctor(string email, string name, string password, string number, string adress, string sq, string sa)
        {
            classDbDoctor.update(email,name,password,number,adress, sq, sa);
        }

        public void set_doctor_specialization(string email, string spec)
        {
            classDbDoctor.set_spec(email, spec);
        }

        public List<classPharmacyProducts> get_Ppharmacy_products_db(string email, string pass)
        {
            
            foreach(classPharmacy i in classDbPharmacy.Db)
            {
                if(i.Email==email && i.Password == pass)
                {
                    return i.Productdb;
                }

            }
            return null;
        }

        public void add_pharmacy_product(string email, string pass,string product, string quantity , string price)
        {

            bool exist = false;
            foreach (classPharmacy j in classDbPharmacy.Db)
            {
                if(j.Email==email && j.Password == pass)
                {
                    
                    foreach (classPharmacyProducts i in j.Productdb)
                    {


                        if (product == i.Product_name)
                        {
                            try
                            {
                                i.Product_quantity += Convert.ToInt32(quantity);

                            }
                            catch (Exception)
                            {
                                i.Product_quantity += 1;

                            }
                            exist = true;
                            //MessageBox.Show("Product Updated");

                        }
                     

                    }
             
                    if (!exist)
                    {
                        classPharmacyProducts pr = new classPharmacyProducts();
                        pr.Product_name = product;
                        pr.Product_price = Convert.ToInt32(price);
                        try
                        {
                            pr.Product_quantity = Convert.ToInt32(quantity);

                        }
                        catch (Exception)
                        {
                            pr.Product_quantity = 1;

                        }

                        j.Productdb.Add(pr);


                        // loginSessionPharmacy.session.productdb.Add(pr);
                        //MessageBox.Show("Product Added");

                    }


                }
                


            }
           

            

            
        }

        public List<classCartItem> get_orders(string email, string pass)
        {
            foreach (classPharmacy i in classDbPharmacy.Db)
            {
                if (i.Email == email && i.Password == pass)
                {
                    return i.Order;
                }

            }
            return null;
        }

        public void update_Pharmacy(string email, string name, string password, string number, string adress, string sq, string sa)
        {
            classDbPharmacy.update(email, name, password, number, adress, sq, sa);
        }

        public void update_hospital(string email, string name, string password, string number, string adress, string sq, string sa)
        {
            classDbHospital.update(email, name, password, number, adress, sq, sa);
        }

        public void update_client(string email, string name, string password, string number, string adress, string sq, string sa)
        {
            classDbClient.update(email, name, password, number, adress, sq, sa);
        }
    }
}
