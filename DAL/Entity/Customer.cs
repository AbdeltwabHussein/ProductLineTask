using productLine.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productLine.DAL
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
