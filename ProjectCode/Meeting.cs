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
    public class Meeting
    {
        public Employee employee;
        private DateTime time;
        private int duration;
        public Customer customer;
        private Boolean isAvailable;

        public Meeting(Employee employee, DateTime time, int duration, Customer customer, Boolean isAvailable)
        {
            this.employee = employee;
            this.time = time;
            this.duration = duration;
            this.customer = customer;
            this.isAvailable = isAvailable;
        }
        public Meeting(Employee employee, DateTime time, int duration, Customer customer, Boolean isAvailable, Boolean isNew)
        {
            this.employee = employee;
            this.time = time;
            this.duration = duration;
            this.customer = customer;
            this.isAvailable = isAvailable;
            if (isNew)
            {
                createMeeting();
                Program.Meetings.Add(this);
            }
        }


        private void createMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_add_meeting  @employeeID ,@time , @duration, @id2 , @isAvailable";
            c.Parameters.AddWithValue("@employeeID", this.employee.get_id());
            c.Parameters.AddWithValue("@time", DateTime.Parse(this.time.ToString()));
            c.Parameters.AddWithValue("@duration", int.Parse(this.duration.ToString()));
            if (customer == null)
            {
                c.Parameters.AddWithValue("@id2", null);
            }
            else
            {
                c.Parameters.AddWithValue("@id2", this.customer.get_id());
            }
            c.Parameters.AddWithValue("@isAvailable", this.isAvailable);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_meeting  @id ,@time , @duration, @id2, @isAvailable";
            c.Parameters.AddWithValue("@id", this.employee.get_id());
            c.Parameters.AddWithValue("@time", DateTime.Parse(this.time.ToString()));
            c.Parameters.AddWithValue("@duration", int.Parse(this.duration.ToString()));
            c.Parameters.AddWithValue("@id2", this.customer.get_id());
            c.Parameters.AddWithValue("@isAvailable", this.isAvailable);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        //getters
        public Employee get_Employee()
        {
            return this.employee;
        }
        public DateTime get_time()
        {
            return this.time;
        }
        public int get_duration()
        {
            return this.duration;
        }
        public Customer get_Customer()
        {
            return this.customer;
        }
        public Boolean get_isAvailable()
        {
            return this.isAvailable;
        }
        //setters
        public void set_time(DateTime d)
        {
            this.time = d;
        }
        public void set_duration(int duration)
        {
            this.duration = duration;
        }
        public void set_isAvailable(Boolean isAvailable)
        {
            this.isAvailable = isAvailable;
            this.updateMeeting();
        }
        public void set_Employee(Employee e)
        {
            this.employee = e;
        }
        public void set_Customer(Customer c)
        {
            this.customer = c;
        }
    }
}