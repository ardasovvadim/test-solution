using AutoMapper;
using TS.Business.Objects;
using TS.Data.Entities;
using TS.Data.Repositories;

namespace TS.Business.Services.Users
{
    public class UserService : ReadOnlyService<UserDto, User>, IUserService
    {
        public UserService(IReadOnlyRepository<User> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}