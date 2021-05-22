using AutoMapper;
using Sporter.Application.Interfaces;
using Sporter.Domain.Interfaces;

namespace Sporter.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public int AddUser()
        {
            throw new System.NotImplementedException();
        }
    }
}