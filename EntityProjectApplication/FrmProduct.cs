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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        DbEntityProductEntities db = new DbEntityProductEntities();
        private void BtnProductList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Table_Product
                                        select new
                                        {
                                            x.ProductId,
                                            x.ProductName,
                                            x.ProductBrand,
                                            x.ProductStock,
                                            x.ProductStatus,
                                            x.ProductPrice,
                                            x.Table_Category.CategoryName,
                                        }).ToList();

        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            Table_Product t = new Table_Product();
            t.ProductName = TxtProductProductName.Text;
            t.ProductBrand = TxtProductProductBrand.Text;
            t.ProductStock = int.Parse(TxtProductStock.Text);
            t.ProductStatus = true;
            t.ProductPrice = decimal.Parse(TxtProductProductPrice.Text);
            t.Category = int.Parse(CmbProductProductCategory.SelectedValue.ToString());
            db.Table_Product.Add(t);
            db.SaveChanges();
            MessageBox.Show("Product Added");
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtProductProductId.Text);
            var prdc = db.Table_Product.Find(x);
            db.Table_Product.Remove(prdc);
            db.SaveChanges();
            MessageBox.Show("Product Deletedd");
        }

        private void BtnProductUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtProductProductId.Text);
            var prdc = db.Table_Product.Find(x);
            prdc.ProductName = TxtProductProductName.Text;
            prdc.ProductBrand = TxtProductProductBrand.Text;
            prdc.ProductStock = int.Parse(TxtProductStock.Text);
            prdc.ProductStatus = true;
            prdc.ProductPrice = decimal.Parse(TxtProductProductPrice.Text);
            prdc.Category = int.Parse(CmbProductProductCategory.Text);
            db.SaveChanges();
            MessageBox.Show("Product Updatedd");
         }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var categorys = (from x in db.Table_Category
                             select new
                             {
                                 x.CategoryId,
                                 x.CategoryName
                             }
                           ).ToList();
            CmbProductProductCategory.ValueMember = "CategoryId";
            CmbProductProductCategory.DisplayMember = "CategoryName";
            CmbProductProductCategory.DataSource = categorys;
        }
    }
}
