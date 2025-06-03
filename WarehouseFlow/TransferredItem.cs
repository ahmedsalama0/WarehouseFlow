using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarehouseFlow
{
    public class TransferredItem
{
        [Key]
    public int Id { get; set; }

    public int FromWarehouseId { get; set; }
    public int ToWarehouseId { get; set; }
    public int ItemId { get; set; }
    public int Qty { get; set; }
    public int SupplierId { get; set; }
    public DateTime ProductionDate { get; set; }
    public int ShelfLife { get; set; }
    public DateTime TransferDate { get; set; }

    public Warehouse FromWarehouse { get; set; } = null!;
    public Warehouse ToWarehouse { get; set; } = null!;
    public Item Item { get; set; } = null!;
    public Supplier Supplier { get; set; } = null!;
}
}
