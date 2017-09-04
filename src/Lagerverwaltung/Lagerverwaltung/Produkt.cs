using System;
using System.Collections.Generic;

namespace Lagerverwaltung
{
    class Produkt
    {
        public String Name { get; set; }
        public int Anzahl { get; set; }
        public int Kosten { get; set; }
        public String Kategorie { get; set; }
        public String Farbe { get; set; }
        public String Details { get; set; }

        public Produkt()
        {
            
        }

        public Produkt(String name, int anzahl, int kosten, String kategorie, String details)
        {
            this.Name = name;
        }
    }


}
