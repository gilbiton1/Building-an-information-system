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
    public partial class addCustomer : Form
    {
        private string id, name, email, phone, address, password,empID;
        private DateTime birthdate;
        private float minRange, maxRange;
        private CustomerStatus status;
        private Boolean goodi;
        private void approve_Click(object sender, EventArgs e)
        {
            id = cusID.Text;
            name = cusName.Text;
            email = cusEmail.Text;
            phone = cusPhone.Text;
            address = cusAddress.Text;
            password = cusPassword.Text;
            birthdate = DateTime.Parse(cusBirthdate.Text.ToString());
            
            status= (CustomerStatus)Enum.Parse(typeof(CustomerStatus), comboBoxStatus.Text);
            
            DateTime today = DateTime.Now;
            goodi = true;
            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,8})+)$");
            var namePattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            var passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            var phonePattern = new Regex(@"^0\d{8,9}$");
            var rangePattern = new Regex(@"^[0-9]([-']?[0-9])+$");

            //check ID
            if (string.IsNullOrEmpty(id))
            {
                goodi = false;
                errorID.SetError(cusID, "Please enter ID!");
            }
            else if (id.Length != 9)
            {
                goodi = false;
                errorID.SetError(cusID, "Please enter 9 digits!");
            }
            else
                errorID.SetError(cusID, null);

            //check name
            if (string.IsNullOrEmpty(name))
            {
                goodi = false;
                errorName.SetError(cusName, "Please enter a name!");
            }
            else if (!namePattern.IsMatch(name))
            {
                goodi = false;
                errorName.SetError(cusName, "Please enter only letters");
            }
            else if (name.Length > 20)
            {
                goodi = false;
                errorName.SetError(cusName, "Please enter a name up to 20 characters");
            }
            else
                errorName.SetError(cusName, null);


            //check email
            if (string.IsNullOrEmpty(email))
            {
                goodi = false;
                errorEmail.SetError(cusEmail, "Please enter an email!");
            }
            else if (!emailPattern.IsMatch(email))
            {
                goodi = false;
                errorEmail.SetError(cusEmail, "Please enter an email in format: word@word.word!");
            }
            else if (email.Length > 50)
            {
                goodi = false;
                errorEmail.SetError(cusEmail, "Please enter an email up to 50 characters");
            }
            else
                errorEmail.SetError(cusEmail, null);


            //check phone
            if (string.IsNullOrEmpty(phone))
            {
                goodi = false;
                errorPhone.SetError(cusPhone, "Please enter a phone!");
            }
            else if (!phonePattern.IsMatch(phone))
            {
                goodi = false;
                errorPhone.SetError(cusPhone, "Please enter a valid phone number!");
            }
            else
                errorPhone.SetError(cusPhone, null);


            //check address
            if (string.IsNullOrEmpty(address))
            {
                goodi = false;
                errorAddress.SetError(cusAddress, "Please enter an address!");
            }
            else if (address.Length > 50)
            {
                goodi = false;
                errorAddress.SetError(cusAddress, "Please enter an address up to 50 characters");
            }
            else
                errorAddress.SetError(cusAddress, null);


            //check password
            if (string.IsNullOrEmpty(password))
            {
                goodi = false;
                errorPassword.SetError(cusPassword, "Please enter a password!");
            }
            else if (!passwordPattern.IsMatch(password))
            {
                goodi = false;
                errorPassword.SetError(cusPassword, "Password must be between 6 and 20 characters and contain one uppercase letter, one lowercase letter, one digit and one special character");
            }
            else
                errorPassword.SetError(cusPassword, null);


            //check birthdate
            if (birthdate==null)
            {
                goodi = false;
                errorBirthdate.SetError(cusBirthdate, "Please enter a birth date!");
            }
            else if (DateTime.Compare(birthdate, today) >0)// returns 0 if birthdate is earlier
            {
                goodi = false;
                errorBirthdate.SetError(cusBirthdate, "Please enter a valid birth date!");
            }
            else
                errorBirthdate.SetError(cusBirthdate, null);


            //check minRange
            if (string.IsNullOrEmpty(cusMinRange.Text))
            {
                goodi = false;
                errorMinRange.SetError(cusMinRange, "Please enter minimum range for the customer!");
            }
            else if (!rangePattern.IsMatch(cusMinRange.Text))
            {
                goodi = false;
                errorMinRange.SetError(cusMinRange, "Please enter only digits!");
            }
            else
                errorMinRange.SetError(cusMinRange, null);


            //check maxRange

            if (string.IsNullOrEmpty(cusMaxRange.Text))
            {
                goodi = false;
                errorMaxRange.SetError(cusMaxRange, "Please enter minimum range for the customer!");
            }
            else if (!rangePattern.IsMatch(cusMaxRange.Text))
            {
                goodi = false;
                errorMaxRange.SetError(cusMinRange, "Please enter only digits!");
            }
            else
                errorMaxRange.SetError(cusMaxRange, null);


            if (goodi)//if pass all checks
            {
                if (Program.seekCustomer(id) == null)//the customer isnt exist
                {
                    minRange = float.Parse(cusMinRange.Text.ToString());
                    maxRange = float.Parse(cusMaxRange.Text.ToString());
                    Customer cus = new Customer(id, name, email, phone, birthdate, address, status, minRange, maxRange, password, true);
                    string text = "Customer was added successfully";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePage f = new HomePage(empID, false);
                    f.Show();
                }
                else
                {
                    string text = "Customer is already exists";
                    //this.Hide();
                    MessageBox.Show(text);
                }
            }
        }

        private void cusEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cusAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cusMinRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cusMaxRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cencel_Click(object sender, EventArgs e)
        {
            CRUDEmployee f = new CRUDEmployee(empID);
            f.Show();
            this.Hide();

        }


        public addCustomer(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(CustomerStatus));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
