using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.WebApi.Model
{
    public class Customers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Street { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string City { get; set; }
        
        [Column(TypeName = "char(2)")]
        public string State { get; set; }

        [Column(TypeName = "decimal(37, 2)")]
        public decimal Credit_Limit { get; set; }
    }
}