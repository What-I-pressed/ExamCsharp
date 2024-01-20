using _13.SimleForm.Services;
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

namespace _13.SimleForm.Categories
{
    public partial class CategoryListForm : Form
    {
        private CategoryManager _CategoryManager;
        private int ID = 1;

        public CategoryListForm(SqlConnection _con)
        {
            _CategoryManager = new CategoryManager(_con);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void pbImage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var category = _CategoryManager.GetCategory(++ID);
            if (category != null)
            {
                lblNameText.Text = category["Name"];
                lblDescriptionText.Text = category["Description"];
                pbImage.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "Pictures", category["Image"]);
                lblCreatedDateText.Text = category["CreatedDate"];
            }
            else
            {
                MessageBox.Show("It is last category in table!");
            }
        }
    }
}
