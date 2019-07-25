using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;
using Susa.Core.Repo;
using Susa.Core.Services.Interface;

namespace Susa.Core.Services
{
    public class LiveSurveyorService : ILiveSurveyorService
    {
        private readonly IAsyncRepository<Live_Surveyors> _liveSurveyorRepository;
        public LiveSurveyorService(IAsyncRepository<Live_Surveyors> asyncRepository)
        {
            this._liveSurveyorRepository = asyncRepository;
        }

        public async Task<Live_Surveyors> LiveInAsync(Live_Surveyors live_Surveyor)
        {
            return await _liveSurveyorRepository.AddAsync(live_Surveyor);
        }

        public Task LiveOutAsync(Live_Surveyors live_Surveyor)
        {
            //_liveSurveyorRepository.ListAsync();
            //await _liveSurveyorRepository.DeleteAsync(live_Surveyor);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Live_Surveyors>> LiveSurveyorsAsync()
        {
            return await _liveSurveyorRepository.ListAllAsync();
        }
    }
}
