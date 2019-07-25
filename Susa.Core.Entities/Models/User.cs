using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public int? Company_ID { get; set; }
        public int? User_Type_Id { get; set; }
        public int? Surveyor_Id { get; set; }//has key nullable default 0
        public int? WorkshopId { get; set; }
        public string UserPassword { get; set; }
        public string IsActive { get; set; }
        public DateTime? Date { get; set; }
        public int? CreadtedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
	    public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
