using System.ComponentModel.DataAnnotations;

namespace CRUD_Imagen.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }

}
