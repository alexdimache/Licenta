using AutoMapper;
using FinancePlanner.Entities.User;
using FinancePlanner.Services.Dtos;

namespace FinancePlanner.Services.Mapper
{
    public static class Mapper
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDto, User>()
                .ForMember(x => x.Id, opt => opt.Ignore());
            });

            return config;
        }
    }
}
