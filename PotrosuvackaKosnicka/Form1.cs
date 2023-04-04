namespace PotrosuvackaKosnicka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Product product1 = new Product("Mleko", "Mlecni Proizvodi", 80f);
            Product product2 = new Product("Ananas", "Ovosje", 60f);
            Product product3 = new Product("Banani", "Ovosje", 70f);
            Product product4 = new Product("Morkov", "zelencuk", 90f);
            listOfProducts.Add(product1);
            listOfProducts.Add(product2);
            listOfProducts.Add(product3);
            listOfProducts.Add(product4);
            foreach (var element in listOfProducts)
            {
                listPr.Items.Add(element);

            }
        }

        public static List<ProductItem> kosnicka = new List<ProductItem>();
        public static List<Product> listOfProducts = new List<Product>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodadiNovProdukt_Click(object sender, EventArgs e)
        {
            novProdukt np = new novProdukt();
            np.ShowDialog();

            listPr.Items.Add(listOfProducts[listOfProducts.Count - 1]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void izbrishiProdukt_Click(object sender, EventArgs e)
        {
            List<Product> toRemove = new List<Product>();
            foreach (Product item in listPr.SelectedItems)
            {
                toRemove.Add(item);
            }

            foreach (var item in toRemove)
            {
                listPr.Items.Remove(item);
                listOfProducts.Remove(item);
            }

            recalculatePrice();
        }

        private void dodadiVoKosnicka_Click(object sender, EventArgs e)
        {
            decimal quantity = numericUpDown1.Value;

            foreach (Product item in listPr.SelectedItems)
            {
                ProductItem productItem = new ProductItem();
                Product newProduct = item;
                productItem.TheProduct = new Product(item.Name, item.Category, item.Price);
                productItem.Quantity = quantity;
                productItem.TheProduct.Price = (float)productItem.Quantity * productItem.TheProduct.Price;

                kosnicka.Add(productItem);
                listCa.Items.Add(productItem);
            }

            recalculatePrice();
        }

        private void isprazniJaListatasoProdukti_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Дали сте сигурни дека сакате да ја испразните листата?",
                "Испразни ја листата?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                listPr.Items.Clear();
                listOfProducts.Clear();
                recalculatePrice();

                if (listCa.SelectedItems.Count == 0 && listPr.SelectedItems.Count == 0)
                {
                    name.Text = "";
                    category.Text = "";
                    price.Text = "";
                }
            }
        }

        private void listPr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPr.SelectedItem != null)
            {
                Product selectedProduct = (Product)listPr.SelectedItem;
                name.Text = selectedProduct.Name;
                category.Text = selectedProduct.Category;
                price.Text = String.Format("{0:0.00}", selectedProduct.Price);


                if (listCa.SelectedItems.Count > 0)
                {
                    listCa.SelectedItems.Clear();
                }

            }

            recalculatePrice();
        }

        private void isprazniJaKosnickata_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Дали сте сигурни дека сакате да ја испразните кошничката?",
                "Испразни ја кошничката?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                kosnicka.Clear();
                listCa.Items.Clear();
                recalculatePrice();

                if (listCa.SelectedItems.Count == 0 && listPr.SelectedItems.Count == 0)
                {
                    name.Text = "";
                    category.Text = "";
                    price.Text = "";
                }
            }

        }

        private void izbrisiOdKosnicka_Click(object sender, EventArgs e)
        {
            List<ProductItem> toRemove = new List<ProductItem>();
            foreach (ProductItem item in listCa.SelectedItems)
            {
                toRemove.Add(item);
            }

            foreach (ProductItem item in toRemove)
            {
                listCa.Items.Remove(item);
            }

            recalculatePrice();
        }

        void recalculatePrice()
        {
            float finalPrice = 0f;
            foreach (ProductItem item in listCa.Items)
            {
                finalPrice += item.TheProduct.Price;
            }
            total.Text = finalPrice.ToString();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void listCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCa.SelectedItem != null)
            {
                ProductItem selectedItem = (ProductItem)listCa.SelectedItem;
                name.Text = selectedItem.TheProduct.Name;
                category.Text = selectedItem.TheProduct.Category;
                price.Text = String.Format("{0:0.00}", selectedItem.TheProduct.Price);
                if (listPr.SelectedItems.Count > 0)
                {
                    listPr.SelectedItems.Clear();
                }
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}