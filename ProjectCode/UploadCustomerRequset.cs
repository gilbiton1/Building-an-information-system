using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace partBproject
{
    public partial class UploadCustomerRequset : Form
    {
        string projectName, apartmentNum, supplier, customer;
        Boolean isGood;

        public UploadCustomerRequset(string customerID)
        {
            this.customer = customerID;
            InitializeComponent();

        }
        //private void UploadCustomerRequset_Load
        private void UCCancel_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(customer, true);
            f.Show();
       
            this.Hide();
        }

        private void UCChooseProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

        private void UploadCustomerRequset_Load(object sender, EventArgs e)
        {
            foreach (Project p in Program.Projects)
                UCChooseProject.Items.Add(p.get_projectName());
            foreach (Supplier s in Program.Suppliers)
                UCChooseSupplier.Items.Add(s.get_supplierName());
        }

        private void UCRChooseApartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pROJECTSBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void showDomain_Click(object sender, EventArgs e)
        {
  
        }

        private void UCContentHeadLine_Click(object sender, EventArgs e)
        {

        }

        private void UCRChooseApartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void search_Click(object sender, EventArgs e)
        {
            UCChooseProject.Enabled = false;
            foreach (Apartment a in Program.Apartments)
            {
                if (a.getProject().get_projectName().Equals(UCChooseProject.Text))
                    UCRChooseApartment.Items.Add(a.getApartmentNum());
            }
        }

        private void UCChooseSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDomain.Text = Program.seekSupplierByName(UCChooseSupplier.Text).get_domain().ToString();
            if (UCChooseSupplier.Text != null)
            {
                showDomain.Visible = true;
            }
        }

        private void UCRrichText_TextChanged(object sender, EventArgs e)
        {
            UCRrichText.MaxLength = 200;
        }

        private void UCApprove_Click(object sender, EventArgs e)
        {
            isGood = true;
            projectName = UCChooseProject.Text;
            apartmentNum = UCRChooseApartment.Text;
            supplier = UCChooseSupplier.Text;
            string requestNum = (Program.getNumOfRequests() + 1).ToString();
            if (!string.IsNullOrEmpty(projectName) && !(Program.seekApartment(int.Parse(apartmentNum), Program.seekProjectByName(projectName).get_serialNumber()) == null))
            {
                string projectSerialNum = Program.seekProjectByName(projectName).get_serialNumber();
            }
            else 
            { 
                isGood = false;
                string error = "Apartment was not found !please choose again apartment or project";
                MessageBox.Show(error);
            }



            if (string.IsNullOrEmpty(UCRrichText.Text))
            {
                isGood = false;
                contentError.SetError(UCRrichText, "please enter content!");
            }
            else
            {
                contentError.SetError(UCRrichText, "");
            }
            if (isGood)
            {
                Supplier s = Program.seekSupplierByName(supplier);
                Customer c = Program.seekCustomer(customer);
                Project p = Program.seekProjectByName(projectName);


                Request r = new Request(requestNum, UCRrichText.Text, (RequestStatus)Enum.Parse(typeof(RequestStatus), "InProgress"), requestNum.ToString(), int.Parse(apartmentNum), p.get_serialNumber(), s, c, true);
                string text = "Request was created successfully";
                this.Hide();
                MessageBox.Show(text);
                HomePage f = new HomePage(customer, true);
                f.Show();
            }

        }
    }
}
