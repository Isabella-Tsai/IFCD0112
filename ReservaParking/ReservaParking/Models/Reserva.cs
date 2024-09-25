using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ReservaParking.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public required DateTime InitPark { get; set; }
        public required DateTime EndPark { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; } = 1;
        [Column(TypeName = "decimal(5,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
    }
}
