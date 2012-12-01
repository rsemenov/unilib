using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Unilib.Frontend.Models
{
    public class RecordModel
    {
        public Guid RecordId { get; set; }
        [DisplayName("Name of record")]
        [Required(ErrorMessage= "Enter name")]
        public string Name { get; set; }
    }
}