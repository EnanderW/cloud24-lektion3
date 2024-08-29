/*public class DbMovieRepository : MovieRepository {

    private ApplicationContext context;

    public MovieRepository(ApplicationContext context) {
        this.context = context;
    }

    public Movie GetMovie(Guid id) {
        return context.Movies.Where().First();
    }

    public void SaveMovie(Movie movie) {
        context.Movies.Add(movie);
        context.Movies.SaveChanges(movie);
    }

}

interface MovieRepository {
    void SaveMovie(Movie movie);
}*/

// Controller - kommunikation
// Service - logik/funktionalitet
// Repository - data hantering