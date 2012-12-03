using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Unilib.Frontend.Models
{
    public class RecordClassificationModel
    {
        [DisplayName("ISBN")]
        public string ISBN { get; set; }

        [DisplayName("ISSN")]
        public string ISSN { get; set; }

        [DisplayName("Національний ідентифікаційний номер")]
        public string NationalNumber { get; set; }

        [DisplayName("Інший ідентифікатор")]
        public string OtherIdentifier { get; set; }

        [DisplayName("Номер документа")]
        public string DocumentNumber { get; set; }
    }
}