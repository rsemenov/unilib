using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unilib.Frontend.Models
{
    public class AuthorModel
    {
        public Guid AuthorId { get; set; }   
        
        [DisplayName("Ім'я автора*")]
        [Required(ErrorMessage = "Введіть ім'я автора")]
        public string Name { get; set; }

        [DisplayName("Повне ім'я*")]
        [Required(ErrorMessage = "Введіть повне ім'я")]
        public string FullName { get; set; }
        
        [DisplayName("First part*")]
        [Required(ErrorMessage = "Введіть First part")]
        public string FirstPart { get; set; }
        
        [DisplayName("Sufix part*")]
        [Required(ErrorMessage = "Sufix part")]
        public string SufixPart { get; set; }

        public string OtherNames { get; set; }
        public string NameAddition { get; set; }
    }
}