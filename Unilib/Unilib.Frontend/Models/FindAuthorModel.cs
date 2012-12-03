using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Unilib.Frontend.Models
{
    public class FindAuthorModel
    {
        [DisplayName("Прізвище* ")]
        [Required(ErrorMessage = "Введіть Прізвище")]
        public string Surname { get; set; }
        [DisplayName("Ім'я")]
        public string Name { get; set; }
        [DisplayName("По-батькові")]
        public string Patronymic { get; set; }
    }
}