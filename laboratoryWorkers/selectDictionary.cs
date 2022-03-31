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
    public partial class selectDictionary : Form
    {
        public selectDictionary()
        {
            InitializeComponent();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            serviceaccount = new serviceAccount();
            serviceaccount.ShowDialog();
        }

        private void buttonAcademicDegree_Click(object sender, EventArgs e)
        {
            servicedictionary = new serviceDictionary(TypeDictionary.Academicdegree);
            servicedictionary.ShowDialog();
        }

        private void buttonFamilyStatus_Click(object sender, EventArgs e)
        {
            servicedictionary = new serviceDictionary(TypeDictionary.Familystatus);
            servicedictionary.ShowDialog();
        }

        private void buttonGender_Click(object sender, EventArgs e)
        {
            servicedictionary = new serviceDictionary(TypeDictionary.Gender);
            servicedictionary.ShowDialog();
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            servicedictionary = new serviceDictionary(TypeDictionary.Position);
            servicedictionary.ShowDialog();
        }

        private serviceAccount serviceaccount;
        private serviceDictionary servicedictionary;
    }
}
