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
        public string[] dataType { get; set; }
        public int[] SelectedThemes { get; set; }
    }
}