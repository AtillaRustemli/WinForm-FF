
namespace WinFrom_FF.Helpers
{
    public static class ErrorProvider
    {
        private static readonly Dictionary<int, string> ErrorMessages = new()
        {
            {200, "Product added successfully"},
            {201, "Product updated successfully"},
            {204, "Product deleted successfully"},
            {404, "Product Not found"},
            {400, "Something is wrong with requested data, or server couldn't understand it."},
            {401, "Unauthorized"},
            {500, "Something went wrong..."}
        };

        public static string GetErrorMessages(int key)
        {
            if (ErrorMessages.Keys.Any(s => s == key))
            {
                return ErrorMessages[key];
            }
            return ErrorMessages[500];
        }

    }
}
