using CatalogService.Models;
using Microsoft.EntityFrameworkCore;
using CatalogService;
using CatalogService.Mapper;

namespace CatalogService.Repository
{
    public class DestinationRepository:IDestinationRepository
    {
        HodofilesContext context;
        public DestinationRepository(HodofilesContext _context) {
            context = _context;
        }

        public async Task<IEnumerable<DestinationDTO>> GetAllDestinations()
        {
            var asd = await context.Destinations.ToListAsync();
            return MapperService.DestinationTODestinationDTO(asd);
        }
    }
}
