using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class User_Type
    {
       [Key]
       public long User_Type_Id { get; set; }
       public string User_Type_name { get; set; }
    
    }
}
