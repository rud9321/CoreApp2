using System;
using Susa.Core.Entities.Models;

namespace Susa.Core.Repo
{
    public sealed class LiveSurveyorsWithLocationSpecification : BaseSpecification<Live_Surveyors>
    {
        public LiveSurveyorsWithLocationSpecification(long id):base(_ => _.SurveyorRefId == id)
        {
            AddInclude(_ => _.Surveyor);
        }
    }
}
