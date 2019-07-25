using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class Surveyor
    {
        public long Surveyor_Id { get; set; }
        public string SurveyorCode { get; set; }
        public string Surveyor_Name { get; set; }
        public string Surveyor_EmailId { get; set; }
        public string Surveyor_MobileNo { get; set; }
        public string Surveyor_LandLine { get; set; }
        public int? StateID { get; set; }
        public int? CityID { get; set; }
        public string Surveyor_Address { get; set; }
        public string BillAddress { get; set; }
        public string Surveyor_License_No { get; set; }
        public string Surveyor_License_Expiry_Date { get; set; }
        public string SURVEYOR_COMPANY_NAME { get; set; }
        public long? COMPANY_ID { get; set; }
        public string Surveyor_GSTIN { get; set; }
        public string Surveyor_PAN { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string BankAddress { get; set; }
        public string BankAccNo { get; set; }
        public string MICRCode { get; set; }
        public int? CaseTypeAllowed { get; set; }
        public int? CaseAllocation { get; set; }
        public int? NoOfCases { get; set; }
        public bool? IsActive { get; set; }
        public bool? WatermarkYNG { get; set; }
       
        public Live_Surveyors Live_Surveyors { get; set; }
    }
}
