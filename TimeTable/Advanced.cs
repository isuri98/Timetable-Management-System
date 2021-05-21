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
    public partial class Advanced : MetroForm
    {
        int ID;
        int AddSuitableId;
        int LecGrpSupId;
        SqlConnection con;
        public Advanced()
        {
            InitializeComponent();
        }
        private void Advanced_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Overlapping";
            String query2 = "Select * from Parallel";
            String query3 = "Select * from Consective";
            String query4 = "select SID, (SubjectCode + ' ' + Tag + ' By ' + Lecturer + ' for ' + GroupID) AS NAME from Sessions";
            String query5 = "select SID, (SubjectCode+ ' ' + Tag + ' By ' + Lecturer + ' for ' + GroupID) AS NAME from Sessions";
            String query10 = "select NO, (lecname) AS NAME from Lecture";

            this.overlappingsession1.DataSource = null;
            overlappingsession1.Items.Clear();

            this.overlappingsession2.DataSource = null;
            overlappingsession2.Items.Clear();

            this.parallelsession1.DataSource = null;
            parallelsession1.Items.Clear();

            this.parallelsession2.DataSource = null;
            parallelsession2.Items.Clear();

            this.consession1.DataSource = null;
            consession1.Items.Clear();

            this.consession2.DataSource = null;
            consession2.Items.Clear();

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd1 = new SqlCommand(query1, con);//to load notOverapping session table
                DataTable dt1 = new DataTable();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt1.Load(sdr1);

                SqlCommand cmd2 = new SqlCommand(query2, con);//to load Parallel session table
                DataTable dt2 = new DataTable();
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                dt2.Load(sdr2);

                SqlCommand cmd3 = new SqlCommand(query3, con);//to load Consective session table
                DataTable dt3 = new DataTable();
                SqlDataReader sdr3 = cmd3.ExecuteReader();
                dt3.Load(sdr3);

                SqlDataAdapter da4 = new SqlDataAdapter(query4, con);//load session1 comboboxes
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "Sessions");

                SqlDataAdapter da5 = new SqlDataAdapter(query5, con);//load session2 comboboxes
                DataSet ds5 = new DataSet();
                da5.Fill(ds5, "Sessions");

                SqlDataAdapter da6 = new SqlDataAdapter(query10, con);//load session2 comboboxes
                DataSet ds6 = new DataSet();
                da6.Fill(ds6, "Lecture");

                overlappingsession1.DisplayMember = "NAME";//load overalpping session1 box
                overlappingsession1.ValueMember = "ID";
                overlappingsession1.DataSource = ds4.Tables["Sessions"];

                parallelsession1.DisplayMember = "NAME";//load Parallel session1 box
                parallelsession1.ValueMember = "ID";
                parallelsession1.DataSource = ds4.Tables["Sessions"];

                consession1.DisplayMember = "NAME";//load Consective session1 box
                consession1.ValueMember = "ID";
                consession1.DataSource = ds4.Tables["Sessions"];

                overlappingsession2.DisplayMember = "NAME";//load overalpping session2 box
                overlappingsession2.ValueMember = "ID";
                overlappingsession2.DataSource = ds5.Tables["Sessions"];

                parallelsession2.DisplayMember = "NAME";//load Parallel session2 box
                parallelsession2.ValueMember = "ID";
                parallelsession2.DataSource = ds5.Tables["Sessions"];

                consession2.DisplayMember = "NAME";//load Consective session2 box
                consession2.ValueMember = "ID";
                consession2.DataSource = ds5.Tables["Sessions"];

                metroComboBoxs1.DisplayMember = "NAME";//load Consective session2 box
                metroComboBoxs1.ValueMember = "ID";
                metroComboBoxs1.DataSource = ds6.Tables["Lecture"];

                overlappingdata.AutoGenerateColumns = true;// load notOverapping session data 
                overlappingdata.DataSource = dt1;

                paralleldata.AutoGenerateColumns = true;// load Parallel session data 
                paralleldata.DataSource = dt2;

                consectivedata.AutoGenerateColumns = true;// load Consective session data 
                consectivedata.DataSource = dt3;

                con.Close();

                overlappingsession1.SelectedIndex = -1;
                overlappingsession2.SelectedIndex = -1;
                parallelsession1.SelectedIndex = -1;
                parallelsession2.SelectedIndex = -1;
                consession1.SelectedIndex = -1;
                consession2.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            String query8 = "Select * from LecGrpSub";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query8, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dataGridViewA4.AutoGenerateColumns = true;
                dataGridViewA4.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            String query9 = "Select * from AddSuitable";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query9, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dataGridView95.AutoGenerateColumns = true;
                dataGridView95.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void lecturers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void ClearNotOverlappingS_Click(object sender, EventArgs e)
        {
            overlappingsession1.SelectedIndex = -1;
            overlappingsession2.SelectedIndex = -1;
        }

        private void ClearParallelS_Click(object sender, EventArgs e)
        {

            parallelsession1.SelectedIndex = -1;
            parallelsession2.SelectedIndex = -1;
            parallelDay.SelectedIndex = -1;
            Parallelstarttime.SelectedIndex = -1;
            parallelendtime.SelectedIndex = -1;
        }

        private void ClearConsectiveS_Click(object sender, EventArgs e)
        {
            consession1.SelectedIndex = -1;
            consession2.SelectedIndex = -1;
            consectiveDay.SelectedIndex = -1;
            consectiveStarttime.SelectedIndex = -1;
            consectiveEndtime.SelectedIndex = -1;
        }

        private void AddNotOverlappingS_Click(object sender, EventArgs e)
        {
            if ((overlappingsession1.Text != string.Empty) && (overlappingsession2.Text != string.Empty))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID1 = "";

                if (overlappingsession1.SelectedItem != null)
                {
                    DataRowView drv = overlappingsession1.SelectedItem as DataRowView;
                    ID1 = drv.Row["SID"].ToString();
                }

                String ID2 = "";

                if (overlappingsession2.SelectedItem != null)
                {
                    DataRowView drv = overlappingsession2.SelectedItem as DataRowView;
                    ID2 = drv.Row["SID"].ToString();
                }

                cmd.CommandText = "INSERT INTO Overlapping (Session1,Session2) VALUES('" + overlappingsession1.Text + "','" + overlappingsession2.Text + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Consecutive Session Added");

                overlappingsession1.SelectedIndex = -1;
                overlappingsession2.SelectedIndex = -1;
                parallelsession1.SelectedIndex = -1;
                parallelsession2.SelectedIndex = -1;
                consession1.SelectedIndex = -1;
                consession2.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String query1 = "select * from Overlapping";

            SqlCommand cmd4 = new SqlCommand(query1, con);
            DataTable dt4 = new DataTable();
            SqlDataReader sdr4 = cmd4.ExecuteReader();
            dt4.Load(sdr4);

            overlappingdata.AutoGenerateColumns = true;
            overlappingdata.DataSource = dt4;

            con.Close();
        }

        private void AddParallelS_Click(object sender, EventArgs e)
        {
            if ((parallelsession1.Text != string.Empty) && (parallelsession2.Text != string.Empty))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID1 = "";

                if (parallelsession1.SelectedItem != null)
                {
                    DataRowView drv = parallelsession1.SelectedItem as DataRowView;
                    ID1 = drv.Row["SID"].ToString();
                }

                String ID2 = "";

                if (parallelsession2.SelectedItem != null)
                {
                    DataRowView drv = parallelsession2.SelectedItem as DataRowView;
                    ID2 = drv.Row["SID"].ToString();
                }

                cmd.CommandText = "INSERT INTO Parallel (Session1 ,Session2, Day_ ,startime ,endtime)VALUES ('" + parallelsession1.Text + "' ,'" + parallelsession2.Text + "' , '" + parallelDay.Text + ".','" + Parallelstarttime.Text + "' ,'" + parallelendtime.Text + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Parallel Session Added");
                parallelsession1.SelectedIndex = -1;
                parallelsession2.SelectedIndex = -1;
                parallelDay.SelectedIndex = -1;
                Parallelstarttime.SelectedIndex = -1;
                parallelendtime.SelectedIndex = -1;
                overlappingsession1.SelectedIndex = -1;
                overlappingsession2.SelectedIndex = -1;
                consession1.SelectedIndex = -1;
                consession2.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String query2 = "select* from Parallel";

            SqlCommand cmd5 = new SqlCommand(query2, con);
            DataTable dt5 = new DataTable();
            SqlDataReader sdr5 = cmd5.ExecuteReader();
            dt5.Load(sdr5);

            paralleldata.AutoGenerateColumns = true;
            paralleldata.DataSource = dt5;

            con.Close();
        }

        private void AddConsectiveS_Click(object sender, EventArgs e)
        {
            if ((consession1.Text != string.Empty) && (consession2.Text != string.Empty))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID1 = "";

                if (consession1.SelectedItem != null)
                {
                    DataRowView drv = consession1.SelectedItem as DataRowView;
                    ID1 = drv.Row["SID"].ToString();
                }

                String ID2 = "";

                if (consession2.SelectedItem != null)
                {
                    DataRowView drv = consession2.SelectedItem as DataRowView;
                    ID2 = drv.Row["SID"].ToString();
                }

                cmd.CommandText = "INSERT INTO Consective (Session1 ,Session2, Day_,startime ,endtime) VALUES ('" + consession1.Text + "' ,'" + consession2.Text + "' ,' " + consectiveDay.Text + "' ,'" + consectiveStarttime.Text + "' ,'" + consectiveEndtime.Text + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Consective Session Added");
                consession1.SelectedIndex = -1;
                consession2.SelectedIndex = -1;
                consectiveDay.SelectedIndex = -1;
                consectiveStarttime.SelectedIndex = -1;
                consectiveEndtime.SelectedIndex = -1;
                overlappingsession1.SelectedIndex = -1;
                overlappingsession2.SelectedIndex = -1;
                parallelsession1.SelectedIndex = -1;
                parallelsession2.SelectedIndex = -1;


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String query3 = "select * from Consective";

            SqlCommand cmd6 = new SqlCommand(query3, con);
            DataTable dt6 = new DataTable();
            SqlDataReader sdr6 = cmd6.ExecuteReader();
            dt6.Load(sdr6);

            consectivedata.AutoGenerateColumns = true;
            consectivedata.DataSource = dt6;

            con.Close();
        }
        private void overlapping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = overlappingdata.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                overlappingsession1.Text = selectRow.Cells[1].Value.ToString();
                overlappingsession2.Text = selectRow.Cells[2].Value.ToString();
            }

        }

        private void consective_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = consectivedata.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                consession1.Text = selectRow.Cells[1].Value.ToString();
                consession2.Text = selectRow.Cells[2].Value.ToString();
            }

        }

        private void parallel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = paralleldata.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                parallelsession1.Text = selectRow.Cells[1].Value.ToString();
                parallelsession2.Text = selectRow.Cells[2].Value.ToString();
            }

        }

        private void Deleteoverlapping_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Overlapping where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Overlapping";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    overlappingdata.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    overlappingsession1.SelectedIndex = -1;
                    overlappingsession2.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void Deleteparallel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Parallel where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Parallel";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    paralleldata.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    parallelsession1.SelectedIndex = -1;
                    parallelsession2.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void DeleteConsective_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Consective where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Consective";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    consectivedata.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    consession1.SelectedIndex = -1;
                    consession2.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void Notoverlapping_Click(object sender, EventArgs e)
        {

        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
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

        private void notavailabele_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button98_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from LecGrpSub where LecGrpSupId = '" + LecGrpSupId + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from LecGrpSub";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewA4.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");


                    metroComboBoxs1.SelectedIndex = -1;
                    metroComboBoxs2.SelectedIndex = -1;
                    metroComboBoxs3.SelectedIndex = -1;
                    metroComboBoxs4.SelectedIndex = -1;
                    metroComboBoxs5.SelectedIndex = -1;
                    LecGrpSupId = 0;

                    notavailable.SelectedTab = tabPage3;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO LecGrpSub (Select_Lecture,Select_Group,Sub_Group,Session_Id,Time) VALUES ('" + metroComboBoxs1.Text + "','" + metroComboBoxs2.Text + "','" + metroComboBoxs3.Text + "','" + metroComboBoxs4.Text + "','" + metroComboBoxs4.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from LecGrpSub";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewA4.DataSource = dt;

                con.Close();



                metroComboBoxs1.SelectedIndex = -1;
                metroComboBoxs2.SelectedIndex = -1;
                metroComboBoxs3.SelectedIndex = -1;
                metroComboBoxs4.SelectedIndex = -1;
                metroComboBoxs5.SelectedIndex = -1;

                notavailable.SelectedTab = tabPage3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Insert add suitable time
        private void button97_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO AddSuitable (Room,Day,Start_Time,End_Time) VALUES ('" + metroComboBoxr1.Text + "','" + metroComboBoxr2.Text + "','" + metroComboBoxr3.Text + "','" + metroComboBoxr4.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from AddSuitable";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView95.DataSource = dt;

                con.Close();



                metroComboBoxr1.SelectedIndex = -1;
                metroComboBoxr2.SelectedIndex = -1;
                metroComboBoxr3.SelectedIndex = -1;
                metroComboBoxr4.SelectedIndex = -1;


                notavailable.SelectedTab = tabPage1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Delete add suitable time
        private void button96_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from AddSuitable where AddSuitableId = '" + AddSuitableId + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from AddSuitable";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView95.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");


                    metroComboBoxr1.SelectedIndex = -1;
                    metroComboBoxr2.SelectedIndex = -1;
                    metroComboBoxr3.SelectedIndex = -1;
                    metroComboBoxr4.SelectedIndex = -1;
                    AddSuitableId = 0;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        //view the add suitable time
        private void dataGridView95_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dataGridView95.Rows[index];
                AddSuitableId = int.Parse(selectRow.Cells[0].Value.ToString());

                metroComboBoxr1.Text = selectRow.Cells[1].Value.ToString();
                metroComboBoxr2.Text = selectRow.Cells[2].Value.ToString();
                metroComboBoxr3.Text = selectRow.Cells[3].Value.ToString();
                metroComboBoxr4.Text = selectRow.Cells[4].Value.ToString();




                notavailable.SelectedTab = tabPage1;

            }
        }
        //Viewing the lectures,groups & sub groups
        private void dataGridViewA4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dataGridViewA4.Rows[index];
                LecGrpSupId = int.Parse(selectRow.Cells[0].Value.ToString());

                metroComboBoxs1.Text = selectRow.Cells[1].Value.ToString();
                metroComboBoxs2.Text = selectRow.Cells[2].Value.ToString();
                metroComboBoxs3.Text = selectRow.Cells[3].Value.ToString();
                metroComboBoxs4.Text = selectRow.Cells[4].Value.ToString();
                metroComboBoxs5.Text = selectRow.Cells[5].Value.ToString();



                notavailable.SelectedTab = tabPage2;

            }
        }
    }
}
