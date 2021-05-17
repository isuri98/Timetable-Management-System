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
    public partial class Rooms : MetroForm
    {
        int ID;
        int S_ID;
        int L_ID;
        int G_ID;
        int P_ID;
        int s_ID;
        int CS_ID;

        SqlConnection con;
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {

            String query1 = "Select * from RoomTags";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvtags.AutoGenerateColumns = true;
                dgvtags.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query3 = "Select * from RoomSubjects";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query3, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvsubjectroom.AutoGenerateColumns = true;
                dgvsubjectroom.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            String query4 = "Select * from RoomLecturers";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query4, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvlecroom.AutoGenerateColumns = true;
                dgvlecroom.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query5 = "Select * from RoomGroups";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query5, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvgroup.AutoGenerateColumns = true;
                dgvgroup.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query6 = "Select * from PreferredRooms";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query6, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvpreferred.AutoGenerateColumns = true;
                dgvpreferred.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query7 = "Select * from RoomSession";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query7, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvsessionroom.AutoGenerateColumns = true;
                dgvsessionroom.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query8 = "Select * from RoomConsecutive";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query8, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvconsessionroom.AutoGenerateColumns = true;
                dgvconsessionroom.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query9 = "select ID, (Session1 + ' ' + Session2 + ' ' + Day_) AS NAME from Consective ";
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString));

                SqlDataAdapter da4 = new SqlDataAdapter(query9, con);//load consecutive session comboxes
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "Consective");

                txtconsecutive.DisplayMember = "NAME"; //load consecutive box
                txtconsecutive.ValueMember = "ID";
                txtconsecutive.DataSource = ds4.Tables["Consective"];

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query10 = "select SID, (SubjectCode + ' ' + Tag + ' By ' + Lecturer + ' for ' + GroupID) AS NAME from Sessions ";
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString));

                SqlDataAdapter da5 = new SqlDataAdapter(query10, con);//load session comboxes
                DataSet ds5 = new DataSet();
                da5.Fill(ds5, "Sessions");

                txtsession.DisplayMember = "NAME"; //load session box
                txtsession.ValueMember = "ID";
                txtsession.DataSource = ds5.Tables["Sessions"];

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomGroups (Group_Or_SubGroup,Room) VALUES ('" + txtgroup.Text + "','" + txtgrproom.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomGroups";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvgroup.DataSource = dt;

                con.Close();


                txtgroup.Text = "";
                txtgrproom.SelectedIndex = -1;



                tagtab.SelectedTab = roomgrppage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void Lectures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();
        }

        private void Subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void Students_Click(object sender, EventArgs e)
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

        private void lecturertabpage_Click(object sender, EventArgs e)
        {

        }

        private void btnlecsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomTags (Tag_Name,Room) VALUES ('" + txttag.Text + "','" + txtroom.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomTags";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvtags.DataSource = dt;

                con.Close();


                txttag.SelectedIndex = -1;
                txtroom.SelectedIndex = -1;



                tagtab.SelectedTab = roomtagpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void managelectab_Click(object sender, EventArgs e)
        {

        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomSubjects (Subject_Name,Room) VALUES ('" + txtsubject.Text + "','" + txtsubroom.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomSubjects";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvsubjectroom.DataSource = dt;

                con.Close();


                txtsubject.SelectedIndex = -1;
                txtsubroom.SelectedIndex = -1;



                tagtab.SelectedTab = roomsubpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void roomlecpage_Click(object sender, EventArgs e)
        {

        }

        private void btnaddlecroom_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomLecturers (Lecturer_Name,Room) VALUES ('" + txtselectlec.Text + "','" + txtroomlec.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomLecturers";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvlecroom.DataSource = dt;

                con.Close();


                txtselectlec.Text = "";
                txtroomlec.SelectedIndex = -1;



                tagtab.SelectedTab = roomlecpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void roomgrppage_Click(object sender, EventArgs e)
        {

        }

        //ADD PREFERED ROOMS
        private void btnaddPrefer_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PreferredRooms (Subject_Name,Tag,Room) VALUES ('" + txtsubtagroom.Text + "','" + txttagsub.Text + "','" + txtsubtag.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from PreferredRooms";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvpreferred.DataSource = dt;

                con.Close();


                txtsubtagroom.SelectedIndex = -1;
                txttagsub.SelectedIndex = -1;
                txtsubtag.SelectedIndex = -1;



                tagtab.SelectedTab = roomsubtagpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }

        }
        //ADD ROOMS FOR SESSIONS
        private void btnAddSession_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomSession (Session,Room) VALUES ('" + txtsession.Text + "','" + txtsessionroom.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomSession";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvsessionroom.DataSource = dt;

                con.Close();

                
                txtsession.SelectedIndex = -1;
                txtsessionroom.SelectedIndex = -1;
               


                tagtab.SelectedTab = roomsessiontabpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //ADD ROOMS FOR A CONSECUTIVE SESSION

        private void addbtncons_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO RoomConsecutive (Consecutive_Session,Room) VALUES ('" + txtconsecutive.Text + "','" + txtconsroom.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from RoomConsecutive";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvconsessionroom.DataSource = dt;

                con.Close();


                txtconsecutive.SelectedIndex = -1;
                txtconsroom.SelectedIndex = -1;



                tagtab.SelectedTab = roomconsessiontabpage;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void roomsubtagpage_Click(object sender, EventArgs e)
        {

        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }
    }
}
