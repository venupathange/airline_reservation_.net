using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineReservationSystem.Data.Entities
{
    [Table("USERS")] // Match your actual table name
    public class User
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; } = string.Empty;

        [Column("EMAIL")]
        public string Email { get; set; } = string.Empty;

        [Column("PASSWORD")]
        public string Password { get; set; } = string.Empty;

        [Column("ROLE")]
        public string Role { get; set; } = "USER";

        [Column("GENDER")]
        public char Gender { get; set; }

        [Column("MOBILENUMBER")]
        public string MobileNumber { get; set; } = string.Empty;

        [Column("CREATEDAT")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
