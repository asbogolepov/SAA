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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUser(tbLogin.Text, tbPassword.Text);
        }

       

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUser(tbLogin.Text, tbPassword.Text);
            }
        }

        private void tbLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUser(tbLogin.Text, tbPassword.Text);
            }
        }

        private void CheckUser(string nickname, string password)
        {
            LtS_SystemDataContext SAA_System = new LtS_SystemDataContext();

            var query = SAA_System.user.Where(user => user.nickname == nickname && user.password == password);

            foreach (var user in query)
            {
                ActiveUser.Id = user.id;
                ActiveUser.Nickname = user.nickname;
                ActiveUser.Password = user.password;
                ActiveUser.Role = user.role;
            }

            if (ActiveUser.Nickname != null)
            {
                Desktop dt = new Desktop();
                dt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не верные логин и/или пароль!", "Отказано в доступе");
                btnLogin.Select();
            }
        }
    }
}
