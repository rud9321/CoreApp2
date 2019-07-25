using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Susa.Core.Entities.Extensions;
using Susa.Core.Entities.Models;

namespace Susa.Core.Entities.Mapping
{
    public class SurveyorMapping : EntityTypeConfiguration<Surveyor>
    {
        public override void Map(EntityTypeBuilder<Surveyor> builder)
        {
            builder.HasKey(t => t.Surveyor_Id);
            builder.HasOne(_ => _.Live_Surveyors)
                .WithOne(_ => _.Surveyor)
                .HasForeignKey<Live_Surveyors>(_ => _.SurveyorRefId);
        }
    }
}
