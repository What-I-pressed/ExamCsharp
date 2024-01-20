using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _13.SimleForm.Services;
using _13.SimleForm.Categories;

namespace _13.SimleForm
{
    public partial class TablesForm : Form
    {
        public string DatabaseName { get; set; }
        private TableManager _TableManager;

        public TablesForm()
        {
            InitializeComponent();
        }

        private void LoadTablesList()
        {
            dgvTables.Rows.Clear();
            var list = _TableManager.GetTablesList();
            foreach (var name in list)
            {
                object[] row = { name };
                dgvTables.Rows.Add(row);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string tableName = dgvTables.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if(tableName == "tblCategories")
                {
                    CategoryListForm CLform = new CategoryListForm(_TableManager.GetSqlConnection());
                    CLform.ShowDialog();
                }
            }
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            _TableManager = new TableManager(DatabaseName);
            LoadTablesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _TableManager.AddCategoryTable();
            LoadTablesList();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryCreationForm dlg = new CategoryCreationForm(_TableManager.GetSqlConnection());
            dlg.ShowDialog();
        }
    }
}
