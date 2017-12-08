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
    public partial class AddFact : Form
    {
        public AddFact()
        {
            InitializeComponent();
        }

        private void AddFact_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.Fact". При необходимости она может быть перемещена или удалена.
            this.factTableAdapter.Fill(this.sAA_StudentDataSet.Fact);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_datetime". При необходимости она может быть перемещена или удалена.
            this.dim_datetimeTableAdapter.Fill(this.sAA_StudentDataSet.dim_datetime);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Student". При необходимости она может быть перемещена или удалена.
            this.dim_StudentTableAdapter.Fill(this.sAA_StudentDataSet.dim_Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Group". При необходимости она может быть перемещена или удалена.
            this.dim_GroupTableAdapter.Fill(this.sAA_StudentDataSet.dim_Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Faculty". При необходимости она может быть перемещена или удалена.
            this.dim_FacultyTableAdapter.Fill(this.sAA_StudentDataSet.dim_Faculty);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LtS_StudentDataContext db = new LtS_StudentDataContext())
            {
                Fact fact = new Fact
                {
                    //id_date = Convert.ToInt32(cbMonth.SelectedValue),
                    id_student = Convert.ToInt32(cbStudent_Fact.SelectedValue),
                    //prof_uspevaemost = Convert.ToDouble(tbProfUsp.Text),
                   // neprof_uspevaemost = Convert.ToDouble(tbNeprofUsp.Text),
                    conference_count = Convert.ToInt32(tbConference.Text),
                    olimp_prizer = Convert.ToInt32(tbOlimpPrize.Text),
                    olimp_winner = Convert.ToInt32(tbOlimpWin.Text),
                    prof_sites = Convert.ToInt32(tbSites.Text),
                   // ocenka_prepodovatela = Convert.ToDouble(tbPrepod.Text),
                   // otziv_zavkaf = Convert.ToDouble(tbZavkaf.Text),
                   // otziv_practica = Convert.ToDouble(tbPractice.Text),
                    publications = Convert.ToInt32(tbPublications.Text),
                    patents = Convert.ToInt32(tbPatents.Text),
                    sertificates = Convert.ToInt32(tbCertificates.Text),
                    projects = Convert.ToInt32(tbProjects.Text),
                   // opit = checkBoxOpit.Checked
                };

                db.Fact.InsertOnSubmit(fact);

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
