using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.webapi.Model
{
    public class Natural_person
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int Id { get; set; }
        
        [Required]
        public int Id_Customer { get; set; }
        public Customers Customers { get; set; }

        [Column(TypeName = "char(14)")]
        public string Cpf { get; set; }
    }
}