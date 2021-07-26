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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        DbEntityProductEntities db = new DbEntityProductEntities();
        private void BtnCategoryList_Click(object sender, EventArgs e)
        {
            var categorys = db.Table_Category.ToList();
            dataGridView1.DataSource = categorys;
        }

        private void BtnCategoryAdd_Click(object sender, EventArgs e)
        {
            Table_Category t = new Table_Category();
            t.CategoryName = TxtCategoryCategoryName.Text;
            db.Table_Category.Add(t);
            db.SaveChanges();
            MessageBox.Show("Category Added....");
            
        }

        private void BtnCategoryDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCategoryCategoryId.Text);
            var ctgr = db.Table_Category.Find(x);
            db.Table_Category.Remove(ctgr);
            db.SaveChanges();
            MessageBox.Show("Category Deleted");
        }

        private void BtnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCategoryCategoryId.Text);
            var ctgr = db.Table_Category.Find(x);
            ctgr.CategoryName = TxtCategoryCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Category Updated");
        }
    }
}
