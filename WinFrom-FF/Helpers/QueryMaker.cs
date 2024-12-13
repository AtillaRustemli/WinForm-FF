using System.Globalization;

namespace WinFrom_FF.Helpers
{
    public class QueryMaker
    {
        //
        //Query makers
        //
        public static string InsertAndUpdateQueryMaker(Product product, string query, string? name = null)
        {
            string resultQuery;
            resultQuery = query.Replace("@Name", product.Name);
            resultQuery = resultQuery.Replace("@Description", product.Description);
            resultQuery = resultQuery.Replace("@Price",
                product.Price.ToString(CultureInfo.InvariantCulture));
            resultQuery = resultQuery.Replace("@CostPrice",
                product.CostPrice.ToString(CultureInfo.InvariantCulture));
            resultQuery = resultQuery.Replace("@Discount",
                product.Discount.ToString(CultureInfo.InvariantCulture));
            resultQuery = resultQuery.Replace("@Category", product.Category);
            resultQuery =
                resultQuery.Replace("@QuantityInStock", product.QuantityInStock.ToString());
            if (name is not null)
            {
                resultQuery = resultQuery.Replace("@name", name);
            }
            return resultQuery;

            
        }
    }
}
