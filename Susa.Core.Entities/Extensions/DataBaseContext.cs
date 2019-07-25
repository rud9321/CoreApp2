using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Susa.Core.Entities.Extensions;

namespace Susa.Core.Entities
{
    public partial class DataBaseContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Type[] types = typeof(EntityTypeConfiguration<>).GetTypeInfo().Assembly.GetTypes();
            IEnumerable<Type> typesToRegister = types
                .Where(type => !string.IsNullOrEmpty(type.Namespace) &&
                                type.GetTypeInfo().BaseType != null &&
                                type.GetTypeInfo().BaseType.GetTypeInfo().IsGenericType &&
                                type.GetTypeInfo().BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                ModelBuilderExtensions.AddConfiguration(modelBuilder, configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
