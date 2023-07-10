using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir!")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir!")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Display(Name = "Ad Soyad")]
        public string FullName => $"{Name} {Surname}";

        [Display(Name = "Personel Resmi")]
        public string AuthorImage { get; set; }


        [Display(Name = "Departman")]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Email en fazla 50 karakter olabilir!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Şifre en fazla 50 karakter olabilir!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }


        // Navigation Properties
        public virtual Department Department { get; set; }

    }
}
