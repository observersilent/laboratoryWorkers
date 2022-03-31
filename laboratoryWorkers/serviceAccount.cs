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
    public partial class serviceAccount : Form
    {
        public serviceAccount()
        {
            InitializeComponent();
            dataGridView.DataSource = Database.accounttable;
            setDataGreedView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add = new addAccount(TypeOperation.Addrecord, (long)dataGridView.CurrentRow.Cells[0].Value);
            add.ShowDialog();
            dataGridView.DataSource = Database.accounttable;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            add = new addAccount(TypeOperation.Editrecord, (long)dataGridView.CurrentRow.Cells[0].Value);
            add.ShowDialog();
            dataGridView.DataSource = Database.accounttable;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Database.dbdel(new Accounts() { Id = Convert.ToInt64(dataGridView.CurrentRow.Cells[0].Value) });
            Database.fillDatatable(ref Database.accounttable);
            dataGridView.DataSource = Database.accounttable;
        }


        private void setDataGreedView()
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[1].HeaderText = "Логин";

            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Пароль";

            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[3].HeaderText = "Обновление данных";

            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].HeaderText = "Внесение данных";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderText = "Доступ к словарям";

        }

        private addAccount add;

    }
}
