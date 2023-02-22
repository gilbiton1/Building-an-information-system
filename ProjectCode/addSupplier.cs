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
    public partial class addSupplier : Form
    {

        private string id, name, address, phone,empID;
        private Proffesion proffesion;
        private Boolean goodi;

        private void cancel_Click(object sender, EventArgs e)
        {
            CRUDSupplier f = new CRUDSupplier(empID);
            f.Show();
            this.Hide();
        }

        private void approve_Click(object sender, EventArgs e)
        {
            id = supID.Text;
            name = supName.Text;
            address = supAddress.Text;
            proffesion = (Proffesion)Enum.Parse(typeof(Proffesion), comboBoxProff.Text);
            phone = supPhone.Text;
            goodi = true;

            var namePattern = new Regex(@"^[a-z]([ -']?[a-z])+$");
            var phonePattern = new Regex(@"^0\d{8,9}$");

            //check ID
            if (string.IsNullOrEmpty(id))
            {
                goodi = false;
                errorID.SetError(supID, "Please enter ID!");
            }
            else if (id.Length != 9)
            {
                goodi = false;
                errorID.SetError(supID, "Please enter 9 digits!");
            }
            else
                errorID.SetError(supID, null);

            //check name
            if (string.IsNullOrEmpty(name))
            {
                goodi = false;
                errorName.SetError(supName, "Please enter a name!");
            }
            else if (!namePattern.IsMatch(name))
            {
                goodi = false;
                errorName.SetError(supName, "Please enter only small letters");
            }
            else if (name.Length > 20)
            {
                goodi = false;
                errorName.SetError(supName, "Please enter a name up to 20 characters");
            }
            else
                errorName.SetError(supName, null);

            //check address
            if (string.IsNullOrEmpty(address))
            {
                goodi = false;
                errorAddress.SetError(supAddress, "Please enter an address!");
            }
            else if (address.Length > 50)
            {
                goodi = false;
                errorAddress.SetError(supAddress, "Please enter an address up to 50 characters");
            }
            else
                errorAddress.SetError(supAddress, null);

            //check phone
            if (string.IsNullOrEmpty(phone))
            {
                goodi = false;
                errorPhone.SetError(supPhone, "Please enter a phone!");
            }
            else if (!phonePattern.IsMatch(phone))
            {
                goodi = false;
                errorPhone.SetError(supPhone, "Please enter a valid phone number!");
            }
            else
                errorPhone.SetError(supPhone, null);

            if (goodi)
            {
                if (Program.seekSupplier(id) == null)
                {
                    Supplier sup = new Supplier(id, name, address, proffesion, phone, true);
                    string text = "Supplier was added successfully";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePage f = new HomePage(empID, false);
                    f.Show();
                }
                else
                {
                    string text = "Supplier is already exists";
                    this.Hide();
                    MessageBox.Show(text);
                }
            }
        }

        private void addSupplier_Load(object sender, EventArgs e)
        {

        }

        public addSupplier(string empID)
        {
            this.empID = empID;
            InitializeComponent();
            comboBoxProff.DataSource = Enum.GetValues(typeof(Proffesion));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
