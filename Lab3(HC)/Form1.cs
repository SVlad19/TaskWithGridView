using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;

            DataPerson.name = "Alex";
            DataPerson.surname = "Ken";
            DataPerson.age = 20;

            DataBook.nameBook= "When Charley Met Emma";
            DataBook.Author = " Amy Webb";
            DataBook.page = 250;
            DataBook.year = 2018;

            DataBook.table = new DataTable();
            DataPerson.table = new DataTable();

            DataPerson.table.Columns.Add("Name", typeof(string));
            DataPerson.table.Columns.Add("Surname", typeof(string));
            DataPerson.table.Columns.Add("Age", typeof(string));

            DataBook.table.Columns.Add("Book", typeof(string));
            DataBook.table.Columns.Add("Author", typeof(string));
            DataBook.table.Columns.Add("Page", typeof(string));
            DataBook.table.Columns.Add("Year", typeof(string));

            DataBook.table.Rows.Add(DataBook.nameBook, DataBook.Author, DataBook.page,
                    DataBook.year);  
            
            DataPerson.table.Rows.Add(DataPerson.name, DataPerson.surname, DataPerson.age);


            dataGridView.DataSource = DataBook.table;
            dataGridView1.DataSource = DataPerson.table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(rowIndex);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];

            if (row.DefaultCellStyle.BackColor == Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
           
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();

            registration.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string query = tbSearch.Text;

            int rowIndex = dataGridView.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Cells.Cast<DataGridViewCell>()
                    .Any(c => c.Value.ToString().Contains(query)))
                .Select(r => r.Index)
                .FirstOrDefault();

            if (rowIndex >= 0)
            {
                dataGridView.CurrentCell = dataGridView[0, rowIndex];
                dataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
    }
}
