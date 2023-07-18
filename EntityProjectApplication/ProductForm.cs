using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        EntityProductEntities db = new EntityProductEntities();

        private void BtnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Product
                                        select new
                                        {
                                            x.ID,
                                            x.Name,
                                            x.Brand,
                                            x.Stock,
                                            x.Price,
                                            x.Category,
                                            x.Status
                                        }).ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = TxtProductName.Text;
            product.Brand = TxtBrand.Text;
            product.Stock = short.Parse(TxtStock.Text);
            product.Category = int.Parse(CmbCategory.SelectedValue.ToString());
            product.Price = decimal.Parse(TxtPrice.Text);
            product.Status = true;
            db.Product.Add(product);
            db.SaveChanges();
            MessageBox.Show("The product has been registered in the system");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var product = db.Product.Find(x);
            db.Product.Remove(product);
            db.SaveChanges();
            MessageBox.Show("The Product is Deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var product = db.Product.Find(x);
            product.Name = TxtProductName.Text;
            product.Brand = TxtBrand.Text;
            product.Stock = short.Parse(TxtStock.Text);
            db.SaveChanges();
            MessageBox.Show("The Product is Updated");
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            var categories = (from x in db.Category
                              select new
                              {
                                  x.ID,
                                  x.Name
                              }
                              ).ToList();
            CmbCategory.ValueMember = "ID";
            CmbCategory.DisplayMember = "Name";
            CmbCategory.DataSource = categories;
        }
    }
}
