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
    public partial class Sessions : MetroForm
    {
        public Sessions()
        {
            InitializeComponent();
        }
        SqlConnection con;

       
        public int SID;
        public String lecturers = "";

        private void Sessions_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Sessions";
            String query2 = "select ID, (Main_Group_ID) AS NAME from Students";
            String query3 = "select SubCode, (SubName) AS NAME from Subject";
            String query4 = "select lecID, (lecname ) AS NAME from Lecture";
            String query5 = "select SubCode, (SubCode) AS NAME from Subject";
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                SqlDataAdapter da2 = new SqlDataAdapter(query2, con);//
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Students");

                SqlDataAdapter da3 = new SqlDataAdapter(query3, con);//
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "Subject");

                SqlDataAdapter da4 = new SqlDataAdapter(query4, con);//
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "Lecture");

                SqlDataAdapter da5 = new SqlDataAdapter(query5, con);//
                DataSet ds5 = new DataSet();
                da5.Fill(ds5, "Subject");

                dgvSessions.AutoGenerateColumns = true;
                dgvSessions.DataSource = dt;

                comboGroup.DisplayMember = "NAME";
                comboGroup.ValueMember = "ID";
                comboGroup.DataSource = ds2.Tables["Students"];

                cmbSsubject1.DisplayMember = "NAME";
                cmbSsubject1.ValueMember = "ID";
                cmbSsubject1.DataSource = ds3.Tables["Subject"];

                cmbSlecturer.DisplayMember = "NAME";
                cmbSlecturer.ValueMember = "ID";
                cmbSlecturer.DataSource = ds4.Tables["Lecture"];

                cmbsubjectCode.DisplayMember = "NAME";
                cmbsubjectCode.ValueMember = "ID";
                cmbsubjectCode.DataSource = ds5.Tables["Subject"];

                comboEditGroup.DisplayMember = "NAME";
                comboEditGroup.ValueMember = "ID";
                comboEditGroup.DataSource = ds2.Tables["Students"];

                comboEditSubject.DisplayMember = "NAME";
                comboEditSubject.ValueMember = "ID";
                comboEditSubject.DataSource = ds3.Tables["Subject"];

                cmbEditlectures.DisplayMember = "NAME";
                cmbEditlectures.ValueMember = "ID";
                cmbEditlectures.DataSource = ds4.Tables["Lecture"];

                cmbEditSessionCode.DisplayMember = "NAME";
                cmbEditSessionCode.ValueMember = "ID";
                cmbEditSessionCode.DataSource = ds5.Tables["Subject"];

                cmbfilterlecturers.DisplayMember = "NAME";
                cmbfilterlecturers.ValueMember = "ID";
                cmbfilterlecturers.DataSource = ds4.Tables["Lecture"];

                cmbfiltersubject.DisplayMember = "NAME";
                cmbfiltersubject.ValueMember = "ID";
                cmbfiltersubject.DataSource = ds3.Tables["Subject"];

                cmbfilterGrp.DisplayMember = "NAME";
                cmbfilterGrp.ValueMember = "ID";
                cmbfilterGrp.DataSource = ds2.Tables["Students"];


                comboGroup.SelectedIndex = -1;
                cmbSsubject1.SelectedIndex = -1;
                cmbSlecturer.SelectedIndex = -1;
                cmbsubjectCode.SelectedIndex = -1;
                comboEditGroup.SelectedIndex = -1;
                comboEditSubject.SelectedIndex = -1;
                cmbEditlectures.SelectedIndex = -1;
                cmbEditSessionCode.SelectedIndex = -1;
                cmbfilterlecturers.SelectedIndex = -1;
                cmbfiltersubject.SelectedIndex = -1;
                cmbfilterGrp.SelectedIndex = -1;



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
       
            sessiontab.SelectedTab = viewsessiontab;
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

            private void lectures_Click(object sender, EventArgs e)
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

            private void TextBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void TextBox19_TextChanged(object sender, EventArgs e)
            {

            }

            private void TextBox11_TextChanged(object sender, EventArgs e)
            {

            }

            private void ComboGroup_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

       
               

        private void BtnSessionsave_Click(object sender, EventArgs e)
            {
           
                try
                {
                    con = ConnectionManager.GetConnection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Sessions (SID,lecturer,SelectedLecturer,Subject,SubjectCode,GroupID,Tag,StudentCount,Duration) VALUES ('"+newSID.Text+"','" + cmbSlecturer.Text + "','" + txtSelectedLecturers.Text + "','" + cmbSsubject1.Text + "','" + cmbsubjectCode.Text + "','" + comboGroup.Text + "','" + comboTag.Text + "','" + noOfStudents.Text + "', '" + duration.Text + "');";
                    cmd.ExecuteNonQuery();
                    String query2 = "Select * from Sessions";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvSessions.DataSource = dt;

                    con.Close();
                newSID.Text = "";
                cmbSlecturer.SelectedIndex = -1;
                lecturers = "";
                txtSelectedLecturers.Text="";
                cmbSsubject1.SelectedIndex = -1;
                cmbsubjectCode.SelectedIndex = -1;
                comboGroup.SelectedIndex = -1;
                comboTag.SelectedIndex = -1;
                noOfStudents.Value = 0;
                duration.Value = 0;
                SID = 0;


                sessiontab.SelectedTab = viewsessiontab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void BtnSessionclear_Click(object sender, EventArgs e)
        {
            newSID.Text = "";
            cmbSlecturer.SelectedIndex = -1;
            lecturers = "";
           txtSelectedLecturers.Text = "";
            cmbSsubject1.SelectedIndex = -1;
            cmbsubjectCode.SelectedIndex = -1;
            comboGroup.SelectedIndex = -1;
            comboTag.SelectedIndex = -1;
            noOfStudents.Value = 0;
            duration.Value = 0;
            SID = 0;
        }

        
        
        public void GetLecturersToFilter()
        {
            
        }

        public void GetSubjectsToFilter()
        {
            
        }

        public void GetGroupsToFilter()
        {
            
        }

        private void Cmbfilterlecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = ConnectionManager.GetConnection();
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sessions WHERE SelectedLecturer LIKE '%" + cmbfilterlecturers.Text + "%'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgvSessions.DataSource = dt;
            //con.Close();
        } 

        private void Cmbfiltersubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = ConnectionManager.GetConnection();
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sessions WHERE Subject LIKE '%" + cmbfiltersubject.Text + "%'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgvSessions.DataSource = dt;
            //con.Close();
        }

        private void CmbfilterGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = ConnectionManager.GetConnection();
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sessions WHERE GroupID LIKE '%" + cmbfilterGrp.Text + "%'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgvSessions.DataSource = dt;
            //con.Close();
        }

        private void DgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dgvSessions.Rows[index];
                SID = int.Parse(selectRow.Cells[0].Value.ToString());
                EditSessionID.Text =(selectRow.Cells[0].Value.ToString());
                cmbEditlectures.Text = selectRow.Cells[1].Value.ToString();
                txtlectures.Text = selectRow.Cells[2].Value.ToString();
                comboEditSubject.Text = selectRow.Cells[3].Value.ToString();
                cmbEditSessionCode.Text = selectRow.Cells[4].Value.ToString();
                comboEditGroup.Text = selectRow.Cells[5].Value.ToString();
                comboEditTag.Text = selectRow.Cells[6].Value.ToString();
                EditNoOfStudents.Text=selectRow.Cells[7].Value.ToString();
                EditDuration.Text = selectRow.Cells[8].Value.ToString();



                //txtlectures.Text = dgvSessions.SelectedRows[0].Cells[1].Value.ToString();
                sessiontab.SelectedTab = editsessiontab;


            }
           
        }

        private void CmbEditlectures_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboEditTag_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboEditGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void ComboEditSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
       
        private void BtnSessionUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Sessions SET Lecturer = '" + cmbEditlectures.Text + "',SelectedLecturer = '" + txtlectures.Text + "',Subject='" + comboEditSubject.Text + "',SubjectCode='" + cmbEditSessionCode.Text + "',GroupID='" + comboEditGroup.Text + "',Tag='" + comboEditTag.Text + "',StudentCount='" + EditNoOfStudents.Text + "',Duration='" + EditDuration.Text + "' WHERE SID = '" + SID + "'";
                cmd.ExecuteNonQuery();

                String query2 = "Select * from Sessions";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvSessions.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");

                EditSessionID.Text = "";
                cmbEditlectures.SelectedIndex = -1;
                txtlectures.Text = "";
                comboEditSubject.SelectedIndex = -1;
                cmbEditSessionCode.SelectedIndex = -1;
                comboEditGroup.SelectedIndex = -1;
                comboEditTag.SelectedIndex = -1;
                EditNoOfStudents.Text = "";
                EditDuration.Text = "";
                SID = 0;
                sessiontab.SelectedTab = viewsessiontab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

                  
        private void BtnSessionDelete_Click(object sender, EventArgs e)
        {
         
}
        private void sessiontab_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (sessiontab.SelectedTab.Name == "tabPageSessionEdit")
                {
                    if (SID == 0)
                    {
                        MessageBox.Show("Please select a session in sessions list ", "No session selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sessiontab.SelectedTab = viewsessiontab;
                    }
                }
            }

        private void TxtEditCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSclear_Click(object sender, EventArgs e)
        {
            EditSessionID.Text = "";
            cmbEditlectures.SelectedIndex = -1;
            txtlectures.Text = "";
            comboEditSubject.SelectedIndex = -1;
            cmbEditSessionCode.SelectedIndex = -1;
            comboEditGroup.SelectedIndex = -1;
            comboEditTag.SelectedIndex = -1;
            EditNoOfStudents.Text = "";
            EditDuration.Text = "";
            SID = 0;
        }

        private void TextSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSessionDelete_Click_1(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Sessions where SID = '" + SID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Sessions";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvSessions.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    //lecturersEdit.Text = "";
                    EditSessionID.Text = "";
                    cmbEditlectures.SelectedIndex = -1;
                    txtlectures.Text = "";
                    comboEditSubject.SelectedIndex = -1;
                    cmbEditSessionCode.SelectedIndex = -1;
                    comboEditGroup.SelectedIndex = -1;
                    comboEditTag.SelectedIndex = -1;
                    EditNoOfStudents.Text = "";
                    EditDuration.Text = "";
                    SID = 0;

                    sessiontab.SelectedTab = viewsessiontab;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void CmbSlecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lecturers = lecturers + cmbSlecturer.Text + ", ";

            txtSelectedLecturers.Text = lecturers;
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

        private void NewSID_TextChanged(object sender, EventArgs e)
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


