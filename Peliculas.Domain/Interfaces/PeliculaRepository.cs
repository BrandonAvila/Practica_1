using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas.Domain.Entities;

namespace Peliculas.Domain.Interfaces
{
    public interface PeliculaRepository
    {
        Task<IEnumerable<Pelicula>> TodosLosDatos();
        Task<Pelicula> PorID(int id);
        Task<int> create(Pelicula pelicula);
        Task<bool> Update(int id, Pelicula pelicula);
    }
}