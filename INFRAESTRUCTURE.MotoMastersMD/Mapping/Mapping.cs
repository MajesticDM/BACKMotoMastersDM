using AutoMapper;
using CORE.MotoMastersMD.DTOs;
using CORE.MotoMastersMD.Entities;

namespace INFRAESTRUCTURE.MotoMastersMD.Mapping
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<Appointments, AppointmentsDTO>();
            CreateMap<AppointmentsDTO, Appointments>();

            CreateMap<AppointmentsStatus, AppointmentsStatusDTO>();
            CreateMap<AppointmentsStatusDTO, AppointmentsStatus>();

            CreateMap<Categories, CategoriesDTO>();
            CreateMap<CategoriesDTO, Categories>();

            CreateMap<Clients, ClientsDTO>();
            CreateMap<ClientsDTO, Clients>();

            CreateMap<PersonalData, PersonalDataDTO>();
            CreateMap<PersonalDataDTO, PersonalData>();

            CreateMap<Products, ProductsDTO>();
            CreateMap<ProductsDTO, Products>();

            CreateMap<Services, ServicesDTO>();
            CreateMap<ServicesDTO, Services>();

            CreateMap<ServicesGiven, ServicesGivenDTO>();
            CreateMap<ServicesGivenDTO, ServicesGiven>();

            CreateMap<SoldProducts, SoldProductsDTO>();
            CreateMap<SoldProductsDTO, SoldProducts>();

            CreateMap<Users, UsersDTO>();
            CreateMap<UsersDTO, Users>();

            CreateMap<UsersType, UsersTypeDTO>();
            CreateMap<UsersTypeDTO, UsersType>();
        }
    }
}
