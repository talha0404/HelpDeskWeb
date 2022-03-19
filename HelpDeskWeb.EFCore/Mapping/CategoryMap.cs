using HelpDeskWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.EFCore.Mapping
{
    public class CategoryMap : BaseEntityMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            modelBuilder.ToTable(nameof(Category));
        }
    }
}
