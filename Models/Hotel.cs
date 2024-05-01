using System.ComponentModel.DataAnnotations;

namespace Otel_MVC.Models
{
    public class Hotel
    {
        [Required]
        public int HotelId { get; set;}
        [Required(ErrorMessage = "Hotel name is required.")]
        public String? HotelName { get; set; }
        [Required]
        public String? PhoneNumber { get; set; } = String.Empty;
        [Required]
        public int StarCount { get; set; }
        [Required]
        public string? Adress { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? HotelURL { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public Hotel(){
            CreateAt = DateTime.Now;
        }

        
    }
}
