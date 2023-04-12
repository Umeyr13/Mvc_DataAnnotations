using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_DataAnnotations.Models
{
    public class Kullanici
    {
        [DisplayName ("Adınız")]
        public string ad { get; set; }


        [DisplayName("Soyadınız")]
        public string soyad { get; set; }


        [DisplayName("Yaş"),Required (ErrorMessage ="{0} değerini girin"), Range(18,65,ErrorMessage = "{1} - {2} yaş arasında olmalıdır")]
        public int yas { get; set; }


        [DisplayName("Kullanıcı adı"), Required(ErrorMessage = "Lütfen Kullanıcı adını giriniz."), MinLength(5,ErrorMessage ="Enaz 5 karakter olmalı"),MaxLength(15, ErrorMessage = "Ençok 15 karakter olmalı")]
        public string kullaniciAdi { get; set; }


        [DisplayName("Sifre"),Required(ErrorMessage ="Lütfen {0} giriniz")]
        public string sifre { get; set; }


        [DisplayName("Sifre(Tekrar)"),Required(ErrorMessage ="Lütfen {0} Tekrar Girin"),Compare(nameof(sifre))]
        public string sifre2 { get; set; }


        [DisplayName("Eposta Adresiniz"), Required(ErrorMessage ="Lüften {0} Giriniz"),EmailAddress(ErrorMessage ="Geçerli {0} giriniz")]
        public string eposta { get; set; }


        [DisplayName("Eposta Tekrar"), Required(ErrorMessage = "Geçerli {0} giriniz"),Compare(nameof(eposta),ErrorMessage ="{0} ile {1} eşleşmiyor")]
        public string eposta2 { get; set; }

    }
}