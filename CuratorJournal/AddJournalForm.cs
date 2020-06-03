using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;


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
        private void printJournal()
        {
            this.Cursor = Cursors.WaitCursor;
            //Объект приложения word
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = null;
            //Путь к файлу
            object pathFile = "E:\\zhurnal.docx";
            object missing = Type.Missing;
            try
            {
                //Загружаем документ
                document = application.Documents.Add(ref pathFile, ref missing, ref missing, ref missing);
            }
            catch (Exception error)
            {
                document.Close(ref missing, ref missing, ref missing);
                application.Quit(ref missing, ref missing, ref missing);
                document = null;
                application = null;
                throw error;
            }

            //Очищаем параметры поиска
            // ???????
            application.Selection.Find.ClearFormatting();
            application.Selection.Find.Replacement.ClearFormatting();

            //Замена значений
             RPS("-куратор-", Journal.Curator.ToString(), application, missing);
             RPS("-должность-", Journal.Curator.positionCurator, application, missing);
             RPS("-группа-", Journal.Group.numberGroup, application, missing);
             RPS("-курс-", Journal.courceGroup.ToString(), application, missing);
             RPS("-шифр-", Journal.Group.cipher.ToString(), application, missing);
             RPS("-учебный год-", Journal.yearJournal.Year.ToString() + "/" + Journal.yearJournal.AddYears(1).Year, application, missing);
             RPS("-специальность-", Journal.Group.specialtyGroup, application, missing);
             Microsoft.Office.Interop.Word.Table tableStatus = application.ActiveDocument.Tables[5];
            Microsoft.Office.Interop.Word.Table tableInfSt = application.ActiveDocument.Tables[6];
            int jTableSt = 1;
            int jTableInf = 2;
            foreach (JournalStudent journalStudent in DBobjects.Entities.JournalStudent.Where(p=>p.idJournal==Journal.idJournal).ToList())
            {
                if (journalStudent.StatusStudent.nameSatusSt != "Нет")
                {
                    if (jTableSt > 1) tableStatus.Rows.Add(ref missing);
                    tableStatus.Rows[jTableSt].Cells[1].Range.Text = jTableSt.ToString()+".";
                    tableStatus.Rows[jTableSt].Cells[2].Range.Text = journalStudent.StatusStudent.nameSatusSt;
                    tableStatus.Rows[jTableSt].Cells[3].Range.Text = journalStudent.Student.ToString();
                    jTableSt++;
                }
                if (jTableInf > 2) tableInfSt.Rows.Add(ref missing);
            }

                saveFileDialogJournal.FileName = "Журнал группы " + Journal.Group.numberGroup + " за " + Journal.courceGroup.ToString() +" курс.docx";
              if (saveFileDialogJournal.ShowDialog() == DialogResult.Cancel) return;
              // получаем выбранный файл 
              object SaveAsFile = saveFileDialogJournal.FileName;
              document.SaveAs2(SaveAsFile, missing, missing, missing);
            document.Close(ref missing, ref missing, ref missing);
            application.Quit(ref missing, ref missing, ref missing);
            document = null;
           // application = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
              application = null;
              //Открываем документ для просмотра.
              System.Diagnostics.Process.Start(SaveAsFile.ToString());
 
            this.Cursor = Cursors.Default;
        }
        private void RPS(string stubTR, string text, Word.Application app, object missing)
        {
            object findText = stubTR;
            object replaceWith = text;
            object replace = 2;
            app.Selection.Find.Execute(ref findText, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceWith,
            ref replace, ref missing, ref missing, ref missing, ref missing);
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

        private void buttonPrintJournal_Click(object sender, EventArgs e)
        {
            printJournal();
        }
    }
}
