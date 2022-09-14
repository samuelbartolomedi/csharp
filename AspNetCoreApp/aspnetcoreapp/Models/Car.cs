using System.ComponentModel.DataAnnotations;

namespace aspnetcoreapp.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }

    }
}
