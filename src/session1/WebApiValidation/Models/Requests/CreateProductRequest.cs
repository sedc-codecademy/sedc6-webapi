using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiValidation.Models.Requests
{
    public class CreateProductRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [StringLength(20,MinimumLength =4, ErrorMessage ="Name must be between 4 and 20 characters long")]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Quantity must be minimum 1 and maximum 100 items")]
        public int Quantity { get; set; }
        public int? ManufacturerId { get; set; }
    }
}