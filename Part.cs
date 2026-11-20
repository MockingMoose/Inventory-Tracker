using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min {  get; set; }

        public int Max { get; set; }

        private static int nextID = 1;

        public static int NextID {  get { return nextID; } }

        public Part()
        { 
            PartID = nextID++;
        }
    }
}
