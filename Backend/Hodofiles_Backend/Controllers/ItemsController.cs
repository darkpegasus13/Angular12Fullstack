using Microsoft.AspNetCore.Mvc;

namespace Hodofiles_Backend.CatalogService.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        //added static as it won't be created every time for each request
        private static readonly List<ItemDTO> items = new List<ItemDTO>()
        {
            new ItemDTO(Guid.NewGuid(), "Potion", "restores small amount of HP",5,DateTimeOffset.UtcNow),
            new ItemDTO(Guid.NewGuid(), "Antidote", "Cures Poison",7,DateTimeOffset.UtcNow),
            new ItemDTO(Guid.NewGuid(), "Bronze Sword", "deals small amount of damage",20,DateTimeOffset.UtcNow)
        };

        [HttpGet]
        public IEnumerable<ItemDTO> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        //here action result is beneficial as we can return status code as well as itemdto
        public ActionResult<ItemDTO> GetById(Guid id)
        {
            var item = items.Where(x => x.id == id).FirstOrDefault();
            if(item==null)
                return NotFound();
            return item;
        }

        [HttpPost]
        public ActionResult Post(CreatedItemDTO created)
        {

            var item = new ItemDTO(Guid.NewGuid(), created.name, created.description,
                created.price, DateTimeOffset.UtcNow);
            items.Add(item);
            return CreatedAtAction(nameof(GetById), new { id = item.id }, item);
        }

        [HttpPut("{id}")]

        public IActionResult Put(Guid id, UpdatedItemDTO updated)
        {
            var old = items.Where(x => x.id == id).FirstOrDefault();
            //creating a clone with
            var newItem = old with
            {
                price = updated.price,
                description = updated.description,
                name = updated.name
            };
            var index = items.FindIndex(x => x.id == id);
            items[index] = newItem;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id, UpdatedItemDTO updated)
        {
            var old = items.Where(x => x.id == id).FirstOrDefault();
            var index = items.FindIndex(x => x.id == id);
            items.RemoveAt(index);
            return NoContent();
        }


    }
}
