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
    public partial class Subjects : MetroForm
    {
        SqlConnection con;
        public Subjects()
        {
            InitializeComponent();
        }

        int ID;
        //public String SubCode;
       public int SubCodeValue = 0;

        private void AddSubject_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Subject";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

               dgvSubjects.AutoGenerateColumns = true;
                dgvSubjects.DataSource = dt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void Subjecttabpage_Click(object sender, EventArgs e)
        {

        }

        private void Btnsubsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Subject (SubCode,SubName,SubYear,SubSem,SubLecHours,SubTuteHours,SubLabHours,SubEvaHours) VALUES ('" + txtsubcode.Text + "','" + txtsubname.Text + "','" + cmboffyear.Text + "','" + cmbsem.Text + "','" + cmblechours.Text + "','" + cmbtutehours.Text + "', '" + cmblabhours.Text + "', '" + cmbevalhours.Text + "');";
                cmd.ExecuteNonQuery();
                String query2 = "Select * from Subject";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvSubjects.DataSource = dt;

                con.Close();

                txtsubcode.Text="";
                txtsubname.Text="";
                cmboffyear.SelectedIndex = -1;
                cmbsem.SelectedIndex = -1;
                cmblechours.SelectedIndex = -1;
                cmbtutehours.SelectedIndex = -1;
                cmblabhours.SelectedIndex = -1;
                cmbevalhours.SelectedIndex = -1;


                subjecttab.SelectedTab =managesubjecttab;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Btnsubclear1_Click(object sender, EventArgs e)
        {
           txtsubcode.Text="";
            txtsubname.Text ="";
            cmboffyear.SelectedIndex = -1;
            cmbsem.SelectedIndex = -1;
            cmblechours.SelectedIndex = -1;
            cmbtutehours.SelectedIndex = -1;
            cmblabhours.SelectedIndex = -1;
            cmbevalhours.SelectedIndex = -1;
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dgvSubjects.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                //SubCode =selectRow.Cells[0].Value.ToString();
                txtEditSubjectCode.Text = selectRow.Cells[1].Value.ToString();
                txtEditSubName.Text = selectRow.Cells[2].Value.ToString();
                cmbEdityear.Text = selectRow.Cells[3].Value.ToString();
                cmbEditsem.Text = selectRow.Cells[4].Value.ToString();
                cmbEditLectureHours.Text = selectRow.Cells[5].Value.ToString();
                cmbEditTute.Text = selectRow.Cells[6].Value.ToString();
                cmbEditLab.Text = selectRow.Cells[7].Value.ToString();
                cmbEditEval.Text = selectRow.Cells[8].Value.ToString();
                SubCodeValue = 1;


            }
        }

        private void BtnSubUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Subject SET SubCode='" +txtEditSubjectCode.Text +"' ,SubName = '" + txtEditSubName.Text + "',SubYear='" + cmbEdityear.Text + "',SubSem='" + cmbEditsem.Text + "',SubLecHours='" + cmbEditLectureHours.Text + "',SubTuteHours='" + cmbEditTute.Text + "',SubLabHours='" + cmbEditLab.Text + "',SubEvaHours='" + cmbEditEval.Text + "' WHERE ID = '" + ID + "'";
                cmd.ExecuteNonQuery();

                String query2 = "Select * from Subject";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvSubjects.DataSource = dt;
               // SubCode = '" +SubCode + "',
                con.Close();

                MessageBox.Show("Updated Succesfully");

                txtEditSubjectCode.Text ="";
                txtEditSubName.Text="";
                cmbEdityear.SelectedIndex = -1;
                cmbEditsem.SelectedIndex = -1;
                cmbEditLectureHours.SelectedIndex = -1;
                cmbEditTute.SelectedIndex = -1;
                cmbEditLab.SelectedIndex = -1;
                cmbEditEval.SelectedIndex = -1;
              SubCodeValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


       

        private void BtnSubDelete_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Subject where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Subject";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvSubjects.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    txtEditSubjectCode.Text="";
                    txtEditSubName.Text="";
                    cmbEdityear.SelectedIndex = -1;
                    cmbEditsem.SelectedIndex = -1;
                    cmbEditLectureHours.SelectedIndex = -1;
                    cmbEditTute.SelectedIndex = -1;
                    cmbEditLab.SelectedIndex = -1;
                    cmbEditEval.SelectedIndex = -1;
                   SubCodeValue = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }
        private void TxtEditSubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtsubname_TextChanged(object sender, EventArgs e)
        {
            //if (txtsubname.Text != "")
            //{
                //cmboffyear.SelectedIndex = -1;

                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select * from Subjects where SubName like '%" + txtsubname.Text + "%' ";
                //cmd.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                //dgvSubjects.DataSource = dt;
                //con.Close();
                //}
                // else if (txtsubname.Text == "")
                //{
                // GetSubjects();
                //}
            //}
        }
        private void Cmboffyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subjecttab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjecttab.SelectedTab.Name == "tabPageSubEdit")
            {
                if (SubCodeValue == 0)
                {
                    MessageBox.Show("Please select a subject in subjects list ", "No subject selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    subjecttab.SelectedTab = managesubjecttab;
                }
            }
        }

        private void BtnSubjectMclear_Click(object sender, EventArgs e)
        {
            txtEditSubjectCode.Text="";
            txtEditSubName.Text="";
            cmbEdityear.SelectedIndex = -1;
            cmbEditsem.SelectedIndex = -1;
            cmbEditLectureHours.SelectedIndex = -1;
            cmbEditTute.SelectedIndex = -1;
            cmbEditLab.SelectedIndex = -1;
            cmbEditEval.SelectedIndex = -1;
            SubCodeValue = 0;

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

        private void TxtSubjectcode1_TextChanged(object sender, EventArgs e)
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
    
   


