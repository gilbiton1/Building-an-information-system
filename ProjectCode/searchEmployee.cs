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

namespace partBproject
{
    public partial class searchEmployee : Form
    {
        private string id, email, name, lastName, password,empID;
        private EmployeeRole role;
        private Gender gender;
        private Boolean isExternal, goodi;
        private Employee existEmp;
        private void approve_Click(object sender, EventArgs e)
        {
            id = EmpID.Text;
            role = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), comboBoxRole.Text);
            gender = (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text);
            email = empEmail.Text;
            name = EmpName.Text;
            lastName = empLastName.Text;
            password = empPassword.Text;
            isExternal = checkBox1.Checked;
            goodi = true;

            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var namePattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            var passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if(string.IsNullOrEmpty(id))
            {
                goodi = false;
                SEerrorID.SetError(EmpID, " Please enter an ID!");
            }
       
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
            else if (!namePattern.IsMatch(name))
            {
                goodi = false;
                errorName.SetError(EmpName, "Please enter only small letters!");
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
                errorLastName.SetError(empLastName, "Please enter only small letters!");
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
                existEmp.set_role(role);
                existEmp.set_gender(gender);
                existEmp.set_email(email);
                existEmp.set_firstName(name);
                existEmp.set_lastName(lastName);
                existEmp.set_password(password);
                existEmp.set_isExternal(isExternal);
                existEmp.updateEmployee();
                string text = "Employee was updated successfully";
                this.Hide();
                MessageBox.Show(text);
                HomePage f = new HomePage(empID, false);
                f.Show();


            }
        }

        private void searchEmployee_Load(object sender, EventArgs e)
        {
            comboBoxRole.Hide();
            comboBoxGender.Hide();
            empEmail.Hide();
            EmpName.Hide();
            empLastName.Hide();
            empPassword.Hide();
            checkBox1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void cencel_Click(object sender, EventArgs e)
        {
            CRUDEmployee f = new CRUDEmployee(empID);
            f.Show();
            this.Hide();
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }


        public searchEmployee(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            comboBoxRole.DataSource = Enum.GetValues(typeof(EmployeeRole));
            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            id = EmpID.Text;
            role = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), comboBoxRole.Text);
            gender = (Gender)Enum.Parse(typeof(Gender), comboBoxGender.Text);
            email = empEmail.Text;
            name = EmpName.Text;
            lastName = empLastName.Text;
            password = empPassword.Text;
            isExternal = checkBox1.Checked;
            if (Program.seekEmployee(EmpID.Text) == null)
            {
                string text = "Employee not exists in system";
                MessageBox.Show(text);
            }
            else
            {
                foreach(Employee em in Program.Employees)
                {
                    if (em.get_id().Equals(id))
                    {
                        comboBoxRole.Text=em.get_role().ToString();
                        comboBoxGender.Text=em.get_gender().ToString();
                        empEmail.Text=em.get_email();
                        EmpName.Text=em.get_firstName();
                        empLastName.Text = em.get_lastName();
                        empPassword.Text=em.get_password();
                        checkBox1.Checked = em.get_isExternal();
                        existEmp = em;
                    }
                }
                comboBoxRole.Show();
                comboBoxGender.Show();
                empEmail.Show();
                EmpName.Show();
                empLastName.Show();
                empPassword.Show();
                checkBox1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                EmpID.Enabled = false ;
            }
        }
        private void bottom1_Click(object sender, EventArgs e)
        {

        }
    }
}
