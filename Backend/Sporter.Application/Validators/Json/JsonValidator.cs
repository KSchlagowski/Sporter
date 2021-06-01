using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Sporter.Application.Validators.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Application.Validators.Json
{
    public class JsonValidator : IJsonValidator
    {
        private readonly JSchemaGenerator _generator;
        
        public JsonValidator()
        {
            _generator = new JSchemaGenerator();
        }

        public bool ValidateJson<T>(JObject jobject)
        {
            return jobject.IsValid(GenerateSchema<T>());
        }
            
        private JSchema GenerateSchema<T>() =>
            _generator.Generate(typeof(T));
    }
}