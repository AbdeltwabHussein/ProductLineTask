using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productLine.DAL.Entity
{
    [Table("Order")]

    public class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
