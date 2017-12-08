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
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Student". При необходимости она может быть перемещена или удалена.
            this.dim_StudentTableAdapter.Fill(this.sAA_StudentDataSet.dim_Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Group". При необходимости она может быть перемещена или удалена.
            this.dim_GroupTableAdapter.Fill(this.sAA_StudentDataSet.dim_Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAA_StudentDataSet.dim_Faculty". При необходимости она может быть перемещена или удалена.
            this.dim_FacultyTableAdapter.Fill(this.sAA_StudentDataSet.dim_Faculty);

            

        }

        //Останавливаем приложение, если закрывается форма
        private void Desktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Реакция центральной таблицы на выбор студента в соответствующем ComboBox
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

            var selected = cbStudent.SelectedValue;

            if (selected != null)
            {

                var facts = SAA_Student.Fact.Where(fact => fact.fact_id == Convert.ToInt32(selected));

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("fio", "Ф.И.О");
                dataGridView1.Columns.Add("date", "Дата");
                dataGridView1.Columns.Add("prof_uspevaemost", "Профильная успеваемость");
                dataGridView1.Columns.Add("neprof_uspevaemost", "Непрофильная успеваемость");
                dataGridView1.Columns.Add("conference_count", "Конференции");
                dataGridView1.Columns.Add("olimp_prizer", "Олимпиады (Призёр)");
                dataGridView1.Columns.Add("olimp_winner", "Олимпиады (Победитель)");
                dataGridView1.Columns.Add("prof_sites", "Подписки (Сайты)");
                dataGridView1.Columns.Add("ocenka_prepodovatela", "Оценка преподавателя");
                dataGridView1.Columns.Add("otziv_zavkaf", "Отзыв Зав. Кафедрой");
                dataGridView1.Columns.Add("otziv_practica", "Отзыв с практики");
                dataGridView1.Columns.Add("publications", "Публикации");
                dataGridView1.Columns.Add("patents", "Патенты");
                dataGridView1.Columns.Add("sertificates", "Сертификаты");
                dataGridView1.Columns.Add("projects", "Проекты");
                dataGridView1.Columns.Add("opit", "Есть опыт");
                dataGridView1.Columns.Add("hide_student_id", "Есть опыт");

                foreach ( var fact in facts )
                {
                    dataGridView1.Rows.Add(
                        fact.dim_Student.fio_student,
                        fact.dim_datetime.month + " " + fact.dim_datetime.Year,
                        fact.prof_uspevaemost,
                        fact.neprof_uspevaemost,
                        fact.conference_count,
                        fact.olimp_prizer,
                        fact.olimp_winner,
                        fact.prof_sites,
                        fact.ocenka_prepodovatela,
                        fact.otziv_zavkaf,
                        fact.otziv_practica,
                        fact.publications,
                        fact.patents,
                        fact.sertificates,
                        fact.projects,
                        fact.opit,
                        fact.id_student
                        );
                }
                dataGridView1.ClearSelection();
                dataGridView1.Columns["hide_student_id"].Visible = false;
            }
            
        }

        //Отмена выделения двойным щелчком мыши по пустому полю в основной таблице
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        //Привязка таблицы снизу к основной таблице
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

            if (dataGridView1.CurrentRow.Cells.Count >= 16)
            {


                var student_id = dataGridView1.CurrentRow.Cells[16].Value;

                var student = SAA_Student.dim_Student.Where(stud => stud.id_student == Convert.ToInt32(student_id));

                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                dataGridView2.Columns.Add("Name", "Название");
                dataGridView2.Columns.Add("Value", "Значение");

                foreach (var stud in student)
                {
                    dataGridView2.Rows.Add("Ф.И.О:", stud.fio_student);
                    dataGridView2.Rows.Add("Факультет:", stud.dim_Group.dim_Faculty.Name_Faculty);
                    dataGridView2.Rows.Add("Группа:", stud.dim_Group.Name_Group);
                    dataGridView2.Rows.Add("Место проживания:", stud.residense_place);
                    dataGridView2.Rows.Add("Телефон:", stud.Phone_student);
                    dataGridView2.Rows.Add("Email:", stud.email_student);
                    dataGridView2.Rows.Add("Зачетная книжка:", stud.zachetka);
                }
            }
        }

        //Косметическая настройка таблицы справа снизу
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        //Вывести данные по факультету
        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

            var selected = cbFaculty.SelectedValue;

            if (selected != null)
            {

                var facts = SAA_Student.Fact.Where(fact => fact.dim_Student.dim_Group.ID_Faculty == Convert.ToInt32(selected));

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("fio", "Ф.И.О");
                dataGridView1.Columns.Add("date", "Дата");
                dataGridView1.Columns.Add("prof_uspevaemost", "Профильная успеваемость");
                dataGridView1.Columns.Add("neprof_uspevaemost", "Непрофильная успеваемость");
                dataGridView1.Columns.Add("conference_count", "Конференции");
                dataGridView1.Columns.Add("olimp_prizer", "Олимпиады (Призёр)");
                dataGridView1.Columns.Add("olimp_winner", "Олимпиады (Победитель)");
                dataGridView1.Columns.Add("prof_sites", "Подписки (Сайты)");
                dataGridView1.Columns.Add("ocenka_prepodovatela", "Оценка преподавателя");
                dataGridView1.Columns.Add("otziv_zavkaf", "Отзыв Зав. Кафедрой");
                dataGridView1.Columns.Add("otziv_practica", "Отзыв с практики");
                dataGridView1.Columns.Add("publications", "Публикации");
                dataGridView1.Columns.Add("patents", "Патенты");
                dataGridView1.Columns.Add("sertificates", "Сертификаты");
                dataGridView1.Columns.Add("projects", "Проекты");
                dataGridView1.Columns.Add("opit", "Есть опыт");
                dataGridView1.Columns.Add("hide_student_id", "Есть опыт");

                foreach (var fact in facts)
                {
                    dataGridView1.Rows.Add(
                        fact.dim_Student.fio_student,
                        fact.dim_datetime.month + " " + fact.dim_datetime.Year,
                        fact.prof_uspevaemost,
                        fact.neprof_uspevaemost,
                        fact.conference_count,
                        fact.olimp_prizer,
                        fact.olimp_winner,
                        fact.prof_sites,
                        fact.ocenka_prepodovatela,
                        fact.otziv_zavkaf,
                        fact.otziv_practica,
                        fact.publications,
                        fact.patents,
                        fact.sertificates,
                        fact.projects,
                        fact.opit,
                        fact.id_student
                        );
                }
                dataGridView1.ClearSelection();
                dataGridView1.Columns["hide_student_id"].Visible = false;
            }
        }

        //Вывести данные по группе
        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

            var selected = cbGroup.SelectedValue;

            if (selected != null)
            {

                var facts = SAA_Student.Fact.Where(fact => fact.dim_Student.ID_Group == Convert.ToInt32(selected));

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("fio", "Ф.И.О");
                dataGridView1.Columns.Add("date", "Дата");
                dataGridView1.Columns.Add("prof_uspevaemost", "Профильная успеваемость");
                dataGridView1.Columns.Add("neprof_uspevaemost", "Непрофильная успеваемость");
                dataGridView1.Columns.Add("conference_count", "Конференции");
                dataGridView1.Columns.Add("olimp_prizer", "Олимпиады (Призёр)");
                dataGridView1.Columns.Add("olimp_winner", "Олимпиады (Победитель)");
                dataGridView1.Columns.Add("prof_sites", "Подписки (Сайты)");
                dataGridView1.Columns.Add("ocenka_prepodovatela", "Оценка преподавателя");
                dataGridView1.Columns.Add("otziv_zavkaf", "Отзыв Зав. Кафедрой");
                dataGridView1.Columns.Add("otziv_practica", "Отзыв с практики");
                dataGridView1.Columns.Add("publications", "Публикации");
                dataGridView1.Columns.Add("patents", "Патенты");
                dataGridView1.Columns.Add("sertificates", "Сертификаты");
                dataGridView1.Columns.Add("projects", "Проекты");
                dataGridView1.Columns.Add("opit", "Есть опыт по специальности");
                dataGridView1.Columns.Add("hide_student_id", "Скрытый id студента");

                foreach (var fact in facts)
                {
                    dataGridView1.Rows.Add(
                        fact.dim_Student.fio_student,
                        fact.dim_datetime.month + " " + fact.dim_datetime.Year,
                        fact.prof_uspevaemost,
                        fact.neprof_uspevaemost,
                        fact.conference_count,
                        fact.olimp_prizer,
                        fact.olimp_winner,
                        fact.prof_sites,
                        fact.ocenka_prepodovatela,
                        fact.otziv_zavkaf,
                        fact.otziv_practica,
                        fact.publications,
                        fact.patents,
                        fact.sertificates,
                        fact.projects,
                        fact.opit,
                        fact.id_student
                        );
                }
                dataGridView1.ClearSelection();
                dataGridView1.Columns["hide_student_id"].Visible = false;
            }
        }

        //Вывести данные только по выбранному студенту
        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

            var selected = dataGridView1.CurrentRow.Cells[16].Value;
            
            if (selected != null)
            {

                var facts = SAA_Student.Fact.Where(fact => fact.fact_id == Convert.ToInt32(selected));

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("fio", "Ф.И.О");
                dataGridView1.Columns.Add("date", "Дата");
                dataGridView1.Columns.Add("prof_uspevaemost", "Профильная успеваемость");
                dataGridView1.Columns.Add("neprof_uspevaemost", "Непрофильная успеваемость");
                dataGridView1.Columns.Add("conference_count", "Конференции");
                dataGridView1.Columns.Add("olimp_prizer", "Олимпиады (Призёр)");
                dataGridView1.Columns.Add("olimp_winner", "Олимпиады (Победитель)");
                dataGridView1.Columns.Add("prof_sites", "Подписки (Сайты)");
                dataGridView1.Columns.Add("ocenka_prepodovatela", "Оценка преподавателя");
                dataGridView1.Columns.Add("otziv_zavkaf", "Отзыв Зав. Кафедрой");
                dataGridView1.Columns.Add("otziv_practica", "Отзыв с практики");
                dataGridView1.Columns.Add("publications", "Публикации");
                dataGridView1.Columns.Add("patents", "Патенты");
                dataGridView1.Columns.Add("sertificates", "Сертификаты");
                dataGridView1.Columns.Add("projects", "Проекты");
                dataGridView1.Columns.Add("opit", "Есть опыт работы по специальности");
                dataGridView1.Columns.Add("hide_student_id", "Есть опыт");

                foreach (var fact in facts)
                {
                    dataGridView1.Rows.Add(
                        fact.dim_datetime.month + " " + fact.dim_datetime.Year,
                        fact.prof_uspevaemost,
                        fact.neprof_uspevaemost,
                        fact.conference_count,
                        fact.olimp_prizer,
                        fact.olimp_winner,
                        fact.prof_sites,
                        fact.ocenka_prepodovatela,
                        fact.otziv_zavkaf,
                        fact.otziv_practica,
                        fact.publications,
                        fact.patents,
                        fact.sertificates,
                        fact.projects,
                        fact.opit,
                        fact.id_student
                        );
                }
                dataGridView1.ClearSelection();
                dataGridView1.Columns["hide_student_id"].Visible = false;
            }
        }

        //Нейро-анализ по выбранному(ым) студенту(ам)
        private void button3_Click(object sender, EventArgs e)
        {
            int isSelected = dataGridView1.SelectedRows.Count;
            if ( isSelected == 1) //Если выбран 1 студент
            {
                if(dataGridView1.CurrentRow.Cells.Count < 16) //Если это не список студентов, то прервать работу
                {
                    return;
                }

                int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[16].Value);

                LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

                var query = SAA_Student.Fact.Where(student => student.id_student == student_id);

                var list = new List<double>();
                var stud = new List<string>();

                foreach (var fact in query)
                {
                    list.Add(Convert.ToDouble(fact.prof_uspevaemost));
                    list.Add(Convert.ToDouble(fact.neprof_uspevaemost));
                    list.Add(Convert.ToDouble(fact.conference_count));
                    list.Add(Convert.ToDouble(fact.olimp_prizer));
                    list.Add(Convert.ToDouble(fact.olimp_winner));
                    list.Add(Convert.ToDouble(fact.prof_sites));
                    list.Add(Convert.ToDouble(fact.ocenka_prepodovatela));
                    list.Add(Convert.ToDouble(fact.otziv_zavkaf));
                    list.Add(Convert.ToDouble(fact.otziv_practica));
                    list.Add(Convert.ToDouble(fact.publications));
                    list.Add(Convert.ToDouble(fact.patents));
                    list.Add(Convert.ToDouble(fact.sertificates));
                    list.Add(Convert.ToDouble(fact.projects));
                    list.Add(Convert.ToDouble(fact.opit));

                    stud.Add(fact.dim_Student.fio_student);
                    stud.Add(fact.dim_Student.dim_Group.Name_Group);
                    stud.Add(fact.dim_Student.dim_Group.dim_Faculty.Name_Faculty);
                }

                string[] array;

                array = NeuralNetwork.analyse(list);

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("student","Студент");
                dataGridView1.Columns.Add("group", "Группа");
                dataGridView1.Columns.Add("faculty", "Факультет");
                dataGridView1.Columns.Add("faculty", "Результат");
                dataGridView1.Columns.Add("faculty", "Уверенность");

                dataGridView1.Rows.Add(stud[0], stud[1], stud[2], array[0], array[1]);
            }
            else if( isSelected > 1 ) //Если выбрано больше 1 строки
            {
                if (dataGridView1.CurrentRow.Cells.Count < 16)
                {
                    return;
                }


                /**
                 * Находим индексы всех выделенных студентов из списка
                 */
                var indexes = new List<int>();

                for (int i = 0; i < dataGridView1.RowCount; i++ )
                {
                    if (dataGridView1[16, i].Selected)
                    {
                        indexes.Add(Convert.ToInt32(dataGridView1[16, i].Value));
                    }
                }

                /*
                 * Готовить dataGridView для вывода данных 
                 */
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("student", "Студент");
                dataGridView1.Columns.Add("group", "Группа");
                dataGridView1.Columns.Add("faculty", "Факультет");
                dataGridView1.Columns.Add("faculty", "Результат");
                dataGridView1.Columns.Add("faculty", "Уверенность");

                /*
                 * Выводим результаты нейронной сети по каждому студенту в список
                 */
                foreach (int item in indexes)
                {
                    string id = item.ToString();

                    LtS_StudentDataContext SAA_Student = new LtS_StudentDataContext();

                    var query = SAA_Student.Fact.Where(student => student.id_student == Convert.ToInt32(id));

                    var list = new List<double>();
                    var stud = new List<string>();

                    foreach (var fact in query)
                    {
                        list.Add(Convert.ToDouble(fact.prof_uspevaemost));
                        list.Add(Convert.ToDouble(fact.neprof_uspevaemost));
                        list.Add(Convert.ToDouble(fact.conference_count));
                        list.Add(Convert.ToDouble(fact.olimp_prizer));
                        list.Add(Convert.ToDouble(fact.olimp_winner));
                        list.Add(Convert.ToDouble(fact.prof_sites));
                        list.Add(Convert.ToDouble(fact.ocenka_prepodovatela));
                        list.Add(Convert.ToDouble(fact.otziv_zavkaf));
                        list.Add(Convert.ToDouble(fact.otziv_practica));
                        list.Add(Convert.ToDouble(fact.publications));
                        list.Add(Convert.ToDouble(fact.patents));
                        list.Add(Convert.ToDouble(fact.sertificates));
                        list.Add(Convert.ToDouble(fact.projects));
                        list.Add(Convert.ToDouble(fact.opit));

                        stud.Add(fact.dim_Student.fio_student);
                        stud.Add(fact.dim_Student.dim_Group.Name_Group);
                        stud.Add(fact.dim_Student.dim_Group.dim_Faculty.Name_Faculty);
                    }

                    string[] array;

                    array = NeuralNetwork.analyse(list);

                    dataGridView1.Rows.Add(stud[0], stud[1], stud[2], array[0], array[1]);

                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана!", "Ошибка");
            }
        }

        private void факультетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFaculty form = new AddFaculty();

            form.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            dim_FacultyTableAdapter.Fill(sAA_StudentDataSet.dim_Faculty);
            this.cbFaculty.DataSource = this.dimFacultyBindingSource;
            cbFaculty.Refresh();

            dim_GroupTableAdapter.Fill(sAA_StudentDataSet.dim_Group);
            this.cbGroup.DataSource = this.fKDIMGROUFACULTYGDIMFACUBindingSource;
            cbGroup.Refresh();

            dim_StudentTableAdapter.Fill(sAA_StudentDataSet.dim_Student);
            this.cbStudent.DataSource = this.fKDIMSTUDGROUPSTUDIMGROUBindingSource;
            cbStudent.Refresh();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

        }

        private void группаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddGroup form = new AddGroup();

            form.Show();      
        }

        private void студентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();

            form.Show();
        }

        private void результатСрезаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFact form = new AddFact();
            form.Show();
        }
    }
}
