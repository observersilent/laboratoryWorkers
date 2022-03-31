using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratoryWorkers
{
    public partial class addWindow : Form
    {
        public addWindow(TypeOperation type, long id)
        {
            InitializeComponent();
            TypeOper = type;
            IdRecord = id;
            setElementControlAdd();

            if (TypeOper == TypeOperation.Editrecord) setElementControlEdit();            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TypeOper == TypeOperation.Addrecord) 
            {
                LaboratoryWorkers worker = new LaboratoryWorkers()
                {
                    Name = workerName,
                    Surname = workerSurname,
                    Middlename = workerMiddlename,
                    Have_children = haveChildren,
                    Birthday = workerBirthdayActive ? workerBirthday : DateTime.MinValue,
                    Gender = workerGender,
                    Family_status = workerFamilystatus,
                    Position = workerPosition,
                    Academic_degree = workerAcademicdegree
                };

                Database.dbadd(worker);
                Database.fillMainDatatable();
            }
            if(TypeOper == TypeOperation.Editrecord)
            {
                LaboratoryWorkers worker = new LaboratoryWorkers()
                {
                    Id = IdRecord,
                    Name = workerName,
                    Surname = workerSurname,
                    Middlename = workerMiddlename,
                    Have_children = haveChildren,
                    Birthday = workerBirthdayActive ? workerBirthday : DateTime.MinValue,
                    Gender = workerGender,
                    Family_status = workerFamilystatus,
                    Position = workerPosition,
                    Academic_degree = workerAcademicdegree
                };

                Database.dbupd(worker);
                Database.fillMainDatatable();
            }

            Close();
        }


        //--------------------------------------------------------------------------------------
        private void maskedTextBoxName_TextChanged(object sender, EventArgs e)
        {
            workerName = maskedTextBoxName.Text;
            validateData();
        }
        private void maskedTextBoxSurname_TextChanged(object sender, EventArgs e)
        {
            workerSurname = maskedTextBoxSurname.Text;
            validateData();
        }
        private void maskedTextBoxMiddleName_TextChanged(object sender, EventArgs e)
        {
            workerMiddlename = maskedTextBoxMiddleName.Text;
            validateData();
        }
        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            workerBirthday = dateTimePickerBirthday.Value.Date;
            workerBirthdayActive = dateTimePickerBirthday.Checked;
        }
        private void comboBoxHaveChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            haveChildren = comboBoxHaveChildren.Text;
        }
        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerGender = (long)comboBoxGender.SelectedValue;
        }
        private void comboBoxFamilyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerFamilystatus = (long)comboBoxFamilyStatus.SelectedValue;
        }
        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerPosition = (long)comboBoxPosition.SelectedValue;
        }
        private void comboBoxAcademicDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerAcademicdegree = (long)comboBoxAcademicDegree.SelectedValue;
        }

        //--------------------------------------------------------------------------------------
        private void validateData()
        {
            bool name = !string.IsNullOrEmpty(maskedTextBoxName.Text);
            bool surname = !string.IsNullOrEmpty(maskedTextBoxSurname.Text);
            bool middlename = !string.IsNullOrEmpty(maskedTextBoxMiddleName.Text);

            buttonAdd.Enabled = name && surname && middlename ? true : false;
        }
        private void setElementControlAdd()
        {
            //название формы
            Text = "Добавление записи";
            labelTitle.Text = "Добавление записи";
            //изначально делаем кнопку не активной
            buttonAdd.Enabled = false;

            //настройка элемента DateTimePicher
            dateTimePickerBirthday.MinDate = DateTime.MinValue;
            dateTimePickerBirthday.Checked = false;
            workerBirthday = dateTimePickerBirthday.Value.Date;
            workerBirthdayActive = dateTimePickerBirthday.Checked;

            //найстройка checkbox наличия детей
            comboBoxHaveChildren.Items.AddRange(new string[] { "", "NO", "YES" });
            comboBoxHaveChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            haveChildren = comboBoxHaveChildren.Text;

            //настройка checkbox для пола
            DataTable tableGender = new DataTable();
            tableGender = Database.getDatatable(Database.sqlGender);
            comboBoxGender.DisplayMember = "name";
            comboBoxGender.ValueMember = "id";
            comboBoxGender.DataSource = tableGender.AsDataView();
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            workerGender = (long)comboBoxGender.SelectedValue;

            //настройка checkbox для семейного статуса
            DataTable tableFamilyStatus = new DataTable();
            tableFamilyStatus = Database.getDatatable(Database.sqlFamilyStatus);
            comboBoxFamilyStatus.DisplayMember = "name";
            comboBoxFamilyStatus.ValueMember = "id";
            comboBoxFamilyStatus.DataSource = tableFamilyStatus.AsDataView();
            comboBoxFamilyStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            workerFamilystatus = (long)comboBoxFamilyStatus.SelectedValue;

            //настойка для должности
            DataTable tablePosition = new DataTable();
            tablePosition = Database.getDatatable(Database.sqlPosition);
            comboBoxPosition.DisplayMember = "name";
            comboBoxPosition.ValueMember = "id";
            comboBoxPosition.DataSource = tablePosition.AsDataView();
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            workerPosition = (long)comboBoxPosition.SelectedValue;

            //Настройки для ученой степени
            DataTable tableAcademicDegree = new DataTable();
            tableAcademicDegree = Database.getDatatable(Database.sqlAcademicDegree);
            comboBoxAcademicDegree.DisplayMember = "name";
            comboBoxAcademicDegree.ValueMember = "id";
            comboBoxAcademicDegree.DataSource = tableAcademicDegree.AsDataView();
            comboBoxAcademicDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            workerAcademicdegree = (long)comboBoxAcademicDegree.SelectedValue;
        }
        private void setElementControlEdit()
        {
            Text = "Редактирование записи";
            labelTitle.Text = "Редактирование записи";
            //изначально делаем кнопку активной
            buttonAdd.Enabled = true;

            LaboratoryWorkers worker = Database.dbgetrow(new LaboratoryWorkers() { Id = IdRecord});

            workerName = worker.Name;
            maskedTextBoxName.Text = workerName;

            workerSurname = worker.Surname;
            maskedTextBoxSurname.Text = workerSurname;

            workerMiddlename = worker.Middlename;
            maskedTextBoxMiddleName.Text = workerMiddlename;

            workerBirthdayActive = worker.Birthday == DateTime.MinValue ? false : true;
            workerBirthday = workerBirthdayActive ? worker.Birthday : DateTime.Now.Date;
            dateTimePickerBirthday.Checked = workerBirthdayActive;
            dateTimePickerBirthday.Value = workerBirthday;

            haveChildren = worker.Have_children;
            comboBoxHaveChildren.SelectedItem = haveChildren;

            workerGender = worker.Gender;
            comboBoxGender.SelectedValue = workerGender;

            workerFamilystatus = worker.Family_status;
            comboBoxFamilyStatus.SelectedValue = workerFamilystatus;

            workerPosition = worker.Position;
            comboBoxPosition.SelectedValue = workerPosition;

            workerAcademicdegree = worker.Academic_degree;
            comboBoxAcademicDegree.SelectedValue = workerAcademicdegree;

        }
        //--------------------------------------------------------------------------------------


        private TypeOperation TypeOper { get; set; }
        private long IdRecord { get; set; }
        private string workerName { get; set; } = null;
        private string workerSurname { get; set; } = null;
        private string workerMiddlename { get; set; } = null;
        private DateTime workerBirthday { get; set; }
        private bool workerBirthdayActive { get; set; }
        private string haveChildren { get; set; }
        private long workerGender { get; set; }
        private long workerFamilystatus { get; set; }
        private long workerPosition { get; set; }
        private long workerAcademicdegree { get; set; }
    }
}
