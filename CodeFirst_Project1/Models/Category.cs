using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_Project1.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name="Kategori Adı")]
        [Required(ErrorMessage ="Kategori adı boş bırakılamaz.")]
        public string Name { get; set; }


        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}