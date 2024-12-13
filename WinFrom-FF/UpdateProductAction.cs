using WinFrom_FF.Enums;
using Constants= WinFrom_FF.Helpers.Constants;
using ErrorProvider= WinFrom_FF.Helpers.ErrorProvider;

namespace WinFrom_FF
{
    public partial class UpdateProductAction : Form
    {
        public UpdateProductAction()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e) => Constants.GoToForm(this, new Form1());


        private void update_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (!(name.Text == string.Empty
                  || category.Text == string.Empty
                  || description.Text == string.Empty || price.Text == string.Empty
                  || costPrice.Text == string.Empty || quantityInStock.Text == string.Empty
                  || !double.TryParse(price.Text, out double newPrice)
                  || !double.TryParse(costPrice.Text, out double newCostPrice)))
            {
                Product updateProduct = new()
                {
                    Name = name.Text,
                    Category = category.Text,
                    Description = description.Text,
                    Price = newPrice,
                    CostPrice = newCostPrice,
                    QuantityInStock = int.Parse(quantityInStock.Text)
                };
                result = Constants.ExecuteCommand(Constants.Update, updateProduct, allProducts.Text);
                Constants.GoToForm(this, new Form1());
            }
            else MessageBox.Show(ErrorProvider.GetErrorMessages(500));


            if (result is not 0) MessageBox.Show(ErrorProvider.GetErrorMessages(result));
        }

        private void UpdateProductAction_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Constants.ExecuteQuery()!.Rows.Count; i++) allProducts.Items.Add(Constants.ExecuteQuery()!.Rows[i]["Name"]);
            for (int i = 0; i < Enum.GetValues(typeof(Category)).Length; i++) category.Items.Add(Enum.GetNames<Category>()[i]);
        }
    }
}
