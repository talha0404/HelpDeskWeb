using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Base
{
    public abstract class Entity : IEntity
    {
        //Direk Nesne oluşturabilecek bir bir nesne olmadığı için abstract olarak tanımlıyoruz.

        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string ActionUser { get; set; }
        public long? UserId { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedDate { get; set; }
        public long? ModifiedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime RecordDate { get; set; }

        public Entity()
        {
            CreatedDate = long.Parse("0");
            ModifiedDate = long.Parse("0");
            IsDeleted = false;
        }
    }
}
