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
    public partial class createContact : Form
    {
        Boolean isGood;
        DateTime d;
        string nowTime;
        string customerID;

        public createContact()
        {
            d = DateTime.Now;
            nowTime = d.ToString("1993-06-11:19:45");
            isGood = true;
            InitializeComponent();
        }
        public createContact(string customerID)
        {
            this.customerID = customerID;
            d = DateTime.Now;
            nowTime = d.ToString("1993-06-11:19:45");
            isGood = true;
            InitializeComponent();
        }
        private void CCApprove_Click(object sender, EventArgs e)
        {
            //check null fields
            if (string.IsNullOrEmpty(CCSubject.Text))
            {
                isGood = false;
                subjectError.SetError(CCSubject, "please enter subject!");
            }
            else
            {
                subjectError.SetError(CCSubject, "");
            }



            if (string.IsNullOrEmpty(CCContent.Text))
            {
                isGood = false;
                contentError.SetError(CCContent, "please enter subject!");
            }
            else
            {
           
                contentError.SetError(CCContent, "");
            }
            if (isGood)
            {
                Customer cus = Program.seekCustomer(customerID);
                Contact c = new Contact(d, CCSubject.Text, CCContent.Text, (ContactStatus)Enum.Parse(typeof(ContactStatus), "NotTreated"), cus, true);
                string text = "Your request has been accepted! We will contact you in the coming days";
                this.Hide();
                MessageBox.Show(text);
                HomePage f = new HomePage(customerID, true);
                f.Show();
            }


        }

        private void CCCancel_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(customerID, true);
            f.Show();
            this.Hide();
        }

        private void createContact_Load(object sender, EventArgs e)
        {
            foreach (Employee emp in Program.Employees)
            {
                CCChooseWorker.Items.Add(emp.get_fullName());
            }
        }

        private void CCChooseWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myDate_ValueChanged(object sender, EventArgs e)
        {


        }

        private void CCChooseWorker_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
