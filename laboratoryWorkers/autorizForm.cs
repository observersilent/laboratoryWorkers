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
    public partial class autorizForm : Form
    {
        public autorizForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Account.connectAccount(textBoxLogin.Text, textBoxPassword.Text);

            if (Account.Login is null)
            {
                labelAutorizStatus.ForeColor = Color.Red;
                labelAutorizStatus.Text = "Неверный логин или пароль";
            }
            else
            {
                labelAutorizStatus.ForeColor = Color.Green;
                labelAutorizStatus.Text = "Верный логин или пароль";
                Close();
            }
        }

    }
}
