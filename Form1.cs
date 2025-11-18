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
    }
}
