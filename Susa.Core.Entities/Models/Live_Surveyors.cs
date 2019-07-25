using System;
namespace Susa.Core.Entities.Models
{
    public class Live_Surveyors
    {
        public int Id { get; set; }
        public long? SurveyorRefId { get; set; }
        public Surveyor Surveyor { get; set; }
        public string Area { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Descriptions { get; set; }
    }
}
