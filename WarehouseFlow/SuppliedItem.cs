using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class SuppliedItem
    {
        [Key]
        public int Id { get; set; }

        public int PermitId { get; set; }
        public int ItemId { get; set; }
        public int WarehouseId { get; set; }

        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public int ShelfLife { get; set; }

        public SupplyPermit Permit { get; set; } = null!;
        public Item Item { get; set; } = null!;
        public Warehouse Warehouse { get; set; } = null!;
    }
}
