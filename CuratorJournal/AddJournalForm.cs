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
    public partial class AddJournalForm : Form
    {
        public Journal Journal;

        public AddJournalForm()
        {
            InitializeComponent();
            Journal = JournalForm.Journal;
            FillJournal();
        }

        private void FillJournal()
        {
            DateTime date = new DateTime(DateTime.Now.Year, 9, 1);            
            lGroup.Text = DBobjects.Entities.Group.FirstOrDefault(p=>p.idGroup==Journal.idGroup).numberGroup;
            lCurator.Text = DBobjects.Entities.Curator.FirstOrDefault(p => p.idCurator == Journal.idCurator).ToString();
            if (Journal.courceGroup!=0)
                numericUpDownKurs.Value = Journal.courceGroup;
            if (Journal.yearJournal.ToString() != "01.01.0001 0:00:00")
                dateTimePickerJournal.Value = Journal.yearJournal;
            else
                dateTimePickerJournal.Value = date;
            if (Journal.idJournal != 0)
            {
                buttonDelete.Visible = true;
                buttonPrintJournal.Visible = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { 
            SaveJournal();
        }

        private void SaveJournal()
        {
            if (Journal.courceGroup == 0)
                Journal.courceGroup = 1;
            if(DBobjects.Entities.Journal.Where(p=> p.idJournal == Journal.idJournal).Count() == 0)
            {
                if (DBobjects.Entities.Journal.Where(p => p.idCurator == Journal.idCurator && p.idGroup == Journal.idGroup && p.courceGroup == Journal.courceGroup).Count() == 0)
                {
                    DBobjects.Entities.Journal.Add(Journal);
                    buttonDelete.Visible = true;
                    buttonPrintJournal.Visible = true;
                }
                else if (DBobjects.Entities.Journal.Where(p => p.idCurator == Journal.idCurator && p.idGroup == Journal.idGroup && p.courceGroup == Journal.courceGroup).Count() > 0 && Journal.idJournal == 0)
                    MessageBox.Show("Журнал на данный курс уже есть");
            }
            DBobjects.Entities.SaveChanges();
        }
        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            Journal.courceGroup = Convert.ToInt32(numericUpDownKurs.Value);
        }

        private void dateTimePickerJournal_ValueChanged(object sender, EventArgs e)
        {
            Journal.yearJournal = dateTimePickerJournal.Value.Date;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DeleteJournal();
            }
        }

        private void DeleteJournal()
        {
            if (DBobjects.Entities.Journal.Where(p => p.idJournal == Journal.idJournal).Count() > 0)
            {
                DBobjects.Entities.Journal.Remove(Journal);
                DBobjects.Entities.SaveChanges();
                MessageBox.Show("Удалено");

            }
        }
    }
}
