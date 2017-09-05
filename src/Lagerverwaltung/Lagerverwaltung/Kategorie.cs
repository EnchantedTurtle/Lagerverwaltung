using System;

namespace Lagerverwaltung
{
    class Kategorie
    {
        public String Name { get; set; }
        public String Id { get; set; }

        public Kategorie(String name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
