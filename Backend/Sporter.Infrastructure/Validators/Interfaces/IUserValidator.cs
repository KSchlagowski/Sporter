using System.Collections.Generic;
using Sporter.Core.Entities;

namespace Sporter.Infrastructure.Validators.Interfaces
{
    public interface IUserValidator
    {
        List<string> Validate(User user);
    }
}