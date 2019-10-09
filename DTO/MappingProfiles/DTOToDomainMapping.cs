using AutoMapper;
using DTO.DTOLibary;
using Entity.Domain;

namespace DTO.MappingProfiles
{
    public class DTOToDomainMapping : Profile
    {
        public DTOToDomainMapping()
        {
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
