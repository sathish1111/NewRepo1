using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TESTSIX.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0,100,ErrorMessage ="Rnage Between 0 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDatetime { get; set; } = DateTime.Now;

    }
}
