namespace SAA
{
    partial class AddFact
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
            this.cbGroup_Fact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFaculty_Fact = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sAA_StudentDataSet = new SAA.SAA_StudentDataSet();
            this.dimFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_FacultyTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter();
            this.fKDIMGROUFACULTYGDIMFACUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_GroupTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStudent_Fact = new System.Windows.Forms.ComboBox();
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_StudentTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_StudentTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProfUsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNeprofUsp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConference = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOlimpPrize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOlimpWin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSites = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.dimdatetimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_datetimeTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_datetimeTableAdapter();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.fKFACTDATETIMEDIMDATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.FactTableAdapter();
            this.tbPrepod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbZavkaf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPractice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPublications = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPatents = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCertificates = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbProjects = new System.Windows.Forms.TextBox();
            this.checkBoxOpit = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMSTUDGROUPSTUDIMGROUBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimdatetimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFACTDATETIMEDIMDATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGroup_Fact
            // 
            this.cbGroup_Fact.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            this.cbGroup_Fact.DisplayMember = "Name_Group";
            this.cbGroup_Fact.FormattingEnabled = true;
            this.cbGroup_Fact.Location = new System.Drawing.Point(250, 44);
            this.cbGroup_Fact.Name = "cbGroup_Fact";
            this.cbGroup_Fact.Size = new System.Drawing.Size(131, 21);
            this.cbGroup_Fact.TabIndex = 15;
            this.cbGroup_Fact.ValueMember = "ID_Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Группа:";
            // 
            // cbFaculty_Fact
            // 
            this.cbFaculty_Fact.DataSource = this.dimFacultyBindingSource;
            this.cbFaculty_Fact.DisplayMember = "Name_Faculty";
            this.cbFaculty_Fact.FormattingEnabled = true;
            this.cbFaculty_Fact.Location = new System.Drawing.Point(9, 45);
            this.cbFaculty_Fact.Name = "cbFaculty_Fact";
            this.cbFaculty_Fact.Size = new System.Drawing.Size(230, 21);
            this.cbFaculty_Fact.TabIndex = 14;
            this.cbFaculty_Fact.ValueMember = "ID_Faculty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Факультет:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOpit);
            this.groupBox1.Controls.Add(this.tbProjects);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbCertificates);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbPatents);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbPublications);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbPractice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbZavkaf);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbPrepod);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbSites);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbOlimpWin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbOlimpPrize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbConference);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNeprofUsp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbProfUsp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных о результатах среза";
            // 
            // sAA_StudentDataSet
            // 
            this.sAA_StudentDataSet.DataSetName = "SAA_StudentDataSet";
            this.sAA_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dimFacultyBindingSource
            // 
            this.dimFacultyBindingSource.DataMember = "dim_Faculty";
            this.dimFacultyBindingSource.DataSource = this.sAA_StudentDataSet;
            // 
            // dim_FacultyTableAdapter
            // 
            this.dim_FacultyTableAdapter.ClearBeforeFill = true;
            // 
            // fKDIMGROUFACULTYGDIMFACUBindingSource
            // 
            this.fKDIMGROUFACULTYGDIMFACUBindingSource.DataMember = "FK_DIM_GROU_FACULTY_G_DIM_FACU";
            this.fKDIMGROUFACULTYGDIMFACUBindingSource.DataSource = this.dimFacultyBindingSource;
            // 
            // dim_GroupTableAdapter
            // 
            this.dim_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Студент:";
            // 
            // cbStudent_Fact
            // 
            this.cbStudent_Fact.DataSource = this.fKDIMSTUDGROUPSTUDIMGROUBindingSource;
            this.cbStudent_Fact.DisplayMember = "fio_student";
            this.cbStudent_Fact.FormattingEnabled = true;
            this.cbStudent_Fact.Location = new System.Drawing.Point(9, 97);
            this.cbStudent_Fact.Name = "cbStudent_Fact";
            this.cbStudent_Fact.Size = new System.Drawing.Size(227, 21);
            this.cbStudent_Fact.TabIndex = 18;
            this.cbStudent_Fact.ValueMember = "id_student";
            // 
            // fKDIMSTUDGROUPSTUDIMGROUBindingSource
            // 
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource.DataMember = "FK_DIM_STUD_GROUP_STU_DIM_GROU";
            this.fKDIMSTUDGROUPSTUDIMGROUBindingSource.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            // 
            // dim_StudentTableAdapter
            // 
            this.dim_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStudent_Fact);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbGroup_Fact);
            this.groupBox2.Controls.Add(this.cbFaculty_Fact);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 139);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор студента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Профильная успеваемость:";
            // 
            // tbProfUsp
            // 
            this.tbProfUsp.Location = new System.Drawing.Point(15, 36);
            this.tbProfUsp.Name = "tbProfUsp";
            this.tbProfUsp.Size = new System.Drawing.Size(100, 20);
            this.tbProfUsp.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Непрофильная успеваемость:";
            // 
            // tbNeprofUsp
            // 
            this.tbNeprofUsp.Location = new System.Drawing.Point(168, 35);
            this.tbNeprofUsp.Name = "tbNeprofUsp";
            this.tbNeprofUsp.Size = new System.Drawing.Size(100, 20);
            this.tbNeprofUsp.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Количество конференций:";
            // 
            // tbConference
            // 
            this.tbConference.Location = new System.Drawing.Point(336, 35);
            this.tbConference.Name = "tbConference";
            this.tbConference.Size = new System.Drawing.Size(100, 20);
            this.tbConference.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Призер в олимпиадах:";
            // 
            // tbOlimpPrize
            // 
            this.tbOlimpPrize.Location = new System.Drawing.Point(15, 92);
            this.tbOlimpPrize.Name = "tbOlimpPrize";
            this.tbOlimpPrize.Size = new System.Drawing.Size(100, 20);
            this.tbOlimpPrize.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Победитель в олимпиадах:";
            // 
            // tbOlimpWin
            // 
            this.tbOlimpWin.Location = new System.Drawing.Point(171, 91);
            this.tbOlimpWin.Name = "tbOlimpWin";
            this.tbOlimpWin.Size = new System.Drawing.Size(100, 20);
            this.tbOlimpWin.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Посещение профильных сайтов:";
            // 
            // tbSites
            // 
            this.tbSites.Location = new System.Drawing.Point(339, 91);
            this.tbSites.Name = "tbSites";
            this.tbSites.Size = new System.Drawing.Size(100, 20);
            this.tbSites.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Оценка ведущего преподавателя:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Дата среза:";
            // 
            // cbYear
            // 
            this.cbYear.DataSource = this.dimdatetimeBindingSource;
            this.cbYear.DisplayMember = "Year";
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(434, 56);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(80, 21);
            this.cbYear.TabIndex = 24;
            this.cbYear.ValueMember = "id_date";
            // 
            // dimdatetimeBindingSource
            // 
            this.dimdatetimeBindingSource.DataMember = "dim_datetime";
            this.dimdatetimeBindingSource.DataSource = this.sAA_StudentDataSet;
            // 
            // dim_datetimeTableAdapter
            // 
            this.dim_datetimeTableAdapter.ClearBeforeFill = true;
            // 
            // cbMonth
            // 
            this.cbMonth.DataSource = this.dimdatetimeBindingSource;
            this.cbMonth.DisplayMember = "month";
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(520, 56);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(90, 21);
            this.cbMonth.TabIndex = 25;
            this.cbMonth.ValueMember = "id_date";
            // 
            // fKFACTDATETIMEDIMDATEBindingSource
            // 
            this.fKFACTDATETIMEDIMDATEBindingSource.DataMember = "FK_FACT_DATETIME__DIM_DATE";
            this.fKFACTDATETIMEDIMDATEBindingSource.DataSource = this.dimdatetimeBindingSource;
            // 
            // factTableAdapter
            // 
            this.factTableAdapter.ClearBeforeFill = true;
            // 
            // tbPrepod
            // 
            this.tbPrepod.Location = new System.Drawing.Point(15, 154);
            this.tbPrepod.Name = "tbPrepod";
            this.tbPrepod.Size = new System.Drawing.Size(100, 20);
            this.tbPrepod.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Оценка зав. кафедрой";
            // 
            // tbZavkaf
            // 
            this.tbZavkaf.Location = new System.Drawing.Point(205, 154);
            this.tbZavkaf.Name = "tbZavkaf";
            this.tbZavkaf.Size = new System.Drawing.Size(100, 20);
            this.tbZavkaf.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Оценка с практики:";
            // 
            // tbPractice
            // 
            this.tbPractice.Location = new System.Drawing.Point(342, 154);
            this.tbPractice.Name = "tbPractice";
            this.tbPractice.Size = new System.Drawing.Size(100, 20);
            this.tbPractice.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Публикации:";
            // 
            // tbPublications
            // 
            this.tbPublications.Location = new System.Drawing.Point(15, 213);
            this.tbPublications.Name = "tbPublications";
            this.tbPublications.Size = new System.Drawing.Size(100, 20);
            this.tbPublications.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Патенты:";
            // 
            // tbPatents
            // 
            this.tbPatents.Location = new System.Drawing.Point(141, 213);
            this.tbPatents.Name = "tbPatents";
            this.tbPatents.Size = new System.Drawing.Size(100, 20);
            this.tbPatents.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(263, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Сертификаты:";
            // 
            // tbCertificates
            // 
            this.tbCertificates.Location = new System.Drawing.Point(266, 213);
            this.tbCertificates.Name = "tbCertificates";
            this.tbCertificates.Size = new System.Drawing.Size(100, 20);
            this.tbCertificates.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(390, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Участие в проектах:";
            // 
            // tbProjects
            // 
            this.tbProjects.Location = new System.Drawing.Point(393, 213);
            this.tbProjects.Name = "tbProjects";
            this.tbProjects.Size = new System.Drawing.Size(100, 20);
            this.tbProjects.TabIndex = 25;
            // 
            // checkBoxOpit
            // 
            this.checkBoxOpit.AutoSize = true;
            this.checkBoxOpit.Location = new System.Drawing.Point(15, 253);
            this.checkBoxOpit.Name = "checkBoxOpit";
            this.checkBoxOpit.Size = new System.Drawing.Size(245, 17);
            this.checkBoxOpit.TabIndex = 27;
            this.checkBoxOpit.Text = "Опыт работы по специальности (Есть/Нет)";
            this.checkBoxOpit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddFact";
            this.Text = "Добавление результатов среза:";
            this.Load += new System.EventHandler(this.AddFact_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMSTUDGROUPSTUDIMGROUBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimdatetimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFACTDATETIMEDIMDATEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbGroup_Fact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFaculty_Fact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private SAA_StudentDataSet sAA_StudentDataSet;
        private System.Windows.Forms.BindingSource dimFacultyBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter dim_FacultyTableAdapter;
        private System.Windows.Forms.BindingSource fKDIMGROUFACULTYGDIMFACUBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter dim_GroupTableAdapter;
        private System.Windows.Forms.ComboBox cbStudent_Fact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fKDIMSTUDGROUPSTUDIMGROUBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_StudentTableAdapter dim_StudentTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSites;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOlimpWin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOlimpPrize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNeprofUsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProfUsp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.BindingSource dimdatetimeBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_datetimeTableAdapter dim_datetimeTableAdapter;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.BindingSource fKFACTDATETIMEDIMDATEBindingSource;
        private SAA_StudentDataSetTableAdapters.FactTableAdapter factTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxOpit;
        private System.Windows.Forms.TextBox tbProjects;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCertificates;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbPatents;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPublications;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPractice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbZavkaf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPrepod;
        private System.Windows.Forms.Button button1;
    }
}