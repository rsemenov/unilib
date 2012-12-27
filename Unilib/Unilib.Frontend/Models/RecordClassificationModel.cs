using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [DisplayName("Призначення")]
        public ListViewModel[] Theme { get; set; }

        public int[] SelectedList { get; set; }
        
    }

    public class ListViewModel
    {
        public string Title { get; set; }
        public int Id { get; set; }
    }
}