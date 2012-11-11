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
        [DisplayName("Authors Name")]
        public string Name { get; set; }
        [DisplayName("Full name")]
        public string FullName { get; set; }
        [DisplayName("First part")]
        public string FirstPart { get; set; }
        [DisplayName("Sufix part")]
        public string SufixPart { get; set; }

        public string OtherNames { get; set; }
        public string NameAddition { get; set; }
    }
}