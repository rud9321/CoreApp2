using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class WorkShop
    {
        [Key]
        public int WorkShopId { get; set; }
        public string WorkShopName { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string GSTIN { get; set; }
        public string Location { get; set; }
      
    }
}   
