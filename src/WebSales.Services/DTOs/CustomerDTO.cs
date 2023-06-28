using System.ComponentModel.DataAnnotations;
using WebSales.Domain.ValueObjects;
using WebSales.Service.Validations;

namespace WebSales.Services.DTOs
{
    public class CustomerDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        [DocumentValidation]
        [Required(ErrorMessage = "{0} is required")]
        public string? Document { get; set; }


        [Display(Name = "Is Legal Person")]
        public bool? IsLegalPerson { get; set; }

        [Display(Name = "Created At")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Modified At")]
        public DateTime? ModifiedAt { get; set; }

        public IEnumerable<ProductDTO> ProductsPurchased { get; set; }

    }
}
