using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asset_project.Shared.Entities
{
    public class StatusType
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null!;

        public bool MaintenanceRequest { get; set; } = false;

        public bool WorkOrder { get; set; } = false;
    }
}
