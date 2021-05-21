using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class Statistics : MetroForm
    {
        SqlConnection con;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            totalLecturerCount();
            totalStudentCount();
            totalSubjectCount();
            totalRoomCount();
            latestlecturer();
            latestgroup();
            latestSubject();
        }
        
        //calculating Registered Lecturer Count
        
        private void totalLecturerCount()
        {
            con = ConnectionManager.GetConnection();
            con.Open(); 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(lecID) as lecCount FROM Lecture";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lec_count = (string)dr["lecCount"].ToString();
                RegLecturers.Text = lec_count;
            }
            con.Close();

        }
        
        //calculating Registered Student Count
        
        private void totalStudentCount()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(ID) as stdCount FROM Students";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string std_count = (string)dr["stdCount"].ToString();
                RegStudents.Text = std_count;
            }
            con.Close();

        }
        
        //calculating Registered Subject Count
        
        private void totalSubjectCount()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(SubCode) as subCount FROM Subject";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sub_count = (string)dr["subCount"].ToString();
                RegSubjects.Text = sub_count;
            }
            con.Close();

        }

        //calculating Registered Room Count
        
        private void totalRoomCount()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(s_ID) as roomCount FROM RoomSession";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string room_count = (string)dr["roomCount"].ToString();
                RegRooms.Text = room_count;
            }
            con.Close();

        }
        
        //Getting Latest Lecturer
        
        private void latestlecturer()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT lecname as lateLec FROM Lecture ORDER BY NO ";
            cmd.ExecuteNonQuery(); 
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string late_lec = (string)dr["lateLec"].ToString();
                LatestLec.Text = late_lec;
            }
            con.Close();

        }
        
         //Getting Latest Group
         
        private void latestgroup()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Main_Group_ID as lategrp FROM Students Where ID=(SELECT MAX(ID) FROM Students)";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string late_grp = (string)dr["lategrp"].ToString();
                LatestGroup.Text = late_grp;
            }
            con.Close();

        }
        
         //Getting Latest Subject

        private void latestSubject()
        {
            con = ConnectionManager.GetConnection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubName as latesub FROM Subject ORDER BY ID ";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string late_sub = (string)dr["latesub"].ToString();
                LatestSub.Text = late_sub;
            }
            con.Close();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegLecturers_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegSubjects_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void LatestLec_TextChanged(object sender, EventArgs e)
        {

        }

        private void LatestGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void LatestSub_TextChanged(object sender, EventArgs e)
        {

        }

        //Linking to Dashboard
        
        private void dashboard_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void locations_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();
        }

        private void subjects_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void students_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void tagpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }
    }
}
