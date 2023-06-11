using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstProjectWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage="Must be in 0 - 100 range")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
