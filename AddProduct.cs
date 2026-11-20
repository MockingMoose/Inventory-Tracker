using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class AddProduct : Form
    {
        private Inventory inventory;

        private Product newProduct;

        private Product? selectedProduct;
        public AddProduct(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.newProduct = new Product();
            newProduct.Name = string.Empty;
            newProduct.InStock = 0;
            newProduct.Price = 0;
            newProduct.Min = 0;
            newProduct.Max = 0;
            candidatePartsDataGridView.DataSource = inventory.AllParts;
            associatedPartsDataGridView.DataSource = newProduct.AssociatedParts;

            candidatePartsDataGridView.ClearSelection();
            candidatePartsDataGridView.CurrentCell = null;
        }
        public AddProduct(Inventory inventory, Product selectedProduct)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.selectedProduct = selectedProduct;
            this.newProduct = selectedProduct;
            addProductLabel.Text = "Modify Product";
            nameTextBox.Text = selectedProduct.Name.ToString();
            inventoryTextBox.Text = selectedProduct.InStock.ToString();
            priceTextBox.Text = selectedProduct.Price.ToString();
            minTextBox.Text = selectedProduct.Min.ToString();
            maxTextBox.Text = selectedProduct.Max.ToString();

            candidatePartsDataGridView.DataSource = inventory.AllParts;
            associatedPartsDataGridView.DataSource = selectedProduct.AssociatedParts;

            candidatePartsDataGridView.ClearSelection();
            candidatePartsDataGridView.CurrentCell = null;
        }

        private void AddProduct_Shown(object sender, EventArgs e)
        {
            candidatePartsDataGridView.ClearSelection();
            candidatePartsDataGridView.CurrentCell = null;

            associatedPartsDataGridView.ClearSelection();
            associatedPartsDataGridView.CurrentCell = null;

            ActiveControl = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(inventoryTextBox.Text, out int InStock))
            {
                MessageBox.Show("Please enter a valid InStock number.");
                return;
            }
            if (!decimal.TryParse(priceTextBox.Text, out decimal Price))
            {
                MessageBox.Show("Please enter a valid Price.");
                return;
            }
            if (!int.TryParse(minTextBox.Text, out int Min))
            {
                MessageBox.Show("Please enter a valid Minimum.");
                return;
            }
            if (!int.TryParse(maxTextBox.Text, out int Max))
            {
                MessageBox.Show("Please enter a valid Maximum.");
                return;
            }
            if (InStock < Min || InStock > Max)
            {
                MessageBox.Show("InStock must be between Min and Max.");
                return;
            }
            newProduct.Name = nameTextBox.Text;
            newProduct.InStock = InStock;
            newProduct.Price = Price;
            newProduct.Min = Min;
            newProduct.Max = Max;
            if (selectedProduct != null)
            {
                newProduct.ProductID = selectedProduct.ProductID;
                newProduct.Name = nameTextBox.Text;
                newProduct.InStock = int.Parse(inventoryTextBox.Text);
                newProduct.Price = decimal.Parse(priceTextBox.Text);
                newProduct.Min = int.Parse(minTextBox.Text);
                newProduct.Max = int.Parse(maxTextBox.Text);

                inventory.updateProduct(selectedProduct.ProductID, newProduct);
            }
            else
            {
                inventory.addProduct(newProduct);
            }
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (candidatePartsDataGridView.SelectedRows.Count == 0) { return; }
                Part? selectedPart =
                    candidatePartsDataGridView.SelectedRows[0].DataBoundItem as Part;
                if (selectedPart != null)
                {
                    selectedProduct.addAssociatedPart(selectedPart);
                    candidatePartsDataGridView.ClearSelection();
                }
            }
            else
            {
                if (candidatePartsDataGridView.SelectedRows.Count == 0) { return; }
                Part selectedPart =
                    (Part)candidatePartsDataGridView.CurrentRow.DataBoundItem;
                if (selectedPart != null)
                {
                    newProduct.addAssociatedPart(selectedPart);
                    candidatePartsDataGridView.ClearSelection();
                }
            }
            candidatePartsDataGridView.DataSource = inventory.AllParts;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (selectedProduct != null)
                {
                    if (associatedPartsDataGridView.SelectedRows.Count == 0) { return; }
                    Part selectedPart =
                        (Part)associatedPartsDataGridView.CurrentRow.DataBoundItem;
                    if (selectedPart != null)
                    {
                        selectedProduct.removeAssociatedPart(selectedPart.PartID);
                        associatedPartsDataGridView.ClearSelection();
                    }
                }
                else
                {
                    if (associatedPartsDataGridView.SelectedRows.Count == 0) { return; }
                    Part selectedPart =
                        (Part)associatedPartsDataGridView.CurrentRow.DataBoundItem;
                    if (selectedPart != null)
                    {
                        newProduct.removeAssociatedPart(selectedPart.PartID);
                        associatedPartsDataGridView.ClearSelection();
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(partsTextBox.Text))
            {
                candidatePartsDataGridView.DataSource = inventory.AllParts;
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
                    candidatePartsDataGridView.DataSource = foundParts;
                    partsTextBox.Clear();
                }
            }
        }
    }
}
