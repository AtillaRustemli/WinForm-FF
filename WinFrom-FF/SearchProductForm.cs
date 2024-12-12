using System.Data;
using System.Windows.Forms;
using WinFrom_FF.Enums;
using Constants=WinFrom_FF.Helpers.Constants;
using ErrorProvider=WinFrom_FF.Helpers.ErrorProvider;

namespace WinFrom_FF
{
    public partial class SearchProductForm : Form
    {
        private bool _isSearching = true;
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Constants.ExecuteQuery()!.Rows.Count; i++) pickedProduct.Items.Add(Constants.ExecuteQuery()!.Rows[i]["Name"]);
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            if (!_isSearching) Constants.GoToForm(this, new Form1());
        }

        private void searchAgain_Click(object sender, EventArgs e)
        {
            if (!_isSearching)
            {
                searchPoint.Visible = true;
                _isSearching = true;
            }
        }

        private void searchRightNow_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            if (!String.IsNullOrEmpty(pickedProduct.Text))
            {
                if (pickedProduct.Text.Contains("'"))
                    pickedProduct.Text = pickedProduct.Text.Replace("'", "''");
                dt = Constants.ExecuteQuery(Constants.SelectOne.Replace("@name", pickedProduct.Text));
                id.Text = dt.Rows[0]["Id"].ToString();
                name.Text = dt.Rows[0]["Name"].ToString();
                category.Text = dt.Rows[0]["Category"].ToString();
                description.Text = dt.Rows[0]["Description"].ToString();
                quantityInStock.Text = dt.Rows[0]["QuantityInStock"].ToString();
                price.Text = dt.Rows[0]["Price"].ToString();
                costPrice.Text = dt.Rows[0]["CostPrice"].ToString();
                discount.Text = dt.Rows[0]["Discount"].ToString();
                createdDate.Text = dt.Rows[0]["CreatedDate"].ToString();
                EraseSearchPoint();
            }
            else ErrorProvider.GetErrorMessages(404);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            EraseSearchPoint();
        }

        private void EraseSearchPoint()
        {
           searchPoint.Visible = false;
           _isSearching = false;
        }
    }
}
