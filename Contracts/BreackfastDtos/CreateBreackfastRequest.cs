
namespace BreackfastDtos
{
    public record CreateBreackfastRequest(
        string Name,
        string Description, 
        DateTime CreatDatetime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet    );

};