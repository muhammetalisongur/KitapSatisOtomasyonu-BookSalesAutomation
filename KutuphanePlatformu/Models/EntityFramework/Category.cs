using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace KutuphanePlatformu.Models.EntityFramework
{
    public class Category
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Kategori Adı")]
        [RegularExpression(@"^[a-zA-ZğüşöçİĞÜŞÖÇ / ı I]+$", ErrorMessage = "Kategori adı sadece harf içerebilir!")]
        public string KategoriAdi { get; set; }

    }
}