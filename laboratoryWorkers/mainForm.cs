using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace laboratoryWorkers
{
    public enum TypeOperation
    {
        Addrecord,
        Editrecord
    }

    public enum TypeDictionary 
    {
        Academicdegree,
        Familystatus,
        Gender,
        Position
    }

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Database.InitialDatabase();
       
            dataGridView.DataSource = Database.datatable;
            setDataGreedView();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            autoriz = new autorizForm();
            Hide();
            autoriz.ShowDialog();
            Show();
            if (Account.Login is null)
            {
                Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search = new searchWindow();
            search.ShowDialog();
            dataGridView.DataSource = Database.datatable;
        }

        private void buttonSkipFiltr_Click(object sender, EventArgs e)
        {
            Database.fillMainDatatable();
            dataGridView.DataSource = Database.datatable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Account.canAddWorker()) 
            {
                add = new addWindow(TypeOperation.Addrecord, (long)dataGridView.CurrentRow.Cells[0].Value);
                add.ShowDialog();
                dataGridView.DataSource = Database.datatable;
            }
            else
            {
                MessageBox.Show("У вас нет прав на добавление/удаление сотрудников!", 
                               "Сообщение", 
                               MessageBoxButtons.OK, 
                               MessageBoxIcon.Information, 
                               MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (Account.canUpdWorker())
            {
                add = new addWindow(TypeOperation.Editrecord, Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value));
                add.ShowDialog();
                dataGridView.DataSource = Database.datatable;
            }
            else
            {
                MessageBox.Show("У вас нет прав на изменение данных работников!",
                               "Сообщение",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
            }


        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            if (Account.canEditDictionary())
            {
                selectDictionary = new selectDictionary();
                selectDictionary.ShowDialog();
                dataGridView.DataSource = Database.datatable;
            }
            else
            {
                MessageBox.Show("У вас нет прав на работу со словарями!",
                               "Сообщение",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Account.canAddWorker())
            {
                Database.dbdel(new LaboratoryWorkers() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value) });
                Database.fillMainDatatable();
                dataGridView.DataSource = Database.datatable;
            }
            else
            {
                MessageBox.Show("У вас нет прав на добавление/удаление сотрудников!",
                               "Сообщение",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonDocumentPrint_Click(object sender, EventArgs e)
        {
            DataGridViewPrinter.printInfo(dataGridView);
        }
  
        private void setDataGreedView()
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 70;
            dataGridView.Columns[5].Width = 40;
            dataGridView.Columns[6].Width = 80;
            dataGridView.Columns[7].Width = 80;
            dataGridView.Columns[8].Width = 80;
            dataGridView.Columns[9].Width = 100;
        }

        private autorizForm autoriz;
        private searchWindow search;
        private addWindow add;
        private selectDictionary selectDictionary;

    }
}
