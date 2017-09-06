using System.Collections.Generic;

namespace Lagerverwaltung
{
    public interface IDatenverwaltung
    {
        void CreateProdukt(Produkt produkt, string categoryId);
        List<Produkt> ReadProdukt();
        void UpdateProdukt(Produkt produkt, string newName, string newDetails, string newKosten, string newAnzahl);
        void DeleteProdukt(string id);

        void CreateCategory(Category category);
        List<Category> ReadCategory();
        void UpdateCategory(Category category, string newName);
        void DeleteCategory(string catName, string catId);
        //CRUD
    }
}
