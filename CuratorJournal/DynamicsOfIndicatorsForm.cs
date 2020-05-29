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
    public partial class DynamicsOfIndicatorsForm : Form
    {
        GroupDynamics groupDynamics;
        public DynamicsOfIndicatorsForm()
        {
            InitializeComponent();
            if (DBobjects.Entities.GroupDynamics.Where(p => p.idJournal == JournalForm.Journal.idJournal).Count() == 0)
            {
                AddTable();
            }
            else
                FillTable();
        }

        private DataTable DynamicsTable()
        {
            DataTable Dynamics = new DataTable();
            DataColumn idGrDin = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn idCoreInd = new DataColumn("idCoreInd", Type.GetType("System.Int32"));
            DataColumn CoreInd = new DataColumn("Основные показатели", Type.GetType("System.String"));
            DataColumn OneSemestr = new DataColumn("1-ый семестр", Type.GetType("System.Int32"));
            DataColumn TwoSemestr = new DataColumn("2-ой семестр", Type.GetType("System.Int32"));
            DataColumn note = new DataColumn("Примечания", Type.GetType("System.String"));
            Dynamics.Columns.Add(idGrDin);
            Dynamics.Columns.Add(idCoreInd);
            Dynamics.Columns.Add(CoreInd);
            Dynamics.Columns.Add(OneSemestr);
            Dynamics.Columns.Add(TwoSemestr);
            Dynamics.Columns.Add(note);
            return Dynamics;
        }
        private void FillTable()
        {
            DataTable DynamicsJournalTable = DynamicsTable();
            List<GroupDynamics> dynamicsJournal = DBobjects.Entities.GroupDynamics.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            foreach (GroupDynamics grdyn in dynamicsJournal)
            {
                DynamicsJournalTable.Rows.Add(grdyn.idGrDin, grdyn.idCoreInd, grdyn.CoreIndicator, grdyn.semesterOneDyn, grdyn.semesterTwoDyn, grdyn.note);
            }
            dgvDynamics.DataSource = DynamicsJournalTable;
            dgvDynamics.Columns[0].Visible = false;
            dgvDynamics.Columns[1].Visible = false;
            dgvDynamics.Columns[2].ReadOnly = true;
           
        }
        private void AddTable()
        {
            DataTable DynamicsJournalTable = DynamicsTable();
            List<CoreIndicator> coreIndicators = DBobjects.Entities.CoreIndicator.ToList();
            foreach (CoreIndicator corInd in coreIndicators)
            {
                DynamicsJournalTable.Rows.Add(0, corInd.idCoreInd,corInd.nameCoreInd, 0,0,"");
            }
            dgvDynamics.DataSource = DynamicsJournalTable;
            dgvDynamics.Columns[0].Visible = false;
            dgvDynamics.Columns[1].Visible = false;
            dgvDynamics.Columns[2].ReadOnly = true;
           
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveDynamics();
            MessageBox.Show("Сохранено");
        }

        private void SaveDynamics()
        {
            foreach (DataGridViewRow dgvr in dgvDynamics.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[0].Value) == 0)
                    groupDynamics = new GroupDynamics();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[1].Value);
                    groupDynamics = DBobjects.Entities.GroupDynamics.FirstOrDefault(p => p.idGrDin == id);
                }
                groupDynamics.idJournal = JournalForm.Journal.idJournal;
                groupDynamics.idGrDin = Convert.ToInt32(dgvr.Cells[0].Value);
                groupDynamics.semesterOneDyn = Convert.ToInt32(dgvr.Cells[3].Value);
                groupDynamics.semesterTwoDyn = Convert.ToInt32(dgvr.Cells[4].Value);
                groupDynamics.idCoreInd = Convert.ToInt32(dgvr.Cells[1].Value);
                groupDynamics.note = dgvr.Cells[5].Value.ToString();
                if (DBobjects.Entities.GroupDynamics.Where(p => p.idGrDin == groupDynamics.idGrDin).Count() == 0)
                {
                    DBobjects.Entities.GroupDynamics.Add(groupDynamics);
                }
                DBobjects.Entities.SaveChanges();
            }
        }

        private void dgvDynamics_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = (TextBox)e.Control;
            if (dgvDynamics.CurrentCell.ColumnIndex == 3 || dgvDynamics.CurrentCell.ColumnIndex == 4)
            {
                textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            }
            else
                textBox.KeyPress -= new KeyPressEventHandler(textBox_KeyPress);
        }

        private void textBox_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!=127)
                e.Handled = true;
        }
    }
}
