using System.Linq;
using Sporter.Domain.Interfaces;
using Sporter.Domain.Models;

namespace Sporter.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context) =>
            _context = context;
        
        public IQueryable<UserModel> GetAllActiveUsers() =>
            _context.UserModels.Where(i => i.IsActive);

        public UserModel GetUser(int userId) =>
            _context.UserModels.FirstOrDefault(i => i.Id == userId);
    }
}