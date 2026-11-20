using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace CSharpPractice
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>(); 

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public bool removeProduct(int productID)
        {
            Product? match = null;

            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    match = product;
                    break;
                }
            }
            if (match != null)
            {
                Products.Remove(match);
                return true;
            }
            return false;
        }

        public Product? lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public void updateProduct(int productID, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;
                    return;
                }
            }
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part? lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public void updatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                    return;
                }
            }    
        }
        
    }
}
