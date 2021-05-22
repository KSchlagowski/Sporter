using Newtonsoft.Json.Linq;
using Sporter.Domain.Models;

namespace Sporter.Application.Interfaces
{
    public interface IJsonService
    {
        string SerializeToJson<T>(T item);
        T DeserializeFromJson<T>(string json);
    }
}