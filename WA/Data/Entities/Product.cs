using System.ComponentModel.DataAnnotations;

namespace WA.Data.Entities
{
    public class Product
  {
        public int Id { get; set; }
        [Required(ErrorMessage = "CategoryRequired")]
        public string Category { get; set; }
        [Required(ErrorMessage = "SizeRequired")]
        public string Size { get; set; }
        [Required(ErrorMessage = "PriceRequired")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "ColorsRequired")]
        public string Colors { get; set; }
        [Required(ErrorMessage = "TitleRequired")]
        public string Title { get; set; }
        [Required(ErrorMessage = "DoorDescriptionRequired")]
        public string DoorDescription { get; set; }
        public string DoorId { get; set; }
        [Required(ErrorMessage = "ManufacturerRequired")]
        public string Manufacturer { get; set; }
  }
}
