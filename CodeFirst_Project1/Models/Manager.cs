using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_Project1.Models
{
    public class Manager
    {
        public int ID { get; set; }

        [Display(Name = "Ad Soyad")]
        [StringLength(maximumLength:150, ErrorMessage ="En fazla 150 karakter olabilir.")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olabilir.")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olabilir.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Mail Adresi")]
        [StringLength(maximumLength: 170, ErrorMessage = "En fazla 170 karakter olabilir.")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Lütfen geçerli bir mail adresi girin.")]
        public string Mail { get; set; }

        [Display(Name = "Fotoğraf")]
        [StringLength(maximumLength:70)]
        public string Image { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

    }
}