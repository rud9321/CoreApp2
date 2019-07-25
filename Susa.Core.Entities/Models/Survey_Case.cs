using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class Survey_Case
    {
        public long Survey_Case_ID { get; set; }
        public string Survey_Case_No { get; set; }
        public DateTime? Survey_Case_Date { get; set; }
        public string Survey_ClaimNO { get; set; }
        public string Survey_PolicyNO { get; set; }
        public long? Company_Id { get; set; }
        public int? WorkShopId { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Mobile { get; set; }
        public string Customer_LandLine { get; set; }
        public long? Case_Type_Id { get; set; }
        public long? Surveyor_ID { get; set; }
        public DateTime? Assigned_DateTime { get; set; }
        public string Survey_Location { get; set; }
        public string Survey_GeoCodes { get; set; }
        public int? Survey_Status_ID { get; set; }
        public DateTime? Status_Change_DateTime { get; set; }
        public DateTime? DateofAllotmentofsurvey { get; set; }
        public DateTime? DateofSurvey { get; set; }
        public string PlaceofSurvey { get; set; }
        public string InsuredName { get; set; }
        public string InsuredAddress { get; set; }
        public string InsuredMobile { get; set; }
        public string EmailID { get; set; }
        public string CmpnyName { get; set; }
        public long? SURVEY_CASE_SERIALNO { get; set; }
        public string Policy_Type { get; set; }
        public string Policy_Start_Date { get; set; }
        public string Policy_End_Date { get; set; }
        public string Policy_Value { get; set; }
        public string SLNO { get; set; }
        public string Intimation_Date { get; set; }
        public string Intimation_Time { get; set; }
        public string Intimation_PlaceG { get; set; }
        public bool? DelayinIntimation { get; set; }
        public string IntimationDelayReason { get; set; }
        public int? USERID { get; set; }//userid default 0 nullable
        public string InsuredContactNo { get; set; }
        public string InspectionOfficialName { get; set; }
        public string InspectionOfficialContactNo { get; set; }
        public int? AreaID { get; set; }//areadid
        public string WorkShopNotes { get; set; }
        public int? StateID { get; set; }
        public int? CityID { get; set; }
        public bool? AssessmentCase { get; set; }//Survey_Case_AssessmentCase
        public int? TemplateID { get; set; }
        public int? IsEstimateSubmitted { get; set; }

    }
}
