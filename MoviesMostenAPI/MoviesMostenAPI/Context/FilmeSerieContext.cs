using Microsoft.EntityFrameworkCore;
using MoviesMostenAPI.Models;

namespace MoviesMostenAPI.Context;

public class FilmeSerieContext : DbContext
{
    public FilmeSerieContext(DbContextOptions options) : base(options) { }

    public DbSet<FilmeSerie> FilmeSeries { get; set; }
}
