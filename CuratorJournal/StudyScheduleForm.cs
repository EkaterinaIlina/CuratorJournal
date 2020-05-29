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
    public partial class StudyScheduleForm : Form
    {
        DateTime date = DateTime.Now;
        StudyingProcess studyingProcessOne;
        StudyingProcess studyingProcessTwo;

        public StudyScheduleForm()
        {
            InitializeComponent();
            if (DBobjects.Entities.StudyingProcess.Where(p => p.idJournal == JournalForm.Journal.idJournal && p.semester == 1).Count() > 0)
            {
                studyingProcessOne = DBobjects.Entities.StudyingProcess.FirstOrDefault(p => p.idJournal == JournalForm.Journal.idJournal && p.semester == 1);
            }
            else
            {
                studyingProcessOne = new StudyingProcess();
                studyingProcessOne.practiceProductEnd =date.Date;
                studyingProcessOne.practiceTrainEnd =  date.Date;
                studyingProcessOne.practiceTrainStart = date.Date;
                studyingProcessOne.holidaysStart = date.Date;
                studyingProcessOne.holidaysEnd = date.Date;
                studyingProcessOne.sessionEnd = date.Date;
                studyingProcessOne.sessionStart = date.Date;
                studyingProcessOne.semesterEnd = date.Date;
                studyingProcessOne.semesterStart = date.Date;
                studyingProcessOne.practiceProductStart = date.Date;
            }
                
            if (DBobjects.Entities.StudyingProcess.Where(p => p.idJournal == JournalForm.Journal.idJournal && p.semester == 2).Count() > 0)
                studyingProcessTwo = DBobjects.Entities.StudyingProcess.FirstOrDefault(p => p.idJournal == JournalForm.Journal.idJournal && p.semester == 2);
            else
            {
                studyingProcessTwo = new StudyingProcess();
                studyingProcessTwo.practiceProductEnd = date.Date;
                studyingProcessTwo.practiceTrainEnd = date.Date;
                studyingProcessTwo.practiceTrainStart = date.Date;
                studyingProcessTwo.holidaysStart = date.Date;
                studyingProcessTwo.holidaysEnd = date.Date;
                studyingProcessTwo.sessionEnd = date.Date;
                studyingProcessTwo.sessionStart = date.Date;
                studyingProcessTwo.semesterEnd = date.Date;
                studyingProcessTwo.semesterStart = date.Date;
                studyingProcessTwo.practiceProductStart = date.Date;
            }               
            FillOne();
            FillTwo();
        }
        private void FillOne()
        {
            dateTimePickerSemS.Value = studyingProcessOne.semesterStart.Date;
            dateTimePickerSemF.Value = studyingProcessOne.semesterEnd.Date;
            dateTimePickerSessionS.Value = studyingProcessOne.sessionStart.Date;
            dateTimePickerSessionF.Value = studyingProcessOne.sessionEnd.Date;
            dateTimePickerHolidaysS.Value = studyingProcessOne.holidaysStart.Date;
            dateTimePickerHolidaysF.Value = studyingProcessOne.holidaysEnd.Date;
            if (studyingProcessOne.practiceTrainStart != null)
            {
                checkBoxTrain.Checked = true;
                dateTimePickerTrainingS.Value = Convert.ToDateTime(studyingProcessOne.practiceTrainStart).Date;
                dateTimePickerTrainingF.Value = Convert.ToDateTime(studyingProcessOne.practiceTrainEnd).Date;
            }
            else
            {
                checkBoxTrain.Checked = false;
                dateTimePickerTrainingS.Value = date.Date;
                dateTimePickerTrainingF.Value = date.Date;
            }
            if (studyingProcessOne.practiceProductStart != null)
            {
                checkBoxProduct.Checked = true;
                dateTimePickerProductF.Value = Convert.ToDateTime(studyingProcessOne.practiceProductStart).Date;
                dateTimePickerProductS.Value = Convert.ToDateTime(studyingProcessOne.practiceProductEnd).Date;
            }
            else
            {
                checkBoxProduct.Checked = false;
                dateTimePickerProductF.Value = date.Date;
                dateTimePickerProductS.Value = date.Date;
            }
        }
        private void FillTwo()
        {
            dateTimePickerSemestrTwoS.Value = studyingProcessTwo.semesterStart.Date;
            dateTimePickerSemestrTwoF.Value = studyingProcessTwo.semesterEnd.Date;
            dateTimePickerSessionTwoS.Value = studyingProcessTwo.sessionStart.Date;
            dateTimePickerSessionTwoF.Value = studyingProcessTwo.sessionEnd.Date;
            dateTimePickerHolidayTwoS.Value = studyingProcessTwo.holidaysStart.Date;
            dateTimePickerHolidayTwoF.Value = studyingProcessTwo.holidaysEnd.Date;
            if (studyingProcessTwo.practiceTrainStart != null)
            {
                checkBoxTrainTwo.Checked = true;
                dateTimePickerTrainTwoS.Value = Convert.ToDateTime(studyingProcessTwo.practiceTrainStart).Date;
                dateTimePickerTrainTwoF.Value = Convert.ToDateTime(studyingProcessTwo.practiceTrainEnd).Date;
            }
            else
            {
                checkBoxTrainTwo.Checked = false;
                dateTimePickerTrainTwoS.Value = date.Date;
                dateTimePickerTrainTwoF.Value = date.Date;
            }
            if (studyingProcessTwo.practiceProductStart != null)
            {
                checkBoxProductTwo.Checked = true;
                dateTimePickerProductTwoF.Value = Convert.ToDateTime(studyingProcessTwo.practiceProductStart).Date;
                dateTimePickerProductTwoS.Value = Convert.ToDateTime(studyingProcessTwo.practiceProductEnd).Date;
            }
            else
            {
                checkBoxProductTwo.Checked = false;
                dateTimePickerProductF.Value = date.Date;
                dateTimePickerProductS.Value = date.Date;
            }
        }

        private void checkBoxTrain_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrain.Checked == true)
                tableLayoutPanelTrainingPractice.Visible = true;
            else
                tableLayoutPanelTrainingPractice.Visible = false;
        }

        private void checkBoxProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProduct.Checked == true)
                tableLayoutPanelProductPractice.Visible = true;
            else
                tableLayoutPanelProductPractice.Visible = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            studyingProcessOne.practiceProductEnd = dateTimePickerProductF.Value.Date;
            studyingProcessOne.practiceTrainEnd = dateTimePickerTrainingF.Value.Date;
            studyingProcessOne.practiceTrainStart = dateTimePickerTrainingS.Value.Date;
            studyingProcessOne.holidaysStart = dateTimePickerHolidaysS.Value.Date;
            studyingProcessOne.holidaysEnd = dateTimePickerHolidaysF.Value.Date;
            studyingProcessOne.sessionEnd = dateTimePickerSessionF.Value.Date;
            studyingProcessOne.sessionStart = dateTimePickerSessionS.Value.Date;
            studyingProcessOne.semesterEnd = dateTimePickerSemF.Value.Date;
            studyingProcessOne.practiceProductStart = dateTimePickerProductS.Value.Date;
            studyingProcessOne.semesterStart = dateTimePickerSemS.Value.Date;

            studyingProcessTwo.practiceProductEnd = dateTimePickerProductTwoF.Value.Date;
            studyingProcessTwo.practiceTrainEnd = dateTimePickerTrainTwoF.Value.Date;
            studyingProcessTwo.practiceTrainStart = dateTimePickerTrainTwoS.Value.Date;
            studyingProcessTwo.holidaysStart = dateTimePickerHolidayTwoS.Value.Date;
            studyingProcessTwo.holidaysEnd = dateTimePickerHolidayTwoF.Value.Date;
            studyingProcessTwo.sessionEnd = dateTimePickerSessionTwoF.Value.Date;
            studyingProcessTwo.sessionStart = dateTimePickerSessionTwoS.Value.Date;
            studyingProcessTwo.semesterEnd = dateTimePickerSemestrTwoF.Value.Date;
            studyingProcessTwo.practiceProductStart = dateTimePickerProductTwoS.Value.Date;
            studyingProcessTwo.semesterStart = dateTimePickerSemestrTwoS.Value.Date;
            SaveProcess();
            MessageBox.Show("Сохранено");
        }

        private void checkBoxTrainTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrainTwo.Checked == true)
                tableLayoutPanelTrainingPracticeTwo.Visible = true;
            else
                tableLayoutPanelTrainingPracticeTwo.Visible = false;
        }

        private void checkBoxProductTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProductTwo.Checked == true)
                tableLayoutPanelProductPracticeTwo.Visible = true;
            else
                tableLayoutPanelProductPracticeTwo.Visible = false;
        }
        private void SaveProcess()
        {
            studyingProcessOne.idJournal = JournalForm.Journal.idJournal;
            studyingProcessOne.semester = 1;
            if (checkBoxTrain.Checked == false)
            {
                studyingProcessOne.practiceTrainStart = null;
                studyingProcessOne.practiceTrainEnd = null;
            }
            if (checkBoxProduct.Checked == false)
            {
                studyingProcessOne.practiceProductStart = null;
                studyingProcessOne.practiceProductEnd = null;
            }
            if (DBobjects.Entities.StudyingProcess.Where(p => p.idStudyingProcess == studyingProcessOne.idStudyingProcess).Count() == 0)
                DBobjects.Entities.StudyingProcess.Add(studyingProcessOne);
            DBobjects.Entities.SaveChanges();

            studyingProcessTwo.idJournal = JournalForm.Journal.idJournal;
            studyingProcessTwo.semester = 2;
            if (checkBoxTrainTwo.Checked == false)
            {
                studyingProcessTwo.practiceTrainStart = null;
                studyingProcessTwo.practiceTrainEnd = null;
            }
            if (checkBoxProductTwo.Checked == false)
            {
                studyingProcessTwo.practiceProductStart = null;
                studyingProcessTwo.practiceProductEnd = null;
            }
            if (DBobjects.Entities.StudyingProcess.Where(p => p.idStudyingProcess == studyingProcessTwo.idStudyingProcess).Count() == 0)
                DBobjects.Entities.StudyingProcess.Add(studyingProcessTwo);
            DBobjects.Entities.SaveChanges();
        }
    }
}
