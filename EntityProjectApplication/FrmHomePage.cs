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
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProduct fr = new FrmProduct();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStatistic fr = new FrmStatistic();
            fr.Show();
        }
    }
}
