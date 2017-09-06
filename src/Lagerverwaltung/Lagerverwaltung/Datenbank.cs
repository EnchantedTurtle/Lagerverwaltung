using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    class Datenbank : IDatenverwaltung
    {
        public void CreateProdukt(Produkt produkt, string categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Produkt> ReadProdukt()
        {
            throw new NotImplementedException();
        }

        public void DeleteProdukt(string id)
        {
            throw new NotImplementedException();
        }

        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> ReadCategory()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category, string newName)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(string catName, string catId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProdukt(Produkt produkt, string newName, string newDetails, string newKosten, string newAnzahl)
        {
            throw new NotImplementedException();
        }
    }
}
