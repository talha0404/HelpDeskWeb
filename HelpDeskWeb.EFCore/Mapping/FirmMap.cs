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
    public class FirmMap : BaseEntityMap<Firm>
    {
        public override void Configure(EntityTypeBuilder<Firm> modelBuilder)
        {
            modelBuilder.ToTable(nameof(Firm));
        }
    }
}
