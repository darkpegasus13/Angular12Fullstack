using System.ComponentModel.DataAnnotations;

namespace Hodofiles_Backend
{
    public record ItemDTO(Guid id, string name, string description,
        decimal price, DateTimeOffset createdDate);

    public record CreatedItemDTO([Required] string name,
        string description,
        [Range(0,1000)]decimal price);

    public record UpdatedItemDTO(string name, string description,
        decimal price);
}
