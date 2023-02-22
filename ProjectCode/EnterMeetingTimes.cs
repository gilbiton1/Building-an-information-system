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
    public partial class EnterMeetingTimes : Form
    {
        string empID;
        public Employee empl;
        private Meeting m;
        private Boolean goodi;
        public EnterMeetingTimes(string empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EMschedule_Click(object sender, EventArgs e)
        {
             goodi = true;
            DateTime dd = DateTime.Parse(dateMeet.Text);
            DateTime Today = DateTime.Now;
            if (DateTime.Compare(dd, Today) < 0)
            {//return <0 if dd earlier, return 1 if Today earlier
                DateError.SetError(dateMeet, "Valid date must be in the future");
                goodi = false;
            }
            else
            {
                DateError.SetError(dateMeet, "");
            }
           
            DateTime hh = DateTime.Parse(this.TimeMeet.Text);
            TimeSpan hourMin;
            hourMin = hh.TimeOfDay;
            if (hourMin >= new TimeSpan(08, 00, 0) && hourMin <= new TimeSpan(19, 00, 0))
            {
                TimeError.SetError(TimeMeet, "");
                goodi = false;
            }
            else
            {
                TimeError.SetError(TimeMeet, "Work hours musr be between 8:00 - 19:00");
                goodi = false;
            }
            if (string.IsNullOrEmpty(comboBoxWorker.Text))
            {
                errorWorker.SetError(comboBoxWorker, "Please enter an employee!");
                goodi = false;
            }
            else
            {
                errorWorker.SetError(comboBoxWorker, "");
            }


            var fullDate = dd.Date + hh.TimeOfDay;

            //check if the worker already have a meeting at this time
            if (IsFree(fullDate, Program.seekEmployeeByFullName(comboBoxWorker.Text)) == false)
            {
                MessageBox.Show("This employee already has a meeting at this time!");
                goodi = false;
            }
            else
            {
                goodi = true;
            }

            Customer cus1 = Program.seekCustomer("0");  //customer is null at this point
                Employee emp = Program.seekEmployeeByFullName(comboBoxWorker.Text.ToString());
            if (emp == null)
                goodi = false;
                if (goodi) {
                    m = new Meeting(emp, DateTime.Parse(fullDate.ToString()), 30, cus1, true, true);      
                    MessageBox.Show("created successfully");
                    HomePage f = new HomePage(empID, false);
                    f.Show();
                this.Hide();
                }
            
        }


        private void EnterMeetingTimes_Load(object sender, EventArgs e)
        {

        }

        private void EnterMeetingTimes_Load_1(object sender, EventArgs e)
        {
            dataGridMeetings.Hide();

            foreach (Employee em in Program.Employees)
            {             
               comboBoxWorker.Items.Add(em.get_fullName());
            }
        }
        //check if the worker already have a meeting at this time
        private Boolean IsFree(DateTime e, Employee employee)
        {
            foreach (Meeting me in Program.Meetings)
            {
                if (me.get_Employee().Equals(employee))
                {
                    if (e >= me.get_time() && e <= me.get_time().AddMinutes(30))
                    {
                        return false;
                    } //me.get_time().CompareTo(e))
                    if (e >= me.get_time().AddMinutes(-30) && e<=me.get_time())
                        return false;

                }
            }
            return true;
        }

        private void TimeMeet_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dateMeet_ValueChanged(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

   

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EMCCancel_Click(object sender, EventArgs e)
        {
           
            HomePage g = new HomePage(empID,false);
            g.Show();           
            this.Hide();
        }

        private void showMeetings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWorker.Text))
            {
                string text = "Please choose an employee";
                MessageBox.Show(text);
            }

            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Date");
                dt.Columns.Add("Hour");
                empl = Program.seekEmployeeByFullName(comboBoxWorker.Text);

                foreach (Meeting m in Program.Meetings)
                {
                    if (empl.get_id().Equals(m.get_Employee().get_id()))
                    {
                        String x = m.get_time().ToString("dd/MM/yyyy");
                        String y = m.get_time().ToString("HH:mm");
                        dt.Rows.Add(x, y);
                    }
                }
                dataGridMeetings.DataSource = dt;
                dataGridMeetings.Show();

            }
        }
    }
}
