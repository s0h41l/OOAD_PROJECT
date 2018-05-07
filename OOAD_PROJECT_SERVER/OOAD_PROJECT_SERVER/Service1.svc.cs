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

        public void set_client_location(string email, string longi, string lati)
        {
            classDbClient.location_set(email, Convert.ToDouble(longi), Convert.ToDouble(lati));
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

        public void add_blood(string email,string pass,string group, string amount)
        {

            bool exist = false;
            foreach (classHospital j in classDbHospital.Db)
            {
                if ( j.Email== email && j.Password == pass)
                {

                    foreach (classBlood i in j.Blood)
                    {


                        if (group == i.Blood_group)
                        {
                            try
                            {
                                i.Amount_in_units += Convert.ToInt32(amount);

                            }
                            catch (Exception)
                            {
                                i.Amount_in_units += 1;

                            }
                            exist = true;
                            //MessageBox.Show("Product Updated");

                        }


                    }

                    if (!exist)
                    {
                        classBlood pr = new classBlood();
                        pr.Blood_group = group;
                       
                        try
                        {
                            pr.Amount_in_units = Convert.ToInt32(amount);

                        }
                        catch (Exception)
                        {
                            pr.Amount_in_units = 1;

                        }

                        j.Blood.Add(pr);


                        // loginSessionPharmacy.session.productdb.Add(pr);
                        //MessageBox.Show("Product Added");

                    }


                }



            }

        }

        public List<classBlood> get_blood(string email, string pass)
        {
            foreach(classHospital i in classDbHospital.Db)
            {
                if(i.Email==email && i.Password == pass)
                {
                    return i.Blood;
                }
            }
            return null;
        }

        public List<classEmergencyCalls> get_emergency_calls(string email, string pass)
        {
            foreach(classHospital i in classDbHospital.Db)
            {
                if(email==i.Email && i.Password == pass)
                {
                    return i.Emergency_calls;
                }
            }
            return null;
        }

        public List<classDoctor> search_doc(string spec)
        {
            List<classDoctor> doc=new List<classDoctor>();
            foreach(classDoctor i in classDbDoctor.Db)
            {
                if (i.Specializtion == spec)
                {
                    doc.Add(i);
                }
            }
            return doc;
        }

        public List<classDoctor> search_doc_near(string spec, string longitude, string latitude)
        {
            throw new NotImplementedException();
        }

        public List<classPharmacy> search_pharmacy(string medicine)
        {
            List<classPharmacy> ph = new List<classPharmacy>();
            foreach(classPharmacy i in classDbPharmacy.Db)
            {
                foreach(classPharmacyProducts j in i.Productdb)
                {
                    if (j.Product_name == medicine)
                    {
                        ph.Add(i);
                    }

                }
            }
            return ph;
        }

        public List<classDoctor> search_pharmacy_near(string medicine, string longitude, string latitude)
        {
            throw new NotImplementedException();
        }

        public List<classHospital> search_hospital(string blood)
        {
            List<classHospital> hosp = new List<classHospital>();
            foreach(classHospital i in classDbHospital.Db)
            {
                foreach(classBlood j in i.Blood)
                {
                    if (j.Blood_group == blood)
                    {
                        hosp.Add(i);

                    }
                }

            }
            return hosp;
        }

        public List<classDoctor> search_hospital_near(string blood, string longitude, string latitude)
        {
            throw new NotImplementedException();
        }

        public void call_ambulance(string name, string email, string adress, string logitude, string latitude)
        {
            classEmergencyCalls em = new classEmergencyCalls();
            em.Caller_name = name;
            em.Caller_email = email;
            em.Caller_Adress = adress;
            em.Caller_latitude = Convert.ToDouble(latitude);
            em.Caller_longitude = Convert.ToDouble(logitude);
            foreach(classHospital i in classDbHospital.Db)
            {
                i.Emergency_calls.Add(em);
            } 
        }

        public void delete_user(string email)
        {
            classDbDoctor.Db.RemoveAll(x => x.Email == email);
            classDbHospital.Db.RemoveAll(x => x.Email == email);
            classDbPharmacy.Db.RemoveAll(x => x.Email == email);
            classDbClient.Db.RemoveAll(x => x.Email == email);
        }

        public void order_product(string buyer_name, string buyer_email, string buyer_number, string adress, string logitude, string latitude, string product_name, string product_amout, string seller_email)
        {
            foreach(classPharmacy i in classDbPharmacy.Db)
            {
                if (i.Email == seller_email)
                {
                    classCartItem c = new classCartItem();
                    c.Buyer_email = buyer_email;
                    c.Buyer_name = buyer_name;
                    c.Buyer_number = buyer_number;
                    c.Buyer_adress = adress;
                    c.Buyar_longitude = logitude;
                    c.Buyer_latitude = latitude;
                    c.Product_ordered = product_name;
                    c.Proudct_amout= product_amout;
                    i.Order.Add(c);
                }
            }
        }

        public void delete_product(string user_email, string product_name)
        {
            foreach(classPharmacy i in classDbPharmacy.Db)
            {
                if (i.Email == user_email)
                {
                    i.Productdb.RemoveAll(x => x.Product_name == product_name);
                }
                
            }
        }

        public void delete_order(string user_email, string order_email)
        {
            foreach(classPharmacy i in classDbPharmacy.Db)
            {
                if (i.Email == user_email)
                {
                    i.Order.RemoveAll(x => x.Buyer_email == order_email);
                }
            }
          
        }

        public void delete_blood(string user_email, string blood_group)
        {
            foreach(classHospital i in classDbHospital.Db)
            {
                if (i.Email == user_email)
                {
                    i.Blood.RemoveAll(x => x.Blood_group == blood_group);
                }
            }
        }

        public void delete_ambulance(string email, string em)
        {
            foreach(classHospital i in classDbHospital.Db)
            {
                if (i.Email == email)
                {
                    i.Emergency_calls.RemoveAll(x => x.Caller_email == em);
                }
            }
        }
    }
}
