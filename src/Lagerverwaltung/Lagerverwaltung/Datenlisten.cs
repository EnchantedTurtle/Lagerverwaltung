using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Datenlisten : IDatenverwaltung
    {
        private List<Category> MainCategories = new List<Category>();

        public void CreateProdukt(Produkt product, string categoryId)
        {
            for (var i = 0; i < MainCategories.Count; i++)
            {
                if (MainCategories[i].CategoryId == categoryId)
                {
                    MainCategories[i].Products.Add(product);
                    return;
                }
            }
        }

        public List<Produkt> ReadProdukt()
        {
            List<Produkt> products = new List<Produkt>();

            for (var i = 0; i < MainCategories.Count; i++)
            {
                for (var j = 0; j < MainCategories[i].Products.Count; j++)
                {
                   products.Add(MainCategories[i].Products[j]);

                }
            }
            return products;
        }

        public void UpdateProdukt(Produkt produkt) //Testing 
        {
            for (var i = 0; i < MainCategories.Count; i++)
            {
                for (var j = 0; j < MainCategories[i].Products.Count; j++)
                {
                    if (MainCategories[i].Products[j].Id == produkt.Id)
                    {
                        MainCategories[i].Products.Remove(MainCategories[i].Products[j]);
                        
                        MainCategories[i].Products.Add(produkt);
                        return;
                    }
                }
            }
        }

        public void DeleteProdukt(string id) //Testing
        {
            for (var j = 0; j < MainCategories.Count; j++)
            {
                for (var i = 0; i < MainCategories[j].Products.Count; i++)
                {
                    if (MainCategories[j].Products[i].Id == id)
                    {
                        MainCategories[j].Products.Remove(MainCategories[j].Products[i]);
                        return;
                    }
                }
            }
        }

        public void CreateCategory(Category category) //ListBox wird nicht angezeigt
        {
            MainCategories.Add(category);
        }

        public List<Category> ReadCategory() //Done
        {
            return MainCategories;
        }

        public void UpdateCategory(Category category) //Done
        {
            for (var i = 0; i < MainCategories.Count; i++)
            {
                if (MainCategories[i].CategoryId.Equals(category.CategoryId))
                {
                    MainCategories.Remove(MainCategories[i]);
                    MainCategories.Insert(i,category);
                    return;
                }
            }
        }

        public void DeleteCategory(string catId) //Done
        {
            for (var i = 0; i < MainCategories.Count; i++)
            {
                if (MainCategories[i].CategoryId == catId)
                {
                    if (MainCategories[i].Products.Count > 0)
                    {
                        MessageBox.Show("Es sind Produkte dieser Kategorie zugeordnet");
                        return;
                    }
                    MainCategories.Remove(MainCategories[i]);
                    return;
                }
            }
        }
    }
}