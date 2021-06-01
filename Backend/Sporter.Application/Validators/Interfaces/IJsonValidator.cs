using Newtonsoft.Json.Linq;

namespace Sporter.Application.Validators.Interfaces
{
    public interface IJsonValidator
    {
        bool ValidateJson<T>(JObject jobject);
    }
}