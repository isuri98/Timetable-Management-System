namespace TimeTable
{
    partial class Generate_Timetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timetable = new System.Windows.Forms.TabControl();
            this.viewlecturertab = new System.Windows.Forms.TabPage();
            this.dgvLecturerTimetable = new System.Windows.Forms.DataGridView();
            this.btnPrintLecturer = new System.Windows.Forms.Button();
            this.btnGenerateLecturer = new System.Windows.Forms.Button();
            this.cmbGenerateLecturer1 = new MetroFramework.Controls.MetroComboBox();
            this.timeLecturer = new System.Windows.Forms.TextBox();
            this.viewstudenttab = new System.Windows.Forms.TabPage();
            this.dgridforStudentTable = new System.Windows.Forms.DataGridView();
            this.btnPrintStudent1 = new System.Windows.Forms.Button();
            this.btnGenerateStudent1 = new System.Windows.Forms.Button();
            this.StudentGrp3 = new System.Windows.Forms.TextBox();
            this.cmbGenerateStudent1 = new MetroFramework.Controls.MetroComboBox();
            this.viewlocationtab = new System.Windows.Forms.TabPage();
            this.btnPrintLocation = new System.Windows.Forms.Button();
            this.btnGenerateLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgridLocationTimetable = new System.Windows.Forms.DataGridView();
            this.cmbGenerateLocation2 = new MetroFramework.Controls.MetroComboBox();
            this.subjects = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.students = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.working_days = new System.Windows.Forms.Button();
            this.locations = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Button();
            this.lectures = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panelSliderMenu = new System.Windows.Forms.Panel();
            this.Timetable.SuspendLayout();
            this.viewlecturertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturerTimetable)).BeginInit();
            this.viewstudenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridforStudentTable)).BeginInit();
            this.viewlocationtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLocationTimetable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSliderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timetable
            // 
            this.Timetable.Controls.Add(this.viewlecturertab);
            this.Timetable.Controls.Add(this.viewstudenttab);
            this.Timetable.Controls.Add(this.viewlocationtab);
            this.Timetable.Location = new System.Drawing.Point(31, 79);
            this.Timetable.Name = "Timetable";
            this.Timetable.SelectedIndex = 0;
            this.Timetable.Size = new System.Drawing.Size(656, 466);
            this.Timetable.TabIndex = 26;
            this.Timetable.Selected += new System.Windows.Forms.TabControlEventHandler(this.Sessiontab_Selected);
            // 
            // viewlecturertab
            // 
            this.viewlecturertab.Controls.Add(this.dgvLecturerTimetable);
            this.viewlecturertab.Controls.Add(this.btnPrintLecturer);
            this.viewlecturertab.Controls.Add(this.btnGenerateLecturer);
            this.viewlecturertab.Controls.Add(this.cmbGenerateLecturer1);
            this.viewlecturertab.Controls.Add(this.timeLecturer);
            this.viewlecturertab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlecturertab.Location = new System.Drawing.Point(4, 27);
            this.viewlecturertab.Name = "viewlecturertab";
            this.viewlecturertab.Padding = new System.Windows.Forms.Padding(3);
            this.viewlecturertab.Size = new System.Drawing.Size(648, 435);
            this.viewlecturertab.TabIndex = 0;
            this.viewlecturertab.Text = "Lecturer";
            this.viewlecturertab.UseVisualStyleBackColor = true;
            // 
            // dgvLecturerTimetable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecturerTimetable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLecturerTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLecturerTimetable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLecturerTimetable.Location = new System.Drawing.Point(28, 91);
            this.dgvLecturerTimetable.Name = "dgvLecturerTimetable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecturerTimetable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLecturerTimetable.Size = new System.Drawing.Size(589, 294);
            this.dgvLecturerTimetable.TabIndex = 149;
            // 
            // btnPrintLecturer
            // 
            this.btnPrintLecturer.BackColor = System.Drawing.Color.Gold;
            this.btnPrintLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLecturer.Location = new System.Drawing.Point(525, 19);
            this.btnPrintLecturer.Name = "btnPrintLecturer";
            this.btnPrintLecturer.Size = new System.Drawing.Size(81, 39);
            this.btnPrintLecturer.TabIndex = 148;
            this.btnPrintLecturer.Text = "Print";
            this.btnPrintLecturer.UseVisualStyleBackColor = false;
            this.btnPrintLecturer.Click += new System.EventHandler(this.BtnPrintLecturer_Click);
            // 
            // btnGenerateLecturer
            // 
            this.btnGenerateLecturer.BackColor = System.Drawing.Color.Red;
            this.btnGenerateLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLecturer.Location = new System.Drawing.Point(419, 19);
            this.btnGenerateLecturer.Name = "btnGenerateLecturer";
            this.btnGenerateLecturer.Size = new System.Drawing.Size(88, 39);
            this.btnGenerateLecturer.TabIndex = 147;
            this.btnGenerateLecturer.Text = "Generate";
            this.btnGenerateLecturer.UseVisualStyleBackColor = false;
            this.btnGenerateLecturer.Click += new System.EventHandler(this.BtnGenerateLecturer_Click);
            // 
            // cmbGenerateLecturer1
            // 
            this.cmbGenerateLecturer1.FormattingEnabled = true;
            this.cmbGenerateLecturer1.ItemHeight = 23;
            this.cmbGenerateLecturer1.Location = new System.Drawing.Point(217, 22);
            this.cmbGenerateLecturer1.Name = "cmbGenerateLecturer1";
            this.cmbGenerateLecturer1.Size = new System.Drawing.Size(177, 29);
            this.cmbGenerateLecturer1.TabIndex = 139;
            this.cmbGenerateLecturer1.UseSelectable = true;
            // 
            // timeLecturer
            // 
            this.timeLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLecturer.Location = new System.Drawing.Point(42, 22);
            this.timeLecturer.Name = "timeLecturer";
            this.timeLecturer.ReadOnly = true;
            this.timeLecturer.Size = new System.Drawing.Size(145, 24);
            this.timeLecturer.TabIndex = 31;
            this.timeLecturer.Text = "Lecturer:";
            // 
            // viewstudenttab
            // 
            this.viewstudenttab.Controls.Add(this.dgridforStudentTable);
            this.viewstudenttab.Controls.Add(this.btnPrintStudent1);
            this.viewstudenttab.Controls.Add(this.btnGenerateStudent1);
            this.viewstudenttab.Controls.Add(this.StudentGrp3);
            this.viewstudenttab.Controls.Add(this.cmbGenerateStudent1);
            this.viewstudenttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewstudenttab.Location = new System.Drawing.Point(4, 27);
            this.viewstudenttab.Name = "viewstudenttab";
            this.viewstudenttab.Padding = new System.Windows.Forms.Padding(3);
            this.viewstudenttab.Size = new System.Drawing.Size(648, 435);
            this.viewstudenttab.TabIndex = 1;
            this.viewstudenttab.Text = "Student";
            this.viewstudenttab.UseVisualStyleBackColor = true;
            // 
            // dgridforStudentTable
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridforStudentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridforStudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridforStudentTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgridforStudentTable.Location = new System.Drawing.Point(38, 107);
            this.dgridforStudentTable.Name = "dgridforStudentTable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridforStudentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgridforStudentTable.Size = new System.Drawing.Size(566, 287);
            this.dgridforStudentTable.TabIndex = 146;
            // 
            // btnPrintStudent1
            // 
            this.btnPrintStudent1.BackColor = System.Drawing.Color.Gold;
            this.btnPrintStudent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStudent1.Location = new System.Drawing.Point(523, 33);
            this.btnPrintStudent1.Name = "btnPrintStudent1";
            this.btnPrintStudent1.Size = new System.Drawing.Size(81, 39);
            this.btnPrintStudent1.TabIndex = 145;
            this.btnPrintStudent1.Text = "Print";
            this.btnPrintStudent1.UseVisualStyleBackColor = false;
            this.btnPrintStudent1.Click += new System.EventHandler(this.BtnPrintStudent1_Click);
            // 
            // btnGenerateStudent1
            // 
            this.btnGenerateStudent1.BackColor = System.Drawing.Color.Red;
            this.btnGenerateStudent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStudent1.Location = new System.Drawing.Point(417, 33);
            this.btnGenerateStudent1.Name = "btnGenerateStudent1";
            this.btnGenerateStudent1.Size = new System.Drawing.Size(88, 39);
            this.btnGenerateStudent1.TabIndex = 144;
            this.btnGenerateStudent1.Text = "Generate";
            this.btnGenerateStudent1.UseVisualStyleBackColor = false;
            this.btnGenerateStudent1.Click += new System.EventHandler(this.BtnGenerateStudent1_Click);
            // 
            // StudentGrp3
            // 
            this.StudentGrp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGrp3.Location = new System.Drawing.Point(21, 33);
            this.StudentGrp3.Name = "StudentGrp3";
            this.StudentGrp3.ReadOnly = true;
            this.StudentGrp3.Size = new System.Drawing.Size(145, 24);
            this.StudentGrp3.TabIndex = 143;
            this.StudentGrp3.Text = "Student Group:";
            // 
            // cmbGenerateStudent1
            // 
            this.cmbGenerateStudent1.FormattingEnabled = true;
            this.cmbGenerateStudent1.ItemHeight = 23;
            this.cmbGenerateStudent1.Location = new System.Drawing.Point(186, 33);
            this.cmbGenerateStudent1.Name = "cmbGenerateStudent1";
            this.cmbGenerateStudent1.Size = new System.Drawing.Size(200, 29);
            this.cmbGenerateStudent1.TabIndex = 139;
            this.cmbGenerateStudent1.UseSelectable = true;
            // 
            // viewlocationtab
            // 
            this.viewlocationtab.Controls.Add(this.btnPrintLocation);
            this.viewlocationtab.Controls.Add(this.btnGenerateLocation);
            this.viewlocationtab.Controls.Add(this.textBox1);
            this.viewlocationtab.Controls.Add(this.dgridLocationTimetable);
            this.viewlocationtab.Controls.Add(this.cmbGenerateLocation2);
            this.viewlocationtab.Location = new System.Drawing.Point(4, 27);
            this.viewlocationtab.Name = "viewlocationtab";
            this.viewlocationtab.Size = new System.Drawing.Size(648, 435);
            this.viewlocationtab.TabIndex = 2;
            this.viewlocationtab.Text = "Location";
            this.viewlocationtab.UseVisualStyleBackColor = true;
            // 
            // btnPrintLocation
            // 
            this.btnPrintLocation.BackColor = System.Drawing.Color.Gold;
            this.btnPrintLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintLocation.Location = new System.Drawing.Point(535, 26);
            this.btnPrintLocation.Name = "btnPrintLocation";
            this.btnPrintLocation.Size = new System.Drawing.Size(81, 39);
            this.btnPrintLocation.TabIndex = 150;
            this.btnPrintLocation.Text = "Print";
            this.btnPrintLocation.UseVisualStyleBackColor = false;
            this.btnPrintLocation.Click += new System.EventHandler(this.BtnPrintLocation_Click);
            // 
            // btnGenerateLocation
            // 
            this.btnGenerateLocation.BackColor = System.Drawing.Color.Red;
            this.btnGenerateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLocation.Location = new System.Drawing.Point(430, 26);
            this.btnGenerateLocation.Name = "btnGenerateLocation";
            this.btnGenerateLocation.Size = new System.Drawing.Size(88, 39);
            this.btnGenerateLocation.TabIndex = 149;
            this.btnGenerateLocation.Text = "Generate";
            this.btnGenerateLocation.UseVisualStyleBackColor = false;
            this.btnGenerateLocation.Click += new System.EventHandler(this.BtnGenerateLocation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 24);
            this.textBox1.TabIndex = 148;
            this.textBox1.Text = "Location:";
            // 
            // dgridLocationTimetable
            // 
            this.dgridLocationTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridLocationTimetable.Location = new System.Drawing.Point(23, 85);
            this.dgridLocationTimetable.Name = "dgridLocationTimetable";
            this.dgridLocationTimetable.Size = new System.Drawing.Size(602, 324);
            this.dgridLocationTimetable.TabIndex = 147;
            // 
            // cmbGenerateLocation2
            // 
            this.cmbGenerateLocation2.FormattingEnabled = true;
            this.cmbGenerateLocation2.ItemHeight = 23;
            this.cmbGenerateLocation2.Location = new System.Drawing.Point(189, 26);
            this.cmbGenerateLocation2.Name = "cmbGenerateLocation2";
            this.cmbGenerateLocation2.Size = new System.Drawing.Size(200, 29);
            this.cmbGenerateLocation2.TabIndex = 144;
            this.cmbGenerateLocation2.UseSelectable = true;
            // 
            // subjects
            // 
            this.subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjects.FlatAppearance.BorderSize = 0;
            this.subjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjects.Image = global::TimeTable.Properties.Resources.book3;
            this.subjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjects.Location = new System.Drawing.Point(0, 152);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(178, 45);
            this.subjects.TabIndex = 13;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = true;
            this.subjects.Click += new System.EventHandler(this.Subjects_Click_1);
            // 
            // panellogo
            // 
            this.panellogo.BackgroundImage = global::TimeTable.Properties.Resources.logo_size;
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panellogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(178, 62);
            this.panellogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 62);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Time Table";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Timetable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(202, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 552);
            this.panel1.TabIndex = 15;
            // 
            // students
            // 
            this.students.Dock = System.Windows.Forms.DockStyle.Top;
            this.students.FlatAppearance.BorderSize = 0;
            this.students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.students.Image = global::TimeTable.Properties.Resources.student;
            this.students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.students.Location = new System.Drawing.Point(0, 377);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(178, 45);
            this.students.TabIndex = 18;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.Students_Click);
            // 
            // rooms
            // 
            this.rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.rooms.FlatAppearance.BorderSize = 0;
            this.rooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rooms.Image = global::TimeTable.Properties.Resources.room;
            this.rooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rooms.Location = new System.Drawing.Point(0, 332);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(178, 45);
            this.rooms.TabIndex = 17;
            this.rooms.Text = "Rooms";
            this.rooms.UseVisualStyleBackColor = true;
            this.rooms.Click += new System.EventHandler(this.Rooms_Click_1);
            // 
            // working_days
            // 
            this.working_days.Dock = System.Windows.Forms.DockStyle.Top;
            this.working_days.FlatAppearance.BorderSize = 0;
            this.working_days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.working_days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.working_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.working_days.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.working_days.Image = global::TimeTable.Properties.Resources.time3;
            this.working_days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.working_days.Location = new System.Drawing.Point(0, 287);
            this.working_days.Name = "working_days";
            this.working_days.Size = new System.Drawing.Size(178, 45);
            this.working_days.TabIndex = 16;
            this.working_days.Text = "Working Days and Hours";
            this.working_days.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.working_days.UseVisualStyleBackColor = true;
            this.working_days.Click += new System.EventHandler(this.Working_days_Click);
            // 
            // locations
            // 
            this.locations.Dock = System.Windows.Forms.DockStyle.Top;
            this.locations.FlatAppearance.BorderSize = 0;
            this.locations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.locations.Image = global::TimeTable.Properties.Resources.location;
            this.locations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locations.Location = new System.Drawing.Point(0, 242);
            this.locations.Name = "locations";
            this.locations.Size = new System.Drawing.Size(178, 45);
            this.locations.TabIndex = 15;
            this.locations.Text = "Locations";
            this.locations.UseVisualStyleBackColor = true;
            this.locations.Click += new System.EventHandler(this.Locations_Click);
            // 
            // tags
            // 
            this.tags.Dock = System.Windows.Forms.DockStyle.Top;
            this.tags.FlatAppearance.BorderSize = 0;
            this.tags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tags.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tags.Image = global::TimeTable.Properties.Resources.Tags;
            this.tags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tags.Location = new System.Drawing.Point(0, 197);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(178, 45);
            this.tags.TabIndex = 14;
            this.tags.Text = "Tags";
            this.tags.UseVisualStyleBackColor = true;
            this.tags.Click += new System.EventHandler(this.Tags_Click_1);
            // 
            // lectures
            // 
            this.lectures.Dock = System.Windows.Forms.DockStyle.Top;
            this.lectures.FlatAppearance.BorderSize = 0;
            this.lectures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectures.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lectures.Image = global::TimeTable.Properties.Resources.lecture2;
            this.lectures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lectures.Location = new System.Drawing.Point(0, 107);
            this.lectures.Name = "lectures";
            this.lectures.Size = new System.Drawing.Size(178, 45);
            this.lectures.TabIndex = 12;
            this.lectures.Text = "Lecturers";
            this.lectures.UseVisualStyleBackColor = true;
            this.lectures.Click += new System.EventHandler(this.Lectures_Click_1);
            // 
            // dashboard
            // 
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboard.Image = global::TimeTable.Properties.Resources.dashboard1;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(0, 62);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(178, 45);
            this.dashboard.TabIndex = 11;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelSliderMenu
            // 
            this.panelSliderMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSliderMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSliderMenu.Controls.Add(this.students);
            this.panelSliderMenu.Controls.Add(this.rooms);
            this.panelSliderMenu.Controls.Add(this.working_days);
            this.panelSliderMenu.Controls.Add(this.locations);
            this.panelSliderMenu.Controls.Add(this.tags);
            this.panelSliderMenu.Controls.Add(this.subjects);
            this.panelSliderMenu.Controls.Add(this.lectures);
            this.panelSliderMenu.Controls.Add(this.dashboard);
            this.panelSliderMenu.Controls.Add(this.panellogo);
            this.panelSliderMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSliderMenu.Location = new System.Drawing.Point(20, 30);
            this.panelSliderMenu.Name = "panelSliderMenu";
            this.panelSliderMenu.Size = new System.Drawing.Size(182, 552);
            this.panelSliderMenu.TabIndex = 14;
            // 
            // Generate_Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(914, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSliderMenu);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "Generate_Timetable";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Generate_Timetable";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Generate_Timetable_Load);
            this.Timetable.ResumeLayout(false);
            this.viewlecturertab.ResumeLayout(false);
            this.viewlecturertab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturerTimetable)).EndInit();
            this.viewstudenttab.ResumeLayout(false);
            this.viewstudenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridforStudentTable)).EndInit();
            this.viewlocationtab.ResumeLayout(false);
            this.viewlocationtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridLocationTimetable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelSliderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Timetable;
        private System.Windows.Forms.TabPage viewlecturertab;
        private System.Windows.Forms.TextBox timeLecturer;
        private System.Windows.Forms.TabPage viewstudenttab;
        private System.Windows.Forms.TabPage viewlocationtab;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button lectures;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panelSliderMenu;
        private MetroFramework.Controls.MetroComboBox cmbGenerateLecturer1;
        private MetroFramework.Controls.MetroComboBox cmbGenerateStudent1;
        private System.Windows.Forms.TextBox StudentGrp3;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox cmbGenerateLocation2;
        private System.Windows.Forms.Button btnPrintLecturer;
        private System.Windows.Forms.Button btnGenerateLecturer;
        private System.Windows.Forms.Button btnPrintStudent1;
        private System.Windows.Forms.Button btnGenerateStudent1;
        private System.Windows.Forms.Button btnPrintLocation;
        private System.Windows.Forms.Button btnGenerateLocation;
        private System.Windows.Forms.DataGridView dgridforStudentTable;
        private System.Windows.Forms.DataGridView dgridLocationTimetable;
        private System.Windows.Forms.DataGridView dgvLecturerTimetable;
    }
}