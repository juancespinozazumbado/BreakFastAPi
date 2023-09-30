namespace BreackfastDtos
{
    public record BreakfastResponse(
        Guid Id,
        string Name,
        DateTime CreateDateTime,
        DateTime EndDateTime,
        DateTime LastModifyDateTime,
        List<string> Savory,
        List<string> Sweet );
}