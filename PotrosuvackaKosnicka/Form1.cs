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

        public static List<Product> kosnicka = new List<Product>();
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

            List<Product> toRemove = new List<Product>();
            foreach (Product item in listPr.SelectedItems)
            {
                kosnicka.Add(item);
                listCa.Items.Add(item);
                toRemove.Add(item);
            }
            foreach (Product item in toRemove)
            {
                listPr.Items.Remove(item);
            }

            recalculatePrice();
        }

        private void isprazniJaListatasoProdukti_Click(object sender, EventArgs e)
        {
            listPr.Items.Clear();
            listOfProducts.Clear();

            recalculatePrice();
        }

        private void listPr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPr.SelectedItem != null)
            {
                Product selectedProduct = (Product)listPr.SelectedItem;
                name.Text = selectedProduct.Name;
                category.Text = selectedProduct.Category;
                price.Text = selectedProduct.Price.ToString();
            }

            recalculatePrice();
        }

        private void isprazniJaKosnickata_Click(object sender, EventArgs e)
        {
            kosnicka.Clear();
            listCa.Items.Clear();
            recalculatePrice();
        }

        private void izbrisiOdKosnicka_Click(object sender, EventArgs e)
        {
            List<Product> toRemove = new List<Product>();
            foreach (Product item in listCa.SelectedItems)
            {
                toRemove.Add(item);
            }
            foreach (Product item in toRemove)
            {
                listCa.Items.Remove(item);
            }
            recalculatePrice();
        }

        void recalculatePrice()
        {
            float finalPrice = 0f;
            foreach(Product item in listCa.Items)
            {
                finalPrice += item.Price;
            }
            total.Text = finalPrice.ToString();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}