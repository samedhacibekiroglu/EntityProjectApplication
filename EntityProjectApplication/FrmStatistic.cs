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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        DbEntityProductEntities db = new DbEntityProductEntities();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            label2.Text = db.Table_Category.Count().ToString();
            label3.Text = db.Table_Product.Count().ToString();
            label9.Text =db.Table_Customer.Count(x => x.Situation == true).ToString();
            label15.Text = db.Table_Customer.Count(x => x.Situation == false).ToString();
            label5.Text = db.Table_Product.Sum(y => y.ProductStock).ToString();
            label7.Text = db.Table_Sales.Sum(z => z.Priece).ToString() + "TL";
            label11.Text = (from x in db.Table_Product orderby x.ProductPrice descending select x.ProductName).FirstOrDefault();
            label17.Text = (from x in db.Table_Product orderby x.ProductPrice ascending select x.ProductName).FirstOrDefault();
            label22.Text = db.Table_Product.Count(z => z.Category == 1).ToString();
            label19.Text = db.Table_Product.Count(n => n.ProductName == "Computer").ToString();
            label24.Text = (from x in db.Table_Customer select x.CustomerCity).Distinct().Count().ToString();
            label13.Text = db.BRING().FirstOrDefault();
        }
    }
}
