using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    [SuppressMessage("ReSharper", "UseNullPropagation")]
    class Datenbank : IDatenverwaltung
    {
        public void CreateProdukt(Produkt produkt, string categoryId)
        {
            using (var db = DbContextLager.Create())
            {
                produkt.CategoryId = categoryId;
                db.Products.Add(produkt);
                db.SaveChanges();
            }
        }

        public List<Produkt> ReadProdukt()
        {
            using (var db = DbContextLager.Create())
            {
                return db.Products.ToList();
            }
        }

        public void DeleteProdukt(string id)
        {
            using (var db = DbContextLager.Create())
            {
                var foundProduct = db.Products.FirstOrDefault(product => product.Id == id);

                if (foundProduct != null)
                {
                    db.Products.Remove(foundProduct);
                    db.SaveChanges();
                }
            }
        }

        public void CreateCategory(Category category)
        {
            using (var db = DbContextLager.Create())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        public List<Category> ReadCategory()
        {
            using (var db = DbContextLager.Create())
            {
                return db.Categories.ToList();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var db = DbContextLager.Create())
            {
                var foundCategory = db.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

                if (foundCategory != null)
                {
                    db.Categories.Remove(foundCategory);
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteCategory(string catId)
        {
            using (var db = DbContextLager.Create())
            {
                var foundCategory = db.Categories.FirstOrDefault(c => c.CategoryId == catId);
                var foundProduct = db.Products.FirstOrDefault(p => p.CategoryId == catId);

                if (foundCategory != null && foundProduct == null)
                {

                    db.Categories.Remove(foundCategory);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Es sind noch Produkte in dieser Kategorie");
                }
            }
        }

        public void UpdateProdukt(Produkt produkt)
        {
            using (var db = DbContextLager.Create())
            {
                var foundProduct = db.Products.FirstOrDefault(p => p.Id == produkt.Id);

                if (foundProduct != null)
                {
                    db.Products.Remove(foundProduct);
                    db.Products.Add(produkt);
                    db.SaveChanges();
                }

            }
            
        }
    }
}
