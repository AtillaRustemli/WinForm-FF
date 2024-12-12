using Constants = WinFrom_FF.Helpers.Constants;
using ErrorProvider = WinFrom_FF.Helpers.ErrorProvider;
using Categories = WinFrom_FF.Enums.Category;

namespace WinFrom_FF
{
    public partial class AddProductAction : Form
    {
        public AddProductAction()
        {
            InitializeComponent();
            for (int i = 0; i < Enum.GetValues(typeof(Categories)).Length; i++) category.Items.Add(Enum.GetNames<Categories>()[i]);
            
        }

        
        private void goBack_Click(object sender, EventArgs e)
        {
            Constants.GoToForm(this, new Form1());

            
        }

        private void add_Click(object sender, EventArgs e)
        {
            int result=0;
            if (!(name.Text == string.Empty || category.Text == string.Empty 
                  || description.Text == string.Empty || price.Text == string.Empty 
                  || costPrice.Text == string.Empty || quantityInStock.Text == string.Empty 
                  || !double.TryParse(price.Text, out double newPrice)
                  || !double.TryParse(costPrice.Text, out double newCostPrice)))
            {
                Product newProduct = new()
                {
                    Name = name.Text,
                    Category = category.Text,
                    Description = description.Text,
                    Price = newPrice,
                    CostPrice = newCostPrice,
                    QuantityInStock = int.Parse(quantityInStock.Text)
                };
                result = Constants.ExecuteCommand(Constants.Insert, newProduct);
                Constants.GoToForm(this,new Form1());
            }
            else MessageBox.Show(ErrorProvider.GetErrorMessages(500));

            if (result is not 0) MessageBox.Show(ErrorProvider.GetErrorMessages(result));




        }
    }
}
