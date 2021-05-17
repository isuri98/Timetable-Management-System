namespace TimeTable
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lecbtn = new System.Windows.Forms.Button();
            this.timetablebtn = new System.Windows.Forms.Button();
            this.sessionbtn = new System.Windows.Forms.Button();
            this.optbtn = new System.Windows.Forms.Button();
            this.statbtn = new System.Windows.Forms.Button();
            this.studentbtn = new System.Windows.Forms.Button();
            this.subjectbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSliderMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelSliderMenu.TabIndex = 10;
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
            this.students.Click += new System.EventHandler(this.student_Click);
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
            this.locations.Click += new System.EventHandler(this.Location_Click);
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
            this.subjects.Click += new System.EventHandler(this.Subjects_Click);
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
            this.lectures.Click += new System.EventHandler(this.Lectures_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lecbtn);
            this.panel1.Controls.Add(this.timetablebtn);
            this.panel1.Controls.Add(this.sessionbtn);
            this.panel1.Controls.Add(this.optbtn);
            this.panel1.Controls.Add(this.statbtn);
            this.panel1.Controls.Add(this.studentbtn);
            this.panel1.Controls.Add(this.subjectbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(197, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 563);
            this.panel1.TabIndex = 11;
            // 
            // lecbtn
            // 
            this.lecbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lecbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecbtn.Image = global::TimeTable.Properties.Resources.teacher;
            this.lecbtn.Location = new System.Drawing.Point(34, 114);
            this.lecbtn.Name = "lecbtn";
            this.lecbtn.Size = new System.Drawing.Size(202, 126);
            this.lecbtn.TabIndex = 8;
            this.lecbtn.Text = "Lecturers";
            this.lecbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lecbtn.UseVisualStyleBackColor = false;
            this.lecbtn.Click += new System.EventHandler(this.Lecbtn_Click);
            // 
            // timetablebtn
            // 
            this.timetablebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.timetablebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetablebtn.Image = global::TimeTable.Properties.Resources.timetable1;
            this.timetablebtn.Location = new System.Drawing.Point(151, 403);
            this.timetablebtn.Name = "timetablebtn";
            this.timetablebtn.Size = new System.Drawing.Size(399, 64);
            this.timetablebtn.TabIndex = 7;
            this.timetablebtn.Text = "Generate New Timetable";
            this.timetablebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timetablebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timetablebtn.UseVisualStyleBackColor = false;
            this.timetablebtn.Click += new System.EventHandler(this.Timetablebtn_Click);
            // 
            // sessionbtn
            // 
            this.sessionbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sessionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionbtn.Image = global::TimeTable.Properties.Resources.session3;
            this.sessionbtn.Location = new System.Drawing.Point(489, 248);
            this.sessionbtn.Name = "sessionbtn";
            this.sessionbtn.Size = new System.Drawing.Size(202, 126);
            this.sessionbtn.TabIndex = 6;
            this.sessionbtn.Text = "Sessions";
            this.sessionbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sessionbtn.UseVisualStyleBackColor = false;
            this.sessionbtn.Click += new System.EventHandler(this.Sessionbtn_Click);
            // 
            // optbtn
            // 
            this.optbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.optbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optbtn.Image = global::TimeTable.Properties.Resources.options;
            this.optbtn.Location = new System.Drawing.Point(262, 248);
            this.optbtn.Name = "optbtn";
            this.optbtn.Size = new System.Drawing.Size(202, 126);
            this.optbtn.TabIndex = 5;
            this.optbtn.Text = "Advanced Options";
            this.optbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.optbtn.UseVisualStyleBackColor = false;
            this.optbtn.Click += new System.EventHandler(this.optbtn_Click);
            // 
            // statbtn
            // 
            this.statbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statbtn.Image = global::TimeTable.Properties.Resources.bar;
            this.statbtn.Location = new System.Drawing.Point(34, 248);
            this.statbtn.Name = "statbtn";
            this.statbtn.Size = new System.Drawing.Size(202, 126);
            this.statbtn.TabIndex = 4;
            this.statbtn.Text = "Statistics";
            this.statbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.statbtn.UseVisualStyleBackColor = false;
            this.statbtn.Click += new System.EventHandler(this.Statbtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.studentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Image = global::TimeTable.Properties.Resources.stu;
            this.studentbtn.Location = new System.Drawing.Point(489, 114);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(202, 126);
            this.studentbtn.TabIndex = 3;
            this.studentbtn.Text = "Students";
            this.studentbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.studentbtn.UseVisualStyleBackColor = false;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // subjectbtn
            // 
            this.subjectbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.subjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectbtn.Image = global::TimeTable.Properties.Resources.book1;
            this.subjectbtn.Location = new System.Drawing.Point(262, 114);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Size = new System.Drawing.Size(202, 126);
            this.subjectbtn.TabIndex = 1;
            this.subjectbtn.Text = "Subjects";
            this.subjectbtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.subjectbtn.UseVisualStyleBackColor = false;
            this.subjectbtn.Click += new System.EventHandler(this.Subjectbtn_Click);
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
            this.label1.Location = new System.Drawing.Point(282, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(938, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSliderMenu);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSliderMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSliderMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button lectures;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button timetablebtn;
        private System.Windows.Forms.Button sessionbtn;
        private System.Windows.Forms.Button optbtn;
        private System.Windows.Forms.Button statbtn;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Button subjectbtn;
        private System.Windows.Forms.Button lecbtn;
        private System.Windows.Forms.Button students;
    }
}

