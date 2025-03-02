using Movies.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Repositories
{
    public interface IMovieRepository
    {
        Task<bool> CreateMovieAsync(Movie movie);
        Task<Movie?> GetMovieByIdAsync(Guid id);
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<bool> UpdateMovieAsync(Movie movie);
        Task<bool> DeleteMovieByIdAsync(Guid id);
    }
}
