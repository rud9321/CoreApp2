using System;
namespace Susa.Core.Entities.Models
{
    public partial class Location : IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }

        //public Surveyor Surveyor { get; set; }
    }
}
