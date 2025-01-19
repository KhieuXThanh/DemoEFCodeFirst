using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEFCodeFirst.Models
{
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }
        public string ProductName1 { get; set; }
        public string ProductName2 { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        [ForeignKey(nameof(BillId))]
        public int BillId { get; set; }
        public Bill Bill { get; set; } 
    }
}
