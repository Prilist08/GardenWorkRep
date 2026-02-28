using GardenERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Interfaces
{
    public interface IAuditLogRepository: IGenericRepository<AuditLog>
    {
    }
}
