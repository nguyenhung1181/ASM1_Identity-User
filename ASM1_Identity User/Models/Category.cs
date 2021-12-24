using System.ComponentModel.DataAnnotations;

namespace ASM1_Identity_User.Models
{
    public class Category
    {
        public int catID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string catName { get; set; }
    }
}
