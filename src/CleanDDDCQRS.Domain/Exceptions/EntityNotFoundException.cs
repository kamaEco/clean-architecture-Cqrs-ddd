using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDDDCQRS.Domain
{
    public class EntityNotFoundException : Exception
    {
        public Guid EntityId { get; }

        public EntityNotFoundException(Guid entityId)
            : base($"Entity with ID {entityId} not found.")
        {
            EntityId = entityId;
        }
    }

}
