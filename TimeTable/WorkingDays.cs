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
    public partial class WorkingDays : MetroForm
    {
        int Id;
        int TimeSlot_Id;
        int DayId;
        

        SqlConnection con;

        public WorkingDays()
        {
            InitializeComponent();
        }
        
        private void WorkingDays_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from WorkingDays";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dataGridViewnw.AutoGenerateColumns = true;
                dataGridViewnw.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            String query2 = "Select * from TSlot";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query2, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            String query3 = "Select * from WorkDayTime";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query3, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgvLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lecturertabpage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewnw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //tabPage2.SelectedTab = managetimetab;
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dataGridViewnw.Rows[index];

                Id = int.Parse(selectRow.Cells[0].Value.ToString());

                numericUpDown1.Text = selectRow.Cells[1].Value.ToString();
               // numericUpDown8.Text= selectRow.Cells[2].Value.ToString();
                //numericUpDown7.Text=selectRow.Cells[3].Value.ToString();




            }


        }

        private void btnnwAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO WorkingDays (Working_Days) VALUES ('" + numericUpDown1.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from WorkingDays";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewnw.DataSource = dt;

                con.Close();


                //cmbfaculty.SelectedIndex = -1;
                //numericUpDown1.Text = "";
                numericUpDown1.Value = 0;

                WorkingDaysTimetab.SelectedTab = workingtabpage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();
        }

        private void subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {

            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void locations_Click(object sender, EventArgs e)
        {

            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void working_days_Click(object sender, EventArgs e)
        {

            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }

        private void rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void btnnwEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE WorkingDays SET Working_Days  = '" + numericUpDown1.Text + "' WHERE Id = '" + Id + "'";

                cmd.ExecuteNonQuery();
 
                String query2 = "Select * from WorkingDays";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewnw.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");


                numericUpDown1.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnnwDelete_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from WorkingDays where Id = '" + Id + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from WorkingDays";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewnw.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    numericUpDown1.Text = "";
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO TSlot (Day,Start_Time,End_Time) VALUES ('" + metroComboBox8.Text + "','" + metroComboBox10.Text + "','" + metroComboBox9.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from TSlot";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();



                metroComboBox8.SelectedIndex = -1;
                metroComboBox10.SelectedIndex = -1;
                metroComboBox9.SelectedIndex = -1;
               
                WorkingDaysTimetab.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dataGridViewnw.Rows[index];

                TimeSlot_Id = int.Parse(selectRow.Cells[0].Value.ToString());

                metroComboBox8.Text = selectRow.Cells[1].Value.ToString();
                metroComboBox10.Text = selectRow.Cells[2].Value.ToString();
                metroComboBox9.Text = selectRow.Cells[3].Value.ToString();


            }
        }

        private void managelectab_Click(object sender, EventArgs e)
        {

        }

        private void btnwtSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO WorkDayTime (Day_1,Time_1,Day_2,Time_2,Day_3,Time_3,Day_4,Time_4,Day_5,Time_5,Day_6,Time_6,Day_7,Time_7) VALUES ('" + metroComboBox1.Text + "','" + numericUpDown2.Text + "','" + metroComboBox2.Text + "','" + numericUpDown8.Text + "','" + metroComboBox3.Text + "','" + numericUpDown7.Text + "','" + metroComboBox4.Text + "','" + numericUpDown6.Text + "','" + metroComboBox5.Text + "','" + numericUpDown5.Text + "','" + metroComboBox6.Text + "','" + numericUpDown9.Text + "','" + metroComboBox7.Text + "','" + numericUpDown10.Text + "');";


                cmd.ExecuteNonQuery();
                String query3 = "Select * from WorkDayTime";

                SqlDataAdapter sda = new SqlDataAdapter(query3, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                con.Close();
                metroComboBox1.SelectedIndex = -1;
                numericUpDown2.Value = 0;
                metroComboBox2.SelectedIndex = -1;
                numericUpDown8.Value = 0;
                metroComboBox3.SelectedIndex = -1;
                numericUpDown7.Value = 0;
                metroComboBox4.SelectedIndex = -1;
                numericUpDown6.Value = 0;
                metroComboBox5.SelectedIndex = -1;
                numericUpDown5.Value = 0;
                metroComboBox6.SelectedIndex = -1;
                numericUpDown9.Value = 0;
                metroComboBox7.SelectedIndex = -1;
                numericUpDown10.Value = 0;

                DayId = 0;

                //cmbfaculty.SelectedIndex = -1;
                //numericUpDown1.Text = "";
                //numericUpDown1.Value = 0;

                WorkingDaysTimetab.SelectedTab = tabPage1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnwtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE WorkDayTime SET Day 1 = '" + metroComboBox1.Text + "',Time 1='" + numericUpDown2.Text + "',Day 2='" + metroComboBox2.Text + "',Time 2='" + numericUpDown8.Text + "',Day 3='" + metroComboBox3.Text + "',Time 3='" + numericUpDown7.Text + "',Day 4='" + metroComboBox4.Text + "',Time 4= '" + numericUpDown6.Text + "',Day 5='" + metroComboBox5.Text + "',Time 5='" + numericUpDown5.Text + "',Day 6='" + metroComboBox6.Text + "',Time 6='" + numericUpDown9.Text + "',Day 7='" + metroComboBox7.Text + "',Time 8='" + numericUpDown10.Text + "' WHERE DayId = '" + DayId + "'";

                cmd.ExecuteNonQuery();

                String query2 = "Select * from WorkDayTime";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");


                metroComboBox1.SelectedIndex = -1;
                numericUpDown2.Text = "";
                metroComboBox2.SelectedIndex = -1;
                numericUpDown8.Text = "";
                metroComboBox3.SelectedIndex = -1;
                numericUpDown7.Text = "";
                metroComboBox4.SelectedIndex = -1;
                numericUpDown6.Text = "";
                metroComboBox5.SelectedIndex = -1;
                numericUpDown5.Text = "";
                metroComboBox6.SelectedIndex = -1;
                numericUpDown9.Text = "";
                metroComboBox7.SelectedIndex = -1;
                numericUpDown10.Text = "";
                DayId = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnwtDelete_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from WorkDayTime where DayId = '" + DayId + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from WorkDayTime";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");


                    metroComboBox1.SelectedIndex = -1;
                    numericUpDown2.Text = "";
                    metroComboBox2.SelectedIndex = -1;
                    numericUpDown8.Text = "";
                    metroComboBox3.SelectedIndex = -1;
                    numericUpDown7.Text = "";
                    metroComboBox4.SelectedIndex = -1;
                    numericUpDown6.Text = "";
                    metroComboBox5.SelectedIndex = -1;
                    numericUpDown5.Text = "";
                    metroComboBox6.SelectedIndex = -1;
                    numericUpDown9.Text = "";
                    metroComboBox7.SelectedIndex = -1;
                    numericUpDown10.Text = "";
                    DayId = 0;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }  
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dataGridView2.Rows[index];
                DayId = int.Parse(selectRow.Cells[0].Value.ToString());

                metroComboBox1.Text = selectRow.Cells[1].Value.ToString();
                numericUpDown2.Text = selectRow.Cells[2].Value.ToString();
                metroComboBox2.Text = selectRow.Cells[3].Value.ToString();
                numericUpDown8.Text = selectRow.Cells[4].Value.ToString();
                metroComboBox3.Text = selectRow.Cells[5].Value.ToString();
                numericUpDown7.Text = selectRow.Cells[6].Value.ToString();
                metroComboBox4.Text = selectRow.Cells[7].Value.ToString();
                numericUpDown6.Text = selectRow.Cells[8].Value.ToString();
                metroComboBox5.Text = selectRow.Cells[9].Value.ToString();
                numericUpDown5.Text = selectRow.Cells[10].Value.ToString();
                metroComboBox6.Text = selectRow.Cells[11].Value.ToString();
                numericUpDown9.Text = selectRow.Cells[12].Value.ToString();
                metroComboBox7.Text = selectRow.Cells[13].Value.ToString();
                numericUpDown10.Text = selectRow.Cells[14].Value.ToString();

                WorkingDaysTimetab.SelectedTab = managetimetab;
                //WorkingDaysTimetab.SelectedTab = managetimetab;
                //WorkingDaysTimetab.SelectedTab = managetimetab;

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE WorkDayTime SET Day_1 = '" + metroComboBox1.Text + "',Time_1='" + numericUpDown2.Text + "',Day_2='" + metroComboBox2.Text + "',Time_2='" + numericUpDown8.Text + "',Day_3='" + metroComboBox3.Text + "',Time_3='" + numericUpDown7.Text + "',Day_4='" + metroComboBox4.Text + "',Time_4= '" + numericUpDown6.Text + "',Day_5='" + metroComboBox5.Text + "',Time_5='" + numericUpDown5.Text + "',Day_6='" + metroComboBox6.Text + "',Time_6='" + numericUpDown9.Text + "',Day_7='" + metroComboBox7.Text + "' WHERE DayId = '" + DayId + "'";

                cmd.ExecuteNonQuery();

                String query2 = "Select * from WorkDayTime";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");


                metroComboBox1.SelectedIndex = -1;
                numericUpDown2.Text = "";
                metroComboBox2.SelectedIndex = -1;
                numericUpDown8.Text = "";
                metroComboBox3.SelectedIndex = -1;
                numericUpDown7.Text = "";
                metroComboBox4.SelectedIndex = -1;
                numericUpDown6.Text = "";
                metroComboBox5.SelectedIndex = -1;
                numericUpDown5.Text = "";
                metroComboBox6.SelectedIndex = -1;
                numericUpDown9.Text = "";
                metroComboBox7.SelectedIndex = -1;
                numericUpDown10.Text = "";
                DayId = 0;
                WorkingDaysTimetab.SelectedTab = tabPage1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from WorkDayTime where DayId = '" + DayId + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from WorkDayTime";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");


                    metroComboBox1.SelectedIndex = -1;
                    numericUpDown2.Text = "";
                    metroComboBox2.SelectedIndex = -1;
                    numericUpDown8.Text = "";
                    metroComboBox3.SelectedIndex = -1;
                    numericUpDown7.Text = "";
                    metroComboBox4.SelectedIndex = -1;
                    numericUpDown6.Text = "";
                    metroComboBox5.SelectedIndex = -1;
                    numericUpDown5.Text = "";
                    metroComboBox6.SelectedIndex = -1;
                    numericUpDown9.Text = "";
                    metroComboBox7.SelectedIndex = -1;
                    numericUpDown10.Text = "";
                    DayId = 0;;
                    WorkingDaysTimetab.SelectedTab = tabPage1;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {
           

        }

        private void button98_Click(object sender, EventArgs e)
        {
            
        }

        private void button97_Click(object sender, EventArgs e)
        {
            


        }

        private void button96_Click(object sender, EventArgs e)
        {
            


            
        }

        private void tabPageS3_Click(object sender, EventArgs e)
        {

        }

        private void tabPageR4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewS44_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
                
            
        }

        private void dataGridView95_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
