using System.ComponentModel;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CSharpPractice
{
    public partial class Form1 : Form
    {

        private Inventory inventory = new Inventory();

        public Form1()
        {
            InitializeComponent();
            // TEST PARTS

            Inhouse iron = new Inhouse();
            iron.Name = "Iron Ore";
            iron.Price = 5.50m;
            iron.InStock = 20;
            iron.Min = 1;
            iron.Max = 50;
            iron.MachineID = 101;

            Inhouse copper = new Inhouse();
            copper.Name = "Copper Ore";
            copper.Price = 8.25m;
            copper.InStock = 15;
            copper.Min = 1;
            copper.Max = 40;
            copper.MachineID = 102;

            Outsourced wood = new Outsourced();
            wood.Name = "Oak Wood";
            wood.Price = 3.75m;
            wood.InStock = 30;
            wood.Min = 5;
            wood.Max = 100;
            wood.CompanyName = "Forest Supply";

            Outsourced leather = new Outsourced();
            leather.Name = "Leather";
            leather.Price = 12.00m;
            leather.InStock = 10;
            leather.Min = 1;
            leather.Max = 25;
            leather.CompanyName = "Leatherworks Inc.";

            // ADD PARTS TO INVENTORY

            inventory.addPart(iron);
            inventory.addPart(copper);
            inventory.addPart(wood);
            inventory.addPart(leather);


            // TEST PRODUCTS

            Product sword = new Product();
            sword.Name = "Iron Sword";
            sword.Price = 35.00m;
            sword.InStock = 5;
            sword.Min = 1;
            sword.Max = 20;

            Product armor = new Product();
            armor.Name = "Leather Armor";
            armor.Price = 50.00m;
            armor.InStock = 3;
            armor.Min = 1;
            armor.Max = 15;


            // ASSOCIATE PARTS WITH PRODUCTS

            sword.addAssociatedPart(iron);
            sword.addAssociatedPart(wood);

            armor.addAssociatedPart(leather);
            armor.addAssociatedPart(wood);


            // ADD PRODUCTS TO INVENTORY

            inventory.addProduct(sword);
            inventory.addProduct(armor);
            ProductsDataGridView.DataSource = inventory.Products;
            PartsDataGridView.DataSource = inventory.AllParts;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PartsDataGridView.ClearSelection();
            ProductsDataGridView.ClearSelection();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(partsTextBox.Text))
            {
                PartsDataGridView.DataSource = inventory.AllParts;
                return;
            }
            if (partsTextBox.Text != null) 
            { 
                string searchPart = partsTextBox.Text;
                BindingList<Part> foundParts = new BindingList<Part>();
                foreach (Part part in inventory.AllParts)
                {
                    if (part.Name.Contains(searchPart, StringComparison.OrdinalIgnoreCase) || 
                        int.TryParse(searchPart, out int partID) &&
                        part.PartID == partID)
                    {
                        foundParts.Add(part);
                    }
                    PartsDataGridView.DataSource = foundParts;
                    partsTextBox.Clear();
                }
            } 
            
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productsTextBox.Text))
            {
                ProductsDataGridView.DataSource = inventory.Products;
                return;
            }
            if (productsTextBox.Text != null)
            {
                string searchProduct = productsTextBox.Text;
                BindingList<Product> foundProducts = new BindingList<Product>();
                foreach (Product product in inventory.Products)
                {
                    if (product.Name.Contains(searchProduct, StringComparison.OrdinalIgnoreCase) ||
                        int.TryParse(searchProduct, out int productID) &&
                        product.ProductID == productID)
                    {
                        foundProducts.Add(product);
                    }
                    ProductsDataGridView.DataSource = foundProducts;
                    productsTextBox.Clear();
                }
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddPart form = new AddPart(inventory);
            form.ShowDialog();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct(inventory);
            form.ShowDialog();

        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (PartsDataGridView.SelectedRows.Count == 0) { return; }
            Part? selectedPart =
                PartsDataGridView.SelectedRows[0].DataBoundItem as Part;

            foreach (Product product in inventory.Products)
            {
                foreach (Part part in product.AssociatedParts)
                {
                    if (part == selectedPart)
                    {
                        MessageBox.Show("Cannot delete part associated with a Product.");
                        return;
                    }
                }
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                if (selectedPart != null)
                {
                    inventory.deletePart(selectedPart);
                    PartsDataGridView.ClearSelection();
                    PartsDataGridView.DataSource = inventory.AllParts;
                }
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            { 
                if (ProductsDataGridView.SelectedRows.Count == 0) { return; }
            Product selectedProduct =
                (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            if (selectedProduct != null)
            {
                inventory.removeProduct(selectedProduct.ProductID);
                PartsDataGridView.ClearSelection();
                ProductsDataGridView.DataSource = inventory.Products;
            }
            }
        }

        private void modifyButton1_Click(object sender, EventArgs e)
        {
            if (PartsDataGridView.SelectedRows.Count == 0) { return; }
            Part selectedPart =
                (Part)PartsDataGridView.CurrentRow.DataBoundItem;
            if (selectedPart != null)
            {
                AddPart form = new AddPart(inventory, selectedPart);
                form.ShowDialog();
            }
            PartsDataGridView.ClearSelection();
        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count == 0) { return; }
            Product selectedProduct =
                (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            if (selectedProduct != null)
            {
                AddProduct form = new AddProduct(inventory, selectedProduct);
                form.ShowDialog();
            }
            ProductsDataGridView.ClearSelection();
        }
    }
}
