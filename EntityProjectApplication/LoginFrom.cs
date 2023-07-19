using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EntityProductEntities db = new EntityProductEntities();
            var query = from x in db.Admin where x.UserName == textBox1.Text && x.Password == textBox2.Text select x;
            if (query.Any())
            {
                MainForm fr = new MainForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You Login Wrong, Check Your Password or Username");
            }
        }
    }
}
