using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;

namespace Susa.Core.Services.Interface
{
    public interface ILiveSurveyorService
    {
        Task<IEnumerable<Live_Surveyors>> LiveSurveyorsAsync();
        Task<Live_Surveyors> LiveInAsync(Live_Surveyors live_Surveyor);
        Task LiveOutAsync(Live_Surveyors live_Surveyor);
    }
}
