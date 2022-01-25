using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Peliculas.Infraestructure.Data;
using Peliculas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Peliculas.Domain.Interfaces;
#pragma warning restore format

namespace Peliculas.Infraestructure.Repositories
{
    public class PeliculasSQLRepository : PeliculaRepository
    {
        private readonly Practica01Context _context;

        public PeliculasSQLRepository(Practica01Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pelicula>> TodosLosDatos()
        {
            var encuentro = _context.Peliculas.Select(g => g);
            return await encuentro.ToListAsync();
        }

        public async Task<Pelicula> PorID(int id)
        {
            var poi = await _context.Peliculas.FirstOrDefaultAsync(dn => dn.Id == id);
            return poi;
        }


        //Crear denuncia
        public async Task<int> create(Pelicula pelicula)
        {
            var entity = pelicula;
            await _context.Peliculas.AddAsync(entity);
            var rows = await _context.SaveChangesAsync();

            if(rows <= 0)
                throw new Exception("El registro no pudo ser completado");
            
            return entity.Id;
        }

        //Actualizar denuncia
        public async Task<bool> Update(int id, Pelicula pelicula)
        {
            if(id <= 0 || pelicula == null)
                throw new ArgumentException("Falta informacion para poder realizar la modificacion");

            var entity = await PorID(id);

            entity.Titulo = pelicula.Titulo;
            entity.Director = pelicula.Director;
            entity.Genero = pelicula.Genero;
            entity.Puntuacion = pelicula.Puntuacion;
            entity.Rating = pelicula.Rating;
            entity.FechaDePublicacion = pelicula.FechaDePublicacion;

            _context.Update(entity);

            var rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}