namespace ProvidersDomain.Models
{
    public class ProductSpecification : ITimeStampedModel
    {
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
        public long SpecificationId { get; set; }
        public virtual Specification Specification { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
    }
}
