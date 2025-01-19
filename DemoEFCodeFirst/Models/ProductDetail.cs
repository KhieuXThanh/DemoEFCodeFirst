using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoEFCodeFirst.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("Product")]
        public int ProductId {  get; set; }

        public Product product { get; set; }
    }
}
