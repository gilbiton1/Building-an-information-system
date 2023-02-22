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
    public class Project
    {
        private string serialNumber;
        private string projectName;
        private DateTime projectDeadLine;
        private string projectLocation;
        private Stage stage;
        private ProjectStatus projectStatus;
        private bool isArchived;//check DB
        public City city;
        public System.Collections.Generic.List<Apartment> apartments;
        public System.Collections.Generic.List<Employee> employees;
        public System.Collections.Generic.List<Supplier> suppliers;
        private bool isNew;

        public Project(string serialNumber, string projectName, DateTime projectDeadLine
            , string projectLocation, Stage stage, ProjectStatus projectStatus, Boolean isArchived, City city, Boolean isNew)
        {
            this.serialNumber = serialNumber;
            this.projectName = projectName;
            this.projectDeadLine = projectDeadLine;
            this.projectLocation = projectLocation;
            this.stage = stage;
            this.projectStatus = projectStatus;
            this.isArchived = isArchived;
            this.city = city;
            this.apartments = new System.Collections.Generic.List<Apartment>();
            this.employees = new System.Collections.Generic.List<Employee>();
            this.suppliers = new System.Collections.Generic.List<Supplier>();
            //this.city.addProject(this);

            if (isNew)
            {
                Program.Projects.Add(this);
                this.createProject();
            }
        }

        public string get_serialNumber()
        {
            return this.serialNumber;
        }
        public string get_projectName()
        {
            return this.projectName;
        }
        public DateTime get_projectDeadLine()
        {
            return this.projectDeadLine;
        }
        public string get_projectLocation()
        {
            return this.projectLocation;
        }
        public Stage get_stage()
        {
            return this.stage;
        }
        public ProjectStatus get_projectStatus()
        {
            return this.projectStatus;
        }
        public Boolean get_isArchived()
        {
            return this.isArchived;
        }
        public City get_city()
        {
            return this.city;
        }
        public void set_projectStatus(ProjectStatus projectStatus)
        {
            this.projectStatus = projectStatus;
        }
        public void set_stage(Stage stage)
        {
            this.stage = stage;
        }


        public void createProject()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_project @serialNumber, @projectName, @projectDeadLine,@projectLocation, @stage, @projectStatus, @isArchived, @cityName";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@projectName", this.projectName);
            c.Parameters.AddWithValue("@projectDeadLine", DateTime.Parse(this.projectDeadLine.ToString()));
            c.Parameters.AddWithValue("@projectLocation", this.projectLocation);
            c.Parameters.AddWithValue("@stage", this.stage.ToString());
            c.Parameters.AddWithValue("@projectStatus", this.projectStatus.ToString());
            c.Parameters.AddWithValue("@isArchived", this.isArchived); //check
            c.Parameters.AddWithValue("@cityName", this.city.get_cityName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }

        public void Update_Project()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Project @serialNumber, @projectName, @projectDeadLine,@projectLocation, @stage, @projectStatus" +
                ", @isArchived, @city";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@projectName", this.projectName);
            c.Parameters.AddWithValue("@projectDeadLine", this.projectDeadLine.ToString("yyyy-MM-dd"));
            c.Parameters.AddWithValue("@projectLocation", this.projectLocation);
            c.Parameters.AddWithValue("@stage", this.stage.ToString());
            c.Parameters.AddWithValue("@projectStatus", this.projectStatus.ToString());
            c.Parameters.AddWithValue("@isArchived", this.isArchived.ToString());
            c.Parameters.AddWithValue("@city", this.city.ToString());
            SQL_CON SC = new SQL_CON();

            SC.execute_non_query(c);

        }
    }
}


