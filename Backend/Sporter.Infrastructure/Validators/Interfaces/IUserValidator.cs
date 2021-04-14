using System.Collections.Generic;
using Sporter.Core.Entities;

namespace Sporter.Infrastructure.Validators.Interfaces
{
    public interface IUserValidator
    {
        public List<string> Validate(User user);
    }
}