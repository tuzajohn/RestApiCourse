using Movies.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies = new();
        public Task<bool> CreateMovieAsync(Movie movie)
        {
            _movies.Add(movie);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteMovieByIdAsync(Guid id)
        {
            var itemCount = _movies.RemoveAll(x => x.Id == id);
            if (itemCount == 0)
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            return Task.FromResult(_movies.AsEnumerable());
        }

        public Task<Movie?> GetMovieByIdAsync(Guid id)
        {
            var movie = _movies.SingleOrDefault(x => x.Id == id);
            return Task.FromResult(movie);
        }

        public Task<bool> UpdateMovieAsync(Movie movie)
        {
            var movieIndex = _movies.FindIndex(x => x.Id == movie.Id);
            if (movieIndex == -1)
            {
                return Task.FromResult(false);
            }

            _movies[movieIndex] = movie;

            return Task.FromResult(true);
        }
    }
}
