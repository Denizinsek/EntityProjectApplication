using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntityProductEntities db = new EntityProductEntities();

        private void BtnList_Click(object sender, EventArgs e)
        {
            var categories = db.Category.ToList();
            dataGridView1.DataSource = categories;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = textBox2.Text;
            db.Category.Add(category);
            db.SaveChanges();
            MessageBox.Show("Category Added");
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var category = db.Category.Find(x);
            db.Category.Remove(category);
            db.SaveChanges();
            MessageBox.Show("Category Deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var category = db.Category.Find(x);
            category.Name = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Category Updated");
        }
    }
}
