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
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }

        public Client Client { get; set; } = null!;
        public ICollection<ReleasedItem> ReleasedItems { get; set; } = new List<ReleasedItem>();
    }
}
