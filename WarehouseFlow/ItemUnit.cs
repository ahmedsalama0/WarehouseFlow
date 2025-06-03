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
    [PrimaryKey(nameof(ItemId), nameof(Unit))]
    public class ItemUnit
    {
        public int ItemId { get; set; }

        [StringLength(50)]
        public string Unit { get; set; } = null!;

        public Item Item { get; set; } = null!;
    }
}
