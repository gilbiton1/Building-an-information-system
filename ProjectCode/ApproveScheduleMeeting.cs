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
    public partial class ApproveScheduleMeeting : Form
    {
        string cusID,dateChoosed,hourChoosed;
        public ApproveScheduleMeeting(string cusID,string hourChoosed,string dateChoosed)
        {
            this.cusID = cusID;
            this.dateChoosed = dateChoosed;
            this.hourChoosed = hourChoosed;
            InitializeComponent();
        }

     
        public void yesButton_Click(object sender, EventArgs e)
        {

            updateMeetingDetails();            
        
            this.Hide();
            anotherMeetingForm a = new anotherMeetingForm(cusID);
            a.Show();

        }

        private void updateMeetingDetails()
        {
            foreach (Meeting m in Program.Meetings)
            {
                if (!string.IsNullOrEmpty(dateChoosed) && !string.IsNullOrEmpty(hourChoosed))//prevent null errors
                {
                    if (m.get_time().Date.Equals(DateTime.Parse(dateChoosed).Date) && m.get_time().TimeOfDay.Equals(DateTime.Parse(hourChoosed).TimeOfDay))// search the meeting
                    {
                        setMeetingCustomer(m, Program.seekCustomer(cusID));
                        m.set_isAvailable(false);
                        Program.seekCustomer(cusID).addMeeting(m);
                        MessageBox.Show("successed");
                    }
                }
            }
        }

        private void setMeetingCustomer(Meeting m, Customer cus)
        {
            m.set_Customer(cus);
        }

        public void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleMeeting f = new ScheduleMeeting(cusID);
            f.Show();
        }
        private void ApproveScheduleMeeting_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
