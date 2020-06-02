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
    public partial class TalcParentForm : Form
    {
        int idStudent;
        TalkParents talkParents;
        StructParentsTalc structParentsTalc;

        public TalcParentForm()
        {
            InitializeComponent();
            comboBoxStudent.DataSource = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            comboBoxStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxStudent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void bAddPrivTalc_Click(object sender, EventArgs e)
        {
            talkParents = new TalkParents();
            talkParents.dateTalkPar = DateTime.Now.Date;
            talkParents.idJournal = JournalForm.Journal.idJournal;
            buttonDelete.Visible = false;
            fillPanel();
        }

        private void dgvTopicTalc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                talkParents = (TalkParents)dgvTopicTalc.Rows[e.RowIndex].DataBoundItem;
                buttonDelete.Visible = true;
                fillPanel();
                comboBoxTopic.SelectedItem = talkParents.TopicTalkParents;
            }
        }
        private void fillPanel()
        {
            panelTalkParent.Visible = true;
            dateTimePickerTalkStudent.Value = talkParents.dateTalkPar;
            textBoxTopic.Text = talkParents.topicTalc;
            comboBoxTopic.DataSource = DBobjects.Entities.TopicTalkParents.ToList();
            fillKin();
            comboBoxTopic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTopic.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            idStudent = Convert.ToInt32(DBobjects.Entities.Student.FirstOrDefault(p => p.surnameStudent + " " + p.nameStudent == comboBoxStudent.Text).idStudent);
            filldgvTalcParent();
            panelTalkParent.Visible = false;
        }
        private void filldgvTalcParent()
        {
            dgvTopicTalc.DataSource = DBobjects.Entities.TalkParents.Where(p=>p.idJournal==JournalForm.Journal.idJournal).ToList(); 
            dgvTopicTalc.Columns[0].Visible = false;
            dgvTopicTalc.Columns[1].Visible = false;
            dgvTopicTalc.Columns[2].Visible = false;
            dgvTopicTalc.Columns[3].HeaderText = "Вопрос для обсуждения";
            dgvTopicTalc.Columns[4].HeaderText = "Дата проведения";
            dgvTopicTalc.Columns[7].HeaderText = "Тема обсуждения";
            dgvTopicTalc.Columns[5].Visible = false;
            dgvTopicTalc.Columns[6].Visible = false;

        }
        private void fillKin()
        {
            DataTable kinTable = new DataTable();
            DataColumn idKin = new DataColumn("idKin", Type.GetType("System.Int32"));
            DataColumn fioKin = new DataColumn("ФИО родственника", Type.GetType("System.String"));
            DataColumn status = new DataColumn("Статус родства", Type.GetType("System.String"));
            DataColumn uchactie = new DataColumn("Статус участия", Type.GetType("System.Boolean"));
            DataColumn idStructtalkParent = new DataColumn("idStructtalkParent", Type.GetType("System.Int32"));

            kinTable.Columns.Add(idKin);
            kinTable.Columns.Add(fioKin);
            kinTable.Columns.Add(status);
            kinTable.Columns.Add(uchactie);
            kinTable.Columns.Add(idStructtalkParent);

            foreach (Kin kin in DBobjects.Entities.Kin.Where(p => p.idStudent == idStudent && (p.kinStatus == "Мать" || p.kinStatus == "Отец" || p.kinStatus == "Опекун")))
            {
                if (DBobjects.Entities.StructParentsTalc.Where(p=>p.idKin==kin.idKin&& p.idTalkParents == talkParents.idTalkPar).Count() > 0)
                {
                    kinTable.Rows.Add(kin.idKin, kin, kin.kinStatus, true, DBobjects.Entities.StructParentsTalc.FirstOrDefault(p => p.idKin == kin.idKin && p.idTalkParents == talkParents.idTalkPar).idStructParentsTalc);
                }
                else
                    kinTable.Rows.Add(kin.idKin, kin, kin.kinStatus, false, 0);

            }
            dataGridViewKin.DataSource = kinTable;
            dataGridViewKin.Columns["idKin"].Visible = false;
            dataGridViewKin.Columns["idStructtalkParent"].Visible = false;
            dataGridViewKin.Columns["ФИО родственника"].ReadOnly = true;
            dataGridViewKin.Columns["Статус родства"].ReadOnly = true;
        }

        private void saveKin()
        {
            foreach (DataGridViewRow dgvr in dataGridViewKin.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[4].Value) == 0)
                    structParentsTalc = new StructParentsTalc();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[4].Value);
                    structParentsTalc = DBobjects.Entities.StructParentsTalc.FirstOrDefault(p => p.idStructParentsTalc == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[3].Value) == true)
                {
                    structParentsTalc.idTalkParents = talkParents.idTalkPar;
                    structParentsTalc.idKin = Convert.ToInt32(dgvr.Cells[0].Value);
                    if (DBobjects.Entities.StructParentsTalc.Where(p => p.idStructParentsTalc == structParentsTalc.idStructParentsTalc).Count() == 0)
                        DBobjects.Entities.StructParentsTalc.Add(structParentsTalc);
                    DBobjects.Entities.SaveChanges();
                }
                else if (structParentsTalc.idStructParentsTalc != 0 && Convert.ToBoolean(dgvr.Cells[3].Value) == false)
                    deleteStructParents();
            }
        }
        private void deleteStructParents()
        {
            if(structParentsTalc!=null)
            DBobjects.Entities.StructParentsTalc.Remove(structParentsTalc);
            DBobjects.Entities.SaveChanges();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        { 
            
            saveTalkParent();
            saveKin();
            MessageBox.Show("Сохранено");
            filldgvTalcParent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgvr in dataGridViewKin.Rows)
                {
                    int id = Convert.ToInt32(dgvr.Cells[4].Value);
                    structParentsTalc = DBobjects.Entities.StructParentsTalc.FirstOrDefault(p => p.idStructParentsTalc == id);
                    if (talkParents != null)
                        deleteStructParents();
                }
                DeletePrivTalk();
                filldgvTalcParent();
            }
        }
        private void saveTalkParent()
        {
            talkParents.idTopTPar = DBobjects.Entities.TopicTalkParents.FirstOrDefault(p => p.nameTopTPar == comboBoxTopic.Text).idTopTPar;
            talkParents.topicTalc = textBoxTopic.Text;
            talkParents.dateTalkPar = dateTimePickerTalkStudent.Value.Date;
            talkParents.idJournal = JournalForm.Journal.idJournal;
            if ((String.IsNullOrWhiteSpace(talkParents.topicTalc )) || talkParents.idTopTPar != 0)
            {
                if (DBobjects.Entities.TalkParents.Where(p => p.idTalkPar == talkParents.idTalkPar).Count() == 0)
                    DBobjects.Entities.TalkParents.Add(talkParents);
                DBobjects.Entities.SaveChanges();
            }
        }

        private void DeletePrivTalk()
        {
            if(DBobjects.Entities.TalkParents.Where(p=>p.idTalkPar==talkParents.idTalkPar).Count()>0)
            DBobjects.Entities.TalkParents.Remove(talkParents);
            DBobjects.Entities.SaveChanges();
        }
    }
}

