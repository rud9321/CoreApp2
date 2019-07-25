using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Susa.Core.Entities.Extensions;
using Susa.Core.Entities.Models;

namespace Susa.Core.Entities.Mapping
{
    public class Survey_CaseMapping : EntityTypeConfiguration<Survey_Case>
    {
        public override void Map(EntityTypeBuilder<Survey_Case> builder)
        {            
            builder.HasKey(t => t.Survey_Case_ID);
        }
    }
}
