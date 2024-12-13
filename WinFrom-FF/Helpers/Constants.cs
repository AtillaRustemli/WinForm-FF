using MySql.Data.MySqlClient;
using System.Data;

namespace WinFrom_FF.Helpers
{
    public static class Constants
    {
        //
        //Connection
        //
        public const string ConnectionString = "Server=localhost;Database=warehouse;Uid=root;Pwd=Atilla@20052009;";
        private static readonly MySqlConnection Connection = new(ConnectionString);

        //
        //SQL Actions
        //
        public const string Insert = "Add";
        public const string Update = "Update";
        public const string Delete = "Delete";
        public const string SearchOne = "SearchOne";

        //
        //Queries
        //
        public static string SelectAll =
            "SELECT Id, Name, Description, QuantityInStock, Price, CostPrice, Discount, category FROM products ORDER BY Id";

        public static string SelectOne =
            "SELECT Id, Name,Description, QuantityInStock,Price, CostPrice, Discount, category, CreatedDate  from products WHERE Name = '@name'";

        public static string CreateNewProduct =
            "INSERT INTO products (Name, Description, Category, QuantityInStock, Price, CostPrice, Discount) VALUES ('@Name', '@Description', '@Category', @QuantityInStock, @Price, @CostPrice, @Discount);";

        public static string UpdateProduct =
            "UPDATE products SET Name = '@Name', Description = '@Description', Category = '@Category', QuantityInStock = @QuantityInStock, Price = @Price, CostPrice = @CostPrice, Discount = @Discount WHERE Name = '@name';";

        public const string DeleteProduct =
            "DELETE FROM products WHERE Name = '@name';";

        //
        //Command and Queries
        //
        public static DataTable ExecuteQuery(string? query = null)
        {
            using (MySqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new(query ?? SelectAll, Connection);
                MySqlDataAdapter adapter = new(command);
                DataTable dataTable = new();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static int ExecuteCommand(string action, Product? newProduct = null, string? name = null)
        {
            string? resultQuery;
            int messageDefiner;
            if (newProduct is not null) newProduct = CheckSyntax(newProduct);
            
            if (name is not null&&name.Contains("'")) name = name.Replace("\'", "''"); 
            switch (action)
            {
                case Insert:
                    if (newProduct is not null)
                    {
                        resultQuery = QueryMaker.InsertAndUpdateQueryMaker(newProduct, CreateNewProduct);
                        if (!PriceConfiguration.IsCorrectPriceRelation(newProduct.Price, newProduct.CostPrice, newProduct.Discount))
                            return 400;
                        messageDefiner = 201;
                    }
                    else return 400;
                    
                    
                    break;
                case Update:
                    if (String.IsNullOrEmpty(name)) return 400;
                    var userUpdate = ExecuteQuery(SelectOne.Replace("@name", name));
                    if (userUpdate.Rows.Count == 1 && newProduct is not null)
                    {
                        resultQuery = QueryMaker.InsertAndUpdateQueryMaker(newProduct, UpdateProduct, name);
                        if (!PriceConfiguration.IsCorrectPriceRelation(newProduct.Price, newProduct.CostPrice, newProduct.Discount))
                            return 400;
                        messageDefiner = 202;
                    }
                    else return 404;
                    break;
                case Delete:
                    if (String.IsNullOrEmpty(name)) return 400;
                    var userDelete = ExecuteQuery(SelectOne.Replace("@name", name));
                    if (userDelete.Rows.Count==1) resultQuery = DeleteProduct.Replace("@name", name);
                    else return 404;
                    messageDefiner = 204;
                    break;
                default: return 500;

            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(resultQuery, connection))
                {
                    connection.Open();
                    try
                    {
                    command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return 409;
                    }
                    return messageDefiner;
                }
            }
        }
        // 
        //Constant methods
        //
        public static void GoToForm(Form currentForm, Form form, bool isMainForm = false)
        {
            form.Show();
            if (isMainForm) currentForm.Hide();
            else currentForm.Dispose();
        }
        //
        //Check syntax
        //
        static Product CheckSyntax(Product product)
        {
            Dictionary<string, string> possibleProblems = new()
                {
                    {"Category", product.Category },
                    {"Name",  product.Name  },
                    {"Description", product.Description }
                };
            foreach (var key in possibleProblems.Keys)
                if (possibleProblems[key].Contains("'")) possibleProblems[key] = possibleProblems[key].Replace("\'", "''");

            product.Category = possibleProblems["Category"];
            product.Name = possibleProblems["Name"];
            product.Description = possibleProblems["Description"];
            return product;
        }
    }
}
