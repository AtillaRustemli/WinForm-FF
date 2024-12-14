using Constants = WinFrom_FF.Helpers.Constants;
using ErrorProvider=WinFrom_FF.Helpers.ErrorProvider;
using SoundProvider = WinFrom_FF.Helpers.SoundProvider;

namespace WinFrom_FF
{
    public partial class Form1 : Form
    {
        private void form_Load() => viewer.DataSource = Constants.ExecuteQuery();

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => form_Load();

        private void addProduct_Click(object sender, EventArgs e) => Constants.GoToForm(this, new AddProductAction(), true);

        private void updateProduct_Click(object sender, EventArgs e) => Constants.GoToForm(this, new UpdateProductAction(), true);

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to delete this product?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = Constants.ExecuteCommand(Constants.Delete, name: viewer.SelectedRows.Count != 0 ? viewer.SelectedRows[0].Cells["Name"].Value.ToString() : null);
                MessageBox.Show(ErrorProvider.GetErrorMessages(result));
                this.form_Load();

            }
        }

        private void searchProduct_Click(object sender, EventArgs e) => Constants.GoToForm(this, new SearchProductForm(), true);

        private void endProgram_Click(object sender, EventArgs e) => Close();

        private void refreshPage_Click(object sender, EventArgs e) => Refresh();        
    }
}
