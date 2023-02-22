using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace partBproject
{
    public partial class addEmployee : Form
    {
        private string id, role, gender, email, name, lastName, password,empID;
        private Boolean isExternal, goodi;
       
        
        private void cencel_Click(object sender, EventArgs e)
        {
            CRUDEmployee f = new CRUDEmployee(empID);
            f.Show();
            this.Hide();
        }
        
     
        public addEmployee(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            comboBoxRole.DataSource = Enum.GetValues(typeof(EmployeeRole));
            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
        }
        
        private void approve_Click(object sender, EventArgs e)
        {
            id = EmpID.Text;
            role = comboBoxRole.Text;
            gender = comboBoxGender.Text;
            email = empEmail.Text;
            name = EmpName.Text;
            lastName = empLastName.Text;
            password = empPassword.Text;
            isExternal = checkBox1.Checked;
            goodi = true;

            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$");
            var namePattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            var passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");


            //check ID
            if (string.IsNullOrEmpty(id))
            {
                goodi = false;
                errorID.SetError(EmpID, "Please enter ID!");
            }
            else if (id.Length != 9)
            {
                goodi = false;
                errorID.SetError(EmpID, "Please enter 9 digits!");
            }
            else
                errorID.SetError(EmpID, null);

            

            //check email
            if (string.IsNullOrEmpty(email))
            {
                goodi = false;
                errorEmail.SetError(empEmail, "Please enter an email!");
            }
            else if (!emailPattern.IsMatch(email))
            {
                goodi = false;
                errorEmail.SetError(empEmail, "Please enter an email in format: word@word.word!");
            }
            else if (email.Length > 50)
            {
                goodi = false;
                errorEmail.SetError(empEmail, "Please enter an email up to 50 characters");
            }
            else
                errorEmail.SetError(empEmail, null);

            //check name
            if (string.IsNullOrEmpty(name))
            {
                goodi = false;
                errorName.SetError(EmpName, "Please enter a name!");
            }
            else if (!namePattern.IsMatch(name)) {
                goodi = false;
                errorName.SetError(EmpName, "Please enter only small letters");
            }
            else if (name.Length > 20)
            {
                goodi = false;
                errorName.SetError(EmpName, "Please enter a name up to 20 characters");
            }
            else
                errorName.SetError(EmpName, null);

            //check last name
            if (string.IsNullOrEmpty(lastName))
            {
                goodi = false;
                errorLastName.SetError(empLastName, "Please enter a last name!");
            }
            else if (!namePattern.IsMatch(lastName))
            {
                goodi = false;
                errorLastName.SetError(empLastName, "Please enter only  small letters");
            }
            else if (lastName.Length > 20)
            {
                goodi = false;
                errorLastName.SetError(empLastName, "Please enter a last name up to 20 characters");
            }
            else
                errorLastName.SetError(empLastName, null);

            //check password
            if (!passwordPattern.IsMatch(password))
            {
                goodi = false;
                errorPassword.SetError(empPassword, "Password must be between 6 and 20 characters and contain one uppercase letter, one lowercase letter, one digit and one special character");
            }
            else
                errorPassword.SetError(empPassword, null);


            if (goodi)
            {
                if (Program.seekEmployee(id) == null)
                {
                    Employee emp = new Employee(id, (EmployeeRole)Enum.Parse(typeof(EmployeeRole), comboBoxRole.Text), (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text), email, name, lastName, password, isExternal, true);
                    string text = "Employee was added successfully";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePage f = new HomePage(empID,false);
                    f.Show();
                }
                else
                {
                    string text = "Employee is already exists";
                    this.Hide();
                    MessageBox.Show(text);
                }
            }
        }


        private void empEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
