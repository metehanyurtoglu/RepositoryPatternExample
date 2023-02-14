using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Base<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
        public DateTime InsertedAt { get; set; }
        public long InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long UpdatedBy { get; set; }
    }

    public class SoftDeleteBase<TPrimaryKey> : Base<TPrimaryKey>
    {
        public bool IsDeleted { get; set; }
    }
}
