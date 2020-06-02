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
    public partial class VisitHostelForm : Form
    {
        DataTable HostelRoom = new DataTable();
        VisitHostel visitHostel;
        ProvenRooms provenRooms;
        
        public VisitHostelForm()
        {
            InitializeComponent();
            DataColumn idResidence = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn NumberHostel = new DataColumn("Общежитие", Type.GetType("System.String"));
            DataColumn Room = new DataColumn("Комната", Type.GetType("System.String"));
            DataColumn StatusProven = new DataColumn("Статус проверки", Type.GetType("System.Boolean"));
            DataColumn ProvenRooms = new DataColumn("ProvenId", Type.GetType("System.Int32"));
            HostelRoom.Columns.Add(idResidence);
            HostelRoom.Columns.Add(NumberHostel);
            HostelRoom.Columns.Add(Room);
            HostelRoom.Columns.Add(StatusProven);
            HostelRoom.Columns.Add(ProvenRooms);
            FillVisit();
        }
        private void FillVisit()
        {
            dgvVisit.DataSource = DBobjects.Entities.VisitHostel.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvVisit.Columns[0].Visible = false;
            dgvVisit.Columns[1].Visible = false;
            dgvVisit.Columns[2].HeaderText = "Дата проведения";
            dgvVisit.Columns[3].HeaderText = "Причина посещения";
            dgvVisit.Columns[4].Visible = false;
            dgvVisit.Columns[5].Visible = false;
        }

        private void FillRoom()
        {
            List<Student> students = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup && p.idResidenceTemp!= null && p.Residence1.idHostel != null).ToList();
            List<Residence> residences = new List<Residence>();
            foreach (Student stud in students)
            {
                if(residences.Where(p=>p.idHostel==stud.Residence1.idHostel&& p.room==stud.Residence1.room).Count()==0)
                residences.Add(DBobjects.Entities.Residence.FirstOrDefault(p => p.idResidence == stud.Residence1.idResidence));
            }
           
            foreach (Residence residence in residences)
            {
                if (DBobjects.Entities.ProvenRooms.Where(p => p.idResidence == residence.idResidence && p.idVisitHostel == visitHostel.idVisitHostel).Count() > 0)
                    HostelRoom.Rows.Add(residence.idResidence, residence.Hostel, residence.room, true, DBobjects.Entities.ProvenRooms.FirstOrDefault(p => p.idResidence == residence.idResidence).idProvenRooms);
                else
                    HostelRoom.Rows.Add(residence.idResidence, residence.Hostel, residence.room, false, 0);
            }          
            dgvRoom.DataSource = HostelRoom;
            dgvRoom.Columns[0].Visible = false;
            dgvRoom.Columns[1].ReadOnly = true;
            dgvRoom.Columns[2].ReadOnly = true;
            dgvRoom.Columns[4].Visible = false;
        }

        private void bAddVisit_Click(object sender, EventArgs e)
        {
            visitHostel = new VisitHostel();
            dgvVisit.ClearSelection();
            visitHostel.dateVisitHostel = DateTime.Now.Date;
            visitHostel.causeVisitHostel = "";
            visitHostel.idJournal = JournalForm.Journal.idJournal;
            FillPanel();
            HostelRoom.Clear();
            FillRoom();
        }
        private void FillPanel()
        {
            panelVisitRoom.Visible = true;
            buttonDelete.Visible = true;
            buttonSave.Visible = true;
            dateTimePickerVisit.Value = visitHostel.dateVisitHostel;
            textBoxCause.Text = visitHostel.causeVisitHostel;
        }

        private void dgvVisit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                visitHostel = (VisitHostel)dgvVisit.Rows[e.RowIndex].DataBoundItem;
                FillPanel();
                HostelRoom.Clear();               
                FillRoom();
            }
        }
        private void SaveVisit()
        { 
                if (DBobjects.Entities.VisitHostel.Where(p => p.idVisitHostel == visitHostel.idVisitHostel).Count() == 0)
                    DBobjects.Entities.VisitHostel.Add(visitHostel);          
        }
        private void SaveStudent()
        {
            foreach (DataGridViewRow dgvr in dgvRoom.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[4].Value) == 0)
                    provenRooms = new ProvenRooms();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[4].Value);
                    provenRooms = DBobjects.Entities.ProvenRooms.FirstOrDefault(p => p.idProvenRooms == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[3].Value) == true)
                {
                    provenRooms.idVisitHostel = visitHostel.idVisitHostel;
                    provenRooms.idResidence = Convert.ToInt32(dgvr.Cells[0].Value);
                    if (DBobjects.Entities.ProvenRooms.Where(p => p.idProvenRooms == provenRooms.idProvenRooms).Count() == 0)
                        DBobjects.Entities.ProvenRooms.Add(provenRooms);
                    DBobjects.Entities.SaveChanges();
                }
                else if (provenRooms.idProvenRooms != 0 && Convert.ToBoolean(dgvr.Cells[3].Value) == false)
                    DeleteProvenRoom();
            }
        }
        private void DeleteProvenRoom()
        {
            DBobjects.Entities.ProvenRooms.Remove(provenRooms);
            DBobjects.Entities.SaveChanges();
        }
       

        private void dateTimePickerVisit_ValueChanged(object sender, EventArgs e)
        {
            visitHostel.dateVisitHostel = dateTimePickerVisit.Value.Date;
        }

        private void textBoxCause_TextChanged(object sender, EventArgs e)
        {
            visitHostel.causeVisitHostel = textBoxCause.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(visitHostel.causeVisitHostel))
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                SaveVisit();
                FillVisit();
                SaveStudent();
                MessageBox.Show("Сохранено");
            }
        }
        private void DeleteVisit()
        {
            if (DBobjects.Entities.VisitHostel.Where(p => p.idVisitHostel == visitHostel.idVisitHostel).Count() > 0)
                DBobjects.Entities.VisitHostel.Remove(visitHostel);
            DBobjects.Entities.SaveChanges();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteVisit();
            panelVisitRoom.Visible = false;
            FillVisit();
        }
    }
}
