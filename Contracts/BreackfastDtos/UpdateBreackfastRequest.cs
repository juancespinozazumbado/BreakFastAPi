
namespace BreackfastDtos
{
    public record UpdateBreakfastRequest(
        string Name,
        string Description, 
        DateTime CreatDatetime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet    );

};