using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDBConnectionSample.SQLServer
{
    public static class ProductsSqlServer
    {
        private static string _connectionString;
        static ProductsSqlServer()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"LocalHost",
                InitialCatalog = "EntityFrameworkDB",
                IntegratedSecurity = true               //Windows Authentication
            };
            // 接続文字列の取得
            _connectionString = builder.ToString();
        }

        public static DataTable GetDataTable()
        {
            // SQLクエリ
            var sql = @"Select * From products";

            // DataTableの作成
            DataTable dt = new DataTable();

            // SQL Connection はDisposeメソッドが存在
            // そのため、usingステートメントを使用して確実に解放する
            using (var sqlConnection = new SqlConnection(_connectionString))
            using (var adapter = new SqlDataAdapter(sql, sqlConnection))
            {
                // 接続を開いてSQLを実行
                sqlConnection.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        public static List<ProductEntity> GetDataReader()
        {
            var result = new List<ProductEntity>();

            // SQLクエリ
            var sql = @"Select * From products";

            using (var connection = new SqlConnection(_connectionString))
            using(var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader()) 
                { 
                    while(reader.Read())
                    {
                        var productId = Convert.ToInt32(reader["id"]);
                        var productName = Convert.ToString(reader["name"]);
                        var unitPrice = Convert.ToInt32(reader["price"]);
                        result.Add(new ProductEntity(productId, productName,unitPrice));
                    }
                }
                // DBの型　　→　　C＃の型
                // bigint    →     Int64
                // int       →     Int32
                // smallint  →     Int16
                // tinyint   →     Byte
                // varchar   →     string
                // decimal   →     decimal
                // reak      →     float toSingle()
                // float     →     double
                // varchar   →     string


            }

            return result;
        }


        public static void Insert(ProductEntity product)
        {
            string sql = @"INSERT INTO products (id , name, price) VALUES (@id , @name, @price)";

            // SQL Connection はDisposeメソッドが存在
            // そのため、usingステートメントを使用して確実に解放する
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id",product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.ExecuteNonQuery();
            }
        }


        public static void Update(ProductEntity product)
        {
            string sql = @"UPDATE products SET name=@name , price=@price WHERE id =@id";

            // SQL Connection はDisposeメソッドが存在
            // そのため、usingステートメントを使用して確実に解放する
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.ExecuteNonQuery();
            }
        }

        public static void Upsert(ProductEntity product)
        {
            string sql = @"UPDATE products SET name=@name , price=@price WHERE id =@id";

            // SQL Connection はDisposeメソッドが存在
            // そのため、usingステートメントを使用して確実に解放する
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                var updateCount = command.ExecuteNonQuery();

                // 更新件数が0件の場合は、INSERTを実行
                if (updateCount == 0)
                {
                    Insert(product);
                }
            }
        }


        public static void Delete(int id)
        {
            string sql = @"DELETE FROM products WHERE id =@id";

            // SQL Connection はDisposeメソッドが存在
            // そのため、usingステートメントを使用して確実に解放する
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                var updateCount = command.ExecuteNonQuery();
            }
        }
    }
}
