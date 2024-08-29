using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/movies")]
public class MovieController : ControllerBase
{
    private MovieService movieService;

    public MovieController(MovieService movieService)
    {
        this.movieService = movieService;
    }

    [HttpPost]
    [Authorize("create_movie")]
    public ActionResult<MovieDto> CreateMovie([FromBody] CreateMovieDto dto)
    {
        try
        {
            Movie result = movieService.CreateMovie(dto);
            return Ok(new MovieDto(result));
        }
        catch (ArgumentException exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [HttpGet]
    public List<MovieDto> SearchMovies([FromQuery] string search) {
        return movieService.SearchMovies(search)
            .ConvertAll(value => new MovieDto(value))
            .ToList();
    }
}

public class CreateMovieDto
{
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }

    public List<Guid> Actors { get; set; }
}

public class MovieDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }

    public List<string> Actors { get; set; }

    public MovieDto(Movie movie)
    {
        this.Id = movie.Id;
        this.Title = movie.Title;
        this.Rating = movie.Rating;
        this.ReleaseDate = movie.ReleaseDate;
        this.Genre = movie.Genre.Id;
        this.Actors = movie.Actors.ConvertAll(value => value.Name).ToList();
    }
}
