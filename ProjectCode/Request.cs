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
    public class Request
    {
        private string requestNumber;
        private string requirement;
        private RequestStatus requestStatus;
        private string catalogNumber;
        private int apartmentNum;
        private string serialNumber;
        public Apartment apartment;
        public Supplier supplier;
        public Customer customer;
        private Boolean isNew;

        public Request(string requestNumber, string requirement, RequestStatus requestStatus, string catalogNumber, int apartmentNum, string serialNumber, Supplier supplier, Customer customer, Boolean isNew)
        {
            this.requestNumber = requestNumber;
            this.requirement = requirement;
            this.requestStatus = requestStatus;
            this.catalogNumber = catalogNumber;
            this.apartmentNum = apartmentNum;
            this.serialNumber = serialNumber;
            //this.apartment = Program.seekApartment(apartmentNum, serialNumber);
            this.supplier = supplier;
            this.customer = customer;

            if (supplier != null)
                this.supplier.addRequest(this);

            this.customer.addRequest(this);

            if (isNew)
            {
                Program.Requests.Add(this);
                this.createRequest();
            }
        }

        public string get_requestNumber()
        {
            return this.requestNumber;
        }
        public string get_requirement()
        {
            return this.requirement;
        }
        public RequestStatus get_requestStatus()
        {
            return this.requestStatus;
        }
        public string get_catalogNumber()
        {
            return this.catalogNumber;
        }
        //public int get_apartment()
        //{
        //    return this.apartment;
        // }
        // public string get_serialNumber()
        // {
        //     return this.serialNumber;
        // }
        public Supplier get_supplier()
        {
            return this.supplier;
        }
        public Customer get_customer()
        {
            return this.customer;
        }
        public void set_requestStatus(RequestStatus requestStatus)
        {
            this.requestStatus = requestStatus;
        }
        public void createRequest()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_request @requestNumber, @requirement, @requestStatus, @catalogNumber, @apartmentNum, @serialNumber, @supplierID, @customerID";
            c.Parameters.AddWithValue("@requestNumber", this.requestNumber);
            c.Parameters.AddWithValue("@requirement", this.requirement);
            c.Parameters.AddWithValue("@requestStatus", this.requestStatus.ToString());
            c.Parameters.AddWithValue("@catalogNumber", this.catalogNumber);
            c.Parameters.AddWithValue("@apartmentNum", this.apartmentNum);
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@supplierID", this.supplier.get_supplierID());
            c.Parameters.AddWithValue("@customerID", this.customer.get_id());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateRequest()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_request @requestNumber, @requirement, @requestStatus, @catalogNumber, @apartmentNum, @serialNumber" +
                ", @supplierID, @customerID";
            c.Parameters.AddWithValue("@requestNumber", this.requestNumber);
            c.Parameters.AddWithValue("@requirement", this.requirement);
            c.Parameters.AddWithValue("@requestStatus", requestStatus.ToString());
            c.Parameters.AddWithValue("@catalogNumber", this.catalogNumber);
            c.Parameters.AddWithValue("@apartmentNum", this.apartmentNum);
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@supplierID", this.supplier.get_supplierID());
            c.Parameters.AddWithValue("@customerID", this.customer.get_id());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }
    }

}
