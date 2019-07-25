using System;
namespace Susa.Core.Entities.Models
{
    public partial class Surveyor_Expertise_Type : IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
