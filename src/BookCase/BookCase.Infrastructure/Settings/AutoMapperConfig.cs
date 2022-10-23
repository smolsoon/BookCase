using AutoMapper;
using BookCase.Core.Entities;
using BookCase.Infrastructure.DTO;

namespace BookCase.Infrastructure.Settings;

public class AutoMapperConfig
{
    public static IMapper Initialize() => new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<User, UserDto>();
    }).CreateMapper();
}