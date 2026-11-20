using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Text;

namespace CSharpPractice
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        private static int nextID = 1;

        public Product()
        {
            ProductID = nextID++;
        }


        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }
        
        public bool removeAssociatedPart(int PartID)
        {
            Part? match = null;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == PartID)
                {
                    match = part;
                    break;
                }
            }
            if (match != null) 
            {
                AssociatedParts.Remove(match);
                return true;
            }
            return false;
        }

        public Part? lookupAssociatedPart(int PartID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (PartID == part.PartID) 
                { 
                    return part; 
                }
            }
            return null;

        }
    }
}
