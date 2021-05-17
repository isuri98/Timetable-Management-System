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
    public partial class Students : MetroForm
    {

        int ID;
        SqlConnection con;
        public Students()
        {
            InitializeComponent();
        }
        private void Students_Load(object sender, EventArgs e)
        {
            String query1 = "Select * from Students";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlCommand cmd = new SqlCommand(query1, con);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                studentdata.AutoGenerateColumns = true;
                studentdata.DataSource = dt;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lecturers_Click(object sender, EventArgs e)
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

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void ClearStudent_Click(object sender, EventArgs e)
        {
            Addstuyr.SelectedIndex = -1;
            Addstusem.SelectedIndex = -1;
            Addstupro.SelectedIndex = -1;
            AddstuMgrp.Text = "";
            AddstuMGID.Text = "";
            Addstusubgrp.Text = "";
            AddstuSubGID.Text = "";
            
        }

        private void ClearStudentMan_Click(object sender, EventArgs e)
        {
            ManagestudentYr.SelectedIndex = -1;
            Managestudentpr.SelectedIndex = -1;
            ManagestudentSem.SelectedIndex = -1;
            ManagestudentMainG.Text = "";
            ManagestudentSubG.Text = "";
            ManagestudentMGID.Text = "";
            ManagestudentSGID.Text = "";
        }

        private void AddStu_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Students (Year,Semester,Program,Main_Group,Main_Group_ID,Sub_Group,Sub_Group_ID) VALUES ('" + Addstuyr.Text + "','" + Addstusem.Text + "','" + Addstupro.Text + "','" + AddstuMgrp.Text + "','" + AddstuMGID.Text + "','" + Addstusubgrp.Text + "', '" + AddstuSubGID.Text + "');";
                cmd.ExecuteNonQuery();
                String query2 = "Select * from Students";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                studentdata.DataSource = dt;

                con.Close();

                Addstuyr.SelectedIndex = -1;
                Addstusem.SelectedIndex = -1;
                Addstupro.SelectedIndex = -1;
                AddstuMgrp.Text = "";
                AddstuMGID.Text = "";
                Addstusubgrp.Text = "";
                AddstuSubGID.Text = "";

                Studenttab.SelectedTab = managestu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void studentdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = studentdata.Rows[index];
                ID = int.Parse(selectRow.Cells[0].Value.ToString());
                ManagestudentYr.Text = selectRow.Cells[1].Value.ToString();
                ManagestudentSem.Text = selectRow.Cells[2].Value.ToString();
                Managestudentpr.Text = selectRow.Cells[3].Value.ToString();
                ManagestudentMainG.Text = selectRow.Cells[4].Value.ToString();
                ManagestudentMGID.Text = selectRow.Cells[5].Value.ToString();
                ManagestudentSubG.Text = selectRow.Cells[6].Value.ToString();
                ManagestudentSGID.Text = selectRow.Cells[7].Value.ToString();

            }

        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Students SET Year = '" + ManagestudentYr.Text + "',Semester = '" + ManagestudentSem.Text + "',Program='" + Managestudentpr.Text + "',Main_Group='" +ManagestudentMainG.Text + "',Main_Group_ID='" + ManagestudentMGID.Text + "',Sub_Group='" + ManagestudentSubG.Text + "',Sub_Group_ID='"+ ManagestudentSGID.Text + "' WHERE ID = '" + ID + "'";
                cmd.ExecuteNonQuery();

                String query2 = "Select * from Students";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                studentdata.DataSource = dt;

                con.Close();

                MessageBox.Show("Updated Succesfully");

                ManagestudentYr.SelectedIndex = -1;
                Managestudentpr.SelectedIndex = -1;
                ManagestudentSem.SelectedIndex = -1;
                ManagestudentMainG.Text = "";
                ManagestudentSubG.Text = "";
                ManagestudentMGID.Text = "";
                ManagestudentSGID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Students where ID = '" + ID + "'";
                    cmd.ExecuteNonQuery();


                    String query2 = "Select * from Students";

                    SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    studentdata.DataSource = dt;


                    con.Close();

                    MessageBox.Show("Delete Succesfully");

                    ManagestudentYr.SelectedIndex = -1;
                    Managestudentpr.SelectedIndex = -1;
                    ManagestudentSem.SelectedIndex = -1;
                    ManagestudentMainG.Text = "";
                    ManagestudentSubG.Text = "";
                    ManagestudentMGID.Text = "";
                    ManagestudentSGID.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void GenerateSubGIDBtn_Click(object sender, EventArgs e)
        {
            AddstuMGID.Text = this.Addstuyr.Text + "." + this.Addstusem.Text + "." + this.Addstupro.Text + ".G" + this.AddstuMgrp.Text;
        }

        private void GenerateGIDBtn_Click(object sender, EventArgs e)
        {
            AddstuSubGID.Text = this.Addstuyr.Text +"."+ this.Addstusem.Text+"." + this.Addstupro.Text + ".G" + this.AddstuMgrp.Text + "." + this.Addstusubgrp.Text;
        }

        private void genmain_Click(object sender, EventArgs e)
        {
            //ManagestudentMGID.Text = "";
            
            ManagestudentMGID.Text= this.ManagestudentYr.Text + "." + this.ManagestudentSem.Text + "." + this.Managestudentpr.Text + ".G" + this.ManagestudentMainG.Text;
        }

        private void gensub_Click(object sender, EventArgs e)
        {
            
            //ManagestudentSGID.Text = "";
            ManagestudentSGID.Text= this.ManagestudentYr.Text + "." + this.ManagestudentSem.Text + "." + this.Managestudentpr.Text + ".G" + this.ManagestudentMainG.Text + "." + this.ManagestudentSubG.Text;
        }

        private void Addstudenttab_Click(object sender, EventArgs e)
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
    }
    }


