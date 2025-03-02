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

        public static MovieResponse MapToResponse(this Movie movie)
        {
            return new MovieResponse
            {
                Id = movie.Id,
                Genres = movie.Genres.ToList(),
                Title = movie   .Title,
                YearOfRelease = movie.YearOfRelease
            };
        }
    }
}
