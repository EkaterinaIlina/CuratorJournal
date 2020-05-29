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
        
        public VisitHostelForm()
        {
            InitializeComponent();
            FillRoom();
        }
        private void FillRoom()
        {
            List<Student> students = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup && p.idResidenceTemp!= null && p.Residence1.idHostel != null).ToList();
            List<Residence> residences = new List<Residence>();
            foreach (Student stud in students)
            {
                if(residences.Where(p=>p.idHostel==stud.Residence1.idHostel&&p.room==stud.Residence1.room).Count()==0)
                residences.Add(DBobjects.Entities.Residence.FirstOrDefault(p => p.idResidence == stud.Residence1.idResidence));
            }
            DataColumn idResidence = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn NumberHostel = new DataColumn("Общежитие", Type.GetType("System.String"));
            DataColumn Room = new DataColumn("Комната", Type.GetType("System.String"));
            DataColumn StatusProven = new DataColumn("Статус проверки", Type.GetType("System.Boolean"));
            DataColumn ProvenRooms = new DataColumn("ProvenId", Type.GetType("System.Int32"));
            HostelRoom.Columns.Add(idResidence);
            HostelRoom.Columns.Add(NumberHostel);
            HostelRoom.Columns.Add(Room);
            HostelRoom.Columns.Add(StatusProven);
            if (DBobjects.Entities.ProvenRooms.Where(p => p.id == st.idStudent && p.idMeeting == meeting.idMeeting).Count() > 0)
)
            HostelRoom.Columns.Add(ProvenRooms);
            dgvRoom.DataSource = HostelRoom;
            dgvRoom.Columns[0].Visible = false;
            dgvRoom.Columns[1].ReadOnly = true;
            dgvRoom.Columns[2].ReadOnly = true;
            dgvRoom.Columns[4].Visible = false;
        }
    }
}
