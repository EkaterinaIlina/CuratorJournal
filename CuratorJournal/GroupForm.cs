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
    public partial class GroupForm : Form
    {
        Group group;
        Journal journal;
        bool flag;
        DateTime date = new DateTime(DateTime.Now.Year, 9, 1);
        public GroupForm(int idCurator)
        {
            InitializeComponent();
            flag = true;
            group = new Group();
            journal = new Journal();
            panel1.Visible = true;
            journal.idCurator = idCurator;
            dateTimePickerYear.Value = date;
        }

        public GroupForm(Group GROUP)
        {
            InitializeComponent();
            lTitle.Text = "Редактирование группы";
            bEdition.Text = "Сохранить";
            bDelete.Visible = true;
            group = GROUP;
            Fill();
            flag = false;
        }

        private void Fill()
        {
            tbInstitute.Text = group.institute;
            tbDepartment.Text = group.department;
            tbNumberGroup.Text = group.numberGroup;
            maskedtbSipher.Text = group.cipher;
            tbSpecialty.Text = group.specialtyGroup;
        }
        private void SaveGroup()
        {
                if (DBobjects.Entities.Group.Where(p => p.idGroup == group.idGroup).Count() == 0)
                {
                    DBobjects.Entities.Group.Add(group);
                }
                if (flag != true)
                    MessageBox.Show("Сохранено");
                DBobjects.Entities.SaveChanges();
                if (flag == true)
                {
                    SaveJournal();
                }
            
}
        private  void SaveJournal()
        {
                journal.idGroup = group.idGroup;
                journal.courceGroup = Convert.ToInt32(numericUpDownKurs.Value);
                journal.yearJournal = Convert.ToDateTime(dateTimePickerYear.Value.Date);
                DBobjects.Entities.Journal.Add(journal);
                DBobjects.Entities.SaveChanges();
        }
        private void bEdition_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(group.institute)|| String.IsNullOrWhiteSpace(group.numberGroup)|| String.IsNullOrWhiteSpace(group.cipher ) || String.IsNullOrWhiteSpace(group.specialtyGroup ) )
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                SaveGroup();
                this.FormClosing -= GroupForm_FormClosing;
                this.Close();
            }
        }
        private void Delete()
        {
            if (DBobjects.Entities.Group.Where(p => p.idGroup == group.idGroup).Count() > 0)
            {
                DBobjects.Entities.Group.Remove(group);
                DBobjects.Entities.SaveChanges();               
                MessageBox.Show("Удалено");
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Delete();
                this.FormClosing -= GroupForm_FormClosing;
                this.Close();
            }
        }

        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Сохранить изменения?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveGroup();
           }
        }

        private void tbInstitute_TextChanged(object sender, EventArgs e)
        {
            group.institute = tbInstitute.Text.Trim();           
        }

        private void tbDepartment_TextChanged(object sender, EventArgs e)
        {
            group.department = tbDepartment.Text.Trim();       
        }

        private void tbNumberGroup_TextChanged(object sender, EventArgs e)
        {
            group.numberGroup = tbNumberGroup.Text.Trim();
        }

        private void tbSpecialty_TextChanged(object sender, EventArgs e)
        {
            group.specialtyGroup = tbSpecialty.Text.Trim();
        }

        private void maskedtbSipher_TextChanged(object sender, EventArgs e)
        {
            group.cipher = maskedtbSipher.Text;
            group.cipher = group.cipher.Replace(',', '.');
        }
    }
}
