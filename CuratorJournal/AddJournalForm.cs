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
            Object falseObj = false;

            try
            {
                //Загружаем документ
                document = application.Documents.Add(ref pathFile, ref missing, ref missing, ref missing);
            

            //Очищаем параметры поиска
            // ???????
            application.Selection.Find.ClearFormatting();
            application.Selection.Find.Replacement.ClearFormatting();

            //Замена значений
             RPS("@куратор", Journal.Curator.ToString(), application, missing);
             RPS("@должность", Journal.Curator.positionCurator, application, missing);
             RPS("@группа", Journal.Group.numberGroup, application, missing);
             RPS("@курс", Journal.courceGroup.ToString(), application, missing);
             RPS("@шифр", Journal.Group.cipher.ToString(), application, missing);
             RPS("@учебный год", Journal.yearJournal.Year.ToString() + "/" + Journal.yearJournal.AddYears(1).Year, application, missing);
             RPS("@специальность", Journal.Group.specialtyGroup, application, missing);
             Microsoft.Office.Interop.Word.Table tableStatus = application.ActiveDocument.Tables[5];            
            Microsoft.Office.Interop.Word.Table tableStipendia = application.ActiveDocument.Tables[7];

            int jTableSt = 1;
            int jTableStip = 2;
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
                if (jTableStip > 2) tableStipendia.Rows.Add(ref missing);
                tableStipendia.Rows[jTableStip].Cells[2].Range.Text = journalStudent.Student.surnameStudent + " " + journalStudent.Student.nameStudent + " " + journalStudent.Student.patronymicStudent;
                    if (journalStudent.stipendSemOne == true)
                    tableStipendia.Rows[jTableStip].Cells[3].Range.Text = "+";
                if (journalStudent.stipendSemTwo == true)
                    tableStipendia.Rows[jTableStip].Cells[4].Range.Text = "+";
                jTableStip++;
            }
            Microsoft.Office.Interop.Word.Table tableInfSt = application.ActiveDocument.Tables[6];
            int jTableInfStud = 2;
            Microsoft.Office.Interop.Word.Table tableVladimir = application.ActiveDocument.Tables[8];
            int jTableVladimir = 2;
            Microsoft.Office.Interop.Word.Table tableInogor = application.ActiveDocument.Tables[9];
            int jTableInogor = 2;
            Microsoft.Office.Interop.Word.Table tablefamilyChild = application.ActiveDocument.Tables[10];
            int jTablefamilyChild = 2;
            Microsoft.Office.Interop.Word.Table tableFamily = application.ActiveDocument.Tables[11];
            int jTableFamily = 2;
            Microsoft.Office.Interop.Word.Table tableFamChild = application.ActiveDocument.Tables[12];
            int jTableFamChild = 2;
            Microsoft.Office.Interop.Word.Table tableLargeRelatives = application.ActiveDocument.Tables[13];
            int jLargeRelatives = 2;
            Microsoft.Office.Interop.Word.Table tableIncomplete = application.ActiveDocument.Tables[14];
            int jIncomplete = 2;
            Microsoft.Office.Interop.Word.Table tableInvaildParents = application.ActiveDocument.Tables[15];
            int jInvaildParents = 2;
            Microsoft.Office.Interop.Word.Table tableQuadian = application.ActiveDocument.Tables[16];
            int jQuadian = 2;
            Microsoft.Office.Interop.Word.Table tableInvaildStudent = application.ActiveDocument.Tables[17];
            int jInvaildStudent = 2;
            List<Student> students = DBobjects.Entities.Student.Where(p => p.idGroup == Journal.idGroup).ToList();
                
            students = students.OrderBy(p => p.surnameStudent).ToList();
            foreach (Student student in students)
            {
                if (jTableInfStud > 2) tableInfSt.Rows.Add(ref missing);
                tableInfSt.Rows[jTableInfStud].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                if(student.formOfTrainStudent==true)
                    tableInfSt.Rows[jTableInfStud].Cells[3].Range.Text = "К";
                else
                    tableInfSt.Rows[jTableInfStud].Cells[3].Range.Text = "Б";
                tableInfSt.Rows[jTableInfStud].Cells[4].Range.Text = student.dateOfBirthStudent.ToShortDateString();
                tableInfSt.Rows[jTableInfStud].Cells[5].Range.Text = student.telephoneStudent;
                
          
                if (student.Residence.town.Contains("Владимир") == true)
                {
                    if (jTableVladimir > 2) tableVladimir.Rows.Add(ref missing);
                    tableVladimir.Rows[jTableVladimir].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                    string adress = student.Residence.country + ", " + student.Residence.region + ", " + student.Residence.district + ", " + student.Residence.town + ", " + student.Residence.street + ", " + student.Residence.korpus + ", " + student.Residence.house + ", " + student.Residence.flat + " ";
                    adress = adress.Replace(", ,", ",");
                    adress = adress.Replace(", ,", ",");
                    adress = adress.TrimEnd(',', ' ');
                    tableVladimir.Rows[jTableVladimir].Cells[3].Range.Text = adress;
                    jTableVladimir++;
                }
                else
                {
                    if (jTableInogor > 2) tableInogor.Rows.Add(ref missing);
                    tableInogor.Rows[jTableInogor].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                    string adressPerman = student.Residence.country + ", " + student.Residence.region + ", " + student.Residence.district + ", " + student.Residence.town + ", " + student.Residence.street + ", " + student.Residence.korpus + ", " + student.Residence.house + ", " + student.Residence.flat + " ";
                    adressPerman = adressPerman.Replace(", ,", ",");
                    adressPerman = adressPerman.Replace(", ,", ",");
                    adressPerman = adressPerman.TrimEnd(',', ' ');
                    tableInogor.Rows[jTableInogor].Cells[3].Range.Text = adressPerman;                     
                   
                    if (student.Residence1.idHostel == 0 || student.Residence1.idHostel == null)
                    {
                        string adressTemp = student.Residence1.country + ", " + student.Residence1.region + ", " + student.Residence1.district + ", " + student.Residence1.town + ", " + student.Residence1.street + ", " + student.Residence1.korpus + ", " + student.Residence1.house + ", " + student.Residence1.flat + " ";
                        adressTemp = adressTemp.Replace(", ,", ",");
                        adressTemp = adressTemp.Replace(", ,", ",");
                        adressTemp = adressPerman.TrimEnd(',',' ');
                        tableInogor.Rows[jTableInogor].Cells[4].Range.Text = adressTemp;
                        jTableInogor++;
                    }
                    else
                    {
                        tableInogor.Rows[jTableInogor].Cells[4].Range.Text =student.Residence1.Hostel.ToString()+ " комната "+ student.Residence1.room;

                        jTableInogor++;
                    }                                       
                }
                if (student.Family.Count() != 0)
                {
                    Family family = DBobjects.Entities.Family.FirstOrDefault(p => p.idStudent == student.idStudent);
                    if (String.IsNullOrEmpty(family.nameChild) == false)
                    {
                        if (jTablefamilyChild > 2) tablefamilyChild.Rows.Add(ref missing);
                        tablefamilyChild.Rows[jTablefamilyChild].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                        tablefamilyChild.Rows[jTablefamilyChild].Cells[3].Range.Text = family.nameChild + "\n" + family.dateOfBirthChild.Value.ToShortDateString();
                        tablefamilyChild.Rows[jTablefamilyChild].Cells[4].Range.Text = family.fullNameSpous + "\n" + family.professionSpous;
                        jTablefamilyChild++;
                    }
                    if (String.IsNullOrEmpty(family.fullNameSpous) == false)
                    {
                            if (jTableFamily > 2) tableFamily.Rows.Add(ref missing);
                            if (student.gender == true)
                            {
                                tableFamily.Rows[jTableFamily].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                                tableFamily.Rows[jTableFamily].Cells[3].Range.Text = family.fullNameSpous;
                            }
                            else
                            {
                                tableFamily.Rows[jTableFamily].Cells[3].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                                tableFamily.Rows[jTableFamily].Cells[2].Range.Text = family.fullNameSpous;
                            }
                            if(family.nameChild!=null)
                            tableFamily.Rows[jTableFamily].Cells[4].Range.Text = family.nameChild.ToString() + "\n" + family.dateOfBirthChild.Value.ToShortDateString().ToString();
                            jTableFamily++;
                    }
                    if (String.IsNullOrEmpty(family.nameChild) == false && student.gender == true && String.IsNullOrEmpty(family.fullNameSpous) == true)
                        {
                            if (jTableFamChild > 2) tableFamChild.Rows.Add(ref missing);
                            tableFamChild.Rows[jTableFamChild].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                            tableFamChild.Rows[jTableFamChild].Cells[3].Range.Text = family.nameChild + "\n" + family.dateOfBirthChild.Value.ToShortDateString();
                            jTableFamChild++;
                        }
                }
                    List<Kin> kins = DBobjects.Entities.Kin.Where(p => p.idStudent == student.idStudent).ToList();
                   
                    if(kins.Where(p=>p.kinStatus=="Брат" || p.kinStatus == "Сестра").Count() >= 2)
                    {
                        if (jLargeRelatives > 2) tableLargeRelatives.Rows.Add(ref missing);
                        tableLargeRelatives.Rows[jLargeRelatives].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                        tableLargeRelatives.Rows[jLargeRelatives].Cells[3].Range.Text = (kins.Where(p => p.kinStatus == "Брат" || p.kinStatus == "Сестра").Count()+1).ToString();
                        jLargeRelatives++;
                    }
                    if(kins.Where(p => p.kinStatus == "Мать" || p.kinStatus == "Отец" && p.kinStatus != "Опекун").Count() < 2 && kins.Count()!=0)
                    {
                        if (jIncomplete > 2) tableIncomplete.Rows.Add(ref missing);
                        tableIncomplete.Rows[jIncomplete].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                        foreach(Kin kin in kins)
                        {
                            if (kin.kinStatus == "Мать" )
                                tableIncomplete.Rows[jIncomplete].Cells[3].Range.Text = kin.kinStatus + " " + kin.fullNameKin + "\nОтец -" ;
                            if (kin.kinStatus == "Отец")
                                tableIncomplete.Rows[jIncomplete].Cells[3].Range.Text = kin.kinStatus + " " + kin.fullNameKin + "\nМать -";
                        }
                        jIncomplete++;
                    }                   
                        foreach (Kin kin in kins)
                        {
                            if (kin.disabilityKin == true && kin.kinStatus != "Опекун" && kin.kinStatus != "Брат" && kin.kinStatus != "Сестра")
                            {
                            if (jInvaildParents > 2) tableInvaildParents.Rows.Add(ref missing);
                            tableInvaildParents.Rows[jInvaildParents].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                            tableInvaildParents.Rows[jInvaildParents].Cells[3].Range.Text = kin.fullNameKin;
                            jInvaildParents++;
                            }
                            
                            if (kin.kinStatus == "Опекун")
                            {
                            if (jQuadian > 2) tableQuadian.Rows.Add(ref missing);
                            tableQuadian.Rows[jQuadian].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                            tableQuadian.Rows[jQuadian].Cells[3].Range.Text = kin.fullNameKin + "\n" + kin.telephoneKin;
                            jQuadian++;
                            }
                        
                        }
                    if (student.disabilityStudent == true)
                    {
                        if (jInvaildStudent > 2) tableInvaildStudent.Rows.Add(ref missing);
                        tableInvaildStudent.Rows[jInvaildStudent].Cells[2].Range.Text = student.surnameStudent + " " + student.nameStudent + " " + student.patronymicStudent;
                        String rez ="";
                        foreach (Kin kin in kins)
                        {
                            if(kin.kinStatus=="Мать" || kin.kinStatus=="Отец" || kin.kinStatus == "Опекун")
                            {
                                rez += kin.kinStatus + " " + kin.fullNameKin + "\n";                                
                            }
                        }
                        rez = rez.TrimEnd('\n', ' ');
                        tableInvaildStudent.Rows[jInvaildStudent].Cells[3].Range.Text = rez;
                    }
                    jTableInfStud++;
                    
                }
                Microsoft.Office.Interop.Word.Table tableDynamics = application.ActiveDocument.Tables[18];
                int jDynamics = 3;
                foreach (GroupDynamics groupDynamics in DBobjects.Entities.GroupDynamics.Where(p => p.idJournal == Journal.idJournal).ToList())
                {
                    if (jDynamics > 3) tableDynamics.Rows.Add(ref missing);
                    tableDynamics.Cell(jDynamics, 2).Range.Text = groupDynamics.CoreIndicator.ToString();
                    tableDynamics.Cell(jDynamics, 3).Range.Text = Math.Round(groupDynamics.semesterOneDyn,2).ToString();
                    tableDynamics.Cell(jDynamics, 4).Range.Text = Math.Round(Convert.ToDouble(groupDynamics.semesterTwoDyn),2).ToString();
                    tableDynamics.Cell(jDynamics, 5).Range.Text = groupDynamics.note;
                    jDynamics++;
                }

                Microsoft.Office.Interop.Word.Table tableGrafik = application.ActiveDocument.Tables[19];
                int jGrafic = 4;
                foreach (StudyingProcess studyingProcess in DBobjects.Entities.StudyingProcess.Where(p => p.idJournal == Journal.idJournal).ToList())
                {
                    if (jGrafic > 4) tableGrafik.Rows.Add(ref missing);
                    tableGrafik.Cell(jGrafic, 1).Range.Text = Journal.courceGroup.ToString();
                    tableGrafik.Cell(jGrafic, 2).Range.Text = studyingProcess.semester.ToString();
                    tableGrafik.Cell(jGrafic, 3).Range.Text = studyingProcess.semesterStart.ToShortDateString();
                    tableGrafik.Cell(jGrafic, 4).Range.Text = studyingProcess.semesterEnd.ToShortDateString();
                    tableGrafik.Cell(jGrafic, 5).Range.Text = studyingProcess.sessionStart.ToShortDateString()+ "/\n" + studyingProcess.sessionEnd.ToShortDateString();
                    if(studyingProcess.practiceProductStart!=null && studyingProcess.practiceTrainStart!=null)
                        tableGrafik.Cell(jGrafic, 6).Range.Text = Convert.ToDateTime(studyingProcess.practiceProductStart).ToShortDateString() + "/\n" + Convert.ToDateTime(studyingProcess.practiceProductEnd).ToShortDateString()+ "\n" + Convert.ToDateTime(studyingProcess.practiceTrainStart).ToShortDateString() + "/\n" + Convert.ToDateTime(studyingProcess.practiceTrainEnd).ToShortDateString();
                    else if(studyingProcess.practiceProductStart != null && studyingProcess.practiceTrainStart == null)
                        tableGrafik.Cell(jGrafic, 6).Range.Text = Convert.ToDateTime(studyingProcess.practiceProductStart).ToShortDateString() + "/\n" + Convert.ToDateTime(studyingProcess.practiceProductEnd).ToShortDateString();
                    else if (studyingProcess.practiceProductStart == null && studyingProcess.practiceTrainStart != null)
                        tableGrafik.Cell(jGrafic, 6).Range.Text =  Convert.ToDateTime(studyingProcess.practiceTrainStart).ToShortDateString() + "/\n" + Convert.ToDateTime(studyingProcess.practiceTrainEnd).ToShortDateString();
                    tableGrafik.Cell(jGrafic, 7).Range.Text = studyingProcess.holidaysStart.ToShortDateString() + "/\n" + studyingProcess.holidaysEnd.ToShortDateString();
                    jGrafic++;
                }
                Microsoft.Office.Interop.Word.Table tableMeeting = application.ActiveDocument.Tables[20];
                int jMeeting = 2;
                foreach( Meeting meeting in DBobjects.Entities.Meeting.Where(p => p.idJournal == Journal.idJournal))
                {
                    if (jMeeting > 2) tableMeeting.Rows.Add(ref missing);
                    tableMeeting.Rows[jMeeting].Cells[1].Range.Text = meeting.dateMeeting.ToShortDateString();
                    tableMeeting.Rows[jMeeting].Cells[2].Range.Text = meeting.questionMeeting;
                    String rezMeeting = "";
                    foreach(LackMeeting lackMeeting in DBobjects.Entities.LackMeeting.Where(p => p.idMeeting == meeting.idMeeting))
                    {
                        rezMeeting += lackMeeting.Student.ToString() + ";\n";
                    }
                    rezMeeting = rezMeeting.TrimEnd('\n', ' ');
                    tableMeeting.Rows[jMeeting].Cells[3].Range.Text = rezMeeting;
                    tableMeeting.Rows[jMeeting].Cells[4].Range.Text = meeting.decisionMeeting;
                    jMeeting++;
                }
                Microsoft.Office.Interop.Word.Table tableAttendance = application.ActiveDocument.Tables[21];
                int jAttendance = 2;
                foreach (Attendance attendance in DBobjects.Entities.Attendance.Where(p => p.idJournal == Journal.idJournal))
                {
                    if (jAttendance > 2) tableAttendance.Rows.Add(ref missing);
                    tableAttendance.Rows[jAttendance].Cells[1].Range.Text = attendance.dateAttendance.ToShortDateString();
                    tableAttendance.Rows[jAttendance].Cells[2].Range.Text = attendance.Discipline.ToString() +"\n("+attendance.OccupationStatus.ToString()+")";
                    tableAttendance.Rows[jAttendance].Cells[3].Range.Text = attendance.fullNameTeach;
                    String rezAttendance = "";
                    foreach (LackAttendance lackAttendance in DBobjects.Entities.LackAttendance.Where(p => p.idAttendance == attendance.idAttendance))
                    {
                        rezAttendance += lackAttendance.Student.ToString() + ";\n";
                    }
                    rezAttendance = rezAttendance.TrimEnd('\n', ' ');
                    tableAttendance.Rows[jAttendance].Cells[4].Range.Text = rezAttendance;
                    jAttendance++;
                }

                Microsoft.Office.Interop.Word.Table tableTalkStudent = application.ActiveDocument.Tables[22];
                int jTalkStudent = 2;
                foreach (PrivateTalk privateTalk in DBobjects.Entities.PrivateTalk.Where(p => p.idJournal == Journal.idJournal))
                {
                    if (jTalkStudent > 2) tableTalkStudent.Rows.Add(ref missing);
                    tableTalkStudent.Rows[jTalkStudent].Cells[1].Range.Text = privateTalk.datePrTalk.ToShortDateString();
                    tableTalkStudent.Rows[jTalkStudent].Cells[2].Range.Text = privateTalk.topicPrTalk;
                    String rezPrivTalk = "";
                    foreach (PrivTalkStudent privTalkStudent in DBobjects.Entities.PrivTalkStudent.Where(p => p.idPrTalk == privateTalk.idPrTalk))
                    {
                        rezPrivTalk += privTalkStudent.Student.ToString() + ";\n";
                    }
                    rezPrivTalk = rezPrivTalk.TrimEnd('\n', ' ');
                    tableTalkStudent.Rows[jTalkStudent].Cells[3].Range.Text = rezPrivTalk;
                    jTalkStudent++;
                }

                Microsoft.Office.Interop.Word.Table tableDisciplineComm = application.ActiveDocument.Tables[23];
                int jDisciplineComm = 2;
                foreach (Offense offense in DBobjects.Entities.Offense.Where(p => p.idJournal == Journal.idJournal))
                {
                    if (jDisciplineComm > 2) tableDisciplineComm.Rows.Add(ref missing);
                    tableDisciplineComm.Rows[jDisciplineComm].Cells[1].Range.Text = offense.dateOffense.ToShortDateString();
                    tableDisciplineComm.Rows[jDisciplineComm].Cells[2].Range.Text = offense.numberProt;
                    tableDisciplineComm.Rows[jDisciplineComm].Cells[3].Range.Text = offense.causeOffense;
                    tableDisciplineComm.Rows[jDisciplineComm].Cells[4].Range.Text = offense.decisionOffense;
                    jDisciplineComm++;
                }
                Microsoft.Office.Interop.Word.Table tableMessage = application.ActiveDocument.Tables[24];
                int jMessage = 1;
                Microsoft.Office.Interop.Word.Table tableMeet = application.ActiveDocument.Tables[25];
                int jMeet = 1;
                Microsoft.Office.Interop.Word.Table tableDeduction = application.ActiveDocument.Tables[26];
                int jDeduction = 1;
                foreach (TalkParents talkParents in DBobjects.Entities.TalkParents.Where(p => p.idJournal == Journal.idJournal))
                {
                    String kins = "";
                    foreach (StructParentsTalc structParentsTalc in DBobjects.Entities.StructParentsTalc.Where(p => p.idTalkParents == talkParents.idTalkPar).ToList())
                    {
                        kins += structParentsTalc.Kin.fullNameKin + ",";
                    }
                    kins = kins.TrimEnd(',', ' ');
                    if (talkParents.TopicTalkParents.ToString()== "Письмо с уведомлением из деканата")
                    {
                        if (jMessage > 1) tableMessage.Rows.Add(ref missing);
                        tableMessage.Rows[jMessage].Cells[1].Range.Text = talkParents.dateTalkPar.ToShortDateString() + " " + talkParents.topicTalc+ ". Письмо отправлено: " + kins;
                        jMessage++;
                    }
                    else if (talkParents.TopicTalkParents.ToString() == "Личная встреча")
                    {
                        if (jMeet > 1) tableMeet.Rows.Add(ref missing);
                        tableMeet.Rows[jMeet].Cells[1].Range.Text = talkParents.dateTalkPar.ToShortDateString() + " " + talkParents.topicTalc + ". Личная встреча состоялась с: " + kins;
                        jMeet++;
                    }
                    else if(talkParents.TopicTalkParents.ToString() == "Совместно с деканатом факультета и ректоратом решался вопрос об отчислении")
                    {
                        if (jDeduction > 1) tableDeduction.Rows.Add(ref missing);
                        tableDeduction.Rows[jDeduction].Cells[1].Range.Text = talkParents.dateTalkPar.ToShortDateString() + " " + talkParents.topicTalc + ". Присутствующие родители: " + kins;
                        jDeduction++;
                    }
                }
                Microsoft.Office.Interop.Word.Table tableVisitHostel = application.ActiveDocument.Tables[27];
                int jVisitHostelHostel = 2;
                foreach (VisitHostel visitHostel in DBobjects.Entities.VisitHostel.Where(p => p.idJournal == Journal.idJournal))
                {
                    if (jVisitHostelHostel > 2) tableVisitHostel.Rows.Add(ref missing);
                    tableVisitHostel.Rows[jVisitHostelHostel].Cells[1].Range.Text = visitHostel.dateVisitHostel.ToShortDateString();
                    tableVisitHostel.Rows[jVisitHostelHostel].Cells[2].Range.Text = visitHostel.causeVisitHostel;
                    String hostel = " ";
                    String rooms = "";
                    foreach (ProvenRooms provenRooms in DBobjects.Entities.ProvenRooms.Where(p => p.idVisitHostel == visitHostel.idVisitHostel))
                    {
                        if (hostel.Contains(" " + provenRooms.Residence.Hostel.ToString() + ", "  )==false)
                            hostel += provenRooms.Residence.Hostel.ToString() + ", ";
                        rooms += provenRooms.Residence.room + ", ";
                    }
                    hostel = hostel.TrimEnd(',', ' ');
                    rooms = rooms.TrimEnd(',', ' ');
                    tableVisitHostel.Rows[jVisitHostelHostel].Cells[3].Range.Text = hostel;
                    tableVisitHostel.Rows[jVisitHostelHostel].Cells[4].Range.Text = rooms;
                    jVisitHostelHostel++;
                }
                Microsoft.Office.Interop.Word.Table tableAchivmentNauch = application.ActiveDocument.Tables[28];
                int jNauch = 1;
                Microsoft.Office.Interop.Word.Table tableAchivmentArtists = application.ActiveDocument.Tables[29];
                int jArtists = 1;
                Microsoft.Office.Interop.Word.Table tableAchivmentSports = application.ActiveDocument.Tables[30];
                int jSports = 1;
                Microsoft.Office.Interop.Word.Table tableAchivmentOther = application.ActiveDocument.Tables[31];
                int jOther = 1;
                string studentsList = "";

                foreach (Event events in DBobjects.Entities.Event.Where(p => p.idJournal == Journal.idJournal))
                {                    
                    foreach (AchivementStudent achivementStudent in DBobjects.Entities.AchivementStudent.Where(p => p.idEvent == events.idEvent).ToList())
                    {                     
                        if (events.TypeOfEvent.ToString() == "Научно-исследовательская работа")
                        {
                            if (jNauch > 1) tableAchivmentNauch.Rows.Add(ref missing);
                            tableAchivmentNauch.Rows[jNauch].Cells[1].Range.Text = events.dateEvent.ToShortDateString() + " " + events.nameEvent+ " Участник: "+achivementStudent.Student.ToString() + ". Руководитель: " + achivementStudent.fullNameSupervis + ", Тема работы: " + achivementStudent.topicWork+". ("+achivementStudent.topicAchivment+")";
                            jNauch++;
                        }
                        else if (events.TypeOfEvent.ToString() == "Художественная самодеятельность")
                        {
                            if (jArtists > 1) tableAchivmentArtists.Rows.Add(ref missing);
                            tableAchivmentArtists.Rows[jArtists].Cells[1].Range.Text = events.dateEvent.ToShortDateString()+ " " + events.nameEvent + ". Участники: " + achivementStudent.Student.ToString() + ". (" + achivementStudent.topicAchivment + ")";
                            jArtists++;
                        }
                        else if (events.TypeOfEvent.ToString() == "Спортивное мероприятие")
                        {
                            if (jSports > 1) tableAchivmentSports.Rows.Add(ref missing);
                            tableAchivmentSports.Rows[jSports].Cells[1].Range.Text = events.dateEvent.ToShortDateString() + " " + events.nameEvent + ". Участник: " + achivementStudent.Student.ToString() + ". (" + achivementStudent.topicAchivment + ")";
                            jSports++;
                        }
                        else
                        {
                            if (jOther > 1) tableAchivmentOther.Rows.Add(ref missing);
                            tableAchivmentOther.Rows[jOther].Cells[1].Range.Text ="Тип мероприятия: "+ events.TypeOfEvent.ToString() + " "+ events.dateEvent.ToShortDateString() + " " + events.nameEvent + ". Участник: " + achivementStudent.Student.ToString() + ". (" + achivementStudent.topicAchivment + ")";
                            jOther++;
                        }
                    }

                }
                saveFileDialogJournal.FileName = "Журнал группы " + Journal.Group.numberGroup + " за " + Journal.courceGroup.ToString() +" курс.docx";
              if (saveFileDialogJournal.ShowDialog() == DialogResult.Cancel) return;
              // получаем выбранный файл 
              object SaveAsFile = saveFileDialogJournal.FileName;
              document.SaveAs2(SaveAsFile, missing, missing, missing);
              document.Close(ref falseObj, ref missing, ref missing);
             application.Quit(ref missing, ref missing, ref missing);
             document = null;                
              System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
              application = null;
              //Открываем документ для просмотра.
              System.Diagnostics.Process.Start(SaveAsFile.ToString());

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {        
                MessageBox.Show(ex.Message);
                document.Close(ref falseObj, ref missing, ref missing);
                application.Quit(ref missing, ref missing, ref missing);
                document = null;
                application = null;               
                this.Cursor = Cursors.Default;
                application.Quit();
            }
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
