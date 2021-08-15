using System;
using TS.Business.Objects;

namespace TS.Business.Services.Users
{
    public interface IUserService
    {
        UserDto GetById(Guid key);
    }
}