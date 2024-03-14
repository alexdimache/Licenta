using AutoMapper;
using FinancePlanner.API.Models;
using FinancePlanner.Services.Dtos;

namespace FinancePlanner.API.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            MapUsers();
        }

        public void MapUsers()
        {
            CreateMap<UserModel, UserDto>()
                .ForMember(dto => dto.CreatedDate, map => map.Ignore())
                .ForMember(dto => dto.ModifiedDate, map => map.Ignore());
        }
    }
}
