using Movies.Application.Models;
using Movies.Contracts.Requests;
using Movies.Contracts.Responses;

namespace Movies.Api.Mapping
{
    public static class ContractMapping
    {
        public static Movie MapToMovie(this CreateMovieRequest request)
        {
            return new Movie
            {
                Id = Guid.NewGuid(),
                Genres = request.Genres.ToList(),
                Title = request.Title,
                YearOfRelease = request.YearOfRelease
            };
        }
        public static Movie MapToMovie(this UpdateMovieRequest request, Guid id)
        {
            return new Movie
            {
                Id = id,
                Genres = request.Genres.ToList(),
                Title = request.Title,
                YearOfRelease = request.YearOfRelease
            };
        }

        public static MovieResponse MapToResponse(this Movie movie)
        {
            return new MovieResponse
            {
                Id = movie.Id,
                Genres = movie.Genres.ToList(),
                Slug = movie.Slug,
                Title = movie.Title,
                YearOfRelease = movie.YearOfRelease
            };
        }
        public static MoviesResponse MapToResponse(this IEnumerable<Movie> movies)
        {
            return new MoviesResponse
            {
                Items = movies.Select(MapToResponse)
            };
        }
    }
}
