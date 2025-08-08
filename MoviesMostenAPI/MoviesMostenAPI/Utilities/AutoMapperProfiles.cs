using AutoMapper;
using MoviesMostenAPI.DTOs;
using MoviesMostenAPI.Models;

namespace MoviesMostenAPI.Utilities;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<FilmeSerie, FilmeSerieDTO>();
        CreateMap<CriarFilmeSerieDTO, FilmeSerie>();
    }
}
