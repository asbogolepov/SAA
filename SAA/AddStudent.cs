using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Group". При необходимости она может быть перемещена или удалена.
            this.dim_GroupTableAdapter.Fill(this.sAA_StudentDataSet.dim_Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Faculty". При необходимости она может быть перемещена или удалена.
            this.dim_FacultyTableAdapter.Fill(this.sAA_StudentDataSet.dim_Faculty);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LtS_StudentDataContext db = new LtS_StudentDataContext())
            {
                dim_Student student = new dim_Student
                {
                    ID_Group = Convert.ToInt32(cbGroup_Stud.SelectedValue),
                    fio_student = tbFIO.Text,
                    residense_place = tbResidense.Text,
                    Phone_student = tbPhone.Text,
                    email_student = tbEmail.Text,
                    zachetka = tbNomerZachetki.Text
                };

                db.dim_Student.InsertOnSubmit(student);

                try
                {
                    db.SubmitChanges();                
                }
                catch(Exception ex)
                {
                    db.SubmitChanges();
                }
            }

            this.Close();
        }
    }
}
