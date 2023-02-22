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
    public class Employee
    {
        private string employeeID;
        private EmployeeRole employeeRole;
        private Gender gender;
        private string email;
        private string firstName;
        private string lastName;
        private string password;
        private Boolean isExternal, isNew;
        private string fullName;
        public static System.Collections.Generic.List<Project> projects;
        public System.Collections.Generic.List<Meeting> meetings;

        public Employee(string employeeID, EmployeeRole employeeRole, Gender gender, string email, string firstName, string lastName, string password, Boolean isExternal, Boolean isNew)
        {
            this.employeeID = employeeID;
            this.employeeRole = employeeRole;
            this.gender = gender;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.isExternal = isExternal;
            fullName = firstName + " " + lastName;
            projects = new System.Collections.Generic.List<Project>();
            meetings = new System.Collections.Generic.List<Meeting>();
            if (isNew)
            {
                this.createEmployee();
                Program.Employees.Add(this);
            }
        }

        public void createEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_employee @id, @role, @gender, @email, @name, @lastName, @password,	@isExternal";
            c.Parameters.AddWithValue("@id", this.employeeID);
            c.Parameters.AddWithValue("@role", this.employeeRole);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@name", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@isExternal", this.isExternal);  //לבדוק אולי צריך המרה של בוליאן
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_employee @id, @role, @gender, @email, @name, @lastName, @password,	@isExternal";
            c.Parameters.AddWithValue("@id", this.employeeID);
            c.Parameters.AddWithValue("@role", this.employeeRole);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@name", this.firstName);
            c.Parameters.AddWithValue("@lastName", this.lastName);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@isExternal", Boolean.Parse(this.isExternal.ToString()));  //לבדוק אולי צריך המרה של בוליאן
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void addMeeting(Meeting m)
        {
            meetings.Add(m);
        }

        //setters
        public string get_id()
        {
            return this.employeeID;
        }
        public string get_password()
        {
            return this.password;
        }
        public EmployeeRole get_role()
        {
            return this.employeeRole;
        }
        public Gender get_gender()
        {
            return this.gender;
        }
        public string get_email()
        {
            return this.email;
        }
        public string get_firstName()
        {
            return this.firstName;
        }
        public string get_lastName()
        {
            return this.lastName;
        }

        public Boolean get_isExternal()
        {
            return this.isExternal;
        }
        public string get_fullName()
        {
            return this.fullName;
        }
        public string get_fullNameWithRole()
        {
            return (this.fullName + " - " + this.employeeRole.ToString());
        }
        public List<Meeting> getMeetings()
        {
            return this.meetings;
        }

        //setters

        public void set_password(string password)
        {
            this.password = password;
        }
        public void set_role(EmployeeRole employeeRole)
        {
            this.employeeRole = employeeRole;
        }

        public void set_gender(Gender gender)
        {
            this.gender = gender;
        }
        public void set_email(string email)
        {
            this.email = email;
        }
        public void set_firstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void set_lastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void set_isExternal(Boolean isExternal)
        {
            this.isExternal = isExternal;
        }

    }
}
