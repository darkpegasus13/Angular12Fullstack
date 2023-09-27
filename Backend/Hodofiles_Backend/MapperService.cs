using CatalogService.Models;

namespace CatalogService.Mapper
{
    public static class MapperService
    {
        public static IEnumerable<DestinationDTO> DestinationTODestinationDTO(List<Destination> dstList)
        {
            var lst =new List<DestinationDTO>();
            foreach(var dst in dstList)
            {
                lst.Add(new DestinationDTO() { description = dst.Description??"NA",id=dst.Id,name = dst.Name ?? "NA" });
            }
            return lst;
        }
    }
}
