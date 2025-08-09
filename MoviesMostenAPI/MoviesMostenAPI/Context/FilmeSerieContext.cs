using Microsoft.EntityFrameworkCore;
using MoviesMostenAPI.Models;

namespace MoviesMostenAPI.Context;

public class FilmeSerieContext : DbContext
{
    public FilmeSerieContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FilmeSerie>().HasData(
            new FilmeSerie { Id = 1, Titulo = "Supernatural", Genero = new List<string> { "Terror", "Drama", "Suspense" }, Descricao = "Os irmãos Sam e Dean Winchester encaram cenários sinistros caçando monstros, mas velhos truques, armas e esconderijos não funcionam mais. Traídos pelos amigos, os irmãos precisam colaborar enquanto enfrentam novos inimigos.", Imagem = "https://m.media-amazon.com/images/M/MV5BMDFmMGZmMGItNGRjNC00NjVjLWI5ODEtNzhjMTE5MmJhN2FkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Gostei = 25, NaoGostei = 8 },
            new FilmeSerie { Id = 2, Titulo = "Game of Thrones", Genero = new List<string> { "Aventura", "Fantasia" }, Descricao = "Sucesso entre os livros mais vendidos, a série de obras 'A Song of Ice and Fire', de George R.R. Martin, é levada à tela quando HBO decide navegar a fundo pelo gênero e recriar a fantasia medieval épica. Este é o retrato de duas famílias poderosas - reis e rainhas, cavaleiros e renegados, homens honestos e mentirosos - disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro. A série foi filmada em Malta e no norte da Irlanda, tendo participação do escritor dos livros.", Imagem = "https://m.media-amazon.com/images/M/MV5BMTNhMDJmNmYtNDQ5OS00ODdlLWE0ZDAtZTgyYTIwNDY3OTU3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Gostei = 16, NaoGostei = 5 },
            new FilmeSerie { Id = 3, Titulo = "Os Vingadores", Genero = new List<string> { "Ação", "Aventura" }, Descricao = "Loki, o irmão de Thor, ganha acesso ao poder ilimitado do cubo cósmico ao roubá-lo de dentro das instalações da S.H.I.E.L.D. Nick Fury, o diretor desta agência internacional que mantém a paz, logo reúne os únicos super-heróis que serão capazes de defender a Terra de ameaças sem precedentes. Homem de Ferro, Capitão América, Hulk, Thor, Viúva Negra e Gavião Arqueiro formam o time dos sonhos de Fury, mas eles precisam aprender a colocar os egos de lado e agir como um grupo em prol da humanidade.", Imagem = "https://br.web.img2.acsta.net/medias/nmedia/18/89/43/82/20052140.jpg", Gostei = 30, NaoGostei = 12 },
            new FilmeSerie { Id = 4, Titulo = "Breaking Bad", Genero = new List<string> { "Drama", "Crime" }, Descricao = "Breaking Bad é uma série de televisão americana criada e produzida por Vince Gilligan. Ela retrata a vida do químico Walter White, um homem brilhante frustrado em dar aulas para adolescentes do ensino médio enquanto lida com um filho sofrendo de paralisia cerebral, uma esposa grávida e dívidas intermináveis. White, então, é diagnosticado com um câncer no pulmão - o que o leva a sofrer um colapso emocional e abraçar uma vida de crimes para pagar suas dívidas hospitalares e dar uma boa vida aos seus filhos.", Imagem = "https://delfos.net.br/wp-content/uploads/2017/05/860343-03-05-17-35.jpg", Gostei = 26, NaoGostei = 7 },
            new FilmeSerie { Id = 5, Titulo = "John Wick", Genero = new List<string> { "Ação", "Crime" }, Descricao = "John Wick é uma franquia de mídia de suspense e ação neo-noir americana criada pelo roteirista Derek Kolstad e estrelada por Keanu Reeves como John Wick, um ex-assassino que é forçado a voltar ao submundo do crime que havia abandonado.", Imagem = "https://m.media-amazon.com/images/I/71+k2-r7vQL._UF894,1000_QL80_.jpg", Gostei = 23, NaoGostei = 2 }
        );
    }

    public DbSet<FilmeSerie> FilmeSeries { get; set; }
}
