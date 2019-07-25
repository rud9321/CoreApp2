using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Susa.Core.Entities.Models;
using Susa.Core.Repo;
using Susa.Core.Services.Interface;

namespace Susa.Core.Services
{
    public class SurveyorService : ISurveyorService
    {
        private readonly IAsyncRepository<Surveyor> _surveyorRepository;
        public SurveyorService(IAsyncRepository<Surveyor> asyncRepository)
        {
            this._surveyorRepository = asyncRepository;
        }        

        public async Task<Surveyor> SurveyorByIdAsync(long id)
        {
            return await _surveyorRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Surveyor>> SurveyorsAsync()
        {
            return await _surveyorRepository.ListAllAsync();
        }
    }
}
