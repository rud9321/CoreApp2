using System;
namespace Susa.Core.Entities.Models
{
    public partial class Broadcast : IBaseModel
    {
        public int Id { get; set; }
        public int Rang { get; set; }//sortest path in km
        public int Acceptance_Time { get; set; }
        public int Rejection_Time { get; set; }
        public int Surveyor_Expertise_Type_Id { get; set; }
        public int Number_of_Requested_Surveyor { get; set; }
        public int Classification_Type_Id { get; set; }
        public string Rattings { get; set; }
        public int? Location_Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
    
}
