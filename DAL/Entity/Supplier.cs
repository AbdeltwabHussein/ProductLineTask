using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productLine.DAL.Entity
{
    [Table("Supplier")]
    public class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
