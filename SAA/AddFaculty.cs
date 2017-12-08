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
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LtS_StudentDataContext db = new LtS_StudentDataContext())
            {
                dim_Faculty faculty = new dim_Faculty
                {
                    Name_Faculty = tbFacultyName.Text
                };

                db.dim_Faculty.InsertOnSubmit(faculty);

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

        private void tbFacultyName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (LtS_StudentDataContext db = new LtS_StudentDataContext())
                {
                    dim_Faculty faculty = new dim_Faculty
                    {
                        Name_Faculty = tbFacultyName.Text
                    };

                    db.dim_Faculty.InsertOnSubmit(faculty);

                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        db.SubmitChanges();
                    }
                }

                this.Close();
            }
        }
    }
}
