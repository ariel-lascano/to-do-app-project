using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModel
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

        public ToDoItem()
        {
                
        }
        
        public ToDoItem(int visualOrder, string name, string? description)
        {
            VisualOrder = visualOrder;
            Name = name; 
            Description = description; 
        }

        public ToDoItem(int id, int visualOrder, string name, string? description) : this(visualOrder, name, description)
        {
            ID = id;
        }
    }
}
