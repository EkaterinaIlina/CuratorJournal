using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CuratorJournal
{
    public partial class StudentForm : Form
    {
        Student student ;
        Residence residence ;
        Residence residenceTemp ;
        Kin kin ;
        Family family = new Family();
        bool flag; // Добавление/редактирование братьев и сестер
        List <Kin> listRelatives;
        Language language;

        public StudentForm(Student STUDENT)
        {
            InitializeComponent();
            student = STUDENT;
            residence = DBobjects.Entities.Residence.FirstOrDefault(p => p.idResidence == student.idResidencePerman);
            if (student.idResidenceTemp != null)
                residenceTemp = DBobjects.Entities.Residence.FirstOrDefault(p => p.idResidence == student.idResidenceTemp);

            else
                residenceTemp = new Residence();
            if (DBobjects.Entities.Family.Where(p => p.idStudent == student.idStudent).Count() > 0)
                family = DBobjects.Entities.Family.FirstOrDefault(p => p.idStudent == student.idStudent);
            MainFill();
            ResidenceFill();
            listRelatives= DBobjects.Entities.Kin.Where(p => p.idStudent == student.idStudent).ToList();            
            KinFill();
            FamilyFill();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public StudentForm(int idGroup)
        {
            InitializeComponent();
            student = new Student();
            residence = new Residence();
            residenceTemp = new Residence();
            kin = new Kin();
            family = new Family();
            student.idGroup = idGroup;
            comboBoxLang.DataSource = DBobjects.Entities.Language.ToList();
            comboBoxLang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxLang.AutoCompleteSource = AutoCompleteSource.ListItems;
            dateTimePickerDateBirth.Value = DateTime.Now;
            dateTimePickerLern.Value = DateTime.Now;            
            listRelatives = new List<Kin>();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }
        
            
        
        private void MainFill()
        {
            buttonDelete.Visible = true;
            buttonSaveStudent.Text = "Сохранить";
            tbSurname.Text = student.surnameStudent;
            tbName.Text = student.nameStudent;
            tbPathr.Text = student.patronymicStudent;
            if (student.formOfTrainStudent == false)
                radioButtonB.Checked = true;
            else
                radioButtonK.Checked = true;
            dateTimePickerDateBirth.Value = student.dateOfBirthStudent.Date;
            maskedTextBoxPhone.Text = student.telephoneStudent;
            if (student.disabilityStudent == true)
                radioButtonInT.Checked = true;
            else
                radioButtonInvF.Checked = true;
            comboBoxLang.DataSource = DBobjects.Entities.Language.ToList();
            comboBoxLang.SelectedItem = student.Language;
            comboBoxLang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxLang.AutoCompleteSource = AutoCompleteSource.ListItems;
            tbPlaceLern.Text = student.nameSchoolStudent;
            dateTimePickerLern.Value = Convert.ToDateTime(student.yearOfManStudent).Date;
        }
        private void ResidenceFill()
        {
            listBoxHostel.DataSource = DBobjects.Entities.Hostel.Select(p => p.nameHostel).ToList();
            listBoxHostel.SelectedItem = listBoxHostel.Items[0];
            tbCountry.Text = residence.country;
            tbDistrict.Text = residence.district;
            tbRegion.Text = residence.region;
            tbTown.Text = residence.town;
            tbStreet.Text = residence.street;
            tbHouse.Text = residence.house;
            tbKorpus.Text = residence.korpus;
            tbFlat.Text = residence.flat;
            if (student.idResidenceTemp != null || student.idResidenceTemp.ToString() != "")
            {
                radioButtonInog.Checked = true;
                if (residence.country == residenceTemp.country && residence.region == residenceTemp.region
                    && residence.district == residenceTemp.district && residence.town == residenceTemp.town
                    && residence.street == residenceTemp.street && residence.house == residenceTemp.house
                    && residence.korpus == residenceTemp.korpus && residence.flat == residenceTemp.flat)
                    radioButtonPropiska.Checked = true;
                else
                {
                    if (residenceTemp.idHostel != null || residenceTemp.idHostel.ToString() != "")
                    {
                        radioButtonHostel.Checked = true;
                        listBoxHostel.SelectedItem = student.Residence1.Hostel;
                        tbRoom.Text = residenceTemp.room;
                    }
                    else
                    {
                        radioButtonOther.Checked = true;
                        tbCountryT.Text = residenceTemp.country;
                        tbDistrictT.Text = residenceTemp.district;
                        tbRegionT.Text = residenceTemp.region;
                        tbTownT.Text = residenceTemp.town;
                        tbStreetT.Text = residenceTemp.street;
                        tbHouseT.Text = residenceTemp.house;
                        tbKorpusT.Text = residenceTemp.korpus;
                        tbFlatT.Text = residenceTemp.flat;
                    }
                }
            }
        }
        private void KinFill()
        {
            dgvKin.DataSource = listRelatives.ToList();
            dgvKin.Columns["idKin"].Visible = false;
            dgvKin.Columns["fullNameKin"].HeaderText = "ФИО";
            dgvKin.Columns["kinStatus"].HeaderText = "Статус родства";
            dgvKin.Columns["telephoneKin"].Visible = false;
            dgvKin.Columns["disabilityKin"].Visible = false;
            dgvKin.Columns["placeOfWorkKin"].Visible = false;
            dgvKin.Columns["idStudent"].Visible = false;
            dgvKin.Columns["TalkParents"].Visible = false;
            dgvKin.Columns["Student"].Visible = false;
        }

        private void dgvKin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bDeleteKin.Visible = true;
                panelRelatives.Visible = true;               
                kin = (Kin)dgvKin.Rows[e.RowIndex].DataBoundItem;
                tbFIOKin.Text = kin.fullNameKin;
                listBoxKinStatus.SelectedItem = kin.kinStatus;
                maskedTextBoxKinPhone.Text = kin.telephoneKin;
                if (kin.disabilityKin == true)
                    radioButtonInvKinT.Checked = true;
                else
                    radioButtonInvKinF.Checked = true;
                tbPlaceEmployment.Text = kin.placeOfWorkKin;
                flag = false;
            }
        }
        private void DeleteKin()
        {
            if (kin.idStudent !=0)
            {
                if (DBobjects.Entities.Kin.Where(p => p.idKin == kin.idKin).Count() > 0)
                {
                    DBobjects.Entities.Kin.Remove(kin);
                    DBobjects.Entities.SaveChanges();
                }
            }
            listRelatives.Remove(kin);
            KinFill();
        }
        private void FamilyFill()
        {
            if (DBobjects.Entities.Family.Where(p => p.idStudent == student.idStudent).Count() > 0)
            {
                radioButtonSelectFamT.Checked = true;
                tbFIOSpous.Text = family.fullNameSpous;
                if (family.statusSpous == true)
                {
                    radioButtonWork.Checked = true;
                    tbProfesion.Text = family.professionSpous;
                }
                if (family.nameChild != null && family.nameChild != "")
                {
                    radioButtonChildTrue.Checked = true;
                    tbChild.Text = family.nameChild;
                    dateTimePickerDateBirthChild.Value = Convert.ToDateTime(family.dateOfBirthChild).Date;
                }
                else
                    radioButtonChildFalse.Checked = true;
            }
        }
        private void ReadSaveStudent()
        {
            if (comboBoxLang.FindString(comboBoxLang.Text) == -1)
            {
                language = new Language();
                language.nameLanguage = comboBoxLang.Text;
                DBobjects.Entities.Language.Add(language);
                DBobjects.Entities.SaveChanges();
            }
            student.idForeignLangStudent = language.idLanguage;
            student.idResidencePerman = residence.idResidence;
            if (residenceTemp.idResidence !=0 && radioButtonVladimir.Checked==false)
                student.idResidenceTemp = residenceTemp.idResidence;
            else
            {
                student.idResidenceTemp = null;
                DeleteResidenceTemp();
            }
                
            if (DBobjects.Entities.Student.Where(p => p.idStudent == student.idStudent).Count() == 0)
                DBobjects.Entities.Student.Add(student);
            DBobjects.Entities.SaveChanges();
        }

        private void ReadSaveResidence()
        {
            if (DBobjects.Entities.Residence.Where(p => p.idResidence == residence.idResidence).Count() == 0)
                DBobjects.Entities.Residence.Add(residence);
            DBobjects.Entities.SaveChanges();
        }

        private void SaveResidenceTemp()
        {
            PropiskaAdd();
            if (DBobjects.Entities.Residence.Where(p => p.idResidence == residenceTemp.idResidence).Count() == 0)
                DBobjects.Entities.Residence.Add(residenceTemp);
            DBobjects.Entities.SaveChanges();
        }

        private void ReadSaveFamily()
        {
            if (radioButtonChildFalse.Checked == true)
                family.dateOfBirthChild = null;
            family.idStudent = student.idStudent;
            if (DBobjects.Entities.Family.Where(p => p.idFamily == family.idFamily).Count() == 0)
                DBobjects.Entities.Family.Add(family);
            DBobjects.Entities.SaveChanges();
        }

        private void DeleteResidenceTemp()
        {
            if (DBobjects.Entities.Residence.Where(p => p.idResidence == residenceTemp.idResidence).Count() > 0)
                DBobjects.Entities.Residence.Remove(residenceTemp);
            DBobjects.Entities.SaveChanges();
        }

        private void DeleteFamily()
        {
            if (DBobjects.Entities.Family.Where(p => p.idFamily == family.idFamily).Count() > 0)
                DBobjects.Entities.Family.Remove(family);
            DBobjects.Entities.SaveChanges();
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOther.Checked == true)
            {
                residenceTemp.flat = "";
                residenceTemp.idHostel = null;
                panelResTemp.Visible = true;
                panelHostel.Visible = false;
            }
        }

        private void radioButtonSelectFamT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSelectFamT.Checked == true) 
                groupBoxFamily.Visible = true;

            else
                groupBoxFamily.Visible = false;
        }

        private void radioButtonHostel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHostel.Checked == true)
            {
                residenceTemp.country = "";
                residenceTemp.region = "";
                residenceTemp.district = "";
                residenceTemp.town = "";
                residenceTemp.street = "";
                residenceTemp.house = "";
                residenceTemp.korpus = "";
                residenceTemp.flat = "";
                panelHostel.Location = new Point(389, 413);
                panelHostel.Visible = true;
                panelResTemp.Visible = false;
                listBoxHostel.DataSource = DBobjects.Entities.Hostel.Select(p => p.nameHostel).ToList();
                listBoxHostel.SelectedItem = listBoxHostel.Items[0];
            }
        }

        private void radioButtonChildTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChildTrue.Checked == true)
            {
                dateTimePickerDateBirthChild.Value = DateTime.Now;
                panelChild.Visible = true;
            }
            else
            {
                panelChild.Visible = false;
                family.nameChild = null;
                family.dateOfBirthChild = null;
            }
        }

        private void radioButtonInog_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true)
                groupBoxSelect.Visible = true;
            else
                groupBoxSelect.Visible = false;
        }
        private void PropiskaAdd()
        {
            if (radioButtonInog.Checked == true && radioButtonPropiska.Checked == true)
            {
                residenceTemp.country = residence.country;
                residenceTemp.district = residence.district;
                residenceTemp.region = residence.region;
                residenceTemp.town = residence.town;
                residenceTemp.town = residence.town;
                residenceTemp.street = residence.street;
                residenceTemp.korpus = residence.korpus;
                residenceTemp.house = residence.house;
                residenceTemp.flat = residence.flat;
                residenceTemp.idHostel = null;
                residenceTemp.room = "";
                panelHostel.Visible = false;
                panelResTemp.Visible = false;
            }
        }
        private void radioButtonPropiska_CheckedChanged(object sender, EventArgs e)
        {
            PropiskaAdd();
        }

        private void radioButtonVladimir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVladimir.Checked == true)
            {
                panelResTemp.Visible = false;
                panelHostel.Visible = false;
            }
        }

        private void radioButtonWork_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWork.Checked == true)
            {
                panelPlaceWork.Visible = true;
                family.statusSpous = true;
            }
            else
            {
                panelPlaceWork.Visible = false;
                family.statusSpous = false;
                family.professionSpous = null;
            }           
        }

        private void buttonSaveStudent_Click(object sender, EventArgs e)
        {
          
            SaveAll();
            this.FormClosing -= StudentForm_FormClosing;
            this.Close();
        }

        private void SaveAll()
        {
            try
            {
                if (IsFieldsEmptyStudent())
                    throw new Exception("Заполните обязательные поля");

                ReadSaveResidence();
                if (radioButtonInog.Checked == true)
                {
                    if (radioButtonHostel.Checked == true)
                    {
                        if (IsFieldsEmptyResidenceTempHostel())
                            throw new Exception("Заполните обязательные поля");
                    }
                    if (radioButtonPropiska.Checked == true || radioButtonOther.Checked == true)
                    {
                        if (IsFieldsEmptyResidenceTemp())
                            throw new Exception("Заполните обязательные поля");
                    }
                    SaveResidenceTemp();
                }
                if (IsFieldsEmptyFamily())
                    throw new Exception("Заполните обязательные поля");
                
                ReadSaveStudent();
                if (radioButtonSelectFamT.Checked == true)
                    ReadSaveFamily();
                else if (radioButtonSelectFamT.Checked == false && family.idFamily != 0)
                    DeleteFamily();
                SaveNewKin();
                DBobjects.Entities.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SaveNewKin()
        {
                foreach (Kin k in listRelatives)
                {
                    kin = k;
                    kin.idStudent = student.idStudent;
                    SaveKin();
                }
        }

        private bool IsFieldsEmptyStudent()
        {
            if (student.surnameStudent == null
                || student.nameStudent == null
                || student.telephoneStudent == null
                || student.nameSchoolStudent == null
                || residence.country == null
                || residence.region == null
                || residence.town == null
                || residence.house == null
                )
            {
                return true;
            }
            return false;
        }
        private bool IsFieldsEmptyFamily()
        {
            if ((radioButtonChildTrue.Checked == true && family.nameChild==null)
                || (radioButtonWork.Checked==true && family.professionSpous==null)
                || (radioButtonSelectFamT.Checked==true && family.fullNameSpous==null && family.nameChild==null))                
            {
                return true;
            }
            return false;
        }
        private bool IsFieldsEmptyResidenceTempHostel()
        {
            if (residenceTemp.room == "" )
            {
                return true;
            }
            return false;
        }
        private bool IsFieldsEmptyResidenceTemp()
        {
            if (residenceTemp.country == ""
                || residenceTemp.region == ""
                || residenceTemp.town == ""
                || residenceTemp.house == ""
                )
            {
                return true;
            }
            return false;
        }

        private void tbPathr_TextChanged(object sender, EventArgs e)
        {
            student.patronymicStudent = tbPathr.Text; 
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            student.nameStudent = tbName.Text;
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            student.surnameStudent = tbSurname.Text;
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked == true)
                student.formOfTrainStudent = false;
            else
                student.formOfTrainStudent = true;            
        }

        private void dateTimePickerDateBirth_ValueChanged(object sender, EventArgs e)
        {
            student.dateOfBirthStudent = dateTimePickerDateBirth.Value.Date;        }

        

        private void tbPlaceLern_TextChanged(object sender, EventArgs e)
        {
            student.nameSchoolStudent = tbPlaceLern.Text;
        }

        private void dateTimePickerLern_ValueChanged(object sender, EventArgs e)
        {
            student.yearOfManStudent = dateTimePickerLern.Value.Date;
        }

        private void radioButtonInT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInT.Checked == true)
                student.disabilityStudent = true;
            else
                student.disabilityStudent = false;
        }

        private void tbCountry_TextChanged(object sender, EventArgs e)
        {
            residence.country = tbCountry.Text;        
        }

        private void tbRegion_TextChanged(object sender, EventArgs e)
        {
            residence.region = tbRegion.Text;
        }

        private void tbDistrict_TextChanged(object sender, EventArgs e)
        {
            residence.district = tbDistrict.Text;
        }

        private void tbTown_TextChanged(object sender, EventArgs e)
        {
            residence.town = tbTown.Text;
        }

        private void tbStreet_TextChanged(object sender, EventArgs e)
        {
            residence.street = tbStreet.Text;
        }

        private void tbHouse_TextChanged(object sender, EventArgs e)
        {
            residence.house = tbHouse.Text;
        }

        private void tbKorpus_TextChanged(object sender, EventArgs e)
        {
            residence.korpus = tbKorpus.Text;
        }

        private void tbFlat_TextChanged(object sender, EventArgs e)
        {
            residence.flat = tbFlat.Text;
        }

        private void tbCountryT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true)
                residenceTemp.country = tbCountryT.Text;
        }

        private void tbRegionT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true)
                residenceTemp.region = tbRegionT.Text; 
        }

        private void tbDistrictT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true)
                residenceTemp.district = tbDistrictT.Text;
        }

        private void tbTownT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true) 
                residenceTemp.town = tbTownT.Text;  
        }

        private void tbStreetT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true)
                residenceTemp.street = tbStreetT.Text;
        }

        private void tbHouseT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true)               
                residenceTemp.house = tbHouseT.Text;     
        }

        private void tbKorpusT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true) 
                residenceTemp.korpus = tbKorpusT.Text;                
        }

        private void tbFlatT_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonOther.Checked == true) 
                residenceTemp.flat = tbFlatT.Text;
        }

        private void tbRoom_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonHostel.Checked == true)
               residenceTemp.room = tbRoom.Text;                   
        }

        private void listBoxHostel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radioButtonInog.Checked == true && radioButtonHostel.Checked == true)
            {
                if(listBoxHostel.SelectedItem!=null)
                    residenceTemp.idHostel = DBobjects.Entities.Hostel.FirstOrDefault(p => p.nameHostel == listBoxHostel.SelectedItem).idHostel;
            }
        }

        private void maskedTextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            student.telephoneStudent = maskedTextBoxPhone.Text;
        }

        private void tbProfesion_TextChanged(object sender, EventArgs e)
        {
            family.professionSpous = tbProfesion.Text;
        }

        private void tbChild_TextChanged(object sender, EventArgs e)
        {
            family.nameChild = tbChild.Text;
        }

        private void dateTimePickerDateBirthChild_ValueChanged(object sender, EventArgs e)
        {
            family.dateOfBirthChild = dateTimePickerDateBirthChild.Value.Date;
        }

        private void tbFIOSpous_TextChanged(object sender, EventArgs e)
        { 
            family.fullNameSpous = tbFIOSpous.Text;
        }

        private void bAddKin_Click(object sender, EventArgs e)
        {
            kin = new Kin();
            tbPlaceEmployment.Text = null;
            tbFIOKin.Text = null;
            maskedTextBoxKinPhone.Text = null;
            kin.disabilityKin=false;
            listBoxKinStatus.SelectedItem = listBoxKinStatus.Items[0];
            panelRelatives.Visible = true;
            flag = true;
        }

        private void listBoxKinStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            kin.kinStatus = listBoxKinStatus.SelectedItem.ToString();
        }
        private void addListKin()
        {
            if (kin.fullNameKin != null)
            {
                if (listRelatives.Where(p => p.kinStatus == kin.kinStatus).Count() == 0)
                    listRelatives.Add(kin);
                else if ((kin.kinStatus == "Брат" || kin.kinStatus == "Сестра") && flag == true)
                    listRelatives.Add(kin);
                else if ((kin.kinStatus == "Мать" || kin.kinStatus == "Отец") && (listRelatives.Where(p => p.kinStatus == "Мать" || p.kinStatus == "Отец").Count() > 0))
                    MessageBox.Show("Уже есть");
            }
            else
                MessageBox.Show("Заполните обязательное поле");
        }

        private void tbFIOKin_TextChanged(object sender, EventArgs e)
        {
            kin.fullNameKin = tbFIOKin.Text;
        }

        private void maskedTextBoxKinPhone_TextChanged(object sender, EventArgs e)
        {
            kin.telephoneKin = maskedTextBoxKinPhone.Text;
        }

        private void radioButtonInvKinT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInvKinT.Checked == true)
                kin.disabilityKin = true;
            else
                kin.disabilityKin = false;
        }

        private void tbPlaceEmployment_TextChanged(object sender, EventArgs e)
        {
            kin.placeOfWorkKin = tbPlaceEmployment.Text;
        }

        private void bSaveKin_Click(object sender, EventArgs e)
        {
            kin.idStudent = student.idStudent;
            addListKin();            
            KinFill();
            panelRelatives.Visible = false;
        }
        private void SaveKin()
        {
            if (DBobjects.Entities.Kin.Where(p => p.idKin == kin.idKin).Count() == 0)
            {
                DBobjects.Entities.Kin.Add(kin);
            }
            DBobjects.Entities.SaveChanges();
        }

        private void bDeleteKin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DeleteKin();
                panelRelatives.Visible = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (DBobjects.Entities.Student.Where(p => p.idStudent == student.idStudent).Count() > 0)
                {
                    DBobjects.Entities.Residence.Remove(residence);
                    if (residenceTemp.idResidence!=0)
                        DBobjects.Entities.Residence.Remove(residenceTemp);
                    DBobjects.Entities.Student.Remove(student);
                    DBobjects.Entities.SaveChanges();
                }
                this.FormClosing -= StudentForm_FormClosing;
                this.Close();
            }
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveAll();
            }
        }     

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {                     
                language = DBobjects.Entities.Language.FirstOrDefault(p => p.nameLanguage == comboBoxLang.Text);          
        }        
    }
}
