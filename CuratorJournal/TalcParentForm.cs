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
        int idTalkParents;
        DataTable kinTable = new DataTable();
        TalkParents talkParents;
        public TalcParentForm()
        {
            InitializeComponent();
            fillStudent();
        }
        private void fillStudent()
        {
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
            idTalkParents = 0;
            fillPanel();
        }

        private void dgvTopicTalc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                talkParents = (TalkParents)dgvTopicTalc.Rows[e.RowIndex].DataBoundItem;
                idTalkParents = talkParents.idTalkPar;
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
            comboBoxStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxStudent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            idStudent = Convert.ToInt32(DBobjects.Entities.Student.FirstOrDefault(p => p.surnameStudent + " " + p.nameStudent == comboBoxStudent.Text).idStudent);
            filldgvTalcParent();
            panelTalkParent.Visible = false;
        }
        private void filldgvTalcParent()
        {
            dgvTopicTalc.DataSource = DBobjects.Entities.TalkParents.Where(p => p.Kin.idStudent == idStudent && p.idJournal == JournalForm.Journal.idJournal).ToList();
            //foreach
        }
        private void fillKin()
        {
            DataColumn idKin = new DataColumn("idKin", Type.GetType("System.Int32"));
            DataColumn fioKin = new DataColumn("ФИО родственника", Type.GetType("System.String"));
            DataColumn status = new DataColumn("Статус родства", Type.GetType("System.String"));
            DataColumn uchactie = new DataColumn("Статус участия", Type.GetType("System.Boolean"));
            DataColumn idtalkParent = new DataColumn("idTalkParent", Type.GetType("System.Int32"));

            kinTable.Columns.Add(idKin);
            kinTable.Columns.Add(fioKin);
            kinTable.Columns.Add(status);
            kinTable.Columns.Add(uchactie);
            kinTable.Columns.Add(idtalkParent);


            dataGridViewKin.DataSource = kinTable;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveTalkParent();
            MessageBox.Show("Сохранено");
            filldgvTalcParent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewKin.Rows)
            {
                int id = Convert.ToInt32(dgvr.Cells[4].Value);
                talkParents = DBobjects.Entities.TalkParents.FirstOrDefault(p => p.idTalkPar == id);
                if(talkParents!=null)
                DeletePrivTalk();
            }
            filldgvTalcParent();
        }
        private void saveTalkParent()
        {
            foreach (DataGridViewRow dgvr in dataGridViewKin.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[4].Value) == 0)
                    talkParents = new TalkParents();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[4].Value);
                    talkParents = DBobjects.Entities.TalkParents.FirstOrDefault(p => p.idTalkPar == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[3].Value) == true)
                {
                    if(DBobjects.Entities.TopicTalkParents.Where(p => p.nameTopTPar == comboBoxTopic.Text).Count()>0)

                    talkParents.idTopTPar = DBobjects.Entities.TopicTalkParents.FirstOrDefault(p => p.nameTopTPar == comboBoxTopic.Text).idTopTPar;
                    talkParents.topicTalc = textBoxTopic.Text;
                    talkParents.dateTalkPar = dateTimePickerTalkStudent.Value.Date;
                    talkParents.idKin = Convert.ToInt32(dgvr.Cells[0].Value);
                    talkParents.idJournal = JournalForm.Journal.idJournal;
                    if (DBobjects.Entities.TalkParents.Where(p => p.idTalkPar == talkParents.idTalkPar).Count() == 0)
                        DBobjects.Entities.TalkParents.Add(talkParents);
                    DBobjects.Entities.SaveChanges();
                }
                else if (talkParents.idTalkPar != 0 && Convert.ToBoolean(dgvr.Cells[3].Value) == false)
                    DeletePrivTalk();
            }
        }
        private void DeletePrivTalk()
        {
            DBobjects.Entities.TalkParents.Remove(talkParents);
            DBobjects.Entities.SaveChanges();
        }

    }
}
