using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;


        public Form1()
        {
            InitializeComponent();
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton10_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton9_Click(object sender, EventArgs e)
        {
                    }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void Location_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void MetroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();

        }

        private void Subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        
    }

        private void Lectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
           addlec.Show();
            
        }

        private void Lecbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();

        }

        private void Subjectbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();

        }

        private void Sessionbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions addsession = new Sessions();
            addsession.Show();

        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void optbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advanced ad = new Advanced();
            ad.Show();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generate_Timetable gentime = new Generate_Timetable();
            gentime.Show();
        }

        private void Statbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics stat = new Statistics();
            stat.Show();
        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }
    }
}
