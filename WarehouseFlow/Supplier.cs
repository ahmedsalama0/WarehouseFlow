using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)] public string? Name { get; set; }
        [StringLength(20)] public string? Mobile { get; set; }
        [StringLength(20)] public string? Fax { get; set; }
        [StringLength(20)] public string? Phone { get; set; }
        [StringLength(100)] public string? Email { get; set; }
        [StringLength(100)] public string? Website { get; set; }

        public ICollection<ReleaseOrder> ReleaseOrders { get; set; } = new List<ReleaseOrder>();
        public ICollection<SupplyPermit> SupplyPermits { get; set; } = new List<SupplyPermit>();
        public ICollection<TransferredItem> TransferredItems { get; set; } = new List<TransferredItem>();
        public ICollection<WarehouseItem> WarehouseItems { get; set; } = new List<WarehouseItem>();
    }
}
