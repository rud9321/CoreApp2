using System;
using System.ComponentModel.DataAnnotations;

namespace Susa.Core.Entities.Models
{
    public partial class Survey_Case_Vehicle_Detail
    {
        [Key]
        public long Survey_Case_Vehicle_Id { get; set; }
        public long? Survey_Case_ID { get; set; }
        public long? Motor_Vehicle_Id { get; set; }
        public string Registration_No { get; set; }
        public string ChasisNo { get; set; }
        public string EngineNo { get; set; }
        public DateTime? Fitness_Ceertificate_Validate_Date { get; set; }
        public string Permit_No { get; set; }
        public string Type_of_Permit { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string MgfYear { get; set; }
        public string Color { get; set; }
        public string OdometerReading { get; set; }
        public string Hypo { get; set; }
        public string VARIANT { get; set; }
        public string FUELTYPE { get; set; }
        public string REGISTRATIONDATE { get; set; }
        public string RegisteredOwner { get; set; }
        public string Transfer_Date { get; set; }
        public string Class_Vehicle { get; set; }
        public string Pre_Accident_Condition { get; set; }
        public string Laden_Wt { get; set; }
        public string Unladen_Wt { get; set; }
        public string CNG_KIT_Status { get; set; }
        public string Permit_Area { get; set; }        
        public string Road_Tax_ValidUpto { get; set; }
        public string seating_capacity { get; set; }
        public int? VINSearchFound { get; set; }
        public DateTime? PermitValidUpto { get; set; }
        public string CubicCapacity { get; set; }
        public string FitnessNo { get; set; }
        public int? IsRCAvailable { get; set; }    
    }
}
