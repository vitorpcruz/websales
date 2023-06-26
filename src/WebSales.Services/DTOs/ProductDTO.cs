using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSales.Services.DTOs
{
    public class ProductDTO
    {
        [Key]
        public int? Id { get; private set; }

        [Required(ErrorMessage="The {0} is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; private set; }

        [MaxLength(1000)]
        public string? Description { get; private set; }

        [Required(ErrorMessage = "The {0} is required")]
        [Range(1, int.MaxValue)]
        public int Quantity { get; private set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "The {0} is required")]
        public decimal? Price { get; private set; }

        [Display(Name="Created At")]
        [Required(ErrorMessage = "The {0} is required")]
        public DateTime CreatedAt { get; private set; }

        [Display(Name = "Modified At")]
        [Required(ErrorMessage = "The {0} is required")]
        public DateTime? ModifiedAt { get; private set; }
    }
}
