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
    public partial class ScheduleMeeting : Form
    {
        Employee emp;
        string dateChoosed, hourChoosed;
        string cusId;
        Boolean good;

        public ScheduleMeeting(string cus)
        {
            cusId = cus;
            InitializeComponent();
        }

        private void SMCancel_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(cusId, true);
            f.Show();
            this.Hide();
        }

        private void ScheduleMeeting_Load(object sender, EventArgs e)
        {
            foreach (Employee emp in Program.Employees)
            {
                Boolean added = false;
                foreach (Meeting m in emp.getMeetings())
                {
                    if (m.get_isAvailable()==true && added==false)
                    {
                SMChooseWorker.Items.Add(emp.get_fullName());                  
                    added = true;
                    }
                }
            }




        }

      
        private void chooseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SMChooseWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SMChooseWorker.Text)) {
                MessageBox.Show("please choose worker");
            }
            else
            {
                getAllFreeMeetings();               
            }
        }
        private void getAllFreeMeetings()
        {
            List<DateTime> dates = new List<DateTime>();
            chooseDate.Items.Clear();
            emp = Program.seekEmployeeByFullName(SMChooseWorker.Text);
            foreach (Meeting m in emp.getMeetings())
            {
                if (m.get_time() != null && m.get_isAvailable() == true && m.get_time() >= DateTime.Now)
                {
                    chooseDate.Items.Add(m.get_time().Date);
                    dates.Add(m.get_time());
                }
            }
            monthCalendar1.BoldedDates = dates.ToArray();//bold the free dates
            showRole.Text = Program.seekEmployeeByFullName(SMChooseWorker.Text).get_role().ToString();
            showRole.Visible = true;
        }


        private void SMChooseHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chooseDate.Text))
            {
                MessageBox.Show("please choose Date");
            }
            else
            {
                getFreeHoursPerDate();   
            }
        }

        private void getFreeHoursPerDate()
        {
            SMChooseHour.Items.Clear();
            foreach (Meeting m in emp.getMeetings())
            {
                if (m.get_time().Date.Equals(DateTime.Parse(chooseDate.Text)) && m.get_isAvailable() == true)
                    SMChooseHour.Items.Add(m.get_time().TimeOfDay);
            }
        }


        private void SCScheduled_Click(object sender, EventArgs e)
        {
            
            hourChoosed = SMChooseHour.Text;
            dateChoosed = chooseDate.Text;

            //check nulls
            if (string.IsNullOrEmpty(SMChooseHour.Text))
            {
                good = false;
                nullHour.SetError(SMChooseHour, "please choose hour !");
            }
            else
            {
                good = true;
                nullHour.SetError(SMChooseHour, "");              
                
            }
            if (string.IsNullOrEmpty(chooseDate.Text))
            {
                good = true;
                nullDate.SetError(chooseDate, "please choose date !");
            }
            else
            {
                good = true;
                nullDate.SetError(chooseDate, "");
            }
            if (string.IsNullOrEmpty(SMChooseWorker.Text))
            {
                good = false;
                nullWorker.SetError(SMChooseWorker, "please choose date !");
            }
            else
            {
                good = true;
                nullWorker.SetError(SMChooseWorker, "");
            }

            //search the meeting at employee list of meetings
            if (!string.IsNullOrEmpty(SMChooseWorker.Text))
            {
                foreach (Meeting m in Program.seekEmployeeByFullName(SMChooseWorker.Text).getMeetings())
                {
                    if (!string.IsNullOrEmpty(dateChoosed) && !string.IsNullOrEmpty(hourChoosed))
                    {
                        if ((m.get_time().Date.Equals(DateTime.Parse(dateChoosed).Date) && m.get_time().TimeOfDay.Equals(DateTime.Parse(hourChoosed).TimeOfDay)))
                        {
                            good = true;
                            break;
                        }
                    }
                    good = false;
                }
            }
            if (good)
            {
                ApproveScheduleMeeting f = new ApproveScheduleMeeting(cusId, hourChoosed, dateChoosed);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid details");
            }

        }

        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ScheduleMeeting_Click(object sender, EventArgs e)
        {
       
        }

        private void SMChooseHour_Click(object sender, EventArgs e)
        {

        }

        private void chooseDate_Click(object sender, EventArgs e)
        {

        }

        private void SMChooseHour_Click_1(object sender, EventArgs e)
        {

        }

        private void chooseDate_Click_1(object sender, EventArgs e)
        {

        }

        private void SMChooseHour_Click_2(object sender, EventArgs e)
        {

        }

        private void employeeRole_Click(object sender, EventArgs e)
        {

        }

        private void showRole_Click(object sender, EventArgs e)
        {
        }
    }
}
