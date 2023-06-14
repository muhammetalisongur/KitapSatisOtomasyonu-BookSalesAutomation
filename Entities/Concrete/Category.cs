using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
       
        public int ID { get; set; }

        [Required(ErrorMessage = "Kategori adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Kategori Adı")]
        [RegularExpression(@"^[a-zA-ZğüşöçİĞÜŞÖÇ / ı I]+$", ErrorMessage = "Kategori adı sadece harf içerebilir!")]
        public string CategoryName { get; set; }

        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}
