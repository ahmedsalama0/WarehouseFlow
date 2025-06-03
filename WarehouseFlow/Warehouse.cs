using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{

    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? Supervisor { get; set; }

        public ICollection<ReleasedItem> ReleasedItems { get; set; } = new List<ReleasedItem>();
        public ICollection<SuppliedItem> SuppliedItems { get; set; } = new List<SuppliedItem>();
        public ICollection<TransferredItem> TransferredItemsFromWarehouse { get; set; } = new List<TransferredItem>();
        public ICollection<TransferredItem> TransferredItemsToWarehouse { get; set; } = new List<TransferredItem>();
        public ICollection<WarehouseItem> WarehouseItems { get; set; } = new List<WarehouseItem>();
    }
}
