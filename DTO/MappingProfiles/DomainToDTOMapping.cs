using AutoMapper;
using DTO.DTOLibary;
using Entity.Domain;

namespace DTO.MappingProfiles
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<CustomerDTO, Customer>();
        }
    }
}
