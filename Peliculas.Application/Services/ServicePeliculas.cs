using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas.Domain.Entities;
using Peliculas.Domain.Interfaces;

namespace Peliculas.Application.Services
{
    public class ServicePeliculas : PeliculaService
    {
        public bool ValidatedMovie (Pelicula pelicula)
        {
            if(string.IsNullOrEmpty(pelicula.Titulo))
                return false;

            if(string.IsNullOrEmpty(pelicula.Director))
                return false;

            if(string.IsNullOrEmpty(pelicula.Genero))
                return false;

            if(string.IsNullOrEmpty(pelicula.FechaDePublicacion))
                return false;

            return true;
        }

        public bool ValidatedUpdateMovie (Pelicula pelicula)
        {
            if(string.IsNullOrEmpty(pelicula.Titulo))
                return false;

            if(string.IsNullOrEmpty(pelicula.Director))
                return false;

            if(string.IsNullOrEmpty(pelicula.Genero))
                return false;

            if(string.IsNullOrEmpty(pelicula.FechaDePublicacion))
                return false;

            return true;
        }
    }
}