using System;
namespace Susa.Core.Entities.Models
{
    public partial class Survey_Tracking : IBaseModel
    {
        public int Id { get; set; }
        public int Survey_Case_Id { get; set; }
        public int Surveyor_Id { get; set; }
        public DateTime Job_Start_Time { get; set; }
        public int Job_Start_Location_Id { get; set; }
        public int Vehicle_Type_Id { get; set; }
        public int Check_In_Time { get; set; }
        public int Check_Out_Time { get; set; }
        public int Check_Out_Location_Id { get; set; }
        public int Total_Distance { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
