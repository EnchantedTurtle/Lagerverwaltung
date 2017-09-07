using System.Collections.Generic;

namespace Lagerverwaltung
{
    public interface IDatenverwaltung
    {
        void CreateProdukt(Produkt produkt, string categoryId);
        List<Produkt> ReadProdukt();
        void UpdateProdukt(Produkt produkt);
        void DeleteProdukt(string id);

        void CreateCategory(Category category);
        List<Category> ReadCategory();
        void UpdateCategory(Category category);
        void DeleteCategory(string catId);
        //CRUD
    }
}
