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
    public partial class FrmEnterance : Form
    {
        public FrmEnterance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityProductEntities db = new DbEntityProductEntities();
            var query = from x in db.Table_Admin where x.UserName == textBox1.Text && x.Password == textBox2.Text select x ;
            if (query.Any())
            {
                FrmHomePage fr = new FrmHomePage();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Entry ");
            }
        }
    }
}
