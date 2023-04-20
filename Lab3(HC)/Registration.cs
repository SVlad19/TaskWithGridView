using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_HC_
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSurname.Text != "" && tbAge.Text != "")
            {
                DataPerson.name = tbName.Text;
                DataPerson.surname = tbSurname.Text;
                DataPerson.age = int.Parse(tbAge.Text);

                DataPerson.table.Rows.Add(DataPerson.name, DataPerson.surname, DataPerson.age);
            }
            else
            {
                MessageBox.Show("You haven`t enter some data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Close();
        }
    }
}
