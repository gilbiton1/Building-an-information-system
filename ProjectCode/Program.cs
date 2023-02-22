using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace partBproject
{
    static class Program
    {
        // The main entry point for the application
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<Project> Projects;
        public static System.Collections.Generic.List<Apartment> Apartments;
        public static System.Collections.Generic.List<City> Cities;
        public static System.Collections.Generic.List<Meeting> Meetings;
        public static System.Collections.Generic.List<Contact> Contacts;
        public static System.Collections.Generic.List<Request> Requests;

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {

            init_customers();
            init_employees();
            init_suppliers();
            init_cities();
            init_projects();
            init_apartments();
            init_meetings();
            init_contacts();
            init_requests();
        }

        public static void init_customers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE [SAD_2].dbo.Get_all_customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers = new List<Customer>();

            while (rdr.Read())
            {
                CustomerStatus cs = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), rdr.GetValue(6).ToString());
                Customer cu = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), cs, float.Parse(rdr.GetValue(7).ToString()), float.Parse(rdr.GetValue(8).ToString()), rdr.GetValue(9).ToString(), false);
                Customers.Add(cu);
            }
        }



        public static void init_employees()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeRole er = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), rdr.GetValue(1).ToString());
                Gender g = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(2).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), er, g, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), Boolean.Parse(rdr.GetValue(7).ToString()), false);
                Employees.Add(e);
            }
        }


        public static void init_suppliers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_suppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();

            while (rdr.Read())
            {
                Proffesion pr = (Proffesion)Enum.Parse(typeof(Proffesion), rdr.GetValue(3).ToString());
                Supplier s = new Supplier(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), pr, rdr.GetValue(4).ToString(), false);
                Suppliers.Add(s);
            }
        }

        public static void init_projects()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_projects";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Projects = new List<Project>();

            while (rdr.Read())
            {
                Stage st = (Stage)Enum.Parse(typeof(Stage), rdr.GetValue(4).ToString());
                ProjectStatus ps = (ProjectStatus)Enum.Parse(typeof(ProjectStatus), rdr.GetValue(5).ToString());
                Project p = new Project(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), st, ps, Boolean.Parse(rdr.GetValue(6).ToString()), seekCity(rdr.GetValue(7).ToString()), false);
                Projects.Add(p);
            }
        }

        public static void init_apartments()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_apartments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Apartments = new List<Apartment>();

            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetValue(4).ToString());
                SaleStatus ss = (SaleStatus)Enum.Parse(typeof(SaleStatus), rdr.GetValue(4).ToString());
                Apartment a = new Apartment(int.Parse(rdr.GetValue(0).ToString()), seekProject(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), ss, float.Parse(rdr.GetValue(5).ToString()), float.Parse(rdr.GetValue(6).ToString()));
                Apartments.Add(a);
            }
        }


        public static void init_cities()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_cities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Cities = new List<City>();

            while (rdr.Read())
            {
                City ci = new City(rdr.GetValue(0).ToString(), false);
                Cities.Add(ci);
            }
        }

        public static void init_meetings()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_meetings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Meetings = new List<Meeting>();

            while (rdr.Read())
            {
                Meeting m = new Meeting(seekEmployee(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), seekCustomer(rdr.GetValue(3).ToString()), Boolean.Parse(rdr.GetValue(4).ToString()), false);
                Meetings.Add(m);
                seekEmployee(rdr.GetValue(0).ToString()).addMeeting(m);
            }
        }

        public static void init_contacts()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_contacts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Contacts = new List<Contact>();

            while (rdr.Read())
            {
                ContactStatus cst = (ContactStatus)Enum.Parse(typeof(ContactStatus), rdr.GetValue(3).ToString());
                Contact co = new Contact(DateTime.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), cst, seekCustomer(rdr.GetValue(4).ToString()), false);
                Contacts.Add(co);
            }
        }


        public static void init_requests()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_requests";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Requests = new List<Request>();

            while (rdr.Read())
            {
                RequestStatus rs = (RequestStatus)Enum.Parse(typeof(RequestStatus), rdr.GetValue(2).ToString());
                Request r = new Request(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rs, rdr.GetValue(3).ToString(), int.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), seekSupplier(rdr.GetValue(6).ToString()), seekCustomer(rdr.GetValue(7).ToString()), false);
                Requests.Add(r);
            }
        }

        public static Customer seekCustomer(String id)
        {
            foreach (Customer c in Customers)
            {
                if (c.get_id().Equals(id))
                    return c;
            }
            return null;
        }

        public static Employee seekEmployee(String id)
        {
            foreach (Employee e in Employees)
            {
                if (e.get_id().Equals(id))
                    return e;
            }
            return null;
        }
        public static Employee seekEmployeeByFullName(String fullName)
        {
            foreach (Employee e in Employees)
            {
                if (e.get_fullName().Equals(fullName))
                    return e;
            }
            return null;
        }

        public static Project seekProject(String serialNumber)
        {
            foreach (Project p in Projects)
            {
                if (p.get_serialNumber().Equals(serialNumber))
                    return p;
            }
            return null;
        }

        public static Project seekProjectByName(String projectName)
        {
            foreach (Project p in Projects)
            {
                if (p.get_projectName().Equals(projectName))
                    return p;
            }
            return null;
        }


        public static City seekCity(String cityName)
        {
            foreach (City c in Cities)
            {
                if (c.get_cityName().Equals(cityName))
                    return c;
            }
            return null;
        }

        public static Supplier seekSupplier(String supplierID)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.get_supplierID().Equals(supplierID))
                    return s;
            }
            return null;
        }
        public static Supplier seekSupplierByName(String supplierName)
        {
            foreach (Supplier s in Suppliers)
            {
                if (s.get_supplierName().Equals(supplierName))
                    return s;
            }
            return null;
        }



        public static Apartment seekApartment(int apartmentNum, String serialNumber)
        {
            foreach (Apartment a in Apartments)
            {
                if (a.getApartmentNum().Equals(apartmentNum) && a.getProject().get_serialNumber().Equals(serialNumber))
                    return a;
            }
            return null;
        }


        public static Boolean containCity(string city)
        {
            foreach (City c in Cities)
            {
                if (c.get_cityName().Equals(city))
                    return true;
            }
            return false;
        }
        public static int getNumOfProjects()
        {
            int count = 0;
            foreach (Project p in Program.Projects)
            {
                count += 1;
            }
            return count;

        }
        public static int getNumOfRequests()
        {
            int count = 0;
            foreach (Request p in Program.Requests)
            {
                count += 1;
            }
            return count;

        }

        /* public static void addCity(City c)
         {
             if(Cities.Contains(c)){

             }
             else
             {
                 Cities.Add(c);
                 SqlCommand co = new SqlCommand();
                 co.CommandText = "EXECUTE dbo.SP_add_city(c)";
                 SQL_CON SC = new SQL_CON();
                 SqlDataReader rdr = SC.execute_query(co);

             }
         }*/


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            Application.Run(new Login());


        }









        //[STAThread]
    }

}