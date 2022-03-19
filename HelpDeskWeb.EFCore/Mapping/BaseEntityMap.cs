using HelpDeskWeb.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.EFCore.Mapping
{
    public abstract class BaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> modelBuilder)
        {
            modelBuilder.HasKey(a => a.Id);
            modelBuilder.HasIndex(u => u.Guid).IsUnique(true);
            modelBuilder.Property(b => b.RecordDate).HasDefaultValueSql("getdate()");
        }
    }
}
