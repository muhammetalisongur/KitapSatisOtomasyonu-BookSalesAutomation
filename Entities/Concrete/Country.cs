﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Country : IEntity
    {
        public int ID { get; set; }

        [Display(Name = "Ülke Adı")]
        [Required(ErrorMessage = "Ülke Adı Boş Geçilemez")]
        public string CountryName { get; set; }


        //Navigation Property
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<BookTranslator> BookTranslator { get; set; }
    }
}
