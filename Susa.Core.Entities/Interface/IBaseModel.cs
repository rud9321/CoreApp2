using System;
namespace Susa.Core.Entities
{
    public interface IBaseModel
    {
        int Id {get;set;}
        string CreatedBy { get; set; }
        DateTime CreatedDateTime { get; set; }        
    }
}
