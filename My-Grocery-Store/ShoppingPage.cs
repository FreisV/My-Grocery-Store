

namespace My_Grocery_Store
{
    public partial class ShoppingPage : Form
    {
        public ShoppingPage()
        {
            InitializeComponent();
            productName.Text = selectedProduct.Name;
            id.Text = selectedProduct.Id;
            price.Text = $"{selectedProduct.Price} zl {selectedProduct.Units}";
        }

        private Product selectedProduct = new Product("cola", "13", "5", UnitsEnum.liter);
        private Basket basket = new Basket();

        private void ReloadShoppingBasket()
        {
            ShoppingBasket.Items.Clear();
            ShoppingBasket.Items.AddRange(basket.Products);
            sum.Text = Convert.ToString(basket.Sum);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(quantity.Value) < 1)
            {
                MessageBox.Show("Quantity can't be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            basket.AddProduct(selectedProduct.Name, Convert.ToInt32(quantity.Value));
            basket.Sum += Convert.ToInt32(selectedProduct.Price) * Convert.ToInt32(quantity.Value);

            ReloadShoppingBasket();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            productName.Text = selectedProduct.Name;
            id.Text = selectedProduct.Id;
            price.Text = $"{selectedProduct.Price} zl {selectedProduct.Units}";

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

        private void ShoppingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
