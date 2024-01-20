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


namespace _13.SimleForm.Categories
{
    public partial class CategoryCreationForm : Form
    {
        private CategoryManager _CategoryManager;
        public CategoryCreationForm(SqlConnection _con)
        {
            _CategoryManager = new CategoryManager(_con);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = _CategoryManager.AddCategory(txtName.Text, txtDescription.Text, txtURL.Text);
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "Pictures", fileName);
                pbImage.Image = new Bitmap(fullPath);
                MessageBox.Show("Category created successfully");
            }
            catch(Exception ex) { MessageBox.Show($"Error occured while category was creating. Check whether url is http not https \n{ex.Message}"); }
        }
    }
}
