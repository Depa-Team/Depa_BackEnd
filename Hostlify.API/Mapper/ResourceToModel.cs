using AutoMapper;
using Hostlify.API.Resource;
using Hostlify.API.Resources;
using Hostlify.Infraestructure;
using Hostlify.Infraestructure.Models;

namespace Hostlify.API.Mapper;

public class ResourceToModel:Profile
{
    public ResourceToModel()
    {
        CreateMap<PlanResource, Plan>();
        CreateMap<PlanResourceGet, Plan>();
        CreateMap<UserResource, User>();
        CreateMap<UserResourceGet, User>();
        CreateMap<LoginResource, User>();
        CreateMap<HistoryResource, History>();
        CreateMap<HistoryResourceGet, History>();
        CreateMap<FlatResource, Flat>();
        CreateMap<FlatResourceGet, Flat>();
        CreateMap<EditFlatResource, Flat>();
    }
}