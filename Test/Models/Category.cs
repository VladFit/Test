using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Display Order")] //changed name
        public int DisplayOrder { get; set; }
    }
}
