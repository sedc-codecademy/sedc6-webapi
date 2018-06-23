using System.Collections.Generic;

namespace DotnetCoreWebapi.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
    }
}
