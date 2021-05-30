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
    public partial class TAG : MetroForm
    {
        int ID;
        SqlConnection con;
        public TAG()
        {
            InitializeComponent();
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            try
            {
                String query1 = "Select * from Tags";

                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                Tagdata.AutoGenerateColumns = true;
                Tagdata.DataSource = dt;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            Form f1 = new Form1();
            f1.Show();
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

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Tags (Subject_code,Subject_name,Tag_Name) VALUES ('" + TagCode.Text + "','" + subjectName.Text + "', '" + TagName.Text + "');";
                cmd.ExecuteNonQuery();

                String query2 = "Select * from Tags";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearTag_Click(object sender, EventArgs e)
        {
            TagCode.Text = "";
            TagName.Text = "";
            subjectName.Text = "";
        }
        private void tagNameData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = Tagdata.Rows[index];
                ID= int.Parse(selectRow.Cells[0].Value.ToString());
                TagCode.Text = selectRow.Cells[1].Value.ToString();
                subjectName.Text = selectRow.Cells[2].Value.ToString();
                TagName.Text = selectRow.Cells[3].Value.ToString();
                
            }

        }
        private void DeleteTag_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Tags where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Tagdata.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    TagCode.Text = "";
                    TagName.Text = "";
                    subjectName.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void UpdateTag_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Tags SET Tag_Name = '" + TagName.Text + "',Subject_name = '" + subjectName.Text + "',Subject_code = '" + TagCode.Text + "' WHERE ID = '" + ID + "'";
                cmd.ExecuteNonQuery();

                String query2 = "Select * from Tags";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchtag_Click(object sender, EventArgs e)
        {
            searchtag.Text = "";
        }

        private void searchtag_TextChanged(object sender, EventArgs e)
        {
            if (searchtagby.Text == "")
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tags WHERE Tag_Name LIKE '%" + searchtag.Text + "%' or Subject_code LIKE '%" + searchtag.Text + "%' or Subject_name LIKE '%" + searchtag.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;
                con.Close();
            }
            else if (searchtagby.Text == "Tag Name")
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tags WHERE Tag_Name LIKE '%" + searchtag.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;
                con.Close();
            }
            else if (searchtagby.Text == "ID")
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tags WHERE ID LIKE '%" + searchtag.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;
                con.Close();
            }
            else if (searchtagby.Text == "Subject Code")
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tags WHERE Subject_code LIKE '%" + searchtag.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;
                con.Close();
            }
            else if (searchtagby.Text == "Subject Name")
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tags WHERE Subject_name LIKE '%" + searchtag.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Tagdata.DataSource = dt;
                con.Close();
            }
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

        private void Searchtagby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
