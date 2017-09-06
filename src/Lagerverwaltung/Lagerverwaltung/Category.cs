using System;
using System.Collections.Generic;

namespace Lagerverwaltung
{
    public class Category
    {
        public String Name { get; set; }
        public String Id { get; set; }
        public List<Produkt> Products { get; set; } = new List<Produkt>();

        public Category(String name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
