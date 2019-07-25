using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Susa.Core.Entities.Extensions;
using Susa.Core.Entities.Models;

namespace Susa.Core.Entities.Mapping
{
    public class BroadcastMapping : EntityTypeConfiguration<Broadcast>
    {
        public override void Map(EntityTypeBuilder<Broadcast> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);
        }
    }
}
