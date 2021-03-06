﻿using System;
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
    public partial class JournalForm : Form
    {
        public static Journal Journal;

        public JournalForm(Journal journal)
        {
            InitializeComponent();
            Journal = journal;
        }


        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            while (MdiChildren.Count() > 0) 
            {
                MdiChildren[0].Close();
            } 
            if (Journal.idJournal != 0)
            {
                switch ((treeViewMenu.SelectedNode).Name)
                {
                case "MainInformation":
                    AddJournalForm addJournalForm = new AddJournalForm();
                    addJournalForm.MdiParent = this;
                    addJournalForm.WindowState = FormWindowState.Maximized;
                    addJournalForm.Show();
                    break;

                case "DinamicGroup":
                    DynamicsOfIndicatorsForm dynamicsOfIndicators = new DynamicsOfIndicatorsForm();
                    dynamicsOfIndicators.WindowState = FormWindowState.Maximized;
                    dynamicsOfIndicators.MdiParent = this;
                    dynamicsOfIndicators.Show();
                    break;

                case "StudentInformation":
                    StudentInformationForm studentInformation = new StudentInformationForm();
                    studentInformation.WindowState = FormWindowState.Maximized;
                    studentInformation.MdiParent = this;
                    studentInformation.Show();
                    break; 
                case "GraficProcess":
                    StudyScheduleForm studySchedule = new StudyScheduleForm();
                    studySchedule.WindowState = FormWindowState.Maximized;
                    studySchedule.MdiParent = this;
                    studySchedule.Show();                        
                    break;   
                case "MeetingJournal":
                    MeetingForm meetingForm = new MeetingForm();
                    meetingForm.WindowState = FormWindowState.Maximized;
                    meetingForm.MdiParent = this;
                    meetingForm.Show();
                    break;
                case "Attendance":
                    AttendanceCheckForm attendanceCheckForm = new AttendanceCheckForm();
                    attendanceCheckForm.WindowState = FormWindowState.Maximized;
                    attendanceCheckForm.MdiParent = this;
                    attendanceCheckForm.Show();
                    break;
                case "VisitHostel":
                    VisitHostelForm visitHostelForm = new VisitHostelForm();
                    visitHostelForm.WindowState = FormWindowState.Maximized;
                    visitHostelForm.MdiParent = this;
                    visitHostelForm.Show();
                    break;

                    case "PerformeMonitor":
                        RatingForm ratingForm = new RatingForm();
                        ratingForm.WindowState = FormWindowState.Maximized;
                        ratingForm.MdiParent = this;
                        ratingForm.Show();
                        break;
                    case "StudentAchivment":
                        EventForm eventForm = new EventForm();
                        eventForm.WindowState = FormWindowState.Maximized;
                        eventForm.MdiParent = this;
                        eventForm.Show();
                        break;
                    case "PrivateTalcParents":
                        EducationalWorkForm educationalWorkForm = new EducationalWorkForm();
                        educationalWorkForm.WindowState = FormWindowState.Maximized;
                        educationalWorkForm.MdiParent = this;
                        educationalWorkForm.Show();
                        break;
                    case "TalckParents":
                        TalcParentForm talcParentForm = new TalcParentForm();
                        talcParentForm.WindowState = FormWindowState.Maximized;
                        talcParentForm.MdiParent = this;
                        talcParentForm.Show();
                        break;

                    case "Offence":
                        DisciplinaryCommissionForm disciplinaryCommissionForm = new DisciplinaryCommissionForm();
                        disciplinaryCommissionForm.WindowState = FormWindowState.Maximized;
                        disciplinaryCommissionForm.MdiParent = this;
                        disciplinaryCommissionForm.Show();
                        break;
                }
            }
            else if((treeViewMenu.SelectedNode).Name== "MainInformation")
            {
                AddJournalForm addJournalForm = new AddJournalForm();
                addJournalForm.MdiParent = this;
                addJournalForm.WindowState = FormWindowState.Maximized;
                addJournalForm.Show();
            }                      
        } 
       
    }
}
