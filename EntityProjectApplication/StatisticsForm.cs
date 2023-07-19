using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        EntityProductEntities db = new EntityProductEntities();
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            label2.Text = db.Category.Count().ToString();
            label3.Text = db.Product.Count().ToString();
            label5.Text = db.Customer.Count(x => x.Status == true).ToString();
            label7.Text = db.Customer.Count(x => x.Status == false).ToString();
            label13.Text = db.Product.Sum(x => x.Stock).ToString();
            label21.Text = db.Sales.Sum(x => x.Price).ToString() + "TL";
            label11.Text = (from x in db.Product orderby x.Price descending select x.Name).FirstOrDefault();
            label9.Text = (from x in db.Product orderby x.Price ascending select x.Name).FirstOrDefault();
            label15.Text = db.Product.Count(x => x.Category == 1).ToString();
            label17.Text = db.Product.Count(x => x.Name == "Freezer").ToString();
            label23.Text = (from x in db.Customer select x.City).Distinct().Count().ToString();
            label19.Text = db.BRINGBRAND().FirstOrDefault();
        }
    }
}
