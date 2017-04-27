using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BJDataLevel.Data
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
    }
}
