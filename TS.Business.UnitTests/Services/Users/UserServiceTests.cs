using System;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TS.Business.Objects;
using TS.Business.Services.Users;
using TS.Data.Entities;
using TS.Data.Repositories;

namespace TS.Business.UnitTests.Services.Users
{
    [TestClass]
    public class UserServiceTests
    {
        private IUserService _userService;
        private IReadOnlyRepository<User> _userRepository;
        private IMapper _mapper;

        [TestInitialize]
        public void TestInitialize()
        {
            _userRepository = Substitute.For<IReadOnlyRepository<User>>();
            _mapper = Substitute.For<IMapper>();
            _userService = new UserService(_userRepository, _mapper);
        }

        [TestMethod]
        public void GetById_ShouldReturnUser_WhenHeIsExists()
        {
            var key = Guid.NewGuid();
            var entity = new User();
            var dto = new UserDto();
            _userRepository.GetById(key).Returns(entity);
            _mapper.Map<UserDto>(entity).Returns(dto);

            var actualResult = _userService.GetById(key);
            
            Assert.AreSame(dto, actualResult);
        }
    }
}