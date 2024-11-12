namespace My_Grocery_Store
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {

            InitializeComponent();
            LoadProductUnits();
        }

        private void LoadProductUnits()
        {
            unitsBox.DataSource = Enum.GetValues(typeof(UnitsEnum));
        }
        private void header_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string nameOfPrd = nameBox.Text;
            string idOfPrd = idBox.Text;
            string priceOfPrd = priceBox.Text;
            string unitsOfPrd = unitsBox.Text;
            Boolean isIdAuto = autoIdCheck.Checked;

            if (nameOfPrd == "" || unitsOfPrd == "" || priceOfPrd == "")
            {
                MessageBox.Show("pls enter data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if(nameOfPrd.Contains("@") || unitsOfPrd.Contains("@") || priceOfPrd.Contains("@"))
            {
                MessageBox.Show("You cant use this @ simbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isIdAuto)
            {
                idOfPrd = nameOfPrd[0] + RandCustNum.generate() + nameOfPrd[nameOfPrd.Length - 1];
            }

            UnitsEnum unitsEnum = StrToEnum.convert(unitsOfPrd);

            Product prd = new Product(nameOfPrd, idOfPrd, priceOfPrd, unitsEnum);

            FileOperations.write(prd.getAll());

            nameBox.Text="";
            idBox.Text = "";
            priceBox.Text = "";

            MessageBox.Show("sucess!", "ok", MessageBoxButtons.OK);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
