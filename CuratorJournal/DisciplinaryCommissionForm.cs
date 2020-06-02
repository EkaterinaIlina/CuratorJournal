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
    public partial class DisciplinaryCommissionForm : Form
    {
        Offense offense;
        public DisciplinaryCommissionForm()
        {
            InitializeComponent();
            fillOffence();
        }
        private void fillOffence()
        {
            dgvOffence.DataSource = DBobjects.Entities.Offense.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvOffence.Columns[0].Visible = false;
            dgvOffence.Columns[1].Visible = false;
            dgvOffence.Columns[2].HeaderText = "Дата проведения";
            dgvOffence.Columns[3].HeaderText = "Номер протокола";
            dgvOffence.Columns[4].HeaderText = "Причина обсуждения";
            dgvOffence.Columns[5].HeaderText = "Принятое решение";
            dgvOffence.Columns[6].Visible = false;
        }
        private void bAddOffence_Click(object sender, EventArgs e)
        {
            offense = new Offense();
            offense.idJournal = JournalForm.Journal.idJournal;
            offense.dateOffense = DateTime.Now.Date;
            bDelete.Visible = false;
            panelOffence.Visible = true;
            fillPanel();
        }
        private void fillPanel()
        {
            dateTimePickerOffence.Value = offense.dateOffense;
            tbDecision.Text = offense.decisionOffense;
            textBoxCause.Text = offense.causeOffense;
            textBoxNumberProt.Text = offense.numberProt;
        }

        private void dgvOffence_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                offense = (Offense)dgvOffence.Rows[e.RowIndex].DataBoundItem;
                fillPanel();
                panelOffence.Visible = true;
                bDelete.Visible = true;
            }
        }
        private void saveOffence()
        {
            if (DBobjects.Entities.Offense.Where(p => p.idOffense == offense.idOffense).Count() == 0)
                DBobjects.Entities.Offense.Add(offense);
            DBobjects.Entities.SaveChanges();
        }
        private void tbDecision_TextChanged(object sender, EventArgs e)
        {
            offense.decisionOffense = tbDecision.Text;
        }

        private void textBoxNumberProt_TextChanged(object sender, EventArgs e)
        {
            offense.numberProt = textBoxNumberProt.Text;
        }

        private void textBoxCause_TextChanged(object sender, EventArgs e)
        {
            offense.causeOffense = textBoxCause.Text;
        }

        private void dateTimePickerOffence_ValueChanged(object sender, EventArgs e)
        {
            offense.dateOffense = dateTimePickerOffence.Value.Date;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(offense.causeOffense)) || (String.IsNullOrWhiteSpace(offense.decisionOffense ))|| (String.IsNullOrWhiteSpace(offense.numberProt )))
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                saveOffence();
                fillOffence();
                MessageBox.Show("Сохранено");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                deleteOffence();
                fillOffence();
                MessageBox.Show("Удалено");
            }
        }
        private void deleteOffence()
        {
            if (DBobjects.Entities.Offense.Where(p => p.idOffense == offense.idOffense).Count() > 0)
            {
                DBobjects.Entities.Offense.Remove(offense);
                DBobjects.Entities.SaveChanges();
            }
        }
    }
}
