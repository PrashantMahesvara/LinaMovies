using AutoMapper;
using LinaMovies.Web.Dto;
using LinaMovies.Web.Models;

namespace LinaMovies.Web.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<Genre, GenreDto>();
            CreateMap<Format, FormatDto>();

            CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<GenreDto, Genre>()
                .ForMember(g => g.Id, opt => opt.Ignore());
            CreateMap<FormatDto, Format>()
                .ForMember(f => f.Id, opt => opt.Ignore());

            
        }
    }
}