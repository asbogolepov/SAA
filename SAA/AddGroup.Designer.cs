namespace SAA
{
    partial class AddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFaculty_Group = new System.Windows.Forms.ComboBox();
            this.dimFacultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAA_StudentDataSet = new SAA.SAA_StudentDataSet();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAbbr = new System.Windows.Forms.TextBox();
            this.sAAStudentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dim_FacultyTableAdapter = new SAA.SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAAStudentDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование группы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Факультет:";
            // 
            // cbFaculty_Group
            // 
            this.cbFaculty_Group.DataSource = this.dimFacultyBindingSource;
            this.cbFaculty_Group.DisplayMember = "Name_Faculty";
            this.cbFaculty_Group.FormattingEnabled = true;
            this.cbFaculty_Group.Location = new System.Drawing.Point(28, 48);
            this.cbFaculty_Group.Name = "cbFaculty_Group";
            this.cbFaculty_Group.Size = new System.Drawing.Size(195, 21);
            this.cbFaculty_Group.TabIndex = 2;
            this.cbFaculty_Group.ValueMember = "ID_Faculty";
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
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(27, 99);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(196, 20);
            this.tbGroupName.TabIndex = 3;
            this.tbGroupName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGroupName_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Аббревиатура:";
            // 
            // tbAbbr
            // 
            this.tbAbbr.Location = new System.Drawing.Point(27, 154);
            this.tbAbbr.Name = "tbAbbr";
            this.tbAbbr.Size = new System.Drawing.Size(196, 20);
            this.tbAbbr.TabIndex = 5;
            this.tbAbbr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAbbr_KeyUp);
            // 
            // sAAStudentDataSetBindingSource
            // 
            this.sAAStudentDataSetBindingSource.DataSource = this.sAA_StudentDataSet;
            this.sAAStudentDataSetBindingSource.Position = 0;
            // 
            // dim_FacultyTableAdapter
            // 
            this.dim_FacultyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAbbr);
            this.groupBox1.Controls.Add(this.cbFaculty_Group);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbGroupName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных о группе:";
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 245);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimFacultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAA_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAAStudentDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFaculty_Group;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbbr;
        private System.Windows.Forms.BindingSource sAAStudentDataSetBindingSource;
        private SAA_StudentDataSet sAA_StudentDataSet;
        private System.Windows.Forms.BindingSource dimFacultyBindingSource;
        private SAA_StudentDataSetTableAdapters.dim_FacultyTableAdapter dim_FacultyTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}