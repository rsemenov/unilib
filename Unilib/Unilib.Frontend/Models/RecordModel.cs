using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Unilib.Frontend.Models
{
    public class RecordModel
    {
        [DisplayName("Скорочена назва запису*")]
        [Required(ErrorMessage = "Введіть скорочену назву запису")]
        public string SortTitle { get; set; }
        
        [DisplayName("Повна назва запису*")]
        [Required(ErrorMessage = "Введіть повну назву запису")]
        public string FullTitle { get; set; }
        
        [DisplayName("Інша назва запису")]
        public string OtherTitle { get; set; }
        
        [DisplayName("Опис назви запису")]
        public string TitleDescription { get; set; }
        
        [DisplayName("Відповідальність*")]
        [Required(ErrorMessage = "Введіть дані про відповідальність")]
        public string Responsibility { get; set; }
        
        [DisplayName("Частина, розділ, назва тому, глави")]
        public string ChapterName { get; set; }
        
        [DisplayName("Публікація*")]
        [Required(ErrorMessage = "Введіть дані про публікацію")]
        public string Publication { get; set; }
        
        [DisplayName("Інформація про публікацію")]
        public string PublicationInfo { get; set; }
        
        [DisplayName("Рік публікації")]
        public string PublicationYear { get; set; }
    }
}