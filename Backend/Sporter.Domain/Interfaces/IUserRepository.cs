using System.Linq;
using Sporter.Domain.Models;

namespace Sporter.Domain.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<UserModel> GetAllActiveUsers();
        UserModel GetUser(int clientId);
    }
}