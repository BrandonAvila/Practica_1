using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Peliculas.Domain.Entities;
using Peliculas.Domain.DTOS.Response;
using Peliculas.Domain.DTOS.Request;

namespace Peliculas.Application.Mappings
{
    public class MapperPeliculas : Profile
    {
        public MapperPeliculas()
        {
            CreateMap<Pelicula, PeliculaResponse>()

            .ForMember(Inf => Inf.InfoPelicula, opt => opt.MapFrom(src => $"Titulo: {src.Titulo} Director: {src.Director}"))
            .ForMember(Inf => Inf.Reseñas, opt => opt.MapFrom(src => $"Puntuacion: {src.Puntuacion} Rating:  {src.Rating}"));

            CreateMap<PeliculaRequest, Pelicula>();
        }
    }
}