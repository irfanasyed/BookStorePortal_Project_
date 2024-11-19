using AutoMapper;
using BookStorePortal_Project_.Dto;
using BookStorePortal_Project_.Models;

namespace BookStorePortal_Project_.BookMapping
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<Store,CreateStoreDto>().ReverseMap();
            CreateMap<Store, ResponseStoreDto>().ReverseMap();
            CreateMap<Store, UpdateStoreDto>().ReverseMap();
            CreateMap<Store, PatchStoreDto>().ReverseMap();

        }
    }
}
