using AutoMapper;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;

namespace Hostlify.API.Mapper;

public class ModelToResource:Profile
{
    public ModelToResource()
    {
        CreateMap<Plan, PlanResource>();
        CreateMap<Plan, PlanResourceGet>();
        CreateMap<User, UserResource>();
        CreateMap<User, UserResourceGet>();
        CreateMap<User, LoginResource>();
        CreateMap<Flat, FlatResource>();
        CreateMap<Flat, FlatResourceGet>();
        CreateMap<Flat, EditFlatResource>();
        CreateMap<History, HistoryResource>();
        CreateMap<History, HistoryResourceGet>();
        
    }
}