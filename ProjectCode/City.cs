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
    public class City
    {
        private string cityName;
        public System.Collections.Generic.List<Project> projects;
        public System.Collections.Generic.List<Customer> customers;

        public City(string cityName, bool isNew)
        {
            this.cityName = cityName;
            this.projects = new System.Collections.Generic.List<Project>();
            this.customers = new System.Collections.Generic.List<Customer>();

            if (isNew)
            {
                this.createCity();
                Program.Cities.Add(this);
            }
        }

        private void createCity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.SP_add_city @cityName";
            c.Parameters.AddWithValue("@cityName", this.cityName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public string get_cityName()
        {
            return this.cityName;
        }
        public void addProject(Project p)
        {
            projects.Add(p);
        }
    }
}
