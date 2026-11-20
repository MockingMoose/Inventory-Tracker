using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class AddPart : Form
    {
        private static int nextID = 1;
        private Inventory inventory;
        private Part? selectedPart;

        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            label1.Text = "Add Part";
            this.inventory = inventory;

        }
        public AddPart(Inventory inventory, Part selectedPart)
        {
            InitializeComponent();


            this.inventory = inventory;
            this.selectedPart = selectedPart;
            label1.Text = "Modify Part";
            nameTextBox.Text = selectedPart.Name.ToString();
            inventoryTextBox.Text = selectedPart.InStock.ToString();
            priceTextBox.Text = selectedPart.Price.ToString();
            minTextBox.Text = selectedPart.Min.ToString();
            maxTextBox.Text = selectedPart.Max.ToString();

            if (selectedPart is Inhouse inHousePart)
            {
                idTextBox.Text = inHousePart.PartID.ToString();
                radioInHouse.Checked = true;
                nameOrIDLabel.Text = "Machine ID";
                nameOrIDTextBox.Text = inHousePart.MachineID.ToString();
            }
            if (selectedPart is Outsourced outsourcedPart)
            {
                idTextBox.Text = outsourcedPart.PartID.ToString();
                radioOutsourced.Checked = true;
                nameOrIDTextBox.Text = outsourcedPart.CompanyName.ToString();
                nameOrIDLabel.Text = "Company Name";
            }
            
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(inventoryTextBox.Text, out int InStock))
            {
                MessageBox.Show("Please enter a valid Inventory amount.");
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
            if (!int.TryParse (maxTextBox.Text, out int Max))
            {
                MessageBox.Show("Please enter a valid Maximum.");
                return;
            }
            if (InStock < Min || InStock > Max)
            {
                MessageBox.Show("InStock must be between Min and Max.");
                return;
            }
            if (Min > Max)
            {
                MessageBox.Show("Minimum must be lower than Maximum.");
                return;
            }
            if (radioInHouse.Checked)
            {
                if (!int.TryParse(nameOrIDTextBox.Text, out int ID))
                {
                    MessageBox.Show("MachineID must be a number.");
                    return;
                }
                if (!int.TryParse(nameOrIDTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return;
                }
                if (selectedPart != null)
                {
                    if (selectedPart is Inhouse existingPart)
                    {
                        existingPart.Name = nameTextBox.Text;
                        existingPart.InStock = InStock;
                        existingPart.Price = Price;
                        existingPart.Min = Min;
                        existingPart.Max = Max;
                        existingPart.MachineID = machineID;
                    }
                    else
                    {
                        MessageBox.Show("You cannot change an Outsourced Part into an In-House Part.");
                        return;
                    }
                }
                else
                {
                    Inhouse newPart = new Inhouse();
                    newPart.Name = nameTextBox.Text;
                    newPart.InStock = InStock;
                    newPart.Price = Price;
                    newPart.Min = Min;
                    newPart.Max = Max;
                    newPart.MachineID = machineID;

                    inventory.addPart(newPart);
                }
            }
            else
            {
                if (int.TryParse(nameOrIDTextBox.Text, out int ID))
                {
                    MessageBox.Show("Company Name must not be a number.");
                    return;
                }

                if (selectedPart != null)
                {
                    if (selectedPart is Outsourced existingPart)
                    {
                        existingPart.Name = nameTextBox.Text;
                        existingPart.InStock = InStock;
                        existingPart.Price = Price;
                        existingPart.Min = Min;
                        existingPart.Max = Max;
                        existingPart.CompanyName = nameOrIDTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("You cannot change an In-House Part into an Outsourced Part.");
                        return;
                    }
                }
                else
                {
                    Outsourced newPart = new Outsourced();
                    newPart.Name = nameTextBox.Text;
                    newPart.InStock = InStock;
                    newPart.Price = Price;
                    newPart.Min = Min;
                    newPart.Max = Max;
                    newPart.CompanyName = nameOrIDTextBox.Text;

                    inventory.addPart(newPart);
                }
            }
            Close();
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourced.Checked)
            {
                nameOrIDLabel.Text = "Company Name";
            }
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInHouse.Checked)
            {
                nameOrIDLabel.Text = "Machine ID";
            }
        }
    }
}
