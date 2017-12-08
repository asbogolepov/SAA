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
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Faculty". При необходимости она может быть перемещена или удалена.
            this.dim_FacultyTableAdapter.Fill(this.sAA_StudentDataSet.dim_Faculty);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LtS_StudentDataContext db = new LtS_StudentDataContext())
            {
                dim_Group group = new dim_Group
                {
                    ID_Faculty = Convert.ToInt32(cbFaculty_Group.SelectedValue),
                    Name_Group = tbGroupName.Text,
                    Abbreviation = tbAbbr.Text
                };

                db.dim_Group.InsertOnSubmit(group);

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

        private void tbGroupName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (LtS_StudentDataContext db = new LtS_StudentDataContext())
                {
                    dim_Group group = new dim_Group
                    {
                        ID_Faculty = Convert.ToInt32(cbFaculty_Group.SelectedValue),
                        Name_Group = tbGroupName.Text,
                        Abbreviation = tbAbbr.Text
                    };

                    db.dim_Group.InsertOnSubmit(group);

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

        private void tbAbbr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (LtS_StudentDataContext db = new LtS_StudentDataContext())
                {
                    dim_Group group = new dim_Group
                    {
                        ID_Faculty = Convert.ToInt32(cbFaculty_Group.SelectedValue),
                        Name_Group = tbGroupName.Text,
                        Abbreviation = tbAbbr.Text
                    };

                    db.dim_Group.InsertOnSubmit(group);

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
