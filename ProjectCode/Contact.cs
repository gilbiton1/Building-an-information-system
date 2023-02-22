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
    public class Contact
    {
        private DateTime time;
        private string topic;
        private string description;
        private ContactStatus contactingStatus;
        public Customer customer;

        public Contact(DateTime time, string topic, string description, ContactStatus contactingStatus, Customer customer)
        {
            this.time = time;
            this.topic = topic;
            this.description = description;
            this.contactingStatus = contactingStatus;
            this.customer = customer;
        }
        public Contact(DateTime time, string topic, string description, ContactStatus contactingStatus, Customer customer, Boolean isNew)
        {
            this.time = time;
            this.topic = topic;
            this.description = description;
            this.contactingStatus = contactingStatus;
            this.customer = customer;
            if (isNew)
            {
                createContact();
                Program.Contacts.Add(this);

            }
        }

        private void createContact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_contact @time, @topic ,@description,@contactingStatus, @customer";
            c.Parameters.AddWithValue("@time", DateTime.Parse(this.time.ToString()));
            c.Parameters.AddWithValue("@topic", this.topic);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@contactingStatus", this.contactingStatus.ToString());
            c.Parameters.AddWithValue("@customer", this.customer.get_id());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        //getters
        public DateTime getTime()
        {
            return this.time;
        }
        public string getTopic()
        {
            return this.topic;
        }
        public string getDescription()
        {
            return this.description;
        }
        public ContactStatus getContactingStatus()
        {
            return this.contactingStatus;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
    }
}