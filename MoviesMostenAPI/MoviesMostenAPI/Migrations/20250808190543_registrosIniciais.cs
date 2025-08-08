using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesMostenAPI.Migrations
{
    /// <inheritdoc />
    public partial class registrosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilmeSeries",
                columns: new[] { "Id", "Descricao", "Genero", "Gostei", "Imagem", "NaoGostei", "Titulo" },
                values: new object[,]
                {
                    { 1, "Os irmãos Sam e Dean Winchester encaram cenários sinistros caçando monstros, mas velhos truques, armas e esconderijos não funcionam mais. Traídos pelos amigos, os irmãos precisam colaborar enquanto enfrentam novos inimigos.", "Drama", 25, "https://m.media-amazon.com/images/M/MV5BMDFmMGZmMGItNGRjNC00NjVjLWI5ODEtNzhjMTE5MmJhN2FkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 8, "Supernatural" },
                    { 2, "Sucesso entre os livros mais vendidos, a série de obras 'A Song of Ice and Fire', de George R.R. Martin, é levada à tela quando HBO decide navegar a fundo pelo gênero e recriar a fantasia medieval épica. Este é o retrato de duas famílias poderosas - reis e rainhas, cavaleiros e renegados, homens honestos e mentirosos - disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro. A série foi filmada em Malta e no norte da Irlanda, tendo participação do escritor dos livros.", "Drama/Fantasia", 16, "https://m.media-amazon.com/images/M/MV5BMTNhMDJmNmYtNDQ5OS00ODdlLWE0ZDAtZTgyYTIwNDY3OTU3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 5, "Game of Thrones" },
                    { 3, "Loki, o irmão de Thor, ganha acesso ao poder ilimitado do cubo cósmico ao roubá-lo de dentro das instalações da S.H.I.E.L.D. Nick Fury, o diretor desta agência internacional que mantém a paz, logo reúne os únicos super-heróis que serão capazes de defender a Terra de ameaças sem precedentes. Homem de Ferro, Capitão América, Hulk, Thor, Viúva Negra e Gavião Arqueiro formam o time dos sonhos de Fury, mas eles precisam aprender a colocar os egos de lado e agir como um grupo em prol da humanidade.", "Ação/Aventura", 30, "https://br.web.img2.acsta.net/medias/nmedia/18/89/43/82/20052140.jpg", 12, "Os Vingadores" },
                    { 4, "Breaking Bad é uma série de televisão americana criada e produzida por Vince Gilligan. Ela retrata a vida do químico Walter White, um homem brilhante frustrado em dar aulas para adolescentes do ensino médio enquanto lida com um filho sofrendo de paralisia cerebral, uma esposa grávida e dívidas intermináveis. White, então, é diagnosticado com um câncer no pulmão - o que o leva a sofrer um colapso emocional e abraçar uma vida de crimes para pagar suas dívidas hospitalares e dar uma boa vida aos seus filhos.", "Drama", 26, "https://delfos.net.br/wp-content/uploads/2017/05/860343-03-05-17-35.jpg", 7, "Breaking Bad" },
                    { 5, "John Wick é uma franquia de mídia de suspense e ação neo-noir americana criada pelo roteirista Derek Kolstad e estrelada por Keanu Reeves como John Wick, um ex-assassino que é forçado a voltar ao submundo do crime que havia abandonado.", "Ação", 23, "https://m.media-amazon.com/images/I/71+k2-r7vQL._UF894,1000_QL80_.jpg", 2, "John Wick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FilmeSeries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
