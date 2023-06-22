using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccess.Configurations.Seeds
{
    public class CategorySeed<T> : DropCreateDatabaseIfModelChanges<Context>
    {

        protected override void Seed(Context context)
        {
            IList<Category> categories = new List<Category>();

            #region Book Categories

            // Kitap Kategorileri
            categories.Add(new Category() { ID = 1, CategoryName = "Bilim Kurgu" });
            categories.Add(new Category() { ID = 2, CategoryName = "Bilim" });
            categories.Add(new Category() { ID = 3, CategoryName = "Çocuk Kitapları" });
            categories.Add(new Category() { ID = 4, CategoryName = "Din" });
            categories.Add(new Category() { ID = 5, CategoryName = "Edebiyat" });
            categories.Add(new Category() { ID = 6, CategoryName = "Eğitim" });
            categories.Add(new Category() { ID = 7, CategoryName = "Felsefe" });
            categories.Add(new Category() { ID = 8, CategoryName = "Hukuk" });
            categories.Add(new Category() { ID = 9, CategoryName = "İnceleme" });
            categories.Add(new Category() { ID = 10, CategoryName = "Kişisel Gelişim" });
            categories.Add(new Category() { ID = 11, CategoryName = "Mizah" });
            categories.Add(new Category() { ID = 12, CategoryName = "Psikoloji" });
            categories.Add(new Category() { ID = 13, CategoryName = "Roman" });
            categories.Add(new Category() { ID = 14, CategoryName = "Sağlık" });
            categories.Add(new Category() { ID = 15, CategoryName = "Sanat" });
            categories.Add(new Category() { ID = 16, CategoryName = "Siyaset" });
            categories.Add(new Category() { ID = 17, CategoryName = "Sosyoloji" });
            categories.Add(new Category() { ID = 18, CategoryName = "Tarih" });
            categories.Add(new Category() { ID = 19, CategoryName = "Yemek" });
            categories.Add(new Category() { ID = 20, CategoryName = "Dünya Klasikleri" });
            categories.Add(new Category() { ID = 21, CategoryName = "Türk Klasikleri" });
            categories.Add(new Category() { ID = 22, CategoryName = "Şiir" });
            categories.Add(new Category() { ID = 23, CategoryName = "Gezi" });
            categories.Add(new Category() { ID = 24, CategoryName = "Biyografi" });
            categories.Add(new Category() { ID = 25, CategoryName = "Anı" });
            categories.Add(new Category() { ID = 26, CategoryName = "Deneme" });
            categories.Add(new Category() { ID = 27, CategoryName = "Masal" });
            categories.Add(new Category() { ID = 28, CategoryName = "Tiyatro" });
            categories.Add(new Category() { ID = 29, CategoryName = "Dergi" });
            categories.Add(new Category() { ID = 30, CategoryName = "Diğer" }); 
            #endregion

            context.Categories.AddRange(categories);

        }
    }

}
