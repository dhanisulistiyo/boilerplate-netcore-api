using AutoMapper;
using boilerplate_netcore_api.Apps.Dtos.In;
using boilerplate_netcore_api.Apps.Dtos.Out;
using boilerplate_netcore_api.Apps.Models;

namespace boilerplate_netcore_api.Apps.Extensions
{
    /// <summary>
    /// Auto mapping models and dtos
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// mapping models to dtos
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Person, PersonOutDtos>().ReverseMap();
            CreateMap<PersonInDtos, Person>().ReverseMap();
        }
    }
}