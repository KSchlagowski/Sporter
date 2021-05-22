using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Sporter.Application.Interfaces;
using Sporter.Application.Validators.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Services
{
    public class JsonService : IJsonService
    {
        private readonly IJsonValidator _validator;

        public JsonService(IJsonValidator validator)
        {
            _validator = validator;
        }

        public string SerializeToJson<T>(T objectToSerialize)
        {
            string serializedObject = JsonConvert.SerializeObject(objectToSerialize);
            JObject json = JObject.Parse(serializedObject);

            if (_validator.ValidateJson<T>(json))
            {
                return serializedObject;
            }

            return null;
        }

        public T DeserializeFromJson<T>(string json)
        {
            json = json.Replace(@"\","");
            T deserializedObject = JsonConvert.DeserializeObject<T>(json);
            JObject jObject = JObject.Parse(json);

            if (_validator.ValidateJson<T>(jObject))
            {
                return deserializedObject;
            }
            
            return default(T);
        }
    }
}