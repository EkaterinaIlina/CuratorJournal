using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CuratorJournal
{
    public partial class Registration : Form
    {
        private Curator curator;
        bool flag;
        public Registration()
        {
            InitializeComponent();
            curator = new Curator();
            flag = false;          
        }
        public Registration(Curator CURATOR)
        {
            InitializeComponent();
            curator = CURATOR;
            flag = true;
            Fill();
        }
        private void Fill()
        {
            lTitle.Text = "Редактирование учетной записи";
            bRegistration.Text = "Сохранить";
            tbSurname.Text = curator.surnameCurator;
            tbName.Text = curator.nameCurator;
            tbPathr.Text = curator.patronymicCurator;
            tbPosition.Text = curator.positionCurator;
            tbLogin.Text = curator.login;
            tbQuestion.Text = curator.question;
            tbAnswer.Text = curator.ansver;
        }
        private void Save()
        {
            if (DBobjects.Entities.Curator.Where(p => p.login == curator.login).Count() == 0 && flag == false)
            {
                DBobjects.Entities.Curator.Add(curator);
                DBobjects.Entities.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен");
                this.Close();
            }
            else if (DBobjects.Entities.Curator.Where(p => p.login == curator.login).Count() > 0 && flag == true)
            {
                DBobjects.Entities.SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            else if (DBobjects.Entities.Curator.Where(p => p.login == curator.login).Count() == 0 && flag == true)
            {
                DBobjects.Entities.SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            else if (DBobjects.Entities.Curator.Where(p => p.login == curator.login).Count() > 0 && flag == false)
            {
                MessageBox.Show("Такой пользователь уже есть");
            }
        }
        public static string GetEncodedHash(string password)
        {
            byte[] data = Encoding.Default.GetBytes(password);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] result = sha.ComputeHash(data);
            password = Convert.ToBase64String(result);
            return password;
        }

        private void bRegistration_Click(object sender, EventArgs e)
        {
            curator.surnameCurator = (tbSurname.Text.Trim());
            curator.nameCurator = (tbName.Text.Trim());
            curator.patronymicCurator = (tbPathr.Text.Trim());
            curator.positionCurator = (tbPosition.Text.Trim());
            curator.login = (tbLogin.Text.Trim());
            curator.password = (GetEncodedHash(tbPassword.Text).Trim());
            curator.question = (tbQuestion.Text.Trim());
            curator.ansver = (tbAnswer.Text.Trim());
            if (String.IsNullOrWhiteSpace(curator.surnameCurator ) || String.IsNullOrWhiteSpace(curator.nameCurator ) || String.IsNullOrWhiteSpace(curator.positionCurator ) || String.IsNullOrWhiteSpace(curator.login )|| String.IsNullOrWhiteSpace(curator.password ) || String.IsNullOrWhiteSpace(curator.question ) || String.IsNullOrWhiteSpace(curator.ansver ))
                MessageBox.Show("Заполните обязательные поля");
            else             
                Save();                
        }

     }
}


