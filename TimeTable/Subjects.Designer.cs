using System;

namespace TimeTable
{
    partial class Subjects
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
            this.subjecttab = new System.Windows.Forms.TabControl();
            this.subjecttabpage = new System.Windows.Forms.TabPage();
            this.cmbevalhours = new System.Windows.Forms.ComboBox();
            this.btnsubclear1 = new System.Windows.Forms.Button();
            this.btnsubsave = new System.Windows.Forms.Button();
            this.cmbsem = new System.Windows.Forms.ComboBox();
            this.cmbtutehours = new System.Windows.Forms.ComboBox();
            this.cmblabhours = new System.Windows.Forms.ComboBox();
            this.cmblechours = new System.Windows.Forms.ComboBox();
            this.cmboffyear = new System.Windows.Forms.ComboBox();
            this.txtSubName1 = new System.Windows.Forms.TextBox();
            this.txtYear1 = new System.Windows.Forms.TextBox();
            this.txtsem1 = new System.Windows.Forms.TextBox();
            this.txtTuteHours1 = new System.Windows.Forms.TextBox();
            this.txtsubcode = new System.Windows.Forms.TextBox();
            this.txtsubname = new System.Windows.Forms.TextBox();
            this.txtEvaHours = new System.Windows.Forms.TextBox();
            this.txtlabHours1 = new System.Windows.Forms.TextBox();
            this.txtlecHours1 = new System.Windows.Forms.TextBox();
            this.txtSubjectcode1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.managesubjecttab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnSubDelete = new System.Windows.Forms.Button();
            this.cmbEditEval = new System.Windows.Forms.ComboBox();
            this.btnSubjectMclear = new System.Windows.Forms.Button();
            this.btnSubUpdate = new System.Windows.Forms.Button();
            this.cmbEditsem = new System.Windows.Forms.ComboBox();
            this.cmbEditTute = new System.Windows.Forms.ComboBox();
            this.cmbEditLab = new System.Windows.Forms.ComboBox();
            this.cmbEditLectureHours = new System.Windows.Forms.ComboBox();
            this.cmbEdityear = new System.Windows.Forms.ComboBox();
            this.txtSubName2 = new System.Windows.Forms.TextBox();
            this.txtYear2 = new System.Windows.Forms.TextBox();
            this.txtsem2 = new System.Windows.Forms.TextBox();
            this.txtTuteHours2 = new System.Windows.Forms.TextBox();
            this.txtEditSubjectCode = new System.Windows.Forms.TextBox();
            this.txtEditSubName = new System.Windows.Forms.TextBox();
            this.txtEvalHours = new System.Windows.Forms.TextBox();
            this.txtLabHours2 = new System.Windows.Forms.TextBox();
            this.txtlecHours2 = new System.Windows.Forms.TextBox();
            this.txtSubCode2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSliderMenu = new System.Windows.Forms.Panel();
            this.students = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.working_days = new System.Windows.Forms.Button();
            this.locations = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.subjecttab.SuspendLayout();
            this.subjecttabpage.SuspendLayout();
            this.managesubjecttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSliderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.subjecttab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(197, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 563);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // subjecttab
            // 
            this.subjecttab.Controls.Add(this.subjecttabpage);
            this.subjecttab.Controls.Add(this.managesubjecttab);
            this.subjecttab.Location = new System.Drawing.Point(23, 67);
            this.subjecttab.Name = "subjecttab";
            this.subjecttab.SelectedIndex = 0;
            this.subjecttab.Size = new System.Drawing.Size(685, 488);
            this.subjecttab.TabIndex = 26;
            // 
            // subjecttabpage
            // 
            this.subjecttabpage.Controls.Add(this.cmbevalhours);
            this.subjecttabpage.Controls.Add(this.btnsubclear1);
            this.subjecttabpage.Controls.Add(this.btnsubsave);
            this.subjecttabpage.Controls.Add(this.cmbsem);
            this.subjecttabpage.Controls.Add(this.cmbtutehours);
            this.subjecttabpage.Controls.Add(this.cmblabhours);
            this.subjecttabpage.Controls.Add(this.cmblechours);
            this.subjecttabpage.Controls.Add(this.cmboffyear);
            this.subjecttabpage.Controls.Add(this.txtSubName1);
            this.subjecttabpage.Controls.Add(this.txtYear1);
            this.subjecttabpage.Controls.Add(this.txtsem1);
            this.subjecttabpage.Controls.Add(this.txtTuteHours1);
            this.subjecttabpage.Controls.Add(this.txtsubcode);
            this.subjecttabpage.Controls.Add(this.txtsubname);
            this.subjecttabpage.Controls.Add(this.txtEvaHours);
            this.subjecttabpage.Controls.Add(this.txtlabHours1);
            this.subjecttabpage.Controls.Add(this.txtlecHours1);
            this.subjecttabpage.Controls.Add(this.txtSubjectcode1);
            this.subjecttabpage.Controls.Add(this.label2);
            this.subjecttabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttabpage.Location = new System.Drawing.Point(4, 27);
            this.subjecttabpage.Name = "subjecttabpage";
            this.subjecttabpage.Padding = new System.Windows.Forms.Padding(3);
            this.subjecttabpage.Size = new System.Drawing.Size(677, 457);
            this.subjecttabpage.TabIndex = 0;
            this.subjecttabpage.Text = "Add Subjects";
            this.subjecttabpage.UseVisualStyleBackColor = true;
            this.subjecttabpage.Click += new System.EventHandler(this.Subjecttabpage_Click);
            // 
            // cmbevalhours
            // 
            this.cmbevalhours.FormattingEnabled = true;
            this.cmbevalhours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbevalhours.Location = new System.Drawing.Point(533, 249);
            this.cmbevalhours.Name = "cmbevalhours";
            this.cmbevalhours.Size = new System.Drawing.Size(121, 21);
            this.cmbevalhours.TabIndex = 71;
            // 
            // btnsubclear1
            // 
            this.btnsubclear1.BackColor = System.Drawing.Color.Red;
            this.btnsubclear1.Location = new System.Drawing.Point(388, 331);
            this.btnsubclear1.Name = "btnsubclear1";
            this.btnsubclear1.Size = new System.Drawing.Size(101, 41);
            this.btnsubclear1.TabIndex = 70;
            this.btnsubclear1.Text = "Clear";
            this.btnsubclear1.UseVisualStyleBackColor = false;
            this.btnsubclear1.Click += new System.EventHandler(this.Btnsubclear1_Click);
            // 
            // btnsubsave
            // 
            this.btnsubsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsubsave.Location = new System.Drawing.Point(199, 331);
            this.btnsubsave.Name = "btnsubsave";
            this.btnsubsave.Size = new System.Drawing.Size(104, 41);
            this.btnsubsave.TabIndex = 69;
            this.btnsubsave.Text = "Save";
            this.btnsubsave.UseVisualStyleBackColor = false;
            this.btnsubsave.Click += new System.EventHandler(this.Btnsubsave_Click);
            // 
            // cmbsem
            // 
            this.cmbsem.FormattingEnabled = true;
            this.cmbsem.Items.AddRange(new object[] {
            "Semester1",
            "Semester2"});
            this.cmbsem.Location = new System.Drawing.Point(182, 249);
            this.cmbsem.Name = "cmbsem";
            this.cmbsem.Size = new System.Drawing.Size(121, 21);
            this.cmbsem.TabIndex = 68;
            // 
            // cmbtutehours
            // 
            this.cmbtutehours.FormattingEnabled = true;
            this.cmbtutehours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbtutehours.Location = new System.Drawing.Point(533, 141);
            this.cmbtutehours.Name = "cmbtutehours";
            this.cmbtutehours.Size = new System.Drawing.Size(121, 21);
            this.cmbtutehours.TabIndex = 67;
            // 
            // cmblabhours
            // 
            this.cmblabhours.FormattingEnabled = true;
            this.cmblabhours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmblabhours.Location = new System.Drawing.Point(533, 194);
            this.cmblabhours.Name = "cmblabhours";
            this.cmblabhours.Size = new System.Drawing.Size(121, 21);
            this.cmblabhours.TabIndex = 66;
            // 
            // cmblechours
            // 
            this.cmblechours.FormattingEnabled = true;
            this.cmblechours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmblechours.Location = new System.Drawing.Point(533, 88);
            this.cmblechours.Name = "cmblechours";
            this.cmblechours.Size = new System.Drawing.Size(121, 21);
            this.cmblechours.TabIndex = 65;
            // 
            // cmboffyear
            // 
            this.cmboffyear.FormattingEnabled = true;
            this.cmboffyear.Items.AddRange(new object[] {
            "Year1",
            "Year2",
            "Year3",
            "Year4"});
            this.cmboffyear.Location = new System.Drawing.Point(182, 193);
            this.cmboffyear.Name = "cmboffyear";
            this.cmboffyear.Size = new System.Drawing.Size(121, 21);
            this.cmboffyear.TabIndex = 64;
            this.cmboffyear.SelectedIndexChanged += new System.EventHandler(this.Cmboffyear_SelectedIndexChanged);
            // 
            // txtSubName1
            // 
            this.txtSubName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName1.Location = new System.Drawing.Point(24, 138);
            this.txtSubName1.Name = "txtSubName1";
            this.txtSubName1.ReadOnly = true;
            this.txtSubName1.Size = new System.Drawing.Size(122, 24);
            this.txtSubName1.TabIndex = 63;
            this.txtSubName1.Text = "Subject Name";
            // 
            // txtYear1
            // 
            this.txtYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear1.Location = new System.Drawing.Point(24, 193);
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.ReadOnly = true;
            this.txtYear1.Size = new System.Drawing.Size(122, 24);
            this.txtYear1.TabIndex = 62;
            this.txtYear1.Text = "Offered Year";
            // 
            // txtsem1
            // 
            this.txtsem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsem1.Location = new System.Drawing.Point(24, 249);
            this.txtsem1.Name = "txtsem1";
            this.txtsem1.ReadOnly = true;
            this.txtsem1.Size = new System.Drawing.Size(122, 24);
            this.txtsem1.TabIndex = 61;
            this.txtsem1.Text = "Offered Semester";
            // 
            // txtTuteHours1
            // 
            this.txtTuteHours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuteHours1.Location = new System.Drawing.Point(358, 138);
            this.txtTuteHours1.Name = "txtTuteHours1";
            this.txtTuteHours1.ReadOnly = true;
            this.txtTuteHours1.Size = new System.Drawing.Size(153, 24);
            this.txtTuteHours1.TabIndex = 60;
            this.txtTuteHours1.Text = "No of Tutorial Hours";
            // 
            // txtsubcode
            // 
            this.txtsubcode.Location = new System.Drawing.Point(182, 89);
            this.txtsubcode.Name = "txtsubcode";
            this.txtsubcode.Size = new System.Drawing.Size(122, 20);
            this.txtsubcode.TabIndex = 59;
            // 
            // txtsubname
            // 
            this.txtsubname.Location = new System.Drawing.Point(182, 138);
            this.txtsubname.Name = "txtsubname";
            this.txtsubname.Size = new System.Drawing.Size(122, 20);
            this.txtsubname.TabIndex = 58;
            this.txtsubname.TextChanged += new System.EventHandler(this.Txtsubname_TextChanged);
            // 
            // txtEvaHours
            // 
            this.txtEvaHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaHours.Location = new System.Drawing.Point(358, 249);
            this.txtEvaHours.Name = "txtEvaHours";
            this.txtEvaHours.ReadOnly = true;
            this.txtEvaHours.Size = new System.Drawing.Size(169, 24);
            this.txtEvaHours.TabIndex = 57;
            this.txtEvaHours.Text = "No of Evaluation Hours";
            // 
            // txtlabHours1
            // 
            this.txtlabHours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlabHours1.Location = new System.Drawing.Point(358, 194);
            this.txtlabHours1.Name = "txtlabHours1";
            this.txtlabHours1.ReadOnly = true;
            this.txtlabHours1.Size = new System.Drawing.Size(153, 24);
            this.txtlabHours1.TabIndex = 56;
            this.txtlabHours1.Text = "No of Lab Hours";
            // 
            // txtlecHours1
            // 
            this.txtlecHours1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlecHours1.Location = new System.Drawing.Point(358, 89);
            this.txtlecHours1.Name = "txtlecHours1";
            this.txtlecHours1.ReadOnly = true;
            this.txtlecHours1.Size = new System.Drawing.Size(153, 24);
            this.txtlecHours1.TabIndex = 55;
            this.txtlecHours1.Text = "No of Lecture Hours";
            // 
            // txtSubjectcode1
            // 
            this.txtSubjectcode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectcode1.Location = new System.Drawing.Point(24, 89);
            this.txtSubjectcode1.Name = "txtSubjectcode1";
            this.txtSubjectcode1.ReadOnly = true;
            this.txtSubjectcode1.Size = new System.Drawing.Size(122, 24);
            this.txtSubjectcode1.TabIndex = 54;
            this.txtSubjectcode1.Text = "Subject Code";
            this.txtSubjectcode1.TextChanged += new System.EventHandler(this.TxtSubjectcode1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Add Subject";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managesubjecttab
            // 
            this.managesubjecttab.Controls.Add(this.label3);
            this.managesubjecttab.Controls.Add(this.dgvSubjects);
            this.managesubjecttab.Controls.Add(this.btnSubDelete);
            this.managesubjecttab.Controls.Add(this.cmbEditEval);
            this.managesubjecttab.Controls.Add(this.btnSubjectMclear);
            this.managesubjecttab.Controls.Add(this.btnSubUpdate);
            this.managesubjecttab.Controls.Add(this.cmbEditsem);
            this.managesubjecttab.Controls.Add(this.cmbEditTute);
            this.managesubjecttab.Controls.Add(this.cmbEditLab);
            this.managesubjecttab.Controls.Add(this.cmbEditLectureHours);
            this.managesubjecttab.Controls.Add(this.cmbEdityear);
            this.managesubjecttab.Controls.Add(this.txtSubName2);
            this.managesubjecttab.Controls.Add(this.txtYear2);
            this.managesubjecttab.Controls.Add(this.txtsem2);
            this.managesubjecttab.Controls.Add(this.txtTuteHours2);
            this.managesubjecttab.Controls.Add(this.txtEditSubjectCode);
            this.managesubjecttab.Controls.Add(this.txtEditSubName);
            this.managesubjecttab.Controls.Add(this.txtEvalHours);
            this.managesubjecttab.Controls.Add(this.txtLabHours2);
            this.managesubjecttab.Controls.Add(this.txtlecHours2);
            this.managesubjecttab.Controls.Add(this.txtSubCode2);
            this.managesubjecttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managesubjecttab.Location = new System.Drawing.Point(4, 27);
            this.managesubjecttab.Name = "managesubjecttab";
            this.managesubjecttab.Padding = new System.Windows.Forms.Padding(3);
            this.managesubjecttab.Size = new System.Drawing.Size(677, 457);
            this.managesubjecttab.TabIndex = 1;
            this.managesubjecttab.Text = "Manage Subjects";
            this.managesubjecttab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Manage Subjects";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(16, 46);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.Size = new System.Drawing.Size(628, 154);
            this.dgvSubjects.TabIndex = 72;
            this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnSubDelete.Location = new System.Drawing.Point(245, 405);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.Size = new System.Drawing.Size(104, 41);
            this.btnSubDelete.TabIndex = 71;
            this.btnSubDelete.Text = "Delete";
            this.btnSubDelete.UseVisualStyleBackColor = false;
            this.btnSubDelete.Click += new System.EventHandler(this.BtnSubDelete_Click);
            // 
            // cmbEditEval
            // 
            this.cmbEditEval.FormattingEnabled = true;
            this.cmbEditEval.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEditEval.Location = new System.Drawing.Point(523, 363);
            this.cmbEditEval.Name = "cmbEditEval";
            this.cmbEditEval.Size = new System.Drawing.Size(121, 21);
            this.cmbEditEval.TabIndex = 70;
            // 
            // btnSubjectMclear
            // 
            this.btnSubjectMclear.BackColor = System.Drawing.Color.Red;
            this.btnSubjectMclear.Location = new System.Drawing.Point(382, 405);
            this.btnSubjectMclear.Name = "btnSubjectMclear";
            this.btnSubjectMclear.Size = new System.Drawing.Size(101, 41);
            this.btnSubjectMclear.TabIndex = 69;
            this.btnSubjectMclear.Text = "Clear";
            this.btnSubjectMclear.UseVisualStyleBackColor = false;
            this.btnSubjectMclear.Click += new System.EventHandler(this.BtnSubjectMclear_Click);
            // 
            // btnSubUpdate
            // 
            this.btnSubUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSubUpdate.Location = new System.Drawing.Point(115, 405);
            this.btnSubUpdate.Name = "btnSubUpdate";
            this.btnSubUpdate.Size = new System.Drawing.Size(104, 41);
            this.btnSubUpdate.TabIndex = 68;
            this.btnSubUpdate.Text = "Update";
            this.btnSubUpdate.UseVisualStyleBackColor = false;
            this.btnSubUpdate.UseWaitCursor = true;
            this.btnSubUpdate.Click += new System.EventHandler(this.BtnSubUpdate_Click);
            // 
            // cmbEditsem
            // 
            this.cmbEditsem.FormattingEnabled = true;
            this.cmbEditsem.Items.AddRange(new object[] {
            "Semester1",
            "Semester2"});
            this.cmbEditsem.Location = new System.Drawing.Point(181, 363);
            this.cmbEditsem.Name = "cmbEditsem";
            this.cmbEditsem.Size = new System.Drawing.Size(121, 21);
            this.cmbEditsem.TabIndex = 67;
            // 
            // cmbEditTute
            // 
            this.cmbEditTute.FormattingEnabled = true;
            this.cmbEditTute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbEditTute.Location = new System.Drawing.Point(523, 272);
            this.cmbEditTute.Name = "cmbEditTute";
            this.cmbEditTute.Size = new System.Drawing.Size(121, 21);
            this.cmbEditTute.TabIndex = 66;
            // 
            // cmbEditLab
            // 
            this.cmbEditLab.FormattingEnabled = true;
            this.cmbEditLab.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbEditLab.Location = new System.Drawing.Point(523, 317);
            this.cmbEditLab.Name = "cmbEditLab";
            this.cmbEditLab.Size = new System.Drawing.Size(121, 21);
            this.cmbEditLab.TabIndex = 65;
            // 
            // cmbEditLectureHours
            // 
            this.cmbEditLectureHours.FormattingEnabled = true;
            this.cmbEditLectureHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbEditLectureHours.Location = new System.Drawing.Point(523, 230);
            this.cmbEditLectureHours.Name = "cmbEditLectureHours";
            this.cmbEditLectureHours.Size = new System.Drawing.Size(121, 21);
            this.cmbEditLectureHours.TabIndex = 64;
            // 
            // cmbEdityear
            // 
            this.cmbEdityear.FormattingEnabled = true;
            this.cmbEdityear.Items.AddRange(new object[] {
            "Year1",
            "Year2",
            "Year3",
            "Year4"});
            this.cmbEdityear.Location = new System.Drawing.Point(183, 317);
            this.cmbEdityear.Name = "cmbEdityear";
            this.cmbEdityear.Size = new System.Drawing.Size(121, 21);
            this.cmbEdityear.TabIndex = 63;
            // 
            // txtSubName2
            // 
            this.txtSubName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName2.Location = new System.Drawing.Point(28, 272);
            this.txtSubName2.Name = "txtSubName2";
            this.txtSubName2.ReadOnly = true;
            this.txtSubName2.Size = new System.Drawing.Size(128, 24);
            this.txtSubName2.TabIndex = 62;
            this.txtSubName2.Text = "Subject Name";
            // 
            // txtYear2
            // 
            this.txtYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear2.Location = new System.Drawing.Point(28, 317);
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.ReadOnly = true;
            this.txtYear2.Size = new System.Drawing.Size(128, 24);
            this.txtYear2.TabIndex = 61;
            this.txtYear2.Text = "Offered Year";
            // 
            // txtsem2
            // 
            this.txtsem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsem2.Location = new System.Drawing.Point(28, 363);
            this.txtsem2.Name = "txtsem2";
            this.txtsem2.ReadOnly = true;
            this.txtsem2.Size = new System.Drawing.Size(128, 24);
            this.txtsem2.TabIndex = 60;
            this.txtsem2.Text = "Offered Semester";
            // 
            // txtTuteHours2
            // 
            this.txtTuteHours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuteHours2.Location = new System.Drawing.Point(346, 272);
            this.txtTuteHours2.Name = "txtTuteHours2";
            this.txtTuteHours2.ReadOnly = true;
            this.txtTuteHours2.Size = new System.Drawing.Size(150, 24);
            this.txtTuteHours2.TabIndex = 59;
            this.txtTuteHours2.Text = "No of Tutorial Hours";
            // 
            // txtEditSubjectCode
            // 
            this.txtEditSubjectCode.Location = new System.Drawing.Point(181, 227);
            this.txtEditSubjectCode.Name = "txtEditSubjectCode";
            this.txtEditSubjectCode.Size = new System.Drawing.Size(122, 20);
            this.txtEditSubjectCode.TabIndex = 58;
            // 
            // txtEditSubName
            // 
            this.txtEditSubName.Location = new System.Drawing.Point(182, 272);
            this.txtEditSubName.Name = "txtEditSubName";
            this.txtEditSubName.Size = new System.Drawing.Size(122, 20);
            this.txtEditSubName.TabIndex = 57;
            this.txtEditSubName.TextChanged += new System.EventHandler(this.TxtEditSubName_TextChanged);
            // 
            // txtEvalHours
            // 
            this.txtEvalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvalHours.Location = new System.Drawing.Point(346, 363);
            this.txtEvalHours.Name = "txtEvalHours";
            this.txtEvalHours.ReadOnly = true;
            this.txtEvalHours.Size = new System.Drawing.Size(159, 24);
            this.txtEvalHours.TabIndex = 56;
            this.txtEvalHours.Text = "No of Evaluation Hours";
            // 
            // txtLabHours2
            // 
            this.txtLabHours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabHours2.Location = new System.Drawing.Point(346, 318);
            this.txtLabHours2.Name = "txtLabHours2";
            this.txtLabHours2.ReadOnly = true;
            this.txtLabHours2.Size = new System.Drawing.Size(150, 24);
            this.txtLabHours2.TabIndex = 55;
            this.txtLabHours2.Text = "No of Lab Hours";
            // 
            // txtlecHours2
            // 
            this.txtlecHours2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlecHours2.Location = new System.Drawing.Point(346, 227);
            this.txtlecHours2.Name = "txtlecHours2";
            this.txtlecHours2.ReadOnly = true;
            this.txtlecHours2.Size = new System.Drawing.Size(150, 24);
            this.txtlecHours2.TabIndex = 54;
            this.txtlecHours2.Text = "No of Lecture Hours";
            // 
            // txtSubCode2
            // 
            this.txtSubCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCode2.Location = new System.Drawing.Point(28, 223);
            this.txtSubCode2.Name = "txtSubCode2";
            this.txtSubCode2.ReadOnly = true;
            this.txtSubCode2.Size = new System.Drawing.Size(128, 24);
            this.txtSubCode2.TabIndex = 53;
            this.txtSubCode2.Text = "Subject Code";
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subjects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panelSliderMenu.Controls.Add(this.button1);
            this.panelSliderMenu.Controls.Add(this.button5);
            this.panelSliderMenu.Controls.Add(this.dashboard);
            this.panelSliderMenu.Controls.Add(this.panellogo);
            this.panelSliderMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSliderMenu.Location = new System.Drawing.Point(15, 30);
            this.panelSliderMenu.Name = "panelSliderMenu";
            this.panelSliderMenu.Size = new System.Drawing.Size(182, 563);
            this.panelSliderMenu.TabIndex = 16;
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::TimeTable.Properties.Resources.book3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Subjects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::TimeTable.Properties.Resources.lecture2;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "Lecturers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // Subjects
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
            this.Name = "Subjects";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.panel1.ResumeLayout(false);
            this.subjecttab.ResumeLayout(false);
            this.subjecttabpage.ResumeLayout(false);
            this.subjecttabpage.PerformLayout();
            this.managesubjecttab.ResumeLayout(false);
            this.managesubjecttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSliderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl subjecttab;
        private System.Windows.Forms.TabPage subjecttabpage;
        private System.Windows.Forms.TabPage managesubjecttab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSliderMenu;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnSubDelete;
        private System.Windows.Forms.ComboBox cmbEditEval;
        private System.Windows.Forms.Button btnSubjectMclear;
        private System.Windows.Forms.Button btnSubUpdate;
        private System.Windows.Forms.ComboBox cmbEditsem;
        private System.Windows.Forms.ComboBox cmbEditTute;
        private System.Windows.Forms.ComboBox cmbEditLab;
        private System.Windows.Forms.ComboBox cmbEditLectureHours;
        private System.Windows.Forms.ComboBox cmbEdityear;
        private System.Windows.Forms.TextBox txtSubName2;
        private System.Windows.Forms.TextBox txtYear2;
        private System.Windows.Forms.TextBox txtsem2;
        private System.Windows.Forms.TextBox txtTuteHours2;
        private System.Windows.Forms.TextBox txtEditSubjectCode;
        private System.Windows.Forms.TextBox txtEditSubName;
        private System.Windows.Forms.TextBox txtEvalHours;
        private System.Windows.Forms.TextBox txtLabHours2;
        private System.Windows.Forms.TextBox txtlecHours2;
        private System.Windows.Forms.TextBox txtSubCode2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbevalhours;
        private System.Windows.Forms.Button btnsubclear1;
        private System.Windows.Forms.Button btnsubsave;
        private System.Windows.Forms.ComboBox cmbsem;
        private System.Windows.Forms.ComboBox cmbtutehours;
        private System.Windows.Forms.ComboBox cmblabhours;
        private System.Windows.Forms.ComboBox cmblechours;
        private System.Windows.Forms.ComboBox cmboffyear;
        private System.Windows.Forms.TextBox txtSubName1;
        private System.Windows.Forms.TextBox txtYear1;
        private System.Windows.Forms.TextBox txtsem1;
        private System.Windows.Forms.TextBox txtTuteHours1;
        private System.Windows.Forms.TextBox txtsubcode;
        private System.Windows.Forms.TextBox txtsubname;
        private System.Windows.Forms.TextBox txtEvaHours;
        private System.Windows.Forms.TextBox txtlabHours1;
        private System.Windows.Forms.TextBox txtlecHours1;
        private System.Windows.Forms.TextBox txtSubjectcode1;
    }
}