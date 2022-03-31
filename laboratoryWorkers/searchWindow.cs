using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace laboratoryWorkers
{
    public partial class searchWindow : Form
    {
        public searchWindow()
        {
            InitializeComponent();
            setElementControlView();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Database.dbSearch(workerName, 
                              workerSurname, 
                              workerMiddlename, 
                              workerBirthday, 
                              workerBirthdayActive, 
                              haveChildren,
                              workerGender,
                              workerFamilystatus,
                              workerPosition,
                              workerAcademicdegree);
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            workerName = textBoxName.Text;   
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            workerSurname = textBoxSurname.Text;
        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {
            workerMiddlename = textBoxMiddleName.Text;
        }

        private void dateTimePickerBirthday_CloseUp(object sender, EventArgs e)
        {
            dateTimePickerBirthday.Format = DateTimePickerFormat.Short;
        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            workerBirthday = dateTimePickerBirthday.Value;
            workerBirthdayActive = dateTimePickerBirthday.Checked;
        }

        private void comboBoxHaveChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            haveChildren = comboBoxHaveChildren.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerGender = comboBoxGender.Text;
        }

        private void comboBoxFamilyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerFamilystatus = comboBoxFamilyStatus.Text;
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerPosition = comboBoxPosition.Text;
        }

        private void comboBoxAcademicDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerAcademicdegree = comboBoxAcademicDegree.Text;
        }

        private void setElementControlView()
        {
            Text = "Окно поиска";
            //настройка элемента DateTimePicher
            dateTimePickerBirthday.Checked = false;
            workerBirthday = dateTimePickerBirthday.Value;
            workerBirthdayActive = dateTimePickerBirthday.Checked;

            //найстройка checkbox наличия детей
            comboBoxHaveChildren.Items.AddRange(new string[] {"" ,"NO", "YES" });
            haveChildren = comboBoxHaveChildren.Text;

            //настройка checkbox для пола
            DataTable tableGender = new DataTable();
            tableGender = Database.getDatatable(Database.sqlGender);
            comboBoxGender.DisplayMember = "name";
            comboBoxGender.ValueMember = "id";
            comboBoxGender.DataSource = tableGender.AsDataView();
            comboBoxGender.Text = "";
            workerGender = comboBoxGender.Text;

            //настройка checkbox для семейного статуса
            DataTable tableFamilyStatus = new DataTable();
            tableFamilyStatus = Database.getDatatable(Database.sqlFamilyStatus);
            comboBoxFamilyStatus.DisplayMember = "name";
            comboBoxFamilyStatus.ValueMember = "id";
            comboBoxFamilyStatus.DataSource = tableFamilyStatus.AsDataView();
            comboBoxFamilyStatus.Text = "";
            workerFamilystatus = comboBoxFamilyStatus.Text;

            //настойка для должности
            DataTable tablePosition = new DataTable();
            tablePosition = Database.getDatatable(Database.sqlPosition);
            comboBoxPosition.DisplayMember = "name";
            comboBoxPosition.ValueMember = "id";
            comboBoxPosition.DataSource = tablePosition.AsDataView();
            comboBoxPosition.Text = "";
            workerPosition = comboBoxPosition.Text;

            //Настройки для ученой степени
            DataTable tableAcademicDegree = new DataTable();
            tableAcademicDegree = Database.getDatatable(Database.sqlAcademicDegree);
            comboBoxAcademicDegree.DisplayMember = "name";
            comboBoxAcademicDegree.ValueMember = "id";
            comboBoxAcademicDegree.DataSource = tableAcademicDegree.AsDataView();
            comboBoxAcademicDegree.Text = "";
            workerAcademicdegree = comboBoxAcademicDegree.Text;
        }

        private string workerName { get; set; } = null;
        private string workerSurname { get; set; } = null;
        private string workerMiddlename { get; set; } = null;
        private DateTime workerBirthday { get; set; }
        private bool workerBirthdayActive { get; set; }
        private string haveChildren { get; set; }
        private string workerGender { get; set; }
        private string workerFamilystatus { get; set; }
        private string workerPosition { get; set; } = null;
        private string workerAcademicdegree { get; set; } = null;

    }
}
