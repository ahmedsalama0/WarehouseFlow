using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WarehouseFlow
{
    [PrimaryKey(nameof(ItemId), nameof(ProductionDate), nameof(ShelfLife))]
    public class WarehouseItem
    {
        [Column(Order = 0)] public int ItemId { get; set; }
        [Column(Order = 1)] public DateTime ProductionDate { get; set; }
        [Column(Order = 2)] public int ShelfLife { get; set; }

        public int WarehouseId { get; set; }
        public int SupplierId { get; set; }
        public DateTime EntryDate { get; set; }

        public Warehouse Warehouse { get; set; } = null!;
        public Item Item { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
    }
}
