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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;



namespace TimeTable


{
    public partial class Generate_Timetable : MetroFramework.Forms.MetroForm
    {
        public int hr = 8;
        public int min = 30;
        public int sec = 0;
        public Generate_Timetable()
        {
            InitializeComponent();
        }
        SqlConnection con;

        public bool True { get; private set; }
        public object DataGridClipboardCopyMode { get; private set; }

        private void Generate_Timetable_Load(object sender, EventArgs e)
        {


            String query2 = "select ID, (Main_Group_ID) AS NAME from Students";

            String query4 = "select lecID, (lecname ) AS NAME from Lecture";

            String query7 = "select ID, (Room_Name) AS NAME from Location";

            try
            {
                con = ConnectionManager.GetConnection();
                con.Open();
                //MessageBox.Show(con.State.ToString());

                SqlDataAdapter da4 = new SqlDataAdapter(query4, con);
                //con.Open();
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "Lecture");

                SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
                //con.Open();
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Students");


                SqlDataAdapter da7 = new SqlDataAdapter(query7, con);
                //con.Open();
                DataSet ds7 = new DataSet();
                da7.Fill(ds7, "Location");

                cmbGenerateLecturer1.DisplayMember = "NAME";
                cmbGenerateLecturer1.ValueMember = "ID";
                cmbGenerateLecturer1.DataSource = ds4.Tables["Lecture"];

                cmbGenerateStudent1.DisplayMember = "NAME";
                cmbGenerateStudent1.ValueMember = "ID";
                cmbGenerateStudent1.DataSource = ds2.Tables["Students"];

                cmbGenerateLocation2.DisplayMember = "NAME";
                cmbGenerateLocation2.ValueMember = "ID";
                cmbGenerateLocation2.DataSource = ds7.Tables["Location"];

                cmbGenerateLecturer1.SelectedIndex = -1;
                cmbGenerateStudent1.SelectedIndex = -1;
                cmbGenerateLocation2.SelectedIndex = -1;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }
        private void Sessiontab_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

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
        private void tags_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }
        private void Location_Click(object sender, EventArgs e)
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

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();

        }

        private void Working_days_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDays workday = new WorkingDays();
            workday.Show();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students student = new Students();
            student.Show();
        }

        private void Rooms_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rooms addroom = new Rooms();
            addroom.Show();
        }

        private void DgvLecturerTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGenerateLecturer_Click(object sender, EventArgs e)
        {

            hr = 8;
            min = 30;
            sec = 0;

            String query6 = "select Lecturer,Subject,SubjectCode,GroupID,Tag,Duration,'1' from Sessions where Lecturer LIKE '%" + cmbGenerateLecturer1.Text + "%'";

            SqlCommand cmd = new SqlCommand(query6, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dgvLecturerTimetable.ColumnCount = 8;
            dgvLecturerTimetable.Columns[0].Name = "Time Slot";
            dgvLecturerTimetable.Columns[1].Name = "Monday";
            dgvLecturerTimetable.Columns[2].Name = "Tuesday";
            dgvLecturerTimetable.Columns[3].Name = "Wednesday";
            dgvLecturerTimetable.Columns[4].Name = "Thursday";
            dgvLecturerTimetable.Columns[5].Name = "Friday";
            dgvLecturerTimetable.Columns[6].Name = "Saturday";
            dgvLecturerTimetable.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgvLecturerTimetable.Rows)
                {
                    try
                    {
                        dgvLecturerTimetable.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgvLecturerTimetable.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgvLecturerTimetable.Rows.Add(row);
            }
        }


        private void timeCalc(int hr1, int min1, int sec1)
        {

            sec += sec1;

            if (sec > 60)
            {
                min++;
                sec -= 60;
            }

            min += min1;

            if (min > 60)
            {
                hr++;
                min -= 60;
            }

            hr += hr1;
        }

        private void BtnGenerateStudent1_Click(object sender, EventArgs e)
        {

            hr = 8;
            min = 30;
            sec = 0;

            String query6 = "select Lecturer ,Subject ,SubjectCode ,GroupID ,Tag ,Duration,'1' from Sessions where GroupID LIKE '%" + cmbGenerateStudent1.Text + "%'";

            SqlCommand cmd = new SqlCommand(query6, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dgridforStudentTable.ColumnCount = 8;
            dgridforStudentTable.Columns[0].Name = "TimeSlot";
            dgridforStudentTable.Columns[1].Name = "Monday";
            dgridforStudentTable.Columns[2].Name = "Tuesday";
            dgridforStudentTable.Columns[3].Name = "Wednesday";
            dgridforStudentTable.Columns[4].Name = "Thursday";
            dgridforStudentTable.Columns[5].Name = "Friday";
            dgridforStudentTable.Columns[6].Name = "Saturday";
            dgridforStudentTable.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgridforStudentTable.Rows)
                {
                    try
                    {
                        dgridforStudentTable.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgridforStudentTable.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgridforStudentTable.Rows.Add(row);
            }
        }

        private void BtnGenerateLocation_Click(object sender, EventArgs e)
        {



            hr = 8;
            min = 30;
            sec = 0;

            String query6 = "select Session,Room,'1' from RoomSession where Room LIKE '%" + cmbGenerateLocation2.Text + "%'";

            SqlCommand cmd = new SqlCommand(query6, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            dgridLocationTimetable.ColumnCount = 8;
            dgridLocationTimetable.Columns[0].Name = "TimeSlot";
            dgridLocationTimetable.Columns[1].Name = "Monday";
            dgridLocationTimetable.Columns[2].Name = "Tuesday";
            dgridLocationTimetable.Columns[3].Name = "Wednesday";
            dgridLocationTimetable.Columns[4].Name = "Thursday";
            dgridLocationTimetable.Columns[5].Name = "Friday";
            dgridLocationTimetable.Columns[6].Name = "Saturday";
            dgridLocationTimetable.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dgridLocationTimetable.Rows)
                {
                    try
                    {
                        dgridLocationTimetable.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgridLocationTimetable.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new System.Collections.ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dgridLocationTimetable.Rows.Add(row);
            }
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location addloc = new Location();
            addloc.Show();
        }

        private void Tags_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TAG tag = new TAG();
            tag.Show();
        }

        private void Subjects_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Subjects addsub = new Subjects();
            addsub.Show();
        }

        private void Lectures_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Lectures addlec = new Lectures();
            addlec.Show();
        }


        private void copyAlltoClipboard()
        {
            dgvLecturerTimetable.RowHeadersVisible = false;
            dgvLecturerTimetable.SelectAll();
            DataObject dataObj = dgvLecturerTimetable.GetClipboardContent();


            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }

        private void BtnPrintLecturer_Click(object sender, EventArgs e)
        {

            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;


            // changing the name of active sheet
            worksheet.Name = "Lecturer";

            // storing header part in Excel
            for (int i = 1; i < dgvLecturerTimetable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvLecturerTimetable.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet
            for (int i = 0; i < dgvLecturerTimetable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvLecturerTimetable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLecturerTimetable.Rows[i].Cells[j].Value.ToString();
                }
            }
        }


        private void copyAlltoClipboard1()
        {
            dgridforStudentTable.RowHeadersVisible = false;
            dgridforStudentTable.SelectAll();
            DataObject dataObj = dgridforStudentTable.GetClipboardContent();


            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }



        
        private void BtnPrintStudent1_Click(object sender, EventArgs e)
        {

            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;


            // changing the name of active sheet
            worksheet.Name = "Lecturer";

            // storing header part in Excel
            for (int i = 1; i < dgridforStudentTable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgridforStudentTable.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet
            for (int i = 0; i < dgridforStudentTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgridforStudentTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgridforStudentTable.Rows[i].Cells[j].Value.ToString();
                }
            }

        }
        private void copyAlltoClipboard2()
        {
            dgridLocationTimetable.RowHeadersVisible = false;
            dgridLocationTimetable.SelectAll();
            DataObject dataObj = dgridLocationTimetable.GetClipboardContent();


            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }
        private void BtnPrintLocation_Click(object sender, EventArgs e)
        {
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            

            // changing the name of active sheet
            worksheet.Name = "Location";

            // storing header part in Excel
            for (int i = 1; i < dgridLocationTimetable.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgridLocationTimetable.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet
            for (int i = 0; i < dgridLocationTimetable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgridLocationTimetable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgridLocationTimetable.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}


