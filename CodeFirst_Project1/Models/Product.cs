using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_Project1.Models
{
    public class Product
    {
        public int ID { get; set; }

        public int Category_ID { get; set; }

        [ForeignKey("Category_ID")]
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "Ürün Adı adı boş bırakılamaz.")]
        [StringLength(maximumLength:150, ErrorMessage ="150 Karakter ile sınırlı")]//nvarchar(150)
        public string Product_Name { get; set; }

        public decimal Price { get; set; }

        public bool Status { get; set; }
    }
}