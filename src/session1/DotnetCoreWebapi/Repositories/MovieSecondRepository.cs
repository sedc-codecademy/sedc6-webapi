using System.Collections.Generic;

namespace DotnetCoreWebapi.Repositories
{
    public class MovieSecondRepository : IMovieRepository
    {
        public int count = 0;

        public MovieSecondRepository() => count++;

        public List<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie{ Id = 200, Name = "deadpool"},
                new Movie{ Id = 200, Name = "deadpool 2"},
                new Movie{ Id = 200, Name = "iscelitel"}
            };
        }
    }
}
