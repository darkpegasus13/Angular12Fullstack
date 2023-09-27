namespace CatalogService.Repository
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<DestinationDTO>> GetAllDestinations();
    }
}
