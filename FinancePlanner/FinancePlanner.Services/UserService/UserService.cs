using AutoMapper;
using FinancePlanner.Data.Repositories;
using FinancePlanner.Data.Repositories.UserRepository;
using FinancePlanner.Data.UnitOfWork;
using FinancePlanner.Entities.User;
using FinancePlanner.Services.Dtos;

namespace FinancePlanner.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<User> _genericRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IRepository<User> genericRepository, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }

        public async Task InsertAsync(UserDto userDto)
        {
            var entity = _mapper.Map<UserDto, User>(userDto);

            await _genericRepository.InsertAsync(entity);
            await _unitOfWork.SaveAsync();
        }
    }
}
