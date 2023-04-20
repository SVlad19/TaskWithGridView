using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Lab3_HC_
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbAuthor.Text != "" && tbPage.Text != "" && tbYear.Text !="") {
                DataBook.nameBook = tbName.Text;
                DataBook.Author = tbAuthor.Text;
                DataBook.page = int.Parse(tbPage.Text);
                DataBook.year = int.Parse(tbYear.Text);

                DataBook.table.Rows.Add(DataBook.nameBook, DataBook.Author, DataBook.page,
                    DataBook.year);
            }
            else
            {
                MessageBox.Show("You haven`t enter some data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

            Close();
        }
    }
}
