using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace partBproject
{
    public class Customer
    {
        private string customerID;
        private string customerName;
        private string customerEmail;
        private string mobilePhone;
        private DateTime dateOfBirth; //to ask
        private string address;
        private CustomerStatus customerStatus;
        private float minRange;
        private float maxRange;
        private string password;
        public System.Collections.Generic.List<Contact> contacts;
        public System.Collections.Generic.List<City> cities;
        public System.Collections.Generic.List<Request> requests;
        public System.Collections.Generic.List<Meeting> meetings;


        public Customer(string customerID, string customerName, string customerEmail, string mobilePhone, DateTime dateOfBirth, string address, CustomerStatus customerStatus, float minRange, float maxRange, string password, bool isNew)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.mobilePhone = mobilePhone;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.customerStatus = customerStatus;
            this.minRange = minRange;
            this.maxRange = maxRange;
            this.password = password;
            this.contacts = new System.Collections.Generic.List<Contact>();
            this.cities = new System.Collections.Generic.List<City>();
            this.requests = new System.Collections.Generic.List<Request>();
            this.meetings = new System.Collections.Generic.List<Meeting>();
            if (isNew)
            {
                this.createCustomer();
                Program.Customers.Add(this);
            }
        }

        public void createCustomer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_customer @id , @name , @email ,@phone , @birthdate , @address , @status , @min , @max , @password";
            c.Parameters.AddWithValue("@id", this.customerID);
            c.Parameters.AddWithValue("@name", this.customerName);
            c.Parameters.AddWithValue("@email", this.customerEmail);
            c.Parameters.AddWithValue("@phone", this.mobilePhone);
            c.Parameters.AddWithValue("@birthdate", DateTime.Parse(this.dateOfBirth.ToString()));
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@status", this.customerStatus.ToString());
            c.Parameters.AddWithValue("@min", float.Parse(this.minRange.ToString()));
            c.Parameters.AddWithValue("@max", float.Parse(this.maxRange.ToString()));
            c.Parameters.AddWithValue("@password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateCustomer() // עדכון לקוח בSQL
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_customer @id , @name , @email , @phone , @birthdate , @address , @status , @min , @max , @password";
            c.Parameters.AddWithValue("@id", this.customerID);
            c.Parameters.AddWithValue("@name", this.customerName);
            c.Parameters.AddWithValue("@email", this.customerEmail);
            c.Parameters.AddWithValue("@phone", this.mobilePhone);
            c.Parameters.AddWithValue("@birthdate", DateTime.Parse(this.dateOfBirth.ToString()));
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@status", this.customerStatus.ToString());
            c.Parameters.AddWithValue("@min", float.Parse(this.minRange.ToString()));
            c.Parameters.AddWithValue("@max", float.Parse(this.maxRange.ToString()));
            c.Parameters.AddWithValue("@password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        //getters
        public string get_id()
        {
            return this.customerID;
        }
        public string get_name()
        {
            return this.customerName;
        }
        public string get_email()
        {
            return this.customerEmail;
        }

        public string get_mobilePhone()
        {
            return this.mobilePhone;
        }
        public DateTime get_dateOfBirth()
        {
            return this.dateOfBirth;
        }
        public string get_address()
        {
            return this.address;
        }

        public CustomerStatus get_customerStatus()
        {
            return customerStatus;
        }
        public void addMeeting(Meeting m)
        {
            meetings.Add(m);
        }
        public float get_minRange()
        {
            return minRange;
        }
        public float get_maxRange()
        {
            return maxRange;
        }
        public string get_password()
        {
            return this.password;
        }
        //setters

        public void set_name(string n)
        {
            this.customerName = n;
        }
        public void set_email(string e)
        {
            this.customerEmail = e;
        }

        public void set_mobilePhone(string m)
        {
            this.mobilePhone = m;
        }
        public void set_dateOfBirth(DateTime d)
        {
            this.dateOfBirth = d;
        }
        public void set_address(string a)
        {
            this.address = a;
        }

        public void set_customerStatus(CustomerStatus c)
        {
            customerStatus = c;
        }
        public void set_minRange(float m)
        {
            minRange = m;
        }
        public void set_maxRange(float m)
        {
            maxRange = m;
        }
        public void set_password(string p)
        {
            this.password = p;
        }
        public void addRequest(Request request)
        {
            this.requests.Add(request);
        }
    }
}
