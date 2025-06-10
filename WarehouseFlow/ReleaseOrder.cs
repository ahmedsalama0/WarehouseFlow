using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class ReleaseOrder
    {
        [Key]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; }

        public Supplier Supplier { get; set; } = null!;
        public ICollection<ReleasedItem> ReleasedItems { get; set; } = new List<ReleasedItem>();
    }
}
