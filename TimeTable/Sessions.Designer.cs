namespace TimeTable
{
    partial class Sessions
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sessiontab = new System.Windows.Forms.TabControl();
            this.viewsessiontab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.cmbfilterGrp = new System.Windows.Forms.ComboBox();
            this.cmbfiltersubject = new System.Windows.Forms.ComboBox();
            this.cmbfilterlecturers = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addsessiontab = new System.Windows.Forms.TabPage();
            this.newSID = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtSelectedLecturers = new System.Windows.Forms.RichTextBox();
            this.cmbSsubject1 = new System.Windows.Forms.ComboBox();
            this.cmbSlecturer = new System.Windows.Forms.ComboBox();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.noOfStudents = new System.Windows.Forms.NumericUpDown();
            this.cmbsubjectCode = new System.Windows.Forms.ComboBox();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSessionclear = new System.Windows.Forms.Button();
            this.btnSessionSave = new System.Windows.Forms.Button();
            this.comboTag = new System.Windows.Forms.ComboBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.txtLectures1 = new System.Windows.Forms.TextBox();
            this.txtTag1 = new System.Windows.Forms.TextBox();
            this.txtStudents1 = new System.Windows.Forms.TextBox();
            this.txtDuration1 = new System.Windows.Forms.TextBox();
            this.txtSubject1 = new System.Windows.Forms.TextBox();
            this.txtGroup1 = new System.Windows.Forms.TextBox();
            this.txtLecturer1 = new System.Windows.Forms.TextBox();
            this.editsessiontab = new System.Windows.Forms.TabPage();
            this.cmbEditSessionCode = new System.Windows.Forms.ComboBox();
            this.EditNoOfStudents = new System.Windows.Forms.NumericUpDown();
            this.EditDuration = new System.Windows.Forms.NumericUpDown();
            this.EditSessionID = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSessionDelete = new System.Windows.Forms.Button();
            this.txtlectures = new System.Windows.Forms.RichTextBox();
            this.btnSclear = new System.Windows.Forms.Button();
            this.btnSessionUpdate = new System.Windows.Forms.Button();
            this.comboEditTag = new System.Windows.Forms.ComboBox();
            this.comboEditSubject = new System.Windows.Forms.ComboBox();
            this.comboEditGroup = new System.Windows.Forms.ComboBox();
            this.cmbEditlectures = new System.Windows.Forms.ComboBox();
            this.txtLectures2 = new System.Windows.Forms.TextBox();
            this.textTag2 = new System.Windows.Forms.TextBox();
            this.txtstudents2 = new System.Windows.Forms.TextBox();
            this.textDuration2 = new System.Windows.Forms.TextBox();
            this.txtSubject2 = new System.Windows.Forms.TextBox();
            this.txtGroup2 = new System.Windows.Forms.TextBox();
            this.txtLecturer2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSliderMenu = new System.Windows.Forms.Panel();
            this.students = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.working_days = new System.Windows.Forms.Button();
            this.locations = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.lectures = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sessiontab.SuspendLayout();
            this.viewsessiontab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.addsessiontab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfStudents)).BeginInit();
            this.editsessiontab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditNoOfStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDuration)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSliderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sessiontab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(197, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 563);
            this.panel1.TabIndex = 13;
            // 
            // sessiontab
            // 
            this.sessiontab.Controls.Add(this.viewsessiontab);
            this.sessiontab.Controls.Add(this.addsessiontab);
            this.sessiontab.Controls.Add(this.editsessiontab);
            this.sessiontab.Location = new System.Drawing.Point(31, 80);
            this.sessiontab.Name = "sessiontab";
            this.sessiontab.SelectedIndex = 0;
            this.sessiontab.Size = new System.Drawing.Size(656, 466);
            this.sessiontab.TabIndex = 26;
            // 
            // viewsessiontab
            // 
            this.viewsessiontab.Controls.Add(this.label3);
            this.viewsessiontab.Controls.Add(this.dgvSessions);
            this.viewsessiontab.Controls.Add(this.cmbfilterGrp);
            this.viewsessiontab.Controls.Add(this.cmbfiltersubject);
            this.viewsessiontab.Controls.Add(this.cmbfilterlecturers);
            this.viewsessiontab.Controls.Add(this.textBox3);
            this.viewsessiontab.Controls.Add(this.textBox2);
            this.viewsessiontab.Controls.Add(this.textBox1);
            this.viewsessiontab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsessiontab.Location = new System.Drawing.Point(4, 27);
            this.viewsessiontab.Name = "viewsessiontab";
            this.viewsessiontab.Padding = new System.Windows.Forms.Padding(3);
            this.viewsessiontab.Size = new System.Drawing.Size(648, 435);
            this.viewsessiontab.TabIndex = 0;
            this.viewsessiontab.Text = "View Session";
            this.viewsessiontab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(246, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 138;
            this.label3.Text = "View Sessions";
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(17, 205);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowHeadersWidth = 51;
            this.dgvSessions.Size = new System.Drawing.Size(620, 196);
            this.dgvSessions.TabIndex = 38;
            this.dgvSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSessions_CellContentClick);
            this.dgvSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSessions_CellContentClick);
            // 
            // cmbfilterGrp
            // 
            this.cmbfilterGrp.FormattingEnabled = true;
            this.cmbfilterGrp.Location = new System.Drawing.Point(358, 135);
            this.cmbfilterGrp.Name = "cmbfilterGrp";
            this.cmbfilterGrp.Size = new System.Drawing.Size(146, 21);
            this.cmbfilterGrp.TabIndex = 36;
            this.cmbfilterGrp.SelectedIndexChanged += new System.EventHandler(this.CmbfilterGrp_SelectedIndexChanged);
            // 
            // cmbfiltersubject
            // 
            this.cmbfiltersubject.FormattingEnabled = true;
            this.cmbfiltersubject.Location = new System.Drawing.Point(506, 95);
            this.cmbfiltersubject.Name = "cmbfiltersubject";
            this.cmbfiltersubject.Size = new System.Drawing.Size(139, 21);
            this.cmbfiltersubject.TabIndex = 35;
            this.cmbfiltersubject.SelectedIndexChanged += new System.EventHandler(this.Cmbfiltersubject_SelectedIndexChanged);
            // 
            // cmbfilterlecturers
            // 
            this.cmbfilterlecturers.FormattingEnabled = true;
            this.cmbfilterlecturers.Location = new System.Drawing.Point(148, 92);
            this.cmbfilterlecturers.Name = "cmbfilterlecturers";
            this.cmbfilterlecturers.Size = new System.Drawing.Size(152, 21);
            this.cmbfilterlecturers.TabIndex = 34;
            this.cmbfilterlecturers.SelectedIndexChanged += new System.EventHandler(this.Cmbfilterlecturers_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(334, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(157, 24);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "Filter By Subject:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(191, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 24);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = " Filter By Group:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "Filter By Lecturer:";
            // 
            // addsessiontab
            // 
            this.addsessiontab.Controls.Add(this.newSID);
            this.addsessiontab.Controls.Add(this.textBox4);
            this.addsessiontab.Controls.Add(this.txtSelectedLecturers);
            this.addsessiontab.Controls.Add(this.cmbSsubject1);
            this.addsessiontab.Controls.Add(this.cmbSlecturer);
            this.addsessiontab.Controls.Add(this.duration);
            this.addsessiontab.Controls.Add(this.noOfStudents);
            this.addsessiontab.Controls.Add(this.cmbsubjectCode);
            this.addsessiontab.Controls.Add(this.txtCode1);
            this.addsessiontab.Controls.Add(this.label2);
            this.addsessiontab.Controls.Add(this.btnSessionclear);
            this.addsessiontab.Controls.Add(this.btnSessionSave);
            this.addsessiontab.Controls.Add(this.comboTag);
            this.addsessiontab.Controls.Add(this.comboGroup);
            this.addsessiontab.Controls.Add(this.txtLectures1);
            this.addsessiontab.Controls.Add(this.txtTag1);
            this.addsessiontab.Controls.Add(this.txtStudents1);
            this.addsessiontab.Controls.Add(this.txtDuration1);
            this.addsessiontab.Controls.Add(this.txtSubject1);
            this.addsessiontab.Controls.Add(this.txtGroup1);
            this.addsessiontab.Controls.Add(this.txtLecturer1);
            this.addsessiontab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsessiontab.Location = new System.Drawing.Point(4, 27);
            this.addsessiontab.Name = "addsessiontab";
            this.addsessiontab.Padding = new System.Windows.Forms.Padding(3);
            this.addsessiontab.Size = new System.Drawing.Size(648, 435);
            this.addsessiontab.TabIndex = 1;
            this.addsessiontab.Text = "Add Session";
            this.addsessiontab.UseVisualStyleBackColor = true;
            // 
            // newSID
            // 
            this.newSID.Location = new System.Drawing.Point(166, 104);
            this.newSID.Name = "newSID";
            this.newSID.Size = new System.Drawing.Size(144, 20);
            this.newSID.TabIndex = 148;
            this.newSID.TextChanged += new System.EventHandler(this.NewSID_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(116, 24);
            this.textBox4.TabIndex = 147;
            this.textBox4.Text = "Session ID";
            // 
            // txtSelectedLecturers
            // 
            this.txtSelectedLecturers.Location = new System.Drawing.Point(166, 174);
            this.txtSelectedLecturers.Name = "txtSelectedLecturers";
            this.txtSelectedLecturers.Size = new System.Drawing.Size(144, 110);
            this.txtSelectedLecturers.TabIndex = 146;
            this.txtSelectedLecturers.Text = "";
            // 
            // cmbSsubject1
            // 
            this.cmbSsubject1.FormattingEnabled = true;
            this.cmbSsubject1.Location = new System.Drawing.Point(166, 294);
            this.cmbSsubject1.Name = "cmbSsubject1";
            this.cmbSsubject1.Size = new System.Drawing.Size(144, 21);
            this.cmbSsubject1.TabIndex = 145;
            // 
            // cmbSlecturer
            // 
            this.cmbSlecturer.FormattingEnabled = true;
            this.cmbSlecturer.Location = new System.Drawing.Point(166, 135);
            this.cmbSlecturer.Name = "cmbSlecturer";
            this.cmbSlecturer.Size = new System.Drawing.Size(144, 21);
            this.cmbSlecturer.TabIndex = 144;
            this.cmbSlecturer.SelectedIndexChanged += new System.EventHandler(this.CmbSlecturer_SelectedIndexChanged);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(514, 288);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(120, 20);
            this.duration.TabIndex = 143;
            // 
            // noOfStudents
            // 
            this.noOfStudents.Location = new System.Drawing.Point(514, 242);
            this.noOfStudents.Name = "noOfStudents";
            this.noOfStudents.Size = new System.Drawing.Size(120, 20);
            this.noOfStudents.TabIndex = 140;
            // 
            // cmbsubjectCode
            // 
            this.cmbsubjectCode.FormattingEnabled = true;
            this.cmbsubjectCode.Location = new System.Drawing.Point(514, 111);
            this.cmbsubjectCode.Name = "cmbsubjectCode";
            this.cmbsubjectCode.Size = new System.Drawing.Size(121, 21);
            this.cmbsubjectCode.TabIndex = 139;
            // 
            // txtCode1
            // 
            this.txtCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode1.Location = new System.Drawing.Point(342, 111);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.ReadOnly = true;
            this.txtCode1.Size = new System.Drawing.Size(144, 24);
            this.txtCode1.TabIndex = 138;
            this.txtCode1.Text = "Subject Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(236, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 137;
            this.label2.Text = "Add Sessions";
            // 
            // btnSessionclear
            // 
            this.btnSessionclear.BackColor = System.Drawing.Color.Red;
            this.btnSessionclear.Location = new System.Drawing.Point(385, 355);
            this.btnSessionclear.Name = "btnSessionclear";
            this.btnSessionclear.Size = new System.Drawing.Size(101, 41);
            this.btnSessionclear.TabIndex = 134;
            this.btnSessionclear.Text = "Clear";
            this.btnSessionclear.UseVisualStyleBackColor = false;
            this.btnSessionclear.Click += new System.EventHandler(this.BtnSessionclear_Click);
            // 
            // btnSessionSave
            // 
            this.btnSessionSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSessionSave.Location = new System.Drawing.Point(206, 355);
            this.btnSessionSave.Name = "btnSessionSave";
            this.btnSessionSave.Size = new System.Drawing.Size(104, 41);
            this.btnSessionSave.TabIndex = 133;
            this.btnSessionSave.Text = "Save";
            this.btnSessionSave.UseVisualStyleBackColor = false;
            this.btnSessionSave.Click += new System.EventHandler(this.BtnSessionsave_Click);
            // 
            // comboTag
            // 
            this.comboTag.FormattingEnabled = true;
            this.comboTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.comboTag.Location = new System.Drawing.Point(514, 201);
            this.comboTag.Name = "comboTag";
            this.comboTag.Size = new System.Drawing.Size(121, 21);
            this.comboTag.TabIndex = 132;
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(514, 156);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(121, 21);
            this.comboGroup.TabIndex = 129;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.ComboGroup_SelectedIndexChanged);
            // 
            // txtLectures1
            // 
            this.txtLectures1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectures1.Location = new System.Drawing.Point(15, 180);
            this.txtLectures1.Name = "txtLectures1";
            this.txtLectures1.ReadOnly = true;
            this.txtLectures1.Size = new System.Drawing.Size(123, 24);
            this.txtLectures1.TabIndex = 127;
            this.txtLectures1.Text = "Selected Lectures";
            // 
            // txtTag1
            // 
            this.txtTag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag1.Location = new System.Drawing.Point(343, 201);
            this.txtTag1.Name = "txtTag1";
            this.txtTag1.ReadOnly = true;
            this.txtTag1.Size = new System.Drawing.Size(144, 24);
            this.txtTag1.TabIndex = 126;
            this.txtTag1.Text = "Select Tag";
            // 
            // txtStudents1
            // 
            this.txtStudents1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudents1.Location = new System.Drawing.Point(343, 242);
            this.txtStudents1.Name = "txtStudents1";
            this.txtStudents1.ReadOnly = true;
            this.txtStudents1.Size = new System.Drawing.Size(144, 24);
            this.txtStudents1.TabIndex = 125;
            this.txtStudents1.Text = "No of Students";
            // 
            // txtDuration1
            // 
            this.txtDuration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration1.Location = new System.Drawing.Point(343, 284);
            this.txtDuration1.Name = "txtDuration1";
            this.txtDuration1.ReadOnly = true;
            this.txtDuration1.Size = new System.Drawing.Size(144, 24);
            this.txtDuration1.TabIndex = 124;
            this.txtDuration1.Text = "Duration(Hours)";
            // 
            // txtSubject1
            // 
            this.txtSubject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject1.Location = new System.Drawing.Point(15, 291);
            this.txtSubject1.Name = "txtSubject1";
            this.txtSubject1.ReadOnly = true;
            this.txtSubject1.Size = new System.Drawing.Size(125, 24);
            this.txtSubject1.TabIndex = 123;
            this.txtSubject1.Text = "Select Subject";
            // 
            // txtGroup1
            // 
            this.txtGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup1.Location = new System.Drawing.Point(343, 156);
            this.txtGroup1.Name = "txtGroup1";
            this.txtGroup1.ReadOnly = true;
            this.txtGroup1.Size = new System.Drawing.Size(144, 24);
            this.txtGroup1.TabIndex = 122;
            this.txtGroup1.Text = "Select Group";
            // 
            // txtLecturer1
            // 
            this.txtLecturer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturer1.Location = new System.Drawing.Point(15, 135);
            this.txtLecturer1.Name = "txtLecturer1";
            this.txtLecturer1.ReadOnly = true;
            this.txtLecturer1.Size = new System.Drawing.Size(116, 24);
            this.txtLecturer1.TabIndex = 121;
            this.txtLecturer1.Text = "Select Lectures";
            // 
            // editsessiontab
            // 
            this.editsessiontab.Controls.Add(this.cmbEditSessionCode);
            this.editsessiontab.Controls.Add(this.EditNoOfStudents);
            this.editsessiontab.Controls.Add(this.EditDuration);
            this.editsessiontab.Controls.Add(this.EditSessionID);
            this.editsessiontab.Controls.Add(this.txtSID);
            this.editsessiontab.Controls.Add(this.txtCode2);
            this.editsessiontab.Controls.Add(this.label4);
            this.editsessiontab.Controls.Add(this.btnSessionDelete);
            this.editsessiontab.Controls.Add(this.txtlectures);
            this.editsessiontab.Controls.Add(this.btnSclear);
            this.editsessiontab.Controls.Add(this.btnSessionUpdate);
            this.editsessiontab.Controls.Add(this.comboEditTag);
            this.editsessiontab.Controls.Add(this.comboEditSubject);
            this.editsessiontab.Controls.Add(this.comboEditGroup);
            this.editsessiontab.Controls.Add(this.cmbEditlectures);
            this.editsessiontab.Controls.Add(this.txtLectures2);
            this.editsessiontab.Controls.Add(this.textTag2);
            this.editsessiontab.Controls.Add(this.txtstudents2);
            this.editsessiontab.Controls.Add(this.textDuration2);
            this.editsessiontab.Controls.Add(this.txtSubject2);
            this.editsessiontab.Controls.Add(this.txtGroup2);
            this.editsessiontab.Controls.Add(this.txtLecturer2);
            this.editsessiontab.Location = new System.Drawing.Point(4, 27);
            this.editsessiontab.Name = "editsessiontab";
            this.editsessiontab.Size = new System.Drawing.Size(648, 435);
            this.editsessiontab.TabIndex = 2;
            this.editsessiontab.Text = "Edit/Delete Sessions";
            this.editsessiontab.UseVisualStyleBackColor = true;
            // 
            // cmbEditSessionCode
            // 
            this.cmbEditSessionCode.FormattingEnabled = true;
            this.cmbEditSessionCode.Location = new System.Drawing.Point(505, 78);
            this.cmbEditSessionCode.Name = "cmbEditSessionCode";
            this.cmbEditSessionCode.Size = new System.Drawing.Size(121, 26);
            this.cmbEditSessionCode.TabIndex = 145;
            // 
            // EditNoOfStudents
            // 
            this.EditNoOfStudents.Location = new System.Drawing.Point(506, 214);
            this.EditNoOfStudents.Name = "EditNoOfStudents";
            this.EditNoOfStudents.Size = new System.Drawing.Size(120, 24);
            this.EditNoOfStudents.TabIndex = 144;
            // 
            // EditDuration
            // 
            this.EditDuration.Location = new System.Drawing.Point(506, 255);
            this.EditDuration.Name = "EditDuration";
            this.EditDuration.Size = new System.Drawing.Size(120, 24);
            this.EditDuration.TabIndex = 143;
            // 
            // EditSessionID
            // 
            this.EditSessionID.Location = new System.Drawing.Point(168, 66);
            this.EditSessionID.Name = "EditSessionID";
            this.EditSessionID.Size = new System.Drawing.Size(147, 24);
            this.EditSessionID.TabIndex = 142;
            this.EditSessionID.TextChanged += new System.EventHandler(this.TextSID_TextChanged);
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.Location = new System.Drawing.Point(15, 66);
            this.txtSID.Name = "txtSID";
            this.txtSID.ReadOnly = true;
            this.txtSID.Size = new System.Drawing.Size(117, 24);
            this.txtSID.TabIndex = 141;
            this.txtSID.Text = "Session ID";
            // 
            // txtCode2
            // 
            this.txtCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode2.Location = new System.Drawing.Point(344, 80);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.ReadOnly = true;
            this.txtCode2.Size = new System.Drawing.Size(127, 24);
            this.txtCode2.TabIndex = 139;
            this.txtCode2.Text = "Subject Code";
            this.txtCode2.TextChanged += new System.EventHandler(this.TextBox19_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(252, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 138;
            this.label4.Text = "Manage Sessions";
            // 
            // btnSessionDelete
            // 
            this.btnSessionDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnSessionDelete.Location = new System.Drawing.Point(297, 314);
            this.btnSessionDelete.Name = "btnSessionDelete";
            this.btnSessionDelete.Size = new System.Drawing.Size(104, 41);
            this.btnSessionDelete.TabIndex = 49;
            this.btnSessionDelete.Text = "Delete";
            this.btnSessionDelete.UseVisualStyleBackColor = false;
            this.btnSessionDelete.Click += new System.EventHandler(this.BtnSessionDelete_Click_1);
            // 
            // txtlectures
            // 
            this.txtlectures.Location = new System.Drawing.Point(168, 156);
            this.txtlectures.Name = "txtlectures";
            this.txtlectures.Size = new System.Drawing.Size(147, 96);
            this.txtlectures.TabIndex = 48;
            this.txtlectures.Text = "";
            // 
            // btnSclear
            // 
            this.btnSclear.BackColor = System.Drawing.Color.Red;
            this.btnSclear.Location = new System.Drawing.Point(440, 314);
            this.btnSclear.Name = "btnSclear";
            this.btnSclear.Size = new System.Drawing.Size(101, 41);
            this.btnSclear.TabIndex = 46;
            this.btnSclear.Text = "Clear";
            this.btnSclear.UseVisualStyleBackColor = false;
            this.btnSclear.Click += new System.EventHandler(this.BtnSclear_Click);
            // 
            // btnSessionUpdate
            // 
            this.btnSessionUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSessionUpdate.Location = new System.Drawing.Point(152, 314);
            this.btnSessionUpdate.Name = "btnSessionUpdate";
            this.btnSessionUpdate.Size = new System.Drawing.Size(104, 41);
            this.btnSessionUpdate.TabIndex = 45;
            this.btnSessionUpdate.Text = "Update";
            this.btnSessionUpdate.UseVisualStyleBackColor = false;
            this.btnSessionUpdate.Click += new System.EventHandler(this.BtnSessionUpdate_Click);
            // 
            // comboEditTag
            // 
            this.comboEditTag.FormattingEnabled = true;
            this.comboEditTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.comboEditTag.Location = new System.Drawing.Point(506, 165);
            this.comboEditTag.Name = "comboEditTag";
            this.comboEditTag.Size = new System.Drawing.Size(121, 26);
            this.comboEditTag.TabIndex = 44;
            this.comboEditTag.SelectedIndexChanged += new System.EventHandler(this.ComboEditTag_SelectedIndexChanged);
            // 
            // comboEditSubject
            // 
            this.comboEditSubject.FormattingEnabled = true;
            this.comboEditSubject.Location = new System.Drawing.Point(168, 270);
            this.comboEditSubject.Name = "comboEditSubject";
            this.comboEditSubject.Size = new System.Drawing.Size(147, 26);
            this.comboEditSubject.TabIndex = 42;
            this.comboEditSubject.SelectedIndexChanged += new System.EventHandler(this.ComboEditSubject_SelectedIndexChanged);
            // 
            // comboEditGroup
            // 
            this.comboEditGroup.FormattingEnabled = true;
            this.comboEditGroup.Location = new System.Drawing.Point(506, 121);
            this.comboEditGroup.Name = "comboEditGroup";
            this.comboEditGroup.Size = new System.Drawing.Size(121, 26);
            this.comboEditGroup.TabIndex = 41;
            this.comboEditGroup.SelectedIndexChanged += new System.EventHandler(this.ComboEditGroup_SelectedIndexChanged);
            // 
            // cmbEditlectures
            // 
            this.cmbEditlectures.FormattingEnabled = true;
            this.cmbEditlectures.Location = new System.Drawing.Point(169, 109);
            this.cmbEditlectures.Name = "cmbEditlectures";
            this.cmbEditlectures.Size = new System.Drawing.Size(146, 26);
            this.cmbEditlectures.TabIndex = 40;
            this.cmbEditlectures.SelectedIndexChanged += new System.EventHandler(this.CmbEditlectures_SelectedIndexChanged);
            // 
            // txtLectures2
            // 
            this.txtLectures2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectures2.Location = new System.Drawing.Point(15, 156);
            this.txtLectures2.Name = "txtLectures2";
            this.txtLectures2.ReadOnly = true;
            this.txtLectures2.Size = new System.Drawing.Size(127, 24);
            this.txtLectures2.TabIndex = 39;
            this.txtLectures2.Text = "Selected Lectures";
            this.txtLectures2.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // textTag2
            // 
            this.textTag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTag2.Location = new System.Drawing.Point(344, 165);
            this.textTag2.Name = "textTag2";
            this.textTag2.ReadOnly = true;
            this.textTag2.Size = new System.Drawing.Size(127, 24);
            this.textTag2.TabIndex = 38;
            this.textTag2.Text = "Select Tag";
            this.textTag2.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // txtstudents2
            // 
            this.txtstudents2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudents2.Location = new System.Drawing.Point(344, 213);
            this.txtstudents2.Name = "txtstudents2";
            this.txtstudents2.ReadOnly = true;
            this.txtstudents2.Size = new System.Drawing.Size(127, 24);
            this.txtstudents2.TabIndex = 37;
            this.txtstudents2.Text = "No of Students";
            // 
            // textDuration2
            // 
            this.textDuration2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDuration2.Location = new System.Drawing.Point(344, 255);
            this.textDuration2.Name = "textDuration2";
            this.textDuration2.ReadOnly = true;
            this.textDuration2.Size = new System.Drawing.Size(127, 24);
            this.textDuration2.TabIndex = 36;
            this.textDuration2.Text = "Duration(Hours)";
            // 
            // txtSubject2
            // 
            this.txtSubject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject2.Location = new System.Drawing.Point(15, 270);
            this.txtSubject2.Name = "txtSubject2";
            this.txtSubject2.ReadOnly = true;
            this.txtSubject2.Size = new System.Drawing.Size(127, 24);
            this.txtSubject2.TabIndex = 35;
            this.txtSubject2.Text = "Select Subject";
            // 
            // txtGroup2
            // 
            this.txtGroup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup2.Location = new System.Drawing.Point(344, 123);
            this.txtGroup2.Name = "txtGroup2";
            this.txtGroup2.ReadOnly = true;
            this.txtGroup2.Size = new System.Drawing.Size(127, 24);
            this.txtGroup2.TabIndex = 34;
            this.txtGroup2.Text = "Select Group";
            // 
            // txtLecturer2
            // 
            this.txtLecturer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturer2.Location = new System.Drawing.Point(15, 111);
            this.txtLecturer2.Name = "txtLecturer2";
            this.txtLecturer2.ReadOnly = true;
            this.txtLecturer2.Size = new System.Drawing.Size(117, 24);
            this.txtLecturer2.TabIndex = 33;
            this.txtLecturer2.Text = "Select Lectures";
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
            this.panel2.Size = new System.Drawing.Size(722, 62);
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
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sessions";
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
            this.panelSliderMenu.Location = new System.Drawing.Point(15, 30);
            this.panelSliderMenu.Name = "panelSliderMenu";
            this.panelSliderMenu.Size = new System.Drawing.Size(182, 563);
            this.panelSliderMenu.TabIndex = 12;
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
            this.students.Click += new System.EventHandler(this.students_Click);
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
            this.rooms.Click += new System.EventHandler(this.Rooms_Click);
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
            this.tags.Click += new System.EventHandler(this.tags_Click);
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
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
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
            this.lectures.Click += new System.EventHandler(this.lectures_Click);
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
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
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
            // Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(938, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSliderMenu);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Sessions";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Sessions_Load);
            this.panel1.ResumeLayout(false);
            this.sessiontab.ResumeLayout(false);
            this.viewsessiontab.ResumeLayout(false);
            this.viewsessiontab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.addsessiontab.ResumeLayout(false);
            this.addsessiontab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfStudents)).EndInit();
            this.editsessiontab.ResumeLayout(false);
            this.editsessiontab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditNoOfStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDuration)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSliderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSliderMenu;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button lectures;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.TabControl sessiontab;
        private System.Windows.Forms.TabPage viewsessiontab;
        private System.Windows.Forms.TabPage addsessiontab;
        private System.Windows.Forms.TabPage editsessiontab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSessionclear;
        private System.Windows.Forms.Button btnSessionSave;
        private System.Windows.Forms.ComboBox comboTag;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.TextBox txtLectures1;
        private System.Windows.Forms.TextBox txtTag1;
        private System.Windows.Forms.TextBox txtStudents1;
        private System.Windows.Forms.TextBox txtDuration1;
        private System.Windows.Forms.TextBox txtSubject1;
        private System.Windows.Forms.TextBox txtGroup1;
        private System.Windows.Forms.TextBox txtLecturer1;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.ComboBox cmbfilterGrp;
        private System.Windows.Forms.ComboBox cmbfiltersubject;
        private System.Windows.Forms.ComboBox cmbfilterlecturers;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSessionDelete;
        private System.Windows.Forms.RichTextBox txtlectures;
        private System.Windows.Forms.Button btnSclear;
        private System.Windows.Forms.Button btnSessionUpdate;
        private System.Windows.Forms.ComboBox comboEditTag;
        private System.Windows.Forms.ComboBox comboEditSubject;
        private System.Windows.Forms.ComboBox comboEditGroup;
        private System.Windows.Forms.ComboBox cmbEditlectures;
        private System.Windows.Forms.TextBox txtLectures2;
        private System.Windows.Forms.TextBox textTag2;
        private System.Windows.Forms.TextBox txtstudents2;
        private System.Windows.Forms.TextBox textDuration2;
        private System.Windows.Forms.TextBox txtSubject2;
        private System.Windows.Forms.TextBox txtGroup2;
        private System.Windows.Forms.TextBox txtLecturer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode1;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.TextBox EditSessionID;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.NumericUpDown noOfStudents;
        private System.Windows.Forms.ComboBox cmbsubjectCode;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.NumericUpDown EditNoOfStudents;
        private System.Windows.Forms.NumericUpDown EditDuration;
        private System.Windows.Forms.ComboBox cmbSsubject1;
        private System.Windows.Forms.ComboBox cmbSlecturer;
        private System.Windows.Forms.RichTextBox txtSelectedLecturers;
        private System.Windows.Forms.TextBox newSID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmbEditSessionCode;
    }
}