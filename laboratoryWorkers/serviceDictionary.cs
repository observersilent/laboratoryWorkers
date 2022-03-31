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
    public partial class serviceDictionary : Form
    {
        public serviceDictionary(TypeDictionary type)
        {
            InitializeComponent();
            typedict = type;

            fillDataGridView();
            setDataGreedView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add = new addDictionary(TypeOperation.Addrecord, typedict, (long)dataGridView.CurrentRow.Cells[0].Value);
            add.ShowDialog();
            fillDataGridView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            add = new addDictionary(TypeOperation.Editrecord, typedict, (long)dataGridView.CurrentRow.Cells[0].Value);
            add.ShowDialog();
            fillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (typedict)
            {
                case TypeDictionary.Academicdegree:
                    Database.dbdel(new Academic_degree() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value)});
                    Database.fillDatatable(ref Database.academdegrtable);
                    dataGridView.DataSource = Database.academdegrtable;
                    break;
                case TypeDictionary.Familystatus:
                    Database.dbdel(new Family_status() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value) });
                    Database.fillDatatable(ref Database.fstatustable);
                    dataGridView.DataSource = Database.fstatustable;
                    break;
                case TypeDictionary.Gender:
                    Database.dbdel(new Genders() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value) });
                    Database.fillDatatable(ref Database.gendertable);
                    dataGridView.DataSource = Database.gendertable;
                    break;
                case TypeDictionary.Position:
                    Database.dbdel(new Position() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value) });
                    Database.fillDatatable(ref Database.positiontable);
                    dataGridView.DataSource = Database.positiontable;
                    break;
            }
        }

        private void fillDataGridView()
        {
            switch (typedict)
            {
                case TypeDictionary.Academicdegree:
                    dataGridView.DataSource = Database.academdegrtable;
                    break;
                case TypeDictionary.Familystatus:
                    dataGridView.DataSource = Database.fstatustable;
                    break;
                case TypeDictionary.Gender:
                    dataGridView.DataSource = Database.gendertable;
                    break;
                case TypeDictionary.Position:
                    dataGridView.DataSource = Database.positiontable;
                    break;
            }
        }

        private void setDataGreedView()
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 200;

            switch (typedict)
            {
                case TypeDictionary.Academicdegree:
                    dataGridView.Columns[1].HeaderText = "Ученая степень";
                    break;
                case TypeDictionary.Familystatus:
                    dataGridView.Columns[1].HeaderText = "Семейное положение";
                    break;
                case TypeDictionary.Gender:
                    dataGridView.Columns[1].HeaderText = "Пол";
                    break;
                case TypeDictionary.Position:
                    dataGridView.Columns[1].HeaderText = "Должность";
                    break;
            }
            
        }

        private TypeDictionary typedict { get; set; }
        private addDictionary add;
    }
}
