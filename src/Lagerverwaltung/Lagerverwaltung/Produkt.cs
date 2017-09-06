using System;

namespace Lagerverwaltung
{
    public class Produkt
    {
        public String Name { get; set; }
        public int Anzahl { get; set; }
        public int Kosten { get; set; }
        public String Details { get; set; }
        public String Id { get; set; }

        public Produkt()
        {
            
        }

        public Produkt(String name, int anzahl, int kosten, String kategorie, String details)
        {
            this.Name = name;
            this.Anzahl = anzahl;
            this.Kosten = kosten;
            this.Details = details;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
