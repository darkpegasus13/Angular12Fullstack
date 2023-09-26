namespace Hodofiles_Backend
{
    public record ItemDTO(Guid id, string name, string description,
        decimal price, DateTimeOffset createdDate);

    public record CreatedItemDTO(string name, string description,
        decimal price);

    public record UpdatedItemDTO(string name, string description,
        decimal price);
}
