using AutoMapper;
using BestPractice.Api.Data.Model;
using BestPractice.Api.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPractice.Api.Extensions
{
    public static class ConfigureMappingProfileExtension
    {
        public static IServiceCollection ConfigureMapping(IServiceCollection services)
        {
            var mapppingConfig = new MapperConfiguration(i => i.AddProfile(new AutoMapperMappingProfile()));
            IMapper mapper = mapppingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
    public class AutoMapperMappingProfile : Profile
    {
        public AutoMapperMappingProfile()
        {
            //isimleri aynı olanlar için bişey söylemeye gerek yok otomatik olarak aktaracaktır
            CreateMap<Contact, ContactDVO>()
                .ForMember(i => i.FullName, y => y.MapFrom(z => z.FirstName + " " + z.LastName))
                .ReverseMap();
        }

    }
}
