using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Unilib.Frontend.Models
{
    public class ContentModel
    {
        [DisplayName("Тип файлу")]
        public ListViewModel[] DataType { get; set; }
        public int[] SelectedList { get; set; }

        [DisplayName("Файл")]
        [Required(ErrorMessage = "Оберіть файл")]
        public HttpPostedFileBase ContentFile { get; set; }
    }
}