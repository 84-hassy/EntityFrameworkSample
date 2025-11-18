using EntityFrameworkDBConnectionSample.Models;
using EntityFrameworkDBConnectionSample.SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDBConnectionSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DataTableReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductsSqlServer.GetDataTable();
        }

        private void ReaderReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductsSqlServer.GetDataReader();
        }

        private void InsertCommandButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int productPrice = int.Parse(ProductPriceTextBox.Text);

            var entity = new ProductEntity( productId, productName, productPrice);
            ProductsSqlServer.Insert(entity);
        }

        private void UpdateCommandButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int productPrice = int.Parse(ProductPriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, productPrice);
            ProductsSqlServer.Update(entity);
        }

        private void UpsertCommandButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int productPrice = int.Parse(ProductPriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, productPrice);
            ProductsSqlServer.Upsert(entity);
        }

        private void DeleteCommandButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            ProductsSqlServer.Delete(productId);
        }

        private void DapperReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductsSqlServer.GetDapper();
        }

        private void DapperInsertButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int productPrice = int.Parse(ProductPriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, productPrice);
            ProductsSqlServer.DapperInsert(entity);
        }

        private void DapperUpdateButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            int productPrice = int.Parse(ProductPriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, productPrice);
            ProductsSqlServer.DapperUpdate(entity);
        }

        private void DapperDeleteButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            ProductsSqlServer.DapperDelete(productId);
        }

        private void EFReadButton_Click(object sender, EventArgs e)
        {
            var source = new List<products>();
            using (var db = new DBContext())
            {
                source.AddRange(db.products);
            }
            
            dataGridView1.DataSource = source;
        }

        private void EFInsertButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {


                products p = new products();
                p.id = int.Parse(ProductIdTextBox.Text);
                p.name = ProductNameTextBox.Text;
                p.price = int.Parse(ProductPriceTextBox.Text);

                db.products.Add(p);
                db.SaveChanges();
            }
        }

        private void EFUpdateButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                var p = db.products.Find(int.Parse(ProductIdTextBox.Text));
                p.name = ProductNameTextBox.Text;
                p.price = int.Parse(ProductPriceTextBox.Text);
                db.SaveChanges();
            }
        }

        private void EFDeleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                var p = db.products.Find(int.Parse(ProductIdTextBox.Text));
                db.products.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
