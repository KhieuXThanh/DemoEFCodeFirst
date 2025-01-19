using System.ComponentModel.DataAnnotations;

namespace DemoEFCodeFirst.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public string CustomerName { get; set; }
    }
}
