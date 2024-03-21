using System.ComponentModel.DataAnnotations;

namespace PermissionManagement.MVC.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
