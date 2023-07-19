using System;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCtgrTrns_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void BtnPrdctTrns_Click(object sender, EventArgs e)
        {
            ProductForm fr = new ProductForm();
            fr.Show();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm fr = new StatisticsForm();
            fr.Show();
        }
    }
}
