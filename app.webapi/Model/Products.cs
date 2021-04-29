using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.WebApi.Model
{
    public class Products
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Amount { get; set; }
        
        [Column(TypeName = "decimal(37, 2)")]
        public int Price { get; set; }
        
        [Required]
        public int Id_categories { get; set; }
        public Categories Categories { get; set; }
    }
}