using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<ItemUnit> ItemUnits { get; set; } = new List<ItemUnit>();
        public ICollection<ReleasedItem> ReleasedItems { get; set; } = new List<ReleasedItem>();
        public ICollection<SuppliedItem> SuppliedItems { get; set; } = new List<SuppliedItem>();
        public ICollection<TransferredItem> TransferredItems { get; set; } = new List<TransferredItem>();
        public ICollection<WarehouseItem> WarehouseItems { get; set; } = new List<WarehouseItem>();
    }
}
