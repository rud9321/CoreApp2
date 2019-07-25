using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;

namespace Susa.Core.Services.Interface
{
    public interface ISurveyorService
    {
        Task<IEnumerable<Surveyor>> SurveyorsAsync();

        Task<Surveyor> SurveyorByIdAsync(long id);
        
    }
}
