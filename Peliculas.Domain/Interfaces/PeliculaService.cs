using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas.Domain.Entities;

namespace Peliculas.Domain.Interfaces
{
    public interface PeliculaService
    {
        bool ValidatedMovie(Pelicula pelicula);
        bool ValidatedUpdateMovie(Pelicula pelicula);
    }
}