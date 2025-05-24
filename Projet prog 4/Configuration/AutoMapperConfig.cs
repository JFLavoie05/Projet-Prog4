using AutoMapper;
using Projet_prog_4.Data;
using Projet_prog_4.Models.PanierDTO;
using Projet_prog_4.Models.SiteWebDTO;

namespace Projet_prog_4.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<SiteWeb, GetSiteWebDTO>();
            CreateMap<SiteWeb, DetailsSiteWebDTO>();
            CreateMap<PostSiteWebDTO, SiteWeb>();
            CreateMap<PutSiteWebDTO, SiteWeb>();
            CreateMap<PutSiteWebDTO, SiteWeb>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Panier, DetailsPanierDTO>();
            CreateMap<PostPanierDTO, Panier>()
                .ForMember(dest => dest.SiteWeb, opt => opt.Ignore()); 
            CreateMap<PutPanierDTO, Panier>()
                .ForMember(dest => dest.SiteWeb, opt => opt.Ignore());
        }
    }
}
