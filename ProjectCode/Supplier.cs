using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partBproject
{
    public class Supplier
    {
        private string supplierID;
        private string supplierName;
        private string supplierAddress;
        private Proffesion domain;
        private string phoneNumber;
        private Boolean isNew;

        public System.Collections.Generic.List<Project> projects;
        public System.Collections.Generic.List<Request> requests;

        public Supplier(string supplierID, string supplierName, string supplierAddress, Proffesion domain, string phoneNumber, Boolean isNew)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.supplierAddress = supplierAddress;
            this.domain = domain;
            this.phoneNumber = phoneNumber;
            projects = new System.Collections.Generic.List<Project>();
            requests = new System.Collections.Generic.List<Request>();
            if (isNew)
            {
                this.createSupplier();
                Program.Suppliers.Add(this);
            }
        }

        private void createSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_supplier @id, @name, @address, @domain, @phone";
            c.Parameters.AddWithValue("@id", this.supplierID);
            c.Parameters.AddWithValue("@name", this.supplierName);
            c.Parameters.AddWithValue("@address", this.supplierAddress);
            c.Parameters.AddWithValue("@domain", this.domain.ToString());
            c.Parameters.AddWithValue("@phone", this.phoneNumber);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_supplier @id, @name, @address, @domain, @phone";
            c.Parameters.AddWithValue("@id", this.supplierID);
            c.Parameters.AddWithValue("@name", this.supplierName);
            c.Parameters.AddWithValue("@address", this.supplierAddress);
            c.Parameters.AddWithValue("@domain", this.domain.ToString());
            c.Parameters.AddWithValue("@phone", this.phoneNumber);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }



        public string get_supplierID()
        {
            return this.supplierID;
        }
        public string get_supplierName()
        {
            return this.supplierName;
        }
        public string get_supplierAddress()
        {
            return this.supplierAddress;
        }
        public Proffesion get_domain()
        {
            return this.domain;
        }
        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        //Setters

        public void set_supplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }
        public void set_supplierAddress(string supplierAddress)
        {
            this.supplierAddress = supplierAddress;
        }

        public void set_domain(Proffesion domain)
        {
            this.domain = domain;
        }
        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void addRequest(Request request)
        {
            this.requests.Add(request);
        }
    }
}