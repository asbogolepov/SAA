namespace SAA
{
    partial class Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.результатСрезаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDIMGROUFACULTYGDIMFACUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAA_StudentDataSet = new SAA.SAA_StudentDataSet();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dim_FacultyTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter();
            this.dim_GroupTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter();
            this.dim_StudentTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_StudentTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMSTUDGROUPSTUDIMGROUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отобразитьToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отобразитьToolStripMenuItem
            // 
            this.отобразитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.студентToolStripMenuItem});
            this.отобразитьToolStripMenuItem.Name = "отобразитьToolStripMenuItem";
            this.отобразитьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.отобразитьToolStripMenuItem.Text = "Отобразить";
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.факультетToolStripMenuItem.Text = "Факультет";
            this.факультетToolStripMenuItem.Click += new System.EventHandler(this.факультетToolStripMenuItem_Click);
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.группаToolStripMenuItem.Text = "Группа";
            this.группаToolStripMenuItem.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // внестиToolStripMenuItem
            // 
            this.внестиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетToolStripMenuItem1,
            this.группаToolStripMenuItem1,
            this.студентToolStripMenuItem1,
            this.результатСрезаToolStripMenuItem});
            this.внестиToolStripMenuItem.Name = "внестиToolStripMenuItem";
            this.внестиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.внестиToolStripMenuItem.Text = "Внести";
            // 
            // факультетToolStripMenuItem1
            // 
            this.факультетToolStripMenuItem1.Name = "факультетToolStripMenuItem1";
            this.факультетToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.факультетToolStripMenuItem1.Text = "Факультет";
            this.факультетToolStripMenuItem1.Click += new System.EventHandler(this.факультетToolStripMenuItem1_Click);
            // 
            // группаToolStripMenuItem1
            // 
            this.группаToolStripMenuItem1.Name = "группаToolStripMenuItem1";
            this.группаToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.группаToolStripMenuItem1.Text = "Группа";
            this.группаToolStripMenuItem1.Click += new System.EventHandler(this.группаToolStripMenuItem1_Click);
            // 
            // студентToolStripMenuItem1
            // 
            this.студентToolStripMenuItem1.Name = "студентToolStripMenuItem1";
            this.студентToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.студентToolStripMenuItem1.Text = "Студент";
            this.студентToolStripMenuItem1.Click += new System.EventHandler(this.студентToolStripMenuItem1_Click);
            // 
            // результатСрезаToolStripMenuItem
            // 
            this.результатСрезаToolStripMenuItem.Name = "результатСрезаToolStripMenuItem";
            this.результатСрезаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.результатСрезаToolStripMenuItem.Text = "Результат среза";
            this.результатСрезаToolStripMenuItem.Click += new System.EventHandler(this.результатСрезаToolStripMenuItem_Click);
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 647);
            this.splitContainer1.SplitterDistance = 406;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1185, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1179, 205);
            this.splitContainer2.SplitterDistance = 563;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbStudent);
            this.groupBox1.Controls.Add(this.cbGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFaculty);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Студент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Учебная группа:";
            // 
            // cbStudent
            // 
            this.cbStudent.DataSource = this.fKDIMSTUDGROUPSTUDIMGROUBindingSource;
            this.cbStudent.DisplayMember = "fio_student";
            this.cbStudent.Location = new System.Drawing.Point(357, 37);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(198, 21);
            this.cbStudent.TabIndex = 3;
            this.cbStudent.ValueMember = "id_student";
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // fKDIMSTUDGROUPSTUDIMGROUBindingSource
            // 
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource.DataMember = "FK_DIM_STUD_GROUP_STU_DIM_GROU";
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            // 
            // fKDIMGROUFACULTYGDIMFACUBindingSource
            // 
            this.fKDIMGROUFACULTYGDIMFACUBindingSource.DataMember = "FK_DIM_GROU_FACULTY_G_DIM_FACU";
            this.fKDIMGROUFACULTYGDIMFACUBindingSource.DataSource = this.dimFacultyBindingSource;
            // 
            // dimFacultyBindingSource
            // 
            this.dimFacultyBindingSource.DataMember = "dim_Faculty";
            this.dimFacultyBindingSource.DataSource = this.sAA_StudentDataSet;
            // 
            // sAA_StudentDataSet
            // 
            this.sAA_StudentDataSet.DataSetName = "SAA_StudentDataSet";
            this.sAA_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGroup
            // 
            this.cbGroup.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            this.cbGroup.DisplayMember = "Name_Group";
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(232, 37);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(119, 21);
            this.cbGroup.TabIndex = 2;
            this.cbGroup.ValueMember = "ID_Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Факультет:";
            // 
            // cbFaculty
            // 
            this.cbFaculty.DataSource = this.dimFacultyBindingSource;
            this.cbFaculty.DisplayMember = "Name_Faculty";
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(10, 37);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(216, 21);
            this.cbFaculty.TabIndex = 0;
            this.cbFaculty.ValueMember = "ID_Faculty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Студент";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(606, 186);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1185, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(1185, 211);
            this.splitContainer3.SplitterDistance = 215;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 211);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нейронная сеть";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Студент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dim_FacultyTableAdapter
            // 
            this.dim_FacultyTableAdapter.ClearBeforeFill = true;
            // 
            // dim_GroupTableAdapter
            // 
            this.dim_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // dim_StudentTableAdapter
            // 
            this.dim_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 671);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1209, 710);
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Analysis Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Desktop_FormClosing);
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMSTUDGROUPSTUDIMGROUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private SAA_StudentDataSet sAA_StudentDataSet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource dimFacultyBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter dim_FacultyTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.BindingSource fKDIMGROUFACULTYGDIMFACUBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter dim_GroupTableAdapter;
        private System.Windows.Forms.BindingSource fKDIMSTUDGROUPSTUDIMGROUBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_StudentTableAdapter dim_StudentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатСрезаToolStripMenuItem;
    }
}