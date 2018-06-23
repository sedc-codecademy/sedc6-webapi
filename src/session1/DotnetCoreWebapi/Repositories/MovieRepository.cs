using System.Collections.Generic;

namespace DotnetCoreWebapi.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie{Id=1,Name="pulp fiction"},
                new Movie{Id=2,Name="avengers"}
            };
        }
    }
}
