using System.Collections.Generic;
using Sporter.Domain.Entities;

namespace Sporter.Infrastructure.Validators.Interfaces
{
    public interface IUserValidator
    {
        List<string> Validate(User user);
    }
}