namespace CashAccount
{
    public partial class Form1 : Form
    {
        public static Product Product { get; set; }
        public List<Product> Products { get; set; }
        public static List<int> UsedCodes { get; set; }
        public Form1()
        {
            InitializeComponent();
            Products = new List<Product>();
            UsedCodes = new List<int>();

            Product product1 = new Product(1,"Milk", 80);
            Product product2 = new Product(2,"Apple", 40);
            Product product3 = new Product(3,"Chocolate", 60);
            Product product4 = new Product(4,"Chips", 90);
            Product product5 = new Product(5,"Pear", 50);
            listBoxProducts.Items.Add(product1);
            listBoxProducts.Items.Add(product2);    
            listBoxProducts.Items.Add(product3);
            listBoxProducts.Items.Add(product4);
            listBoxProducts.Items.Add(product5);
            UsedCodes.Add(product1.Code);
            UsedCodes.Add(product2.Code);
            UsedCodes.Add(product3.Code);
            UsedCodes.Add(product4.Code);
            UsedCodes.Add(product5.Code);

        }

        void recalculatePrice()
        {
            decimal price = 0;
            foreach (Item item in listBoxReceipt.Items)
            {
                price += item.Quantity * item.Product.Price;
            }
            decimal tax = numericUpDownTax.Value;
            decimal finalPrice = price + price * (tax / 100);

            textBoxForPay.Text = finalPrice.ToString();
            textBoxTotal.Text = price.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            newProduct nP = new newProduct();
            nP.ShowDialog();

            if (Product != null)
            {
                Products.Add(Product);
                listBoxProducts.Items.Add(Product);
                UsedCodes.Add(Product.Code);
            }
        }

        private void numericUpDownTax_ValueChanged(object sender, EventArgs e)
        {
            recalculatePrice();
        }

        private void addToReceipt_Click(object sender, EventArgs e)
        {
            Product selectedProduct = listBoxProducts.SelectedItem as Product;
            if (selectedProduct != null)
            {
                Item itemAddedToReceipt = new Item(selectedProduct, (int)numericUpDownQuantity.Value);
                listBoxReceipt.Items.Add(itemAddedToReceipt);
                recalculatePrice();
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Дали сте сигурни дека сакате да ја избришите ставката?", "Избриши ставка?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                listBoxReceipt.Items.Remove(listBoxReceipt.SelectedItem);
                recalculatePrice();
            }
        }
    }
}