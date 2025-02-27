using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CRUD_Imagen.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "SubCategory Name")]
        public string SubCategoryName { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
