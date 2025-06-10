using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseFlow
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)] public string? Name { get; set; }
        [StringLength(20)] public string? Mobile { get; set; }
        [StringLength(20)] public string? Fax { get; set; }
        [StringLength(20)] public string? Phone { get; set; }
        [StringLength(100)] public string? Email { get; set; }
        [StringLength(100)] public string? Website { get; set; }

        
    }
}
