using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM1_Identity_User.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProducID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string ProductName { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Unit { get; set; }

        public int Status { get; set; }
    }
}
