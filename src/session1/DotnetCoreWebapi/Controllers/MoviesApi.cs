using DotnetCoreWebapi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebapi.Controllers
{
    [Route("/movies")]
    public class MoviesApi : Controller
    {
        private readonly IMovieRepository repo;
        private readonly IMovieRepository repo2;

        public MoviesApi(IMovieRepository repo,IMovieRepository repo2)
        {
            this.repo = repo;
            this.repo2 = repo2;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(repo.GetAll());
        }
    }
}
