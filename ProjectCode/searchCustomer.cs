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
    public partial class searchCustomer : Form
    {
        private string id, name, email, phone, address, password,empID;
        private DateTime birthdate;
        private float minRange, maxRange;
        private Customer existCus;

        private void cusPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cencel_Click(object sender, EventArgs e)
        {
            CRUDCustomer f = new CRUDCustomer(empID);
            f.Show();
            this.Hide();
        }

        private CustomerStatus status;
        private Boolean goodi;

        private void approve_Click(object sender, EventArgs e)
        {
            id = cusID.Text;
            name = cusName.Text;
            email = cusEmail.Text;
            phone = cusPhone.Text;
            birthdate = DateTime.Parse(cusBirthdate.Text.ToString());
            address = cusAddress.Text;
            status = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), comboBoxStatus.Text);
            //minRange = float.Parse(cusMinRange.Text.ToString());
            //maxRange = float.Parse(cusMaxRange.Text.ToString());
            password = cusPassword.Text;

            goodi = true;

            DateTime today = DateTime.Now;
            var emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var namePattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            var passwordPattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            var phonePattern = new Regex(@"^0\d{8,9}$");

            if(string.IsNullOrEmpty(id))
            {
                goodi = false;
                errorID.SetError(cusID, "Please enter an ID!");
            }

            //check name
            if (string.IsNullOrEmpty(name))
            {
                goodi = false;
                errorName.SetError(cusName, "Please enter a name!");
            }
            else if (!namePattern.IsMatch(name))
            {
                goodi = false;
                errorName.SetError(cusName, "Please enter only letters!");
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
            if (birthdate == null)
            {
                goodi = false;
                errorBirthdate.SetError(cusBirthdate, "Please enter a birth date!");
            }
            else if (DateTime.Compare(birthdate, today) > 0)// returns 0 if birthdate is earlier
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
            else
                errorMinRange.SetError(cusMinRange, null);

            //check maxRange

            if (string.IsNullOrEmpty(cusMaxRange.Text))
            {
                goodi = false;
                errorMaxRange.SetError(cusMaxRange, "Please enter minimum range for the customer!");
            }
            else
                errorMaxRange.SetError(cusMaxRange, null);

            if (goodi)
            {
                minRange = float.Parse(cusMinRange.Text.ToString());
                maxRange = float.Parse(cusMaxRange.Text.ToString());
                existCus.set_name(name);
                existCus.set_email(email);
                existCus.set_mobilePhone(phone);
                existCus.set_dateOfBirth(birthdate);
                existCus.set_address(address);
                existCus.set_customerStatus(status);
                existCus.set_minRange(minRange);
                existCus.set_maxRange(maxRange);
                existCus.set_password(password);
                existCus.updateCustomer();
                string text = "Customer was updated successfully";
                this.Hide();
                MessageBox.Show(text);
                HomePage f = new HomePage(empID, false);
                f.Show();
            }
        }

       
        public searchCustomer(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            comboBoxStatus.DataSource = Enum.GetValues(typeof(CustomerStatus));

        }

        private void searchCustomer_Load(object sender, EventArgs e)
        {
            cusName.Hide();
            cusEmail.Hide();
            cusPhone.Hide();
            cusBirthdate.Hide();
            cusAddress.Hide();
            comboBoxStatus.Hide();
            cusMinRange.Hide();
            cusMaxRange.Hide();
            cusPassword.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            id = cusID.Text;
            name = cusName.Text;
            email = cusEmail.Text;
            phone = cusPhone.Text;
            birthdate = DateTime.Parse(cusBirthdate.Text.ToString());
            address = cusAddress.Text;
            status = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), comboBoxStatus.Text);
         
            password = cusPassword.Text;

            if (Program.seekCustomer(cusID.Text) == null)
            {
                string text = "Customer not exists in system";
                MessageBox.Show(text);
            }
            else
            {
                foreach (Customer cu in Program.Customers)
                {
                    if (cu.get_id().Equals(id))
                    {
                        cusName.Text = cu.get_name();
                        cusEmail.Text = cu.get_email();
                        cusPhone.Text = cu.get_mobilePhone();
                        cusBirthdate.Text = cu.get_dateOfBirth().ToString();//check
                        cusAddress.Text = cu.get_address();
                        comboBoxStatus.Text = cu.get_customerStatus().ToString();
                        cusMinRange.Text = cu.get_minRange().ToString();
                        cusMaxRange.Text = cu.get_maxRange().ToString();
                        cusPassword.Text = cu.get_password();
                        existCus = cu;
                    }
                }
                cusName.Show();
                cusEmail.Show();
                cusPhone.Show();
                cusBirthdate.Show();
                cusAddress.Show();
                comboBoxStatus.Show();
                cusMinRange.Show();
                cusMaxRange.Show();
                cusPassword.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                cusID.Enabled = false;
            }

        }
    }
}
