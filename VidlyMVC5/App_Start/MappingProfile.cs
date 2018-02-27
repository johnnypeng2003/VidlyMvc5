using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidlyMVC5.Dtos;
using VidlyMVC5.Models;

namespace VidlyMVC5.App_Start
{
    public class MappingProfile : Profile
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<CustomerDto, Customer>();
                cfg.CreateMap<Movie, MovieDto>();
                cfg.CreateMap<MovieDto, Movie>();
                cfg.CreateMap<MembershipType, MembershipTypeDto>();
            });
        }
    }
}