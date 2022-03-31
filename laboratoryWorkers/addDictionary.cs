using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratoryWorkers
{
    public partial class addDictionary : Form
    {
        public addDictionary(TypeOperation typeOper, TypeDictionary typeDict, long id)
        {
            InitializeComponent();
            typeOperation = typeOper;
            typeDictionary = typeDict;
            IdRecord = id;
            setElementControlAdd();

            if (typeOperation == TypeOperation.Editrecord) setElementControlEdit();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            valueName = textBoxName.Text;
            validateData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (typeOperation == TypeOperation.Addrecord)
            {
                switch (typeDictionary)
                {
                    case TypeDictionary.Academicdegree:
                        Database.dbadd(new Academic_degree() {Name = valueName });
                        Database.fillDatatable(ref Database.academdegrtable);
                        break;
                    case TypeDictionary.Familystatus:
                        Database.dbadd(new Family_status() { Name = valueName});
                        Database.fillDatatable(ref Database.fstatustable);
                        break;
                    case TypeDictionary.Gender:
                        Database.dbadd(new Genders() { Name = valueName});
                        Database.fillDatatable(ref Database.gendertable);
                        break;
                    case TypeDictionary.Position:
                        Database.dbadd(new Position() { Name = valueName });
                        Database.fillDatatable(ref Database.positiontable);
                        break;
                }
            }

            if (typeOperation == TypeOperation.Editrecord)
            {
                switch (typeDictionary)
                {
                    case TypeDictionary.Academicdegree:
                        Database.dbupd(new Academic_degree() {Id = IdRecord, Name = valueName });
                        Database.fillDatatable(ref Database.academdegrtable);
                        break;
                    case TypeDictionary.Familystatus:
                        Database.dbupd(new Family_status() { Id = IdRecord, Name = valueName });
                        Database.fillDatatable(ref Database.fstatustable);
                        break;
                    case TypeDictionary.Gender:
                        Database.dbupd(new Genders() { Id = IdRecord, Name = valueName });
                        Database.fillDatatable(ref Database.gendertable);
                        break;
                    case TypeDictionary.Position:
                        Database.dbupd(new Position() { Id = IdRecord, Name = valueName });
                        Database.fillDatatable(ref Database.positiontable);
                        break;
                }
            }
            Close();
        }

        private void validateData()
        {
            bool name = !string.IsNullOrEmpty(valueName);
            buttonAdd.Enabled = name;
        }

        private void setElementControlAdd()
        {
            labelTitle.Text = "Добавление в справочник";
            Text = "Добавление в справочник";
            buttonAdd.Enabled = false;
            valueName = textBoxName.Text;        
        }

        private void setElementControlEdit()
        {
            buttonAdd.Enabled = true;
            labelTitle.Text = "Редактирование справочника";
            Text = "Редактирование справочника";

            IDictionaryRow row = null;
            switch (typeDictionary)
            {
                case TypeDictionary.Academicdegree:
                    row = Database.dbgetrow(new Academic_degree() { Id = IdRecord });
                    break;
                case TypeDictionary.Familystatus:
                    row = Database.dbgetrow(new Family_status() { Id = IdRecord });
                    break;
                case TypeDictionary.Gender:
                    row = Database.dbgetrow(new Genders() { Id = IdRecord });
                    break;
                case TypeDictionary.Position:
                    row = Database.dbgetrow(new Position() { Id = IdRecord });
                    break;
            }
            valueName = row.Name;
            textBoxName.Text = valueName;
        }

        private string valueName { get; set; }
        private long IdRecord { get; set; }
        private TypeOperation typeOperation { get; set; }
        private TypeDictionary typeDictionary { get; set; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
