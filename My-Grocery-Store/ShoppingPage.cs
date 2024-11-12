

namespace My_Grocery_Store
{
    public partial class ShoppingPage : Form
    {
        public ShoppingPage()
        {
            InitializeComponent();
        }

        private Product[] products = [];
        private Product? selectedProduct = null;
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
            else if (selectedProduct == null)
            {
                MessageBox.Show("You didn't select any product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            basket.AddProduct(selectedProduct.Name, Convert.ToInt32(quantity.Value));
            basket.Sum += Convert.ToInt32(selectedProduct.Price) * Convert.ToInt32(quantity.Value);

            ReloadShoppingBasket();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            selectedProduct = products[listBox1.SelectedIndex];

            productName.Text = selectedProduct.Name;
            id.Text = selectedProduct.Id;
            price.Text = $"{selectedProduct.Price} zl /{selectedProduct.Units}";

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your Sum is: {basket.Sum}\nThank tou for shopping");
            basket.Clear();
            ReloadShoppingBasket();
        }

        private void ShoppingPage_Load(object sender, EventArgs e)
        {
            products = FileOperations.getProds();


            foreach (Product product in products)
            {
                if (product ==  null) continue;
                listBox1.Items.Add(product.Name);
            }
        }
    }
}
