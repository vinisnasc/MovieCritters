﻿using MovieCritters.Domain.Entities;

namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IMovieRepository : IRepository<Movie>, IAsyncRepository<Movie>
    {
        
    }
}
