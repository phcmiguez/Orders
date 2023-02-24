using Orders.Entities;

namespace Orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            Product p1 = new Product("iPhone 14 Pro Max", 6700.00);
            Product p2 = new Product("Macbook Pro Retina", 12987.90);
            
            products.Add(p1);
            products.Add(p2);

            cmbProducts.DataSource = products;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by PHCM", "About");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbProducts.Text.Length > 0)
            {

                if (!lstOrders.Items.Contains(cmbProducts.Text))
                {
                    lstOrders.Items.Add(cmbProducts.Text);
                }
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(cmbProducts.SelectedItem != null)
            {
                lstOrders.Items.Remove(lstOrders.SelectedItem);
            }
        }
    }
}