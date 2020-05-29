using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CuratorJournal
{
    public partial class Authorization : Form
    {
        ICollection<Curator> users;
        public Curator Cur { get; private set; }
        public Authorization()
        {
            InitializeComponent();
            this.FormClosed += CloseForm;

        }
        private void linkLReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Registration formReg = new Registration();
            formReg.ShowDialog();
        }
       private void CloseForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.FormClosed -= CloseForm;
                    form.FormClosed += CloseForm;
                }
            }
            else
                Application.ExitThread();
        }
        string GetEncodedHash(string password)
        {
            byte[] data = Encoding.Default.GetBytes(password);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] result = sha.ComputeHash(data);
            password = Convert.ToBase64String(result);
            return password;
        }
        private void bEnter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            users = DBobjects.Entities.Curator.ToList();            
            if (users.Where(p => p.login == tbLogin.Text.Trim() && p.password == GetEncodedHash(tbPassword.Text.Trim())).Count() > 0)
            {
                Cur = (Curator)DBobjects.Entities.Curator.Where(p => p.login == tbLogin.Text.Trim()).FirstOrDefault();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль");
                this.Cursor = Cursors.Default;
            }
        }

        private void linkLabelRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryPassword form = new RecoveryPassword();
            form.ShowDialog();
        }

       
    }
}

