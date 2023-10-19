using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SharedModel
{
    /// <summary>
    /// DTO object of table 'dbo.data' 
    /// </summary>
    [Table("data", Schema = "dbo")]
    public class ToDoItem
    {
        [Key]
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("visualOrder")]
        public int VisualOrder { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        public ToDoItem()
        {
        }
        
        public ToDoItem(int visualOrder, string name, string description)
        {
            VisualOrder = visualOrder;
            Name = name; 
            Description = description; 
        }
    }
}
