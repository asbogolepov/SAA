namespace SAA
{
    partial class AddStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFaculty_Stud = new System.Windows.Forms.ComboBox();
            this.sAA_StudentDataSet = new SAA.SAA_StudentDataSet();
            this.sAAStudentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dimFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_FacultyTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGroup_Stud = new System.Windows.Forms.ComboBox();
            this.fKDIMGROUFACULTYGDIMFACUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_GroupTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResidense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNomerZachetki = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAAStudentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbNomerZachetki);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbResidense);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbGroup_Stud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFaculty_Stud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных о студенте:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факультет:";
            // 
            // cbFaculty_Stud
            // 
            this.cbFaculty_Stud.DataSource = this.dimFacultyBindingSource;
            this.cbFaculty_Stud.DisplayMember = "Name_Faculty";
            this.cbFaculty_Stud.FormattingEnabled = true;
            this.cbFaculty_Stud.Location = new System.Drawing.Point(22, 45);
            this.cbFaculty_Stud.Name = "cbFaculty_Stud";
            this.cbFaculty_Stud.Size = new System.Drawing.Size(230, 21);
            this.cbFaculty_Stud.TabIndex = 1;
            this.cbFaculty_Stud.ValueMember = "ID_Faculty";
            // 
            // sAA_StudentDataSet
            // 
            this.sAA_StudentDataSet.DataSetName = "SAA_StudentDataSet";
            this.sAA_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAAStudentDataSetBindingSource
            // 
            this.sAAStudentDataSetBindingSource.DataSource = this.sAA_StudentDataSet;
            this.sAAStudentDataSetBindingSource.Position = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа:";
            // 
            // cbGroup_Stud
            // 
            this.cbGroup_Stud.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            this.cbGroup_Stud.DisplayMember = "Name_Group";
            this.cbGroup_Stud.FormattingEnabled = true;
            this.cbGroup_Stud.Location = new System.Drawing.Point(263, 44);
            this.cbGroup_Stud.Name = "cbGroup_Stud";
            this.cbGroup_Stud.Size = new System.Drawing.Size(131, 21);
            this.cbGroup_Stud.TabIndex = 2;
            this.cbGroup_Stud.ValueMember = "ID_Group";
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
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО:";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(22, 99);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(230, 20);
            this.tbFIO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Место проживания:";
            // 
            // tbResidense
            // 
            this.tbResidense.Location = new System.Drawing.Point(22, 156);
            this.tbResidense.Name = "tbResidense";
            this.tbResidense.Size = new System.Drawing.Size(171, 20);
            this.tbResidense.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(22, 209);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(171, 20);
            this.tbPhone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "e-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(218, 209);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(176, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер зачетной книжки:";
            // 
            // tbNomerZachetki
            // 
            this.tbNomerZachetki.Location = new System.Drawing.Point(263, 99);
            this.tbNomerZachetki.Name = "tbNomerZachetki";
            this.tbNomerZachetki.Size = new System.Drawing.Size(131, 20);
            this.tbNomerZachetki.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 286);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAAStudentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDIMGROUFACULTYGDIMFACUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFaculty_Stud;
        private System.Windows.Forms.BindingSource sAAStudentDataSetBindingSource;
        private SAA_StudentDataSet sAA_StudentDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dimFacultyBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter dim_FacultyTableAdapter;
        private System.Windows.Forms.ComboBox cbGroup_Stud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKDIMGROUFACULTYGDIMFACUBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_GroupTableAdapter dim_GroupTableAdapter;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomerZachetki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResidense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}