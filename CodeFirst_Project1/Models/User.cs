using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst_Project1.Models
{
    public class User
    {
        public int ID { get; set; }
        [Display(Name = "Ad Soyad")]
        [StringLength(maximumLength: 150, ErrorMessage = "En fazla 150 karakter olabilir.")]
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
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen geçerli bir mail adresi girin.")]
        public string Mail { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

        [Display(Name ="Kayıt Tarihi")]
        public DateTime RegistrationDate { get; set; }

        [Display(Name ="Kullanıcı Yetkisi")]
        public Enums.AuthorityEnum Authority { get; set; }

        [Display(Name ="Yetki Onayı")]
        public bool AuthorityApproval { get; set; }

        [Display(Name ="Doğrulama Kodu")]
        public string VerificationCode { get; set; }

        [Display(Name ="Silindi mi?")]
        public bool Deleted { get; set; }

        public virtual ICollection<UserActivationTime> ActivationTimes { get; set; }
    }
}