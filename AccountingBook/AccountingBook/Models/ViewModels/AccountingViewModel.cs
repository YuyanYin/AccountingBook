using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingBook.Models.ViewModels
{
    public class AccountingViewModel
    {
        public int Seq { get; set; }
        public string Type { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }
        public string Note { get; set; }
    }
}