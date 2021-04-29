using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.WebApi.Model
{
    public class Categories
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}