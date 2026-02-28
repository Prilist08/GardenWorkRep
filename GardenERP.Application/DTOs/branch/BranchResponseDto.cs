using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs.branch
{
    public class BranchResponseDto
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
