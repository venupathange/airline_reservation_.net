using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineReservationSystem.Data.Entities
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        [Column("USER_ID")] // ✅ Match Oracle column
        public int UserId { get; set; }

        public decimal Balance { get; set; } = 0.00m;

        public virtual User User { get; set; } = null!;
    }
}
