using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models
{
    public class OrderProductPart : ITimeStampedModel
    {
        public long ProductId { get; set; }
        public long OrderId { get; set; }
        public double Price { get; set; }
        public double Quantity {  get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime LastModified {  get; set; }
    }
}
