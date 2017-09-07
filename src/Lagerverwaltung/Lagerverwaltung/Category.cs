using System;
using System.Collections.Generic;

namespace Lagerverwaltung
{
    public class Category
    {
        public String Name { get; set; }
        public String CategoryId { get; set; }
        //public virtual ICollection<Produkt> Products { get; set; }

        public List<Produkt> Products { get; set; } = new List<Produkt>();

        public Category()
        {
        }

        public Category(String name)
        {
            this.Name = name;
            this.CategoryId = Guid.NewGuid().ToString();
        }
    }
}
