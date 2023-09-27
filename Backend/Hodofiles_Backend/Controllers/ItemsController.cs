using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatalogService.Mapper;
using CatalogService;
using CatalogService.Repository;

namespace Hodofiles_Backend.CatalogService.Controllers
{
    [Route("Destinations")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        IDestinationRepository repo;

        public ItemsController(IDestinationRepository _repo)
        {
            repo = _repo;
        }
        

        [HttpGet]
        public async Task<IEnumerable<DestinationDTO>> Get()
        {
            return await repo.GetAllDestinations();
        }

        //[HttpGet("{id}")]
        ////here action result is beneficial as we can return status code as well as itemdto
        //public ActionResult<ItemDTO> GetById(Guid id)
        //{
        //    var item = items.Where(x => x.id == id).FirstOrDefault();
        //    if (item == null)
        //        return NotFound();
        //    return item;

        //}

        //[HttpPost]
        //public ActionResult Post(CreatedItemDTO created)
        //{

        //    var item = new ItemDTO(Guid.NewGuid(), created.name, created.description,
        //        created.price, DateTimeOffset.UtcNow);
        //    items.Add(item);
        //    return CreatedAtAction(nameof(GetById), new { id = item.id }, item);
        //}

        //[HttpPut("{id}")]

        //public IActionResult Put(Guid id, UpdatedItemDTO updated)
        //{
        //    var old = items.Where(x => x.id == id).FirstOrDefault();
        //    //creating a clone with
        //    var newItem = old with
        //    {
        //        price = updated.price,
        //        description = updated.description,
        //        name = updated.name
        //    };
        //    var index = items.FindIndex(x => x.id == id);
        //    items[index] = newItem;
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(Guid id, UpdatedItemDTO updated)
        //{
        //    var old = items.Where(x => x.id == id).FirstOrDefault();
        //    var index = items.FindIndex(x => x.id == id);
        //    items.RemoveAt(index);
        //    return NoContent();
        //}

    }
}
