
namespace TimeTable
{
    partial class Location
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
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationtab = new System.Windows.Forms.TabControl();
            this.locationtabpage = new System.Windows.Forms.TabPage();
            this.txtroomname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlocclear = new System.Windows.Forms.Button();
            this.btnlocsave = new System.Windows.Forms.Button();
            this.txtcapacity = new System.Windows.Forms.ComboBox();
            this.txtroomtype = new System.Windows.Forms.ComboBox();
            this.txtbuildname = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.manageloctab = new System.Windows.Forms.TabPage();
            this.comboEditbuilding = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.btnLocDelete = new System.Windows.Forms.Button();
            this.btnLMclear = new System.Windows.Forms.Button();
            this.btnLocUpdate = new System.Windows.Forms.Button();
            this.comboEditroomtype = new System.Windows.Forms.ComboBox();
            this.comboEditcapacity = new System.Windows.Forms.ComboBox();
            this.comboEditroomname = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSliderMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.locationtab.SuspendLayout();
            this.locationtabpage.SuspendLayout();
            this.manageloctab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panelSliderMenu.Controls.Add(this.button1);
            this.panelSliderMenu.Controls.Add(this.dashboard);
            this.panelSliderMenu.Controls.Add(this.panellogo);
            this.panelSliderMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSliderMenu.Location = new System.Drawing.Point(15, 36);
            this.panelSliderMenu.Name = "panelSliderMenu";
            this.panelSliderMenu.Size = new System.Drawing.Size(182, 557);
            this.panelSliderMenu.TabIndex = 28;
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
            this.locations.Click += new System.EventHandler(this.locations_Click);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::TimeTable.Properties.Resources.lecture2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lecturers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.Controls.Add(this.locationtab);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(197, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 557);
            this.panel1.TabIndex = 30;
            // 
            // locationtab
            // 
            this.locationtab.Controls.Add(this.locationtabpage);
            this.locationtab.Controls.Add(this.manageloctab);
            this.locationtab.Location = new System.Drawing.Point(16, 67);
            this.locationtab.Name = "locationtab";
            this.locationtab.SelectedIndex = 0;
            this.locationtab.Size = new System.Drawing.Size(695, 460);
            this.locationtab.TabIndex = 27;
            // 
            // locationtabpage
            // 
            this.locationtabpage.Controls.Add(this.txtroomname);
            this.locationtabpage.Controls.Add(this.label2);
            this.locationtabpage.Controls.Add(this.btnlocclear);
            this.locationtabpage.Controls.Add(this.btnlocsave);
            this.locationtabpage.Controls.Add(this.txtcapacity);
            this.locationtabpage.Controls.Add(this.txtroomtype);
            this.locationtabpage.Controls.Add(this.txtbuildname);
            this.locationtabpage.Controls.Add(this.textBox11);
            this.locationtabpage.Controls.Add(this.textBox3);
            this.locationtabpage.Controls.Add(this.textBox2);
            this.locationtabpage.Controls.Add(this.textBox1);
            this.locationtabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtabpage.Location = new System.Drawing.Point(4, 27);
            this.locationtabpage.Name = "locationtabpage";
            this.locationtabpage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.locationtabpage.Size = new System.Drawing.Size(687, 429);
            this.locationtabpage.TabIndex = 0;
            this.locationtabpage.Text = "Add Location";
            this.locationtabpage.UseVisualStyleBackColor = true;
            this.locationtabpage.Click += new System.EventHandler(this.locationtabpage_Click);
            // 
            // txtroomname
            // 
            this.txtroomname.FormattingEnabled = true;
            this.txtroomname.Items.AddRange(new object[] {
            "A401",
            "A411",
            "D204",
            "E204",
            "E304"});
            this.txtroomname.Location = new System.Drawing.Point(173, 211);
            this.txtroomname.Name = "txtroomname";
            this.txtroomname.Size = new System.Drawing.Size(121, 21);
            this.txtroomname.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(267, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 119;
            this.label2.Text = "Add Location";
            // 
            // btnlocclear
            // 
            this.btnlocclear.BackColor = System.Drawing.Color.Red;
            this.btnlocclear.Location = new System.Drawing.Point(371, 297);
            this.btnlocclear.Name = "btnlocclear";
            this.btnlocclear.Size = new System.Drawing.Size(101, 36);
            this.btnlocclear.TabIndex = 47;
            this.btnlocclear.Text = "Clear";
            this.btnlocclear.UseVisualStyleBackColor = false;
            this.btnlocclear.Click += new System.EventHandler(this.btnlocclear_Click);
            // 
            // btnlocsave
            // 
            this.btnlocsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlocsave.Location = new System.Drawing.Point(189, 297);
            this.btnlocsave.Name = "btnlocsave";
            this.btnlocsave.Size = new System.Drawing.Size(104, 36);
            this.btnlocsave.TabIndex = 46;
            this.btnlocsave.Text = "Save";
            this.btnlocsave.UseVisualStyleBackColor = false;
            this.btnlocsave.Click += new System.EventHandler(this.btnlocsave_Click);
            // 
            // txtcapacity
            // 
            this.txtcapacity.FormattingEnabled = true;
            this.txtcapacity.Items.AddRange(new object[] {
            "60",
            "80",
            "90",
            "120",
            "150",
            "170",
            "200",
            "230"});
            this.txtcapacity.Location = new System.Drawing.Point(514, 133);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(121, 21);
            this.txtcapacity.TabIndex = 42;
            // 
            // txtroomtype
            // 
            this.txtroomtype.FormattingEnabled = true;
            this.txtroomtype.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratory"});
            this.txtroomtype.Location = new System.Drawing.Point(514, 208);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(121, 21);
            this.txtroomtype.TabIndex = 41;
            // 
            // txtbuildname
            // 
            this.txtbuildname.FormattingEnabled = true;
            this.txtbuildname.Items.AddRange(new object[] {
            "Faculty of Computing Building",
            "Faculty of Business Building",
            "Faculty of Engineering Building",
            "New Building"});
            this.txtbuildname.Location = new System.Drawing.Point(173, 137);
            this.txtbuildname.Name = "txtbuildname";
            this.txtbuildname.Size = new System.Drawing.Size(121, 21);
            this.txtbuildname.TabIndex = 40;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(22, 207);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(123, 24);
            this.textBox11.TabIndex = 39;
            this.textBox11.Text = "Room Name";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(357, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 24);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "Room Type";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(357, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 24);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Capacity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Building Name";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // manageloctab
            // 
            this.manageloctab.Controls.Add(this.comboEditbuilding);
            this.manageloctab.Controls.Add(this.label3);
            this.manageloctab.Controls.Add(this.dgvLocations);
            this.manageloctab.Controls.Add(this.btnLocDelete);
            this.manageloctab.Controls.Add(this.btnLMclear);
            this.manageloctab.Controls.Add(this.btnLocUpdate);
            this.manageloctab.Controls.Add(this.comboEditroomtype);
            this.manageloctab.Controls.Add(this.comboEditcapacity);
            this.manageloctab.Controls.Add(this.comboEditroomname);
            this.manageloctab.Controls.Add(this.textBox4);
            this.manageloctab.Controls.Add(this.textBox6);
            this.manageloctab.Controls.Add(this.textBox12);
            this.manageloctab.Controls.Add(this.textBox16);
            this.manageloctab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageloctab.Location = new System.Drawing.Point(4, 27);
            this.manageloctab.Name = "manageloctab";
            this.manageloctab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.manageloctab.Size = new System.Drawing.Size(687, 429);
            this.manageloctab.TabIndex = 1;
            this.manageloctab.Text = "Edit/Delete Location";
            this.manageloctab.UseVisualStyleBackColor = true;
            // 
            // comboEditbuilding
            // 
            this.comboEditbuilding.FormattingEnabled = true;
            this.comboEditbuilding.Items.AddRange(new object[] {
            "Faculty of Computing Building",
            "Faculty of Business Building",
            "Faculty of Engineering Building",
            "New Building"});
            this.comboEditbuilding.Location = new System.Drawing.Point(206, 109);
            this.comboEditbuilding.Name = "comboEditbuilding";
            this.comboEditbuilding.Size = new System.Drawing.Size(121, 21);
            this.comboEditbuilding.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(257, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 119;
            this.label3.Text = "Manage Locations";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvLocations
            // 
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Location = new System.Drawing.Point(6, 295);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.RowHeadersWidth = 51;
            this.dgvLocations.Size = new System.Drawing.Size(630, 128);
            this.dgvLocations.TabIndex = 50;
            this.dgvLocations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocations_CellClick);
            this.dgvLocations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocations_CellClick);
            // 
            // btnLocDelete
            // 
            this.btnLocDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnLocDelete.Location = new System.Drawing.Point(275, 253);
            this.btnLocDelete.Name = "btnLocDelete";
            this.btnLocDelete.Size = new System.Drawing.Size(101, 36);
            this.btnLocDelete.TabIndex = 49;
            this.btnLocDelete.Text = "Delete";
            this.btnLocDelete.UseVisualStyleBackColor = false;
            this.btnLocDelete.Click += new System.EventHandler(this.btnLocDelete_Click);
            // 
            // btnLMclear
            // 
            this.btnLMclear.BackColor = System.Drawing.Color.Red;
            this.btnLMclear.Location = new System.Drawing.Point(446, 253);
            this.btnLMclear.Name = "btnLMclear";
            this.btnLMclear.Size = new System.Drawing.Size(104, 36);
            this.btnLMclear.TabIndex = 48;
            this.btnLMclear.Text = "Clear";
            this.btnLMclear.UseVisualStyleBackColor = false;
            this.btnLMclear.Click += new System.EventHandler(this.btnLMclear_Click);
            // 
            // btnLocUpdate
            // 
            this.btnLocUpdate.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLocUpdate.Location = new System.Drawing.Point(111, 253);
            this.btnLocUpdate.Name = "btnLocUpdate";
            this.btnLocUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnLocUpdate.TabIndex = 47;
            this.btnLocUpdate.Text = "Update";
            this.btnLocUpdate.UseVisualStyleBackColor = false;
            this.btnLocUpdate.Click += new System.EventHandler(this.BtnLocUpdate_Click);
            // 
            // comboEditroomtype
            // 
            this.comboEditroomtype.FormattingEnabled = true;
            this.comboEditroomtype.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratory"});
            this.comboEditroomtype.Location = new System.Drawing.Point(542, 186);
            this.comboEditroomtype.Name = "comboEditroomtype";
            this.comboEditroomtype.Size = new System.Drawing.Size(121, 21);
            this.comboEditroomtype.TabIndex = 45;
            // 
            // comboEditcapacity
            // 
            this.comboEditcapacity.FormattingEnabled = true;
            this.comboEditcapacity.Items.AddRange(new object[] {
            "60",
            "80",
            "90",
            "120",
            "150",
            "170",
            "200",
            "230"});
            this.comboEditcapacity.Location = new System.Drawing.Point(542, 109);
            this.comboEditcapacity.Name = "comboEditcapacity";
            this.comboEditcapacity.Size = new System.Drawing.Size(121, 21);
            this.comboEditcapacity.TabIndex = 44;
            // 
            // comboEditroomname
            // 
            this.comboEditroomname.FormattingEnabled = true;
            this.comboEditroomname.Items.AddRange(new object[] {
            "A401",
            "A411",
            "D204",
            "E204",
            "E304"});
            this.comboEditroomname.Location = new System.Drawing.Point(206, 190);
            this.comboEditroomname.Name = "comboEditroomname";
            this.comboEditroomname.Size = new System.Drawing.Size(121, 21);
            this.comboEditroomname.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(42, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(123, 24);
            this.textBox4.TabIndex = 41;
            this.textBox4.Text = "Building Name";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(42, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(123, 24);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "Room Name";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(387, 186);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(125, 24);
            this.textBox12.TabIndex = 38;
            this.textBox12.Text = "Room Type";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(387, 110);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(125, 24);
            this.textBox16.TabIndex = 33;
            this.textBox16.Text = "Capacity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 62);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(308, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Locations";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Location
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
            this.Name = "Location";
            this.Padding = new System.Windows.Forms.Padding(15, 36, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Location_Load);
            this.panelSliderMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.locationtab.ResumeLayout(false);
            this.locationtabpage.ResumeLayout(false);
            this.locationtabpage.PerformLayout();
            this.manageloctab.ResumeLayout(false);
            this.manageloctab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button locations;
        private System.Windows.Forms.Panel panelSliderMenu;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button working_days;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl locationtab;
        private System.Windows.Forms.TabPage locationtabpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlocclear;
        private System.Windows.Forms.Button btnlocsave;
        private System.Windows.Forms.ComboBox txtcapacity;
        private System.Windows.Forms.ComboBox txtroomtype;
        private System.Windows.Forms.ComboBox txtbuildname;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage manageloctab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.Button btnLocDelete;
        private System.Windows.Forms.Button btnLMclear;
        private System.Windows.Forms.Button btnLocUpdate;
        private System.Windows.Forms.ComboBox comboEditroomtype;
        private System.Windows.Forms.ComboBox comboEditcapacity;
        private System.Windows.Forms.ComboBox comboEditroomname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.ComboBox txtroomname;
        private System.Windows.Forms.ComboBox comboEditbuilding;
    }
}