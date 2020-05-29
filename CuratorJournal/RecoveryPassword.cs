using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuratorJournal
{
    public partial class RecoveryPassword : Form
    {
        ICollection<Curator> users;
        Curator curator;
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOnward_Click(object sender, EventArgs e)
        {
            users = DBobjects.Entities.Curator.ToList();
            if (users.Where(p => p.login == tbLogin.Text.Trim()).Count() > 0)
            {
                panelRecovery.Visible = true;
                curator =DBobjects.Entities.Curator.Where(p => p.login == tbLogin.Text.Trim()).FirstOrDefault();
                tbQuestion.Text = curator.question.ToString();
            }
            else
            {
                panelRecovery.Visible = false;
                MessageBox.Show("Данный логин не найден");
            }
        }

        private void bOnwardCheck_Click(object sender, EventArgs e)
        {
            if (curator.ansver == tbAnswer.Text)
            {
                Registration registration = new Registration(curator);
                registration.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не правильный ответ");
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            panelRecovery.Visible = false;
        }
    }
}
