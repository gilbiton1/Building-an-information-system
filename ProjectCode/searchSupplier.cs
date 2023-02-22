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
    public partial class searchSupplier : Form
    {
        private string id, name, address, phone,empID;
        private Proffesion proffesion;
        private Boolean goodi;
        private Supplier existSup;

        private void cancel_Click(object sender, EventArgs e)
        {
            CRUDSupplier f = new CRUDSupplier(empID);
            f.Show();
            this.Hide();
        }

        private void supID_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            id = supID.Text;
            //name = supName.Text;
            //address = supAddress.Text;
            //proffesion = (Proffesion)Enum.Parse(typeof(Proffesion), comboBoxProff.Text);
            //phone = supPhone.Text;

            if (Program.seekSupplier(supID.Text) == null)
            {
                string text = "Supplier not exists in system";
                MessageBox.Show(text);
            }
            else
            {
                existSup = Program.seekSupplier(supID.Text);
                supName.Text = existSup.get_supplierName();
                supAddress.Text = existSup.get_supplierAddress();
                ///comboBoxProff.Text = s.get_domain().ToString();
               // comboBox1.DataSource = Enum.GetValues(typeof(Proffesion));
                comboBoxProff.Text = existSup.get_domain().ToString();
                supPhone.Text = existSup.get_phoneNumber();

                   
                
                supName.Show();
                supAddress.Show();
                comboBoxProff.Show();
                supPhone.Show();

                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                supID.Enabled = false;
            }
        }

  
        private void searchSupplier_Load(object sender, EventArgs e)
            {
                supName.Hide();
                supAddress.Hide();
            comboBoxProff.Hide();
                supPhone.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
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

            if (string.IsNullOrEmpty(id))
            {
                goodi = false;
                errorName.SetError(supID, "Please enter an id!");
            }

            //check name
            if (string.IsNullOrEmpty(name))
                {
                    goodi = false;
                    errorName.SetError(supName, "Please enter a name!");
                }
                else if (!namePattern.IsMatch(name))
                {
                    goodi = false;
                    errorName.SetError(supName, "Please enter only small letters!");
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
                    existSup.set_supplierName(name);
                    existSup.set_supplierAddress(address);
                    existSup.set_domain(proffesion);
                    existSup.set_phoneNumber(phone);
                    existSup.updateSupplier();
                    string text = "Supplier was updated successfully";
                    this.Hide();
                    MessageBox.Show(text);
                    HomePage f = new HomePage(empID, false);
                    f.Show();
            }
            }
        


            public searchSupplier(string empID)
            {
                this.empID = empID;
                InitializeComponent();
                comboBoxProff.DataSource = Enum.GetValues(typeof(Proffesion));

            }
    }
}
