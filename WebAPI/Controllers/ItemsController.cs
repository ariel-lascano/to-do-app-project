using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModel;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : Controller
    {
        private readonly ApplicationDatabaseContext _context;

        public ItemsController(ApplicationDatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Pick all entries from database.
        /// </summary>
        /// <returns> Collection of entries. </returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<ToDoItem>? items = await _context.Data.ToListAsync();

            if (items == null)
                return NotFound();

            return Ok(items);
        }

        /// <summary>
        /// Pick single data by id, example:
        /// http://localhost:5001/items/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ToDoItem? item = await _context.Data.FindAsync(id);
        
            if (item == null)
                return NotFound();
        
            return Ok(item);
        }

        /// <summary>
        /// Create object by argument:
        /// </summary>
        /// <param name="item"> New item. </param>
        /// <returns> Result. </returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ToDoItem item)
        {
            // Following if check data in DTO is valid:
            if (ModelState.IsValid)
            {
                _context.Data.Add(item);
                await _context.SaveChangesAsync();
                
                // Produce response by result of 'adding' operation:
                return CreatedAtAction("Get", new { id = item.ID }, item);  
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        /// <summary>
        /// Update existing entry
        /// </summary>
        /// <param name="id"> PK of existing item </param>
        /// <param name="item"> Updated data: </param>
        /// <returns> Result: </returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ToDoItem item)
        {
            var existingItem = await _context.Data.FindAsync(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = item.Name;
            existingItem.VisualOrder = item.VisualOrder;
            existingItem.Description = item.Description;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Delete item by ID.
        /// </summary>
        /// <param name="id"> argument for delete. </param>
        /// <returns> Result: </returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Data.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Data.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}