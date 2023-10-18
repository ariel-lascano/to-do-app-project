using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    /// <summary>
    /// DTO object of table 'dbo.data' 
    /// </summary>
    [Table("data", Schema = "dbo")]
    public class ToDoItem
    {
        [Key]
        public int ID { get; set; }
        public int VisualOrder { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
