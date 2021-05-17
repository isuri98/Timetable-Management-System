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
    public partial class Lectures : MetroForm
    {
        public Lectures()
        {
            InitializeComponent();
        }
        SqlConnection con;

        public int NO;
        public int LecturerID;
        public float LecturerRank;

        private void AddLecturer_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Lecture";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvLecturers.AutoGenerateColumns = true;
                dgvLecturers.DataSource = dt;

                con.Close();
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

        private void subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btnlecsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "INSERT INTO Lecture (lecID,lecname,lecfaculty,lecdepartment,leccenter,lecbuilding,leclevel,lecRank) VALUES ('" + txtempID.Text + "','" + txtlecname.Text + "','" + cmbfaculty.Text + "','" + cmbdepartment.Text + "','" + cmbcenter.Text + "','" + cmbbuilding.Text + "', '"  + cmblevel.Text + "', '" + txtlecrank.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from Lecture";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvLecturers.DataSource = dt;

                con.Close();

                txtempID.Text = "";
                txtlecname.Text="";
                // cmbfaculty.SelectedIndex = -1;
               cmbdepartment.SelectedIndex = -1;
                cmbcenter.SelectedIndex = -1;
                cmbbuilding.SelectedIndex = -1;
                cmblevel.SelectedIndex = -1;
                txtlecrank.Text = "";
               LecturerID = 0;

                lecturertab.SelectedTab = managelectab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Btnlecclear_Click(object sender, EventArgs e)
        {
            txtempID.Text = "";
            txtlecname.Text = "";
            //cmbfaculty.SelectedIndex = -1;
            cmbfaculty.Text = "";
            cmbdepartment.SelectedIndex = -1;
            cmbcenter.SelectedIndex = -1;
            cmbbuilding.SelectedIndex = -1;
            cmblevel.SelectedIndex = -1;
            txtlecrank.Text = "";
            LecturerID = 0;
        }

        private void dgvLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dgvLecturers.Rows[index];
                //ID = int.Parse(selectRow.Cells[0].Value.ToString());
                NO = int.Parse(selectRow.Cells[0].Value.ToString());
                LecturerID= int.Parse(selectRow.Cells[1].Value.ToString());
                EditempID.Text=selectRow.Cells[1].Value.ToString();
                txtEditLecName.Text = selectRow.Cells[2].Value.ToString();
                comboEditfaculty.Text = selectRow.Cells[3].Value.ToString();
                comboEditdepartment.Text = selectRow.Cells[4].Value.ToString();
                comboEditcenter.Text = selectRow.Cells[5].Value.ToString();
                comboEditbuilding.Text = selectRow.Cells[6].Value.ToString();
                comboEditlevel.Text = selectRow.Cells[7].Value.ToString();
                txtEditRank.Text = selectRow.Cells[8].Value.ToString();
               


            }

        }

        private void BtnMclear_Click(object sender, EventArgs e)
        {
            EditempID.Text = "";
            txtEditLecName.Text = "";
            //comboEditfaculty.SelectedIndex = -1;
            comboEditfaculty.Text = "";
            comboEditdepartment.SelectedIndex = -1;
            comboEditcenter.SelectedIndex = -1;
            comboEditbuilding.SelectedIndex = -1;
            comboEditlevel.SelectedIndex = -1;
            txtEditRank.Text = "";
            LecturerID = 0;

        }

        private void BtnLecUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Lecture SET LecID = '" + EditempID.Text + "',lecName = '" + txtEditLecName.Text + "',lecdepartment='" + comboEditdepartment.Text + "',leccenter='" + comboEditcenter.Text + "',lecbuilding='" + comboEditbuilding.Text + "',leclevel='" + comboEditlevel.Text + "',lecRank='" + txtEditRank.Text + "' WHERE NO = '" + NO + "'";

                cmd.ExecuteNonQuery();
                //lecID = '" + EditempID.Text + "',
                String query2 = "Select * from Lecture";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvLecturers.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");

              

                   
                    //cmd.Parameters.AddWithValue("@lecRank", LecturerRank + "." + this.LecturerID);
                    //cmd.Parameters.AddWithValue("@LecID", this.LecturerID);

                EditempID.Text = "";
                txtEditLecName.Text="";
               // comboEditfaculty.SelectedIndex = -1;
                comboEditdepartment.SelectedIndex = -1;
                comboEditcenter.SelectedIndex = -1;
                comboEditbuilding.SelectedIndex = -1;
                comboEditlevel.SelectedIndex = -1;
                txtEditRank.Text = "";
                LecturerID = 0;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void BtnLecDelete_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Lecture where NO = '" + NO + "'"; 
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Lecture";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvLecturers.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    EditempID.Text = "";
                    txtEditLecName.Text="";
                   //comboEditfaculty.SelectedIndex = -1;
                    comboEditdepartment.SelectedIndex = -1;
                    comboEditcenter.SelectedIndex = -1;
                    comboEditbuilding.SelectedIndex = -1;
                    comboEditlevel.SelectedIndex = -1;
                    txtEditRank.Text = "";
                    LecturerID = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }
        private void Cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdepartment.Items.Clear();

            if (cmbfaculty.SelectedItem.Equals("Engineering"))
            {
                cmbdepartment.Items.Add("CE");
                cmbdepartment.Items.Add("EEE");
                cmbdepartment.Items.Add("ME");
                cmbdepartment.Items.Add("QS");
            }
            else if (cmbfaculty.SelectedItem.Equals("Computing"))
            {
                cmbdepartment.Items.Add("CSSE");
                cmbdepartment.Items.Add("DS");
                cmbdepartment.Items.Add("CSNE");
                cmbdepartment.Items.Add("IT");
                cmbdepartment.Items.Add("CS");
                cmbdepartment.Items.Add("IM");
                cmbdepartment.Items.Add("ISE");
            }
            else if (cmbfaculty.SelectedItem.Equals("Business"))
            {
                cmbdepartment.Items.Add("AF");
                cmbdepartment.Items.Add("BA");
                cmbdepartment.Items.Add("HCM");
                cmbdepartment.Items.Add("MM");
                cmbdepartment.Items.Add("IM");
                cmbdepartment.Items.Add("BM");
            }
            else if (cmbfaculty.SelectedItem.Equals("Humanities and Science"))
            {
                cmbdepartment.Items.Add("MU");
                cmbdepartment.Items.Add("ELT");
            }
             //cmbfaculty.SelectedIndex = -1;
        }

        private void ComboEditfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
           comboEditdepartment.Items.Clear();

            if (comboEditfaculty.SelectedItem.Equals("Engineering"))
            {
                comboEditdepartment.Items.Add("CE");
                comboEditdepartment.Items.Add("EEE");
                comboEditdepartment.Items.Add("ME");
                comboEditdepartment.Items.Add("QS");
            }
            else if (comboEditfaculty.SelectedItem.Equals("Computing"))
            {
                comboEditdepartment.Items.Add("CSSE");
                comboEditdepartment.Items.Add("DS");
                comboEditdepartment.Items.Add("CSNE");
                comboEditdepartment.Items.Add("IT");
                comboEditdepartment.Items.Add("CS");
                comboEditdepartment.Items.Add("IM");
                comboEditdepartment.Items.Add("ISE");

            }
            else if (comboEditfaculty.SelectedItem.Equals("Business"))
            {
                comboEditdepartment.Items.Add("AF");
                comboEditdepartment.Items.Add("BA");
                comboEditdepartment.Items.Add("HCM");
                comboEditdepartment.Items.Add("MM");
                comboEditdepartment.Items.Add("IM");
                comboEditdepartment.Items.Add("BM");
            }
            else if (comboEditfaculty.SelectedItem.Equals("Humanities and Science"))
            {
                comboEditdepartment.Items.Add("MU");
                comboEditdepartment.Items.Add("ELT");
            }
        }
            private void lecturertab_SelectedIndexChanged(object sender, EventArgs e)
            {
                //if (lecturertab.SelectedTab.Name == "tabPageLecEdit")
               // {
                   // if (LecturerID == 0)
                   // {
                     //   MessageBox.Show("Please select a lecturer in lecture list ", "No lecturer selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //lecturertab.SelectedTab =managelectab;
                    //}
               // }
            }

        private void Btngenrank_Click(object sender, EventArgs e)
        {


            if (cmblevel.Text.Equals("Professor"))
            {
                LecturerRank = 1;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (cmblevel.Text.Equals("Assistant Professor"))
            {
                LecturerRank = 2;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (cmblevel.Text.Equals("Senior Lecturer(HG)"))
            {
                LecturerRank = 3;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (cmblevel.Text.Equals("Senior Lecturer"))
            {
                LecturerRank = 4;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (cmblevel.Text.Equals("Lecturer"))
            {
                LecturerRank = 5;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (cmblevel.Text.Equals("Assistant Lecturer"))
            {
                LecturerRank = 6;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else
            {
                LecturerRank = 7;
                txtlecrank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
           
        }

        private void Cmbcenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lecturertabpage_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditRank_Click(object sender, EventArgs e)
        {

            if (comboEditlevel.Text.Equals("Professor"))
            {
                LecturerRank = 1;
                txtEditRank.Text = this.LecturerRank + "." + this.EditempID.Text;
            }
            else if (comboEditlevel.Text.Equals("Assistant Professor"))
            {
                LecturerRank = 2;
                txtEditRank.Text = this.LecturerRank + "." + this.EditempID.Text;
            }
            else if (comboEditlevel.Text.Equals("Senior Lecturer(HG)"))
            {
                LecturerRank = 3;
                txtEditRank.Text = this.LecturerRank + "." + this.EditempID.Text;
            }
            else if (comboEditlevel.Text.Equals("Senior Lecturer"))
            {
                LecturerRank = 4;
                txtlecrank.Text = this.LecturerRank + "." + this.EditempID.Text;
            }
            else if (comboEditlevel.Text.Equals("Lecturer"))
            {
                LecturerRank = 5;
                txtEditRank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else if (comboEditlevel.Text.Equals("Assistant Lecturer"))
            {
                LecturerRank = 6;
                txtEditRank.Text = this.LecturerRank + "." + this.txtempID.Text;
            }
            else
            {
                LecturerRank = 7;
                txtlecrank.Text = this.LecturerRank + "." + this.EditempID.Text;
            }
        }

        private void DgvLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }
    }
    }

   

