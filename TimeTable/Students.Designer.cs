namespace TimeTable
{
    partial class Students
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
            this.Studenttab = new System.Windows.Forms.TabControl();
            this.addstudenttab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStu = new System.Windows.Forms.Button();
            this.ClearStudent = new System.Windows.Forms.Button();
            this.GenerateGIDBtn = new System.Windows.Forms.Button();
            this.GenerateSubGIDBtn = new System.Windows.Forms.Button();
            this.AddstuSubGID = new MetroFramework.Controls.MetroTextBox();
            this.Addstusubgrp = new MetroFramework.Controls.MetroTextBox();
            this.AddstuMGID = new MetroFramework.Controls.MetroTextBox();
            this.AddstuMgrp = new MetroFramework.Controls.MetroTextBox();
            this.Addstupro = new MetroFramework.Controls.MetroComboBox();
            this.Addstusem = new MetroFramework.Controls.MetroComboBox();
            this.Addstuyr = new MetroFramework.Controls.MetroComboBox();
            this.AddstuSubID = new System.Windows.Forms.TextBox();
            this.AddstuSub = new System.Windows.Forms.TextBox();
            this.AddstuMGI = new System.Windows.Forms.TextBox();
            this.AddstuMG = new System.Windows.Forms.TextBox();
            this.Addstupr = new System.Windows.Forms.TextBox();
            this.Addstuse = new System.Windows.Forms.TextBox();
            this.AddstuYear = new System.Windows.Forms.TextBox();
            this.managestu = new System.Windows.Forms.TabPage();
            this.gensub = new System.Windows.Forms.Button();
            this.genmain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentdata = new System.Windows.Forms.DataGridView();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.ClearStudentMan = new System.Windows.Forms.Button();
            this.ManagestudentMGID = new MetroFramework.Controls.MetroTextBox();
            this.ManagestudentMainG = new MetroFramework.Controls.MetroTextBox();
            this.Managestudentpr = new MetroFramework.Controls.MetroComboBox();
            this.ManagestuMGID = new System.Windows.Forms.TextBox();
            this.ManagestuMG = new System.Windows.Forms.TextBox();
            this.Managestupr = new System.Windows.Forms.TextBox();
            this.ManagestudentSGID = new MetroFramework.Controls.MetroTextBox();
            this.ManagestudentSubG = new MetroFramework.Controls.MetroTextBox();
            this.ManagestudentSem = new MetroFramework.Controls.MetroComboBox();
            this.ManagestudentYr = new MetroFramework.Controls.MetroComboBox();
            this.ManagestuSID = new System.Windows.Forms.TextBox();
            this.ManagestuSub = new System.Windows.Forms.TextBox();
            this.Managestusem = new System.Windows.Forms.TextBox();
            this.Managestuyr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSliderMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.working_days = new System.Windows.Forms.Button();
            this.locations = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.lecturers = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Studenttab.SuspendLayout();
            this.addstudenttab.SuspendLayout();
            this.managestu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSliderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Studenttab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(197, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 563);
            this.panel1.TabIndex = 17;
            // 
            // Studenttab
            // 
            this.Studenttab.Controls.Add(this.addstudenttab);
            this.Studenttab.Controls.Add(this.managestu);
            this.Studenttab.Location = new System.Drawing.Point(32, 80);
            this.Studenttab.Margin = new System.Windows.Forms.Padding(0);
            this.Studenttab.Name = "Studenttab";
            this.Studenttab.Padding = new System.Drawing.Point(10, 0);
            this.Studenttab.SelectedIndex = 0;
            this.Studenttab.Size = new System.Drawing.Size(680, 474);
            this.Studenttab.TabIndex = 1;
            // 
            // addstudenttab
            // 
            this.addstudenttab.BackColor = System.Drawing.Color.Gainsboro;
            this.addstudenttab.Controls.Add(this.label3);
            this.addstudenttab.Controls.Add(this.AddStu);
            this.addstudenttab.Controls.Add(this.ClearStudent);
            this.addstudenttab.Controls.Add(this.GenerateGIDBtn);
            this.addstudenttab.Controls.Add(this.GenerateSubGIDBtn);
            this.addstudenttab.Controls.Add(this.AddstuSubGID);
            this.addstudenttab.Controls.Add(this.Addstusubgrp);
            this.addstudenttab.Controls.Add(this.AddstuMGID);
            this.addstudenttab.Controls.Add(this.AddstuMgrp);
            this.addstudenttab.Controls.Add(this.Addstupro);
            this.addstudenttab.Controls.Add(this.Addstusem);
            this.addstudenttab.Controls.Add(this.Addstuyr);
            this.addstudenttab.Controls.Add(this.AddstuSubID);
            this.addstudenttab.Controls.Add(this.AddstuSub);
            this.addstudenttab.Controls.Add(this.AddstuMGI);
            this.addstudenttab.Controls.Add(this.AddstuMG);
            this.addstudenttab.Controls.Add(this.Addstupr);
            this.addstudenttab.Controls.Add(this.Addstuse);
            this.addstudenttab.Controls.Add(this.AddstuYear);
            this.addstudenttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudenttab.Location = new System.Drawing.Point(4, 25);
            this.addstudenttab.Margin = new System.Windows.Forms.Padding(0);
            this.addstudenttab.Name = "addstudenttab";
            this.addstudenttab.Size = new System.Drawing.Size(672, 445);
            this.addstudenttab.TabIndex = 0;
            this.addstudenttab.Text = "Add Student";
            this.addstudenttab.UseVisualStyleBackColor = true;
            this.addstudenttab.Click += new System.EventHandler(this.Addstudenttab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(278, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 118;
            this.label3.Text = "Add Student\r\n";
            // 
            // AddStu
            // 
            this.AddStu.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddStu.Location = new System.Drawing.Point(342, 366);
            this.AddStu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddStu.Name = "AddStu";
            this.AddStu.Size = new System.Drawing.Size(111, 32);
            this.AddStu.TabIndex = 117;
            this.AddStu.Text = "ADD";
            this.AddStu.UseVisualStyleBackColor = false;
            this.AddStu.Click += new System.EventHandler(this.AddStu_Click);
            // 
            // ClearStudent
            // 
            this.ClearStudent.BackColor = System.Drawing.Color.Yellow;
            this.ClearStudent.Location = new System.Drawing.Point(200, 366);
            this.ClearStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearStudent.Name = "ClearStudent";
            this.ClearStudent.Size = new System.Drawing.Size(111, 32);
            this.ClearStudent.TabIndex = 116;
            this.ClearStudent.Text = "Clear";
            this.ClearStudent.UseVisualStyleBackColor = false;
            this.ClearStudent.Click += new System.EventHandler(this.ClearStudent_Click);
            // 
            // GenerateGIDBtn
            // 
            this.GenerateGIDBtn.BackColor = System.Drawing.Color.Red;
            this.GenerateGIDBtn.Location = new System.Drawing.Point(532, 330);
            this.GenerateGIDBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateGIDBtn.Name = "GenerateGIDBtn";
            this.GenerateGIDBtn.Size = new System.Drawing.Size(80, 25);
            this.GenerateGIDBtn.TabIndex = 115;
            this.GenerateGIDBtn.Text = "Generate";
            this.GenerateGIDBtn.UseVisualStyleBackColor = false;
            this.GenerateGIDBtn.Click += new System.EventHandler(this.GenerateGIDBtn_Click);
            // 
            // GenerateSubGIDBtn
            // 
            this.GenerateSubGIDBtn.BackColor = System.Drawing.Color.Red;
            this.GenerateSubGIDBtn.Location = new System.Drawing.Point(532, 250);
            this.GenerateSubGIDBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateSubGIDBtn.Name = "GenerateSubGIDBtn";
            this.GenerateSubGIDBtn.Size = new System.Drawing.Size(80, 25);
            this.GenerateSubGIDBtn.TabIndex = 114;
            this.GenerateSubGIDBtn.Text = "Generate";
            this.GenerateSubGIDBtn.UseVisualStyleBackColor = false;
            this.GenerateSubGIDBtn.Click += new System.EventHandler(this.GenerateSubGIDBtn_Click);
            // 
            // AddstuSubGID
            // 
            // 
            // 
            // 
            this.AddstuSubGID.CustomButton.Image = null;
            this.AddstuSubGID.CustomButton.Location = new System.Drawing.Point(118, 2);
            this.AddstuSubGID.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuSubGID.CustomButton.Name = "";
            this.AddstuSubGID.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.AddstuSubGID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddstuSubGID.CustomButton.TabIndex = 1;
            this.AddstuSubGID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddstuSubGID.CustomButton.UseSelectable = true;
            this.AddstuSubGID.CustomButton.Visible = false;
            this.AddstuSubGID.Lines = new string[0];
            this.AddstuSubGID.Location = new System.Drawing.Point(334, 330);
            this.AddstuSubGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuSubGID.MaxLength = 32767;
            this.AddstuSubGID.Name = "AddstuSubGID";
            this.AddstuSubGID.PasswordChar = '\0';
            this.AddstuSubGID.ReadOnly = true;
            this.AddstuSubGID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddstuSubGID.SelectedText = "";
            this.AddstuSubGID.SelectionLength = 0;
            this.AddstuSubGID.SelectionStart = 0;
            this.AddstuSubGID.ShortcutsEnabled = true;
            this.AddstuSubGID.Size = new System.Drawing.Size(180, 24);
            this.AddstuSubGID.TabIndex = 113;
            this.AddstuSubGID.UseSelectable = true;
            this.AddstuSubGID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddstuSubGID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Addstusubgrp
            // 
            // 
            // 
            // 
            this.Addstusubgrp.CustomButton.Image = null;
            this.Addstusubgrp.CustomButton.Location = new System.Drawing.Point(118, 2);
            this.Addstusubgrp.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstusubgrp.CustomButton.Name = "";
            this.Addstusubgrp.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.Addstusubgrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Addstusubgrp.CustomButton.TabIndex = 1;
            this.Addstusubgrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Addstusubgrp.CustomButton.UseSelectable = true;
            this.Addstusubgrp.CustomButton.Visible = false;
            this.Addstusubgrp.Lines = new string[0];
            this.Addstusubgrp.Location = new System.Drawing.Point(334, 288);
            this.Addstusubgrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstusubgrp.MaxLength = 32767;
            this.Addstusubgrp.Name = "Addstusubgrp";
            this.Addstusubgrp.PasswordChar = '\0';
            this.Addstusubgrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Addstusubgrp.SelectedText = "";
            this.Addstusubgrp.SelectionLength = 0;
            this.Addstusubgrp.SelectionStart = 0;
            this.Addstusubgrp.ShortcutsEnabled = true;
            this.Addstusubgrp.Size = new System.Drawing.Size(180, 24);
            this.Addstusubgrp.TabIndex = 112;
            this.Addstusubgrp.UseSelectable = true;
            this.Addstusubgrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Addstusubgrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddstuMGID
            // 
            // 
            // 
            // 
            this.AddstuMGID.CustomButton.Image = null;
            this.AddstuMGID.CustomButton.Location = new System.Drawing.Point(118, 2);
            this.AddstuMGID.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMGID.CustomButton.Name = "";
            this.AddstuMGID.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.AddstuMGID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddstuMGID.CustomButton.TabIndex = 1;
            this.AddstuMGID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddstuMGID.CustomButton.UseSelectable = true;
            this.AddstuMGID.CustomButton.Visible = false;
            this.AddstuMGID.Lines = new string[0];
            this.AddstuMGID.Location = new System.Drawing.Point(334, 245);
            this.AddstuMGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMGID.MaxLength = 32767;
            this.AddstuMGID.Name = "AddstuMGID";
            this.AddstuMGID.PasswordChar = '\0';
            this.AddstuMGID.ReadOnly = true;
            this.AddstuMGID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddstuMGID.SelectedText = "";
            this.AddstuMGID.SelectionLength = 0;
            this.AddstuMGID.SelectionStart = 0;
            this.AddstuMGID.ShortcutsEnabled = true;
            this.AddstuMGID.Size = new System.Drawing.Size(180, 24);
            this.AddstuMGID.TabIndex = 111;
            this.AddstuMGID.UseSelectable = true;
            this.AddstuMGID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddstuMGID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddstuMgrp
            // 
            // 
            // 
            // 
            this.AddstuMgrp.CustomButton.Image = null;
            this.AddstuMgrp.CustomButton.Location = new System.Drawing.Point(118, 2);
            this.AddstuMgrp.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMgrp.CustomButton.Name = "";
            this.AddstuMgrp.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.AddstuMgrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddstuMgrp.CustomButton.TabIndex = 1;
            this.AddstuMgrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddstuMgrp.CustomButton.UseSelectable = true;
            this.AddstuMgrp.CustomButton.Visible = false;
            this.AddstuMgrp.Lines = new string[0];
            this.AddstuMgrp.Location = new System.Drawing.Point(334, 202);
            this.AddstuMgrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMgrp.MaxLength = 32767;
            this.AddstuMgrp.Name = "AddstuMgrp";
            this.AddstuMgrp.PasswordChar = '\0';
            this.AddstuMgrp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddstuMgrp.SelectedText = "";
            this.AddstuMgrp.SelectionLength = 0;
            this.AddstuMgrp.SelectionStart = 0;
            this.AddstuMgrp.ShortcutsEnabled = true;
            this.AddstuMgrp.Size = new System.Drawing.Size(180, 24);
            this.AddstuMgrp.TabIndex = 110;
            this.AddstuMgrp.UseSelectable = true;
            this.AddstuMgrp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddstuMgrp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Addstupro
            // 
            this.Addstupro.DropDownHeight = 150;
            this.Addstupro.FormattingEnabled = true;
            this.Addstupro.IntegralHeight = false;
            this.Addstupro.ItemHeight = 23;
            this.Addstupro.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "CS",
            "CSNE",
            "ISE"});
            this.Addstupro.Location = new System.Drawing.Point(334, 159);
            this.Addstupro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstupro.MaxDropDownItems = 100;
            this.Addstupro.Name = "Addstupro";
            this.Addstupro.Size = new System.Drawing.Size(181, 29);
            this.Addstupro.TabIndex = 109;
            this.Addstupro.UseSelectable = true;
            // 
            // Addstusem
            // 
            this.Addstusem.DropDownHeight = 150;
            this.Addstusem.FormattingEnabled = true;
            this.Addstusem.IntegralHeight = false;
            this.Addstusem.ItemHeight = 23;
            this.Addstusem.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.Addstusem.Location = new System.Drawing.Point(334, 112);
            this.Addstusem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstusem.MaxDropDownItems = 100;
            this.Addstusem.Name = "Addstusem";
            this.Addstusem.Size = new System.Drawing.Size(181, 29);
            this.Addstusem.TabIndex = 108;
            this.Addstusem.UseSelectable = true;
            // 
            // Addstuyr
            // 
            this.Addstuyr.DropDownHeight = 150;
            this.Addstuyr.FormattingEnabled = true;
            this.Addstuyr.IntegralHeight = false;
            this.Addstuyr.ItemHeight = 23;
            this.Addstuyr.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.Addstuyr.Location = new System.Drawing.Point(334, 71);
            this.Addstuyr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstuyr.MaxDropDownItems = 100;
            this.Addstuyr.Name = "Addstuyr";
            this.Addstuyr.Size = new System.Drawing.Size(181, 29);
            this.Addstuyr.TabIndex = 107;
            this.Addstuyr.UseSelectable = true;
            // 
            // AddstuSubID
            // 
            this.AddstuSubID.Location = new System.Drawing.Point(98, 324);
            this.AddstuSubID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuSubID.Multiline = true;
            this.AddstuSubID.Name = "AddstuSubID";
            this.AddstuSubID.ReadOnly = true;
            this.AddstuSubID.Size = new System.Drawing.Size(179, 31);
            this.AddstuSubID.TabIndex = 106;
            this.AddstuSubID.Text = "Sub Group ID";
            // 
            // AddstuSub
            // 
            this.AddstuSub.Location = new System.Drawing.Point(98, 282);
            this.AddstuSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuSub.Multiline = true;
            this.AddstuSub.Name = "AddstuSub";
            this.AddstuSub.ReadOnly = true;
            this.AddstuSub.Size = new System.Drawing.Size(179, 31);
            this.AddstuSub.TabIndex = 105;
            this.AddstuSub.Text = "Sub Group";
            // 
            // AddstuMGI
            // 
            this.AddstuMGI.Location = new System.Drawing.Point(98, 240);
            this.AddstuMGI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMGI.Multiline = true;
            this.AddstuMGI.Name = "AddstuMGI";
            this.AddstuMGI.ReadOnly = true;
            this.AddstuMGI.Size = new System.Drawing.Size(179, 31);
            this.AddstuMGI.TabIndex = 104;
            this.AddstuMGI.Text = "Main Group ID";
            // 
            // AddstuMG
            // 
            this.AddstuMG.Location = new System.Drawing.Point(98, 196);
            this.AddstuMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuMG.Multiline = true;
            this.AddstuMG.Name = "AddstuMG";
            this.AddstuMG.ReadOnly = true;
            this.AddstuMG.Size = new System.Drawing.Size(179, 31);
            this.AddstuMG.TabIndex = 103;
            this.AddstuMG.Text = "Main Group";
            // 
            // Addstupr
            // 
            this.Addstupr.Location = new System.Drawing.Point(98, 151);
            this.Addstupr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstupr.Multiline = true;
            this.Addstupr.Name = "Addstupr";
            this.Addstupr.ReadOnly = true;
            this.Addstupr.Size = new System.Drawing.Size(179, 33);
            this.Addstupr.TabIndex = 102;
            this.Addstupr.Text = "program";
            // 
            // Addstuse
            // 
            this.Addstuse.Location = new System.Drawing.Point(98, 106);
            this.Addstuse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addstuse.Multiline = true;
            this.Addstuse.Name = "Addstuse";
            this.Addstuse.ReadOnly = true;
            this.Addstuse.Size = new System.Drawing.Size(179, 31);
            this.Addstuse.TabIndex = 101;
            this.Addstuse.Text = "semester";
            // 
            // AddstuYear
            // 
            this.AddstuYear.Location = new System.Drawing.Point(98, 65);
            this.AddstuYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddstuYear.Multiline = true;
            this.AddstuYear.Name = "AddstuYear";
            this.AddstuYear.ReadOnly = true;
            this.AddstuYear.Size = new System.Drawing.Size(179, 31);
            this.AddstuYear.TabIndex = 100;
            this.AddstuYear.Text = "Year";
            // 
            // managestu
            // 
            this.managestu.BackColor = System.Drawing.Color.Gainsboro;
            this.managestu.Controls.Add(this.gensub);
            this.managestu.Controls.Add(this.genmain);
            this.managestu.Controls.Add(this.label2);
            this.managestu.Controls.Add(this.studentdata);
            this.managestu.Controls.Add(this.DeleteStudent);
            this.managestu.Controls.Add(this.UpdateStudent);
            this.managestu.Controls.Add(this.ClearStudentMan);
            this.managestu.Controls.Add(this.ManagestudentMGID);
            this.managestu.Controls.Add(this.ManagestudentMainG);
            this.managestu.Controls.Add(this.Managestudentpr);
            this.managestu.Controls.Add(this.ManagestuMGID);
            this.managestu.Controls.Add(this.ManagestuMG);
            this.managestu.Controls.Add(this.Managestupr);
            this.managestu.Controls.Add(this.ManagestudentSGID);
            this.managestu.Controls.Add(this.ManagestudentSubG);
            this.managestu.Controls.Add(this.ManagestudentSem);
            this.managestu.Controls.Add(this.ManagestudentYr);
            this.managestu.Controls.Add(this.ManagestuSID);
            this.managestu.Controls.Add(this.ManagestuSub);
            this.managestu.Controls.Add(this.Managestusem);
            this.managestu.Controls.Add(this.Managestuyr);
            this.managestu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managestu.Location = new System.Drawing.Point(4, 25);
            this.managestu.Margin = new System.Windows.Forms.Padding(0);
            this.managestu.Name = "managestu";
            this.managestu.Size = new System.Drawing.Size(672, 445);
            this.managestu.TabIndex = 1;
            this.managestu.Text = "Edit/Delete Student";
            this.managestu.UseVisualStyleBackColor = true;
            // 
            // gensub
            // 
            this.gensub.BackColor = System.Drawing.Color.DarkRed;
            this.gensub.Location = new System.Drawing.Point(266, 382);
            this.gensub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gensub.Name = "gensub";
            this.gensub.Size = new System.Drawing.Size(23, 24);
            this.gensub.TabIndex = 120;
            this.gensub.Text = "G";
            this.gensub.UseVisualStyleBackColor = false;
            this.gensub.Click += new System.EventHandler(this.gensub_Click);
            // 
            // genmain
            // 
            this.genmain.BackColor = System.Drawing.Color.DarkRed;
            this.genmain.Location = new System.Drawing.Point(532, 351);
            this.genmain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genmain.Name = "genmain";
            this.genmain.Size = new System.Drawing.Size(23, 24);
            this.genmain.TabIndex = 119;
            this.genmain.Text = "G";
            this.genmain.UseVisualStyleBackColor = false;
            this.genmain.Click += new System.EventHandler(this.genmain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(256, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 118;
            this.label2.Text = "Manage Student\r\n";
            // 
            // studentdata
            // 
            this.studentdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdata.Location = new System.Drawing.Point(26, 67);
            this.studentdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentdata.Name = "studentdata";
            this.studentdata.RowHeadersWidth = 51;
            this.studentdata.RowTemplate.Height = 24;
            this.studentdata.Size = new System.Drawing.Size(628, 174);
            this.studentdata.TabIndex = 114;
            this.studentdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentdata_CellClick);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.Red;
            this.DeleteStudent.Location = new System.Drawing.Point(560, 363);
            this.DeleteStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(84, 32);
            this.DeleteStudent.TabIndex = 117;
            this.DeleteStudent.Text = "Delete";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.BackColor = System.Drawing.Color.MediumOrchid;
            this.UpdateStudent.Location = new System.Drawing.Point(560, 318);
            this.UpdateStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(84, 32);
            this.UpdateStudent.TabIndex = 116;
            this.UpdateStudent.Text = "Update";
            this.UpdateStudent.UseVisualStyleBackColor = false;
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // ClearStudentMan
            // 
            this.ClearStudentMan.BackColor = System.Drawing.Color.Yellow;
            this.ClearStudentMan.Location = new System.Drawing.Point(560, 274);
            this.ClearStudentMan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearStudentMan.Name = "ClearStudentMan";
            this.ClearStudentMan.Size = new System.Drawing.Size(84, 32);
            this.ClearStudentMan.TabIndex = 115;
            this.ClearStudentMan.Text = "Clear";
            this.ClearStudentMan.UseVisualStyleBackColor = false;
            this.ClearStudentMan.Click += new System.EventHandler(this.ClearStudentMan_Click);
            // 
            // ManagestudentMGID
            // 
            // 
            // 
            // 
            this.ManagestudentMGID.CustomButton.Image = null;
            this.ManagestudentMGID.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.ManagestudentMGID.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentMGID.CustomButton.Name = "";
            this.ManagestudentMGID.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.ManagestudentMGID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManagestudentMGID.CustomButton.TabIndex = 1;
            this.ManagestudentMGID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManagestudentMGID.CustomButton.UseSelectable = true;
            this.ManagestudentMGID.CustomButton.Visible = false;
            this.ManagestudentMGID.Lines = new string[0];
            this.ManagestudentMGID.Location = new System.Drawing.Point(413, 351);
            this.ManagestudentMGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentMGID.MaxLength = 32767;
            this.ManagestudentMGID.Name = "ManagestudentMGID";
            this.ManagestudentMGID.PasswordChar = '\0';
            this.ManagestudentMGID.ReadOnly = true;
            this.ManagestudentMGID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManagestudentMGID.SelectedText = "";
            this.ManagestudentMGID.SelectionLength = 0;
            this.ManagestudentMGID.SelectionStart = 0;
            this.ManagestudentMGID.ShortcutsEnabled = true;
            this.ManagestudentMGID.Size = new System.Drawing.Size(114, 24);
            this.ManagestudentMGID.TabIndex = 113;
            this.ManagestudentMGID.UseSelectable = true;
            this.ManagestudentMGID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManagestudentMGID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManagestudentMainG
            // 
            // 
            // 
            // 
            this.ManagestudentMainG.CustomButton.Image = null;
            this.ManagestudentMainG.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.ManagestudentMainG.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentMainG.CustomButton.Name = "";
            this.ManagestudentMainG.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.ManagestudentMainG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManagestudentMainG.CustomButton.TabIndex = 1;
            this.ManagestudentMainG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManagestudentMainG.CustomButton.UseSelectable = true;
            this.ManagestudentMainG.CustomButton.Visible = false;
            this.ManagestudentMainG.Lines = new string[0];
            this.ManagestudentMainG.Location = new System.Drawing.Point(413, 309);
            this.ManagestudentMainG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentMainG.MaxLength = 32767;
            this.ManagestudentMainG.Name = "ManagestudentMainG";
            this.ManagestudentMainG.PasswordChar = '\0';
            this.ManagestudentMainG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManagestudentMainG.SelectedText = "";
            this.ManagestudentMainG.SelectionLength = 0;
            this.ManagestudentMainG.SelectionStart = 0;
            this.ManagestudentMainG.ShortcutsEnabled = true;
            this.ManagestudentMainG.Size = new System.Drawing.Size(114, 24);
            this.ManagestudentMainG.TabIndex = 112;
            this.ManagestudentMainG.UseSelectable = true;
            this.ManagestudentMainG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManagestudentMainG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Managestudentpr
            // 
            this.Managestudentpr.DropDownHeight = 150;
            this.Managestudentpr.FormattingEnabled = true;
            this.Managestudentpr.IntegralHeight = false;
            this.Managestudentpr.ItemHeight = 24;
            this.Managestudentpr.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "CS",
            "CSNE",
            "ISE"});
            this.Managestudentpr.Location = new System.Drawing.Point(413, 262);
            this.Managestudentpr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Managestudentpr.MaxDropDownItems = 100;
            this.Managestudentpr.Name = "Managestudentpr";
            this.Managestudentpr.Size = new System.Drawing.Size(115, 30);
            this.Managestudentpr.TabIndex = 111;
            this.Managestudentpr.UseSelectable = true;
            // 
            // ManagestuMGID
            // 
            this.ManagestuMGID.Location = new System.Drawing.Point(283, 341);
            this.ManagestuMGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestuMGID.Multiline = true;
            this.ManagestuMGID.Name = "ManagestuMGID";
            this.ManagestuMGID.ReadOnly = true;
            this.ManagestuMGID.Size = new System.Drawing.Size(120, 31);
            this.ManagestuMGID.TabIndex = 110;
            this.ManagestuMGID.Text = "Group ID";
            this.ManagestuMGID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManagestuMG
            // 
            this.ManagestuMG.Location = new System.Drawing.Point(283, 303);
            this.ManagestuMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestuMG.Multiline = true;
            this.ManagestuMG.Name = "ManagestuMG";
            this.ManagestuMG.ReadOnly = true;
            this.ManagestuMG.Size = new System.Drawing.Size(120, 31);
            this.ManagestuMG.TabIndex = 109;
            this.ManagestuMG.Text = "Main Group";
            this.ManagestuMG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Managestupr
            // 
            this.Managestupr.Location = new System.Drawing.Point(283, 257);
            this.Managestupr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Managestupr.Multiline = true;
            this.Managestupr.Name = "Managestupr";
            this.Managestupr.ReadOnly = true;
            this.Managestupr.Size = new System.Drawing.Size(120, 31);
            this.Managestupr.TabIndex = 108;
            this.Managestupr.Text = "Program";
            this.Managestupr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManagestudentSGID
            // 
            // 
            // 
            // 
            this.ManagestudentSGID.CustomButton.Image = null;
            this.ManagestudentSGID.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.ManagestudentSGID.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentSGID.CustomButton.Name = "";
            this.ManagestudentSGID.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.ManagestudentSGID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManagestudentSGID.CustomButton.TabIndex = 1;
            this.ManagestudentSGID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManagestudentSGID.CustomButton.UseSelectable = true;
            this.ManagestudentSGID.CustomButton.Visible = false;
            this.ManagestudentSGID.Lines = new string[0];
            this.ManagestudentSGID.Location = new System.Drawing.Point(148, 381);
            this.ManagestudentSGID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentSGID.MaxLength = 32767;
            this.ManagestudentSGID.Name = "ManagestudentSGID";
            this.ManagestudentSGID.PasswordChar = '\0';
            this.ManagestudentSGID.ReadOnly = true;
            this.ManagestudentSGID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManagestudentSGID.SelectedText = "";
            this.ManagestudentSGID.SelectionLength = 0;
            this.ManagestudentSGID.SelectionStart = 0;
            this.ManagestudentSGID.ShortcutsEnabled = true;
            this.ManagestudentSGID.Size = new System.Drawing.Size(114, 24);
            this.ManagestudentSGID.TabIndex = 107;
            this.ManagestudentSGID.UseSelectable = true;
            this.ManagestudentSGID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManagestudentSGID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManagestudentSubG
            // 
            // 
            // 
            // 
            this.ManagestudentSubG.CustomButton.Image = null;
            this.ManagestudentSubG.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.ManagestudentSubG.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentSubG.CustomButton.Name = "";
            this.ManagestudentSubG.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.ManagestudentSubG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManagestudentSubG.CustomButton.TabIndex = 1;
            this.ManagestudentSubG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManagestudentSubG.CustomButton.UseSelectable = true;
            this.ManagestudentSubG.CustomButton.Visible = false;
            this.ManagestudentSubG.Lines = new string[0];
            this.ManagestudentSubG.Location = new System.Drawing.Point(148, 341);
            this.ManagestudentSubG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentSubG.MaxLength = 32767;
            this.ManagestudentSubG.Name = "ManagestudentSubG";
            this.ManagestudentSubG.PasswordChar = '\0';
            this.ManagestudentSubG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManagestudentSubG.SelectedText = "";
            this.ManagestudentSubG.SelectionLength = 0;
            this.ManagestudentSubG.SelectionStart = 0;
            this.ManagestudentSubG.ShortcutsEnabled = true;
            this.ManagestudentSubG.Size = new System.Drawing.Size(114, 24);
            this.ManagestudentSubG.TabIndex = 106;
            this.ManagestudentSubG.UseSelectable = true;
            this.ManagestudentSubG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManagestudentSubG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManagestudentSem
            // 
            this.ManagestudentSem.DropDownHeight = 150;
            this.ManagestudentSem.FormattingEnabled = true;
            this.ManagestudentSem.IntegralHeight = false;
            this.ManagestudentSem.ItemHeight = 24;
            this.ManagestudentSem.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.ManagestudentSem.Location = new System.Drawing.Point(148, 303);
            this.ManagestudentSem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentSem.MaxDropDownItems = 100;
            this.ManagestudentSem.Name = "ManagestudentSem";
            this.ManagestudentSem.Size = new System.Drawing.Size(115, 30);
            this.ManagestudentSem.TabIndex = 105;
            this.ManagestudentSem.UseSelectable = true;
            // 
            // ManagestudentYr
            // 
            this.ManagestudentYr.DropDownHeight = 150;
            this.ManagestudentYr.FormattingEnabled = true;
            this.ManagestudentYr.IntegralHeight = false;
            this.ManagestudentYr.ItemHeight = 24;
            this.ManagestudentYr.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.ManagestudentYr.Location = new System.Drawing.Point(148, 262);
            this.ManagestudentYr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestudentYr.MaxDropDownItems = 100;
            this.ManagestudentYr.Name = "ManagestudentYr";
            this.ManagestudentYr.Size = new System.Drawing.Size(115, 30);
            this.ManagestudentYr.TabIndex = 104;
            this.ManagestudentYr.UseSelectable = true;
            // 
            // ManagestuSID
            // 
            this.ManagestuSID.Location = new System.Drawing.Point(16, 375);
            this.ManagestuSID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestuSID.Multiline = true;
            this.ManagestuSID.Name = "ManagestuSID";
            this.ManagestuSID.ReadOnly = true;
            this.ManagestuSID.Size = new System.Drawing.Size(120, 31);
            this.ManagestuSID.TabIndex = 103;
            this.ManagestuSID.Text = "Sub Group ID";
            this.ManagestuSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManagestuSub
            // 
            this.ManagestuSub.Location = new System.Drawing.Point(16, 336);
            this.ManagestuSub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagestuSub.Multiline = true;
            this.ManagestuSub.Name = "ManagestuSub";
            this.ManagestuSub.ReadOnly = true;
            this.ManagestuSub.Size = new System.Drawing.Size(120, 31);
            this.ManagestuSub.TabIndex = 102;
            this.ManagestuSub.Text = "Sub Group";
            this.ManagestuSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Managestusem
            // 
            this.Managestusem.Location = new System.Drawing.Point(16, 297);
            this.Managestusem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Managestusem.Multiline = true;
            this.Managestusem.Name = "Managestusem";
            this.Managestusem.ReadOnly = true;
            this.Managestusem.Size = new System.Drawing.Size(120, 31);
            this.Managestusem.TabIndex = 101;
            this.Managestusem.Text = "Semester";
            this.Managestusem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Managestuyr
            // 
            this.Managestuyr.Location = new System.Drawing.Point(16, 257);
            this.Managestuyr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Managestuyr.Multiline = true;
            this.Managestuyr.Name = "Managestuyr";
            this.Managestuyr.ReadOnly = true;
            this.Managestuyr.Size = new System.Drawing.Size(120, 31);
            this.Managestuyr.TabIndex = 100;
            this.Managestuyr.Text = "Year";
            this.Managestuyr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // panelSliderMenu
            // 
            this.panelSliderMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSliderMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSliderMenu.Controls.Add(this.button1);
            this.panelSliderMenu.Controls.Add(this.rooms);
            this.panelSliderMenu.Controls.Add(this.working_days);
            this.panelSliderMenu.Controls.Add(this.locations);
            this.panelSliderMenu.Controls.Add(this.tags);
            this.panelSliderMenu.Controls.Add(this.subjects);
            this.panelSliderMenu.Controls.Add(this.lecturers);
            this.panelSliderMenu.Controls.Add(this.dashboard);
            this.panelSliderMenu.Controls.Add(this.panellogo);
            this.panelSliderMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSliderMenu.Location = new System.Drawing.Point(15, 30);
            this.panelSliderMenu.Name = "panelSliderMenu";
            this.panelSliderMenu.Size = new System.Drawing.Size(182, 563);
            this.panelSliderMenu.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::TimeTable.Properties.Resources.student;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.working_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.working_days.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.working_days.Image = global::TimeTable.Properties.Resources.time3;
            this.working_days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.working_days.Location = new System.Drawing.Point(0, 287);
            this.working_days.Name = "working_days";
            this.working_days.Size = new System.Drawing.Size(178, 45);
            this.working_days.TabIndex = 16;
            this.working_days.Text = "Working Days and Hours\r\n";
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
            this.subjects.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.subjects.UseVisualStyleBackColor = false;
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
            // 
            // lecturers
            // 
            this.lecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturers.FlatAppearance.BorderSize = 0;
            this.lecturers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturers.Image = global::TimeTable.Properties.Resources.lecture2;
            this.lecturers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lecturers.Location = new System.Drawing.Point(0, 107);
            this.lecturers.Name = "lecturers";
            this.lecturers.Size = new System.Drawing.Size(178, 45);
            this.lecturers.TabIndex = 12;
            this.lecturers.Text = "Lecturers";
            this.lecturers.UseVisualStyleBackColor = true;
            this.lecturers.Click += new System.EventHandler(this.lecturers_Click);
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
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(938, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSliderMenu);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Students";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.Studenttab.ResumeLayout(false);
            this.addstudenttab.ResumeLayout(false);
            this.addstudenttab.PerformLayout();
            this.managestu.ResumeLayout(false);
            this.managestu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSliderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Studenttab;
        private System.Windows.Forms.TabPage addstudenttab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddStu;
        private System.Windows.Forms.Button ClearStudent;
        private System.Windows.Forms.Button GenerateGIDBtn;
        private System.Windows.Forms.Button GenerateSubGIDBtn;
        private MetroFramework.Controls.MetroTextBox AddstuSubGID;
        private MetroFramework.Controls.MetroTextBox Addstusubgrp;
        private MetroFramework.Controls.MetroTextBox AddstuMGID;
        private MetroFramework.Controls.MetroTextBox AddstuMgrp;
        private MetroFramework.Controls.MetroComboBox Addstupro;
        private MetroFramework.Controls.MetroComboBox Addstusem;
        private MetroFramework.Controls.MetroComboBox Addstuyr;
        private System.Windows.Forms.TextBox AddstuSubID;
        private System.Windows.Forms.TextBox AddstuSub;
        private System.Windows.Forms.TextBox AddstuMGI;
        private System.Windows.Forms.TextBox AddstuMG;
        private System.Windows.Forms.TextBox Addstupr;
        private System.Windows.Forms.TextBox Addstuse;
        private System.Windows.Forms.TextBox AddstuYear;
        private System.Windows.Forms.TabPage managestu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button UpdateStudent;
        private System.Windows.Forms.Button ClearStudentMan;
        private System.Windows.Forms.DataGridView studentdata;
        private MetroFramework.Controls.MetroTextBox ManagestudentMGID;
        private MetroFramework.Controls.MetroTextBox ManagestudentMainG;
        private MetroFramework.Controls.MetroComboBox Managestudentpr;
        private System.Windows.Forms.TextBox ManagestuMGID;
        private System.Windows.Forms.TextBox ManagestuMG;
        private System.Windows.Forms.TextBox Managestupr;
        private MetroFramework.Controls.MetroTextBox ManagestudentSGID;
        private MetroFramework.Controls.MetroTextBox ManagestudentSubG;
        private MetroFramework.Controls.MetroComboBox ManagestudentSem;
        private MetroFramework.Controls.MetroComboBox ManagestudentYr;
        private System.Windows.Forms.TextBox ManagestuSID;
        private System.Windows.Forms.TextBox ManagestuSub;
        private System.Windows.Forms.TextBox Managestusem;
        private System.Windows.Forms.TextBox Managestuyr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSliderMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button lecturers;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button gensub;
        private System.Windows.Forms.Button genmain;
    }
}