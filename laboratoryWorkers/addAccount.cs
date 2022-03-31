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
    public partial class addAccount : Form
    {
        public addAccount(TypeOperation type, long id)
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
            if(TypeOper == TypeOperation.Addrecord)
            {
                Accounts account = new Accounts()
                {
                    Login = Login,
                    Password = Password,
                    Update_employeed = UpdateWorker,
                    Insert_employee = InsertDel,
                    Allow_dictionary = Dictionary
                };

                Database.dbadd(account);
                Database.fillDatatable(ref Database.accounttable);
            }

            if (TypeOper == TypeOperation.Editrecord)
            {
                Accounts account = new Accounts()
                {
                    Id = IdRecord,
                    Login = Login,
                    Password = Password,
                    Update_employeed = UpdateWorker,
                    Insert_employee = InsertDel,
                    Allow_dictionary = Dictionary
                };

                Database.dbupd(account);
                Database.fillDatatable(ref Database.accounttable);
            }

            Close();
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            Login = textBoxLogin.Text;
            validateData();
        }

        private void textBoxPassord_TextChanged(object sender, EventArgs e)
        {
            Password = textBoxPassord.Text;
            validateData();
        }

        private void comboBoxUpdateWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWorker = comboBoxUpdateWorker.Text;
            validateData();
        }

        private void comboBoxInsertDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertDel = comboBoxInsertDel.Text;
            validateData();
        }

        private void comboBoxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary = comboBoxDictionary.Text;
            validateData();
        }

        private void setElementControlAdd() 
        { 
            labelTitle.Text = "Добавление аккаунта";
            Text = "Добавление аккаунта";    
            buttonAdd.Enabled = false;
           
            comboBoxUpdateWorker.Items.AddRange(new string[] {"NO", "YES" });
            comboBoxUpdateWorker.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateWorker = comboBoxUpdateWorker.Text;

            comboBoxInsertDel.Items.AddRange(new string[] { "NO", "YES" });
            comboBoxInsertDel.DropDownStyle = ComboBoxStyle.DropDownList;
            InsertDel = comboBoxInsertDel.Text;

            comboBoxDictionary.Items.AddRange(new string[] { "NO", "YES" });
            comboBoxDictionary.DropDownStyle = ComboBoxStyle.DropDownList;
            Dictionary = comboBoxDictionary.Text;
        }

        private void setElementControlEdit()
        {
            buttonAdd.Enabled = true;
            labelTitle.Text = "Редактирование аккаунтов";
            Text = "Редактирование аккаунтов";

            Accounts account = Database.dbgetrow(new Accounts() { Id = IdRecord });
            Login = account.Login;
            textBoxLogin.Text = Login;

            Password = account.Password;
            textBoxPassord.Text = Password;

            UpdateWorker = account.Update_employeed;
            comboBoxUpdateWorker.SelectedItem = UpdateWorker;

            InsertDel = account.Insert_employee;
            comboBoxInsertDel.SelectedItem = InsertDel;

            Dictionary = account.Allow_dictionary;
            comboBoxDictionary.SelectedItem = Dictionary;

        }

        private void validateData()
        {
            bool login = !string.IsNullOrEmpty(Login);
            bool password = !string.IsNullOrEmpty(Password);
            bool update = !string.IsNullOrEmpty(UpdateWorker);
            bool inserdel = !string.IsNullOrEmpty(InsertDel);
            bool dict = !string.IsNullOrEmpty(Dictionary);

            buttonAdd.Enabled = login && password && update && inserdel && dict ? true : false;
        }

        private TypeOperation TypeOper { get; set; }
        private long IdRecord { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }

        private string UpdateWorker { get; set; }
        private string InsertDel { get; set; }
        private string Dictionary { get; set; }

    }




}
