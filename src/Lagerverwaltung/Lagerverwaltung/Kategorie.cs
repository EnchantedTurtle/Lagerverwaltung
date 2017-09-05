using System;
namespace Lagerverwaltung
{
    class Kategorie
    {
        public String Name { get; set; }
        public String Farbe { get; set; }
        public String Id { get; set; }

        public Kategorie(String name, String id)
        {
            this.Name = name;
            this.Id = id
        }
    }
}
