//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using DataAccess.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class ContactForm  : BaseEntity
    {

        [Display(Name = "Ad")]
        [DataType(DataType.Text)]
        [System.ComponentModel.DataAnnotations.Required]
        public String Name { get; set; }

        [Display(Name = "Soyad")]
        [DataType(DataType.Text)]
        [System.ComponentModel.DataAnnotations.Required]
        public String Lastname { get; set; }

        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Required]
        public String EMail { get; set; }

        [Display(Name = "Telefon Numaras�")]
        [DataType(DataType.PhoneNumber)]
        [System.ComponentModel.DataAnnotations.Required]
        public String Phone { get; set; }

        [Display(Name = "Konu")]
        [DataType(DataType.Text)]
        [System.ComponentModel.DataAnnotations.Required]
        [MaxLength(75)]
        public String Subject { get; set; }

        [Display(Name = "Mesaj")]
        [DataType(DataType.MultilineText)]
        [System.ComponentModel.DataAnnotations.Required]
        public String Message { get; set; }

        [DefaultValue(false)]
        public bool isRead { get; set; }

    }
}
