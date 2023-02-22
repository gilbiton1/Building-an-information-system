using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partBproject
{
    public partial class createProject : Form
    {

        string name, location, city,empID;
        DateTime endTime;
        Boolean goodi;
        City ci;  
        public createProject(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            CPcomboBoxStage.DataSource = Enum.GetValues(typeof(Stage));
            CPcomboBoxStatus.DataSource = Enum.GetValues(typeof(ProjectStatus));
        }
        private void locationText_TextChanged(object sender, EventArgs e)
        {

        }

        private void createProject_Load(object sender, EventArgs e)
        { 
            label2.Text = (Program.getNumOfProjects() + 1).ToString();


        }


        private void locationText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CPapproveButton_Click_1(object sender, EventArgs e)
        {
            var nameRightPattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            name = projectText.Text.ToString();
            endTime = CPEndTime.Value;
            location = locationText.Text.ToString();
            city = CPCityText.Text.ToString();
            goodi = true;

            //valid name
            if (string.IsNullOrEmpty(name))
            {
                goodi = false;
                nameError.SetError(projectText, "Please enter project name!");
            }
            else if (name.Length > 20)
            {
                goodi = false;
                nameError.SetError(projectText, "Please enter a name up to 20 character");
            }
            else if (!(nameRightPattern.IsMatch(name)))
            {
                goodi = false;
                nameError.SetError(projectText, "valid name must contain only letters");
            }
            else if (!nameRightPattern.IsMatch(name))
            {
                goodi = false;
                nameError.SetError(projectText, "Please use only small letters. At least 2 letters to the name");

            }
            else
                nameError.SetError(projectText, null);



            //valid location
            if (string.IsNullOrEmpty(location))
            {
                goodi = false;
                locationError.SetError(locationText, "Please enter a location!");
            }
            else if (location.Length > 50)
            {
                goodi = false;
                locationError.SetError(locationText, "Please enter a location up to 50 character");
            }
            else if (!(nameRightPattern.IsMatch(location)))
            {
                goodi = false;
                locationError.SetError(locationText, "valid location must contain only letters");
            }
            else if (!nameRightPattern.IsMatch(location))
            {
                goodi = false;
                nameError.SetError(locationText, "Please use only small letters. At least 2 letters to the location");

            }
            else
                locationError.SetError(locationText, null);




            //valid city
            if (string.IsNullOrEmpty(city))
            {
                goodi = false;
                cityError.SetError(CPCityText, "Please enter a city!");
            }
            else if (city.Length > 20)
            {
                goodi = false;
                cityError.SetError(CPCityText, "Please enter a city up to 20 character");

            }
            else if (!nameRightPattern.IsMatch(city))
            {
                goodi = false;
                cityError.SetError(CPCityText, "valid city must contain only letters");
            }
            else if (!nameRightPattern.IsMatch(city))
            {
                goodi = false;
                nameError.SetError(CPCityText, "Please use only small letters. At least 2 letters to the city");

            }
            else
            {
                cityError.SetError(CPCityText, null);

            }

            if (goodi)
            {
                if (!Program.containCity(CPCityText.Text))
                    ci = new City(CPCityText.Text, true);
                ci = Program.seekCity(CPCityText.Text);
                Project p = new Project(label2.Text, name, endTime, location, (Stage)Enum.Parse(typeof(Stage), CPcomboBoxStage.Text), (ProjectStatus)Enum.Parse(typeof(ProjectStatus), CPcomboBoxStatus.Text), false, ci, true);
                string text = "Project was created successfully";
                this.Hide();
                MessageBox.Show(text);
                HomePage f = new HomePage(empID, false);
                f.Show();
            }
        }



        private void CPcancelButton_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(empID, false);
            f.Show();
            this.Hide();
        }

    }
}
