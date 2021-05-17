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
    public partial class Location : MetroForm
    {
        int ID;
        SqlConnection con;
        public Location()
        {
            InitializeComponent();
        }
        private void location_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }
        //DB CONNECTION

        private void Location_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Location";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                dgvLocations.AutoGenerateColumns = true;
                dgvLocations.DataSource = dt;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
                    }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //SAVE LOCATION

        private void btnlocsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Location (Building_Name,Capacity,Room_Name,Room_Type) VALUES ('" + txtbuildname.Text + "','" + txtcapacity.Text + "','" + txtroomname.Text + "','" + txtroomtype.Text + "');";




                cmd.ExecuteNonQuery();
                String query2 = "Select * from Location";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvLocations.DataSource = dt;

                con.Close();

        
                txtbuildname.SelectedIndex = -1;
                txtcapacity.SelectedIndex = -1;
                txtroomname.SelectedIndex = -1;
                txtroomtype.SelectedIndex = -1;


                locationtab.SelectedTab = manageloctab;

            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        //CLEAR BUTTON

        private void btnlocclear_Click(object sender, EventArgs e)
        {
            
            txtbuildname.SelectedIndex = -1;
            txtcapacity.SelectedIndex = -1;
            txtroomname.SelectedIndex = -1;
            txtroomtype.SelectedIndex = -1;

        }

        private void dgvLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dgvLocations.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                
                comboEditbuilding.Text = selectRow.Cells[1].Value.ToString();
                comboEditcapacity.Text = selectRow.Cells[2].Value.ToString();
                comboEditroomname.Text = selectRow.Cells[3].Value.ToString();
                comboEditroomtype.Text = selectRow.Cells[4].Value.ToString();
                



            }

        }

        //UPDATE LOCATION
        private void BtnLocUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Location SET Building_Name = '" + comboEditbuilding.Text + "',Capacity='" + comboEditcapacity.Text + "',Room_Name='" + comboEditroomname.Text + "',Room_Type='" + comboEditroomtype.Text + "' WHERE ID = '" + ID + "'";

                cmd.ExecuteNonQuery();
                
                String query2 = "Select * from Location";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvLocations.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");




                //cmd.Parameters.AddWithValue("@lecRank", LecturerRank + "." + this.LecturerID);
                //cmd.Parameters.AddWithValue("@LecID", this.LecturerID);

                //EditempID.Text = "";
            
                
                comboEditbuilding.SelectedIndex = -1;
                comboEditcapacity.SelectedIndex = -1;
                comboEditroomname.SelectedIndex = -1;
                comboEditroomtype.SelectedIndex = -1;
                

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

        private void locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void btnLMclear_Click(object sender, EventArgs e)
        {
            comboEditbuilding.SelectedIndex = -1;
            comboEditcapacity.SelectedIndex = -1;
            comboEditroomname.SelectedIndex = -1;
            comboEditroomtype.SelectedIndex = -1;

        }

        //DELETE LOCATION
        private void btnLocDelete_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Location where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Location";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvLocations.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    comboEditbuilding.SelectedIndex = -1;
                    comboEditcapacity.SelectedIndex = -1;
                    comboEditroomname.SelectedIndex = -1;
                    comboEditroomtype.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            
        }
    }

        private void locationtabpage_Click(object sender, EventArgs e)
        {

        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }

        private void manageloctab_Click(object sender, EventArgs e)
        {

        }
    }
}
