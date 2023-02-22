using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partBproject
{
    public partial class HomePage : Form
    {
        string cusId;
        public HomePage(string user, Boolean isCus)
        {
            cusId = user;
            InitializeComponent();
            if (isCus == true)//customer
            {
                enterTimeMeetings.Visible = false;
                createProject.Visible = false;
                CRUDCustomer.Visible = false;
                CRUDSupplier.Visible = false;
                CRUDemployees.Visible = false;             
            }
            else
            {//worker
                Employee emp = Program.seekEmployee(user);
                string role = Program.seekEmployee(user).get_role().ToString();
                scheduleAmeeting.Visible = false;
                createContact.Visible = false;
                uploadCustomerRequset.Visible = false;

                if (role.Equals("SecurityHead") || role.Equals("Secretary"))
                {
                    enterTimeMeetings.Visible = true;
                    createProject.Visible = false;
                }
                else if (role.Equals("Ceo"))
                {
                    enterTimeMeetings.Visible = true;
                    scheduleAmeeting.Visible = true;
                    createContact.Visible = true;
                    uploadCustomerRequset.Visible = true;
                }
                else if (emp.get_isExternal())
                {
                    enterTimeMeetings.Visible = false;
                    createProject.Visible = false;
                    CRUDCustomer.Visible = false;
                    CRUDemployees.Visible = false;
                    CRUDSupplier.Visible = false; 
                }
                else
                {
                    CRUDCustomer.Visible = true;
                    CRUDemployees.Visible = true;
                    CRUDSupplier.Visible = true;
                    enterTimeMeetings.Visible = false;
                    createProject.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//secratery and head secratery only
        {
            EnterMeetingTimes em = new EnterMeetingTimes(cusId);
            em.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void scheduleAmeeting_Click(object sender, EventArgs e)//customer only
        {
            ScheduleMeeting s = new ScheduleMeeting(cusId);//SEND CUS
            s.Show();
            this.Hide();
        }

        private void createContact_Click(object sender, EventArgs e)//customer only
        {
            createContact t = new createContact(cusId);//SEND CUS
            t.Show();
            this.Hide();
        }

        private void uploadCustomerRequset_Click(object sender, EventArgs e)//customer only
        {
            UploadCustomerRequset u = new UploadCustomerRequset(cusId);//SEND CUS
            u.Show();
            this.Hide();

        }

        private void createProject_Click(object sender, EventArgs e)//ceo only
        {
            createProject c = new createProject(cusId);
            c.Show();
            this.Hide();
        }

        private void CRUDemployees_Click(object sender, EventArgs e)
        {
            CRUDEmployee c = new CRUDEmployee(cusId);
            c.Show();
            this.Hide();
        }

        private void CRUDSupplier_Click_1(object sender, EventArgs e)
        {
            CRUDSupplier c = new CRUDSupplier(cusId);
            c.Show();
            this.Hide();
        }

        private void CRUDCustomer_Click(object sender, EventArgs e)
        {
            CRUDCustomer c = new CRUDCustomer(cusId);
            c.Show();
            this.Hide();
        }
    }
}