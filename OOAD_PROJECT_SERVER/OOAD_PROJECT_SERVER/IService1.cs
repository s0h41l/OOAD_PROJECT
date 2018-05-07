using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OOAD_PROJECT_SERVER
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        bool clientExist(string email);
        [OperationContract]
        List<classClient> getAllClients();
        [OperationContract]
        void initiate();
        [OperationContract]
        classAdmin get_admin_obj();
        [OperationContract]
        void update_admin(string name, string password, string number, string adress);
        [OperationContract]
        bool is_exist_cleint(string email);
        [OperationContract]

        void register_client(string name, string email, string password, string number, string type, string sq, string sa);

        [OperationContract]
        bool is_exist_doctor(string email);
        [OperationContract]
        void register_doctor(string name, string email, string password, string number, string type, string sq, string sa);

        [OperationContract]
        bool is_exist_hospital(string email);
        [OperationContract]
        void register_hospital(string name, string email, string password, string number, string type, string sq, string sa);

        [OperationContract]
        bool is_exist_Pharmacy(string email);
        [OperationContract]
        void register_Pharmacy(string name, string email, string password, string number, string type, string sq, string sa);
        [OperationContract]
        List<classDoctor> getAllDoctors();
        [OperationContract]
        List<classHospital> getAllHospital();
        [OperationContract]
        List<classPharmacy> getAllPharmacy();
        [OperationContract]
        bool is_valid_client(string email, string pass);
        [OperationContract]
        bool is_valid_doctor(string email, string pass);
        [OperationContract]
        bool is_valid_hospital(string email, string pass);
        [OperationContract]
        bool is_valid_pharmacy(string email, string pass);
        [OperationContract]
        classDoctor get_doctor(string email, string pass);
        [OperationContract]
        classHospital get_hospital(string email, string pass);
        [OperationContract]
        classClient get_client(string email, string pass);
        [OperationContract]
        classPharmacy get_pharmacy(string email, string pass);

        [OperationContract]
        void set_client_location(string email, string longi, string lati);
        [OperationContract]
        void set_doctor_location(string email,string longi,string lati);
        [OperationContract]
        void set_pharmacy_location(string email, string longi, string lati);
        [OperationContract]
        void set_hospital_location(string email, string longi, string lati);

        [OperationContract]
        void update_doctor(string email, string name, string password, string number, string adress,string sq,string sa);
        [OperationContract]
        void set_doctor_specialization(string email, string spec);

        [OperationContract]
        List<classPharmacyProducts> get_Ppharmacy_products_db(string email, string pass);

        [OperationContract]
        void add_pharmacy_product(string email, string pass, string product, string quantity, string price);
        [OperationContract]
        List<classCartItem> get_orders(string email, string pass);
        [OperationContract]
        void update_Pharmacy(string email, string name, string password, string number, string adress, string sq, string sa);
        [OperationContract]
        void update_hospital(string email, string name, string password, string number, string adress, string sq, string sa);
        [OperationContract]
        void update_client(string email, string name, string password, string number, string adress, string sq, string sa);
        [OperationContract]
        void add_blood(string email, string pass, string group, string amount);
        [OperationContract]
        List<classBlood> get_blood(string email, string pass);
        [OperationContract]
        List<classEmergencyCalls> get_emergency_calls(string name, string pass);
        [OperationContract]
        List<classDoctor> search_doc(string spec);
        [OperationContract]
        List<classDoctor> search_doc_near(string spec,string longitude,string latitude);
        [OperationContract]
        List<classPharmacy> search_pharmacy(string medicine);
        [OperationContract]
        List<classDoctor> search_pharmacy_near(string medicine, string longitude, string latitude);
        [OperationContract]
        List<classHospital> search_hospital(string blood);
        [OperationContract]
        List<classDoctor> search_hospital_near(string blood, string longitude, string latitude);
        [OperationContract]
        void call_ambulance(string name,string email,string adress,string logitude,string latitude);
        [OperationContract]
        void delete_user(string email);
        [OperationContract]
        void order_product(string buyer_name, string buyer_email,string buyer_number,string adress,string logitude,string latitude,string product_name,string product_amout,string seller_email);
        [OperationContract]
        void delete_product(string user_email,string product_name);
        [OperationContract]
        void delete_order(string user_email, string order_email);
        [OperationContract]
        void delete_blood(string user_email, string blood_group);
        [OperationContract]
        void delete_ambulance(string email, string em);
        


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
