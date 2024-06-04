using IngressosNet.Data;
using IngressosNet.Models;
using IngressosNet.Models.Enums;

namespace eTickets.Data;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetService<IngressosNetContext>();

        if (context?.Database != null)
        {
            context.Database.EnsureCreated();
        }

        // Cinema
        if (context?.Cinemas != null && !context.Cinemas.Any())
        {
            context.Cinemas.AddRange(new List<Cinema>()
                {
                    new()
                    {
                        Nome = "Cinema 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Descricao = "Esta é a descrição do primeiro cinema"
                    },
                    new()
                    {
                        Nome = "Cinema 2",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                        Descricao = "Esta é a descrição do segundo cinema"
                    },
                    new()
                    {
                        Nome = "Cinema 3",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                        Descricao = "Esta é a descrição do terceiro cinema"
                    },
                    new()
                    {
                        Nome = "Cinema 4",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                        Descricao = "Esta é a descrição do quarto cinema"
                    },
                    new()
                    {
                        Nome = "Cinema 5",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                        Descricao = "Esta é a descrição do quinto cinema"
                    },
                });
            context.SaveChanges();
        }

        // Atores
        if (context?.Atores != null && !context.Atores.Any())
        {
            context.Atores.AddRange(new List<Ator>()
                {
                    new()
                    {
                        NomeCompleto = "Ator 1",
                        Biografia = "Esta é a biografia do primeiro ator",
                        FotoDoPerfil = "http://dotnethow.net/images/actors/actor-1.jpeg"

                    },
                    new()
                    {
                        NomeCompleto = "Ator 2",
                        Biografia = "Esta é a biografia do segundo ator",
                        FotoDoPerfil = "http://dotnethow.net/images/actors/actor-2.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Ator 3",
                        Biografia = "Esta é a biografia do segundo ator",
                        FotoDoPerfil = "http://dotnethow.net/images/actors/actor-3.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Ator 4",
                        Biografia = "Esta é a biografia do segundo ator",
                        FotoDoPerfil = "http://dotnethow.net/images/actors/actor-4.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Ator 5",
                        Biografia = "Esta é a biografia do segundo ator",
                        FotoDoPerfil = "http://dotnethow.net/images/actors/actor-5.jpeg"
                    }
                });
            context.SaveChanges();
        }

        // Produtores
        if (context?.Produtores != null && !context.Produtores.Any())
        {
            context.Produtores.AddRange(new List<Produtor>()
                {
                    new()
                    {
                        NomeCompleto = "Produtor 1",
                        Biografia = "Esta é a biografia do primeiro produtor",
                        FotoDoPerfil = "http://dotnethow.net/images/producers/producer-1.jpeg"

                    },
                    new()
                    {
                        NomeCompleto = "Produtor 2",
                        Biografia = "Esta é a biografia do segundo produtor",
                        FotoDoPerfil = "http://dotnethow.net/images/producers/producer-2.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Produtor 3",
                        Biografia = "Esta é a biografia do segundo produtor",
                        FotoDoPerfil = "http://dotnethow.net/images/producers/producer-3.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Produtor 4",
                        Biografia = "Esta é a biografia do segundo produtor",
                        FotoDoPerfil = "http://dotnethow.net/images/producers/producer-4.jpeg"
                    },
                    new()
                    {
                        NomeCompleto = "Produtor 5",
                        Biografia = "Esta é a biografia do segundo produtor",
                        FotoDoPerfil = "http://dotnethow.net/images/producers/producer-5.jpeg"
                    }
                });
            context.SaveChanges();
        }
        // Filmes
        if (context?.Filmes != null && !context.Filmes.Any())
        {
            context.Filmes.AddRange(new List<Filme>()
                {
                    new()
                    {
                        Nome = "Life",
                        Sinopse = "Este é a sinopse do filme Life",
                        Preco = 39.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-3.jpeg",
                        DataDeLancamento = DateTime.Now.AddDays(-10),
                        DataDeEncerramento = DateTime.Now.AddDays(10),
                        CinemaId = 3,
                        ProdutorId = 3,
                        Categoria = ECategoriaFilme.Documentario
                    },
                    new()
                    {
                        Nome = "The Shawshank Redemption",
                        Sinopse = "Este é a sinopse do filme The Shawshank Redemption",
                        Preco = 29.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        DataDeLancamento = DateTime.Now,
                        DataDeEncerramento = DateTime.Now.AddDays(3),
                        CinemaId = 1,
                        ProdutorId = 1,
                        Categoria = ECategoriaFilme.Acao
                    },
                    new()
                    {
                        Nome = "Ghost",
                        Sinopse = "Este é a sinopse do filme Ghost",
                        Preco = 39.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-4.jpeg",
                        DataDeLancamento = DateTime.Now,
                        DataDeEncerramento = DateTime.Now.AddDays(7),
                        CinemaId = 4,
                        ProdutorId = 4,
                        Categoria = ECategoriaFilme.Terror
                    },
                    new()
                    {
                        Nome = "Race",
                        Sinopse = "Este é a sinonse do filme Race",
                        Preco = 39.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-6.jpeg",
                        DataDeLancamento = DateTime.Now.AddDays(-10),
                        DataDeEncerramento = DateTime.Now.AddDays(-5),
                        CinemaId = 1,
                        ProdutorId = 2,
                        Categoria = ECategoriaFilme.Documentario
                    },
                    new()
                    {
                        Nome = "Scoob",
                        Sinopse = "Este é a sinopse do filme Scoob",
                        Preco = 39.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-7.jpeg",
                        DataDeLancamento = DateTime.Now.AddDays(-10),
                        DataDeEncerramento = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProdutorId = 3,
                        Categoria = ECategoriaFilme.Desenho
                    },
                    new()
                    {
                        Nome = "Cold Soles",
                        Sinopse = "Este é a sinopse do filme Cold Soles",
                        Preco = 39.50,
                        UrlDaImagem = "http://dotnethow.net/images/movies/movie-8.jpeg",
                        DataDeLancamento = DateTime.Now.AddDays(3),
                        DataDeEncerramento = DateTime.Now.AddDays(20),
                        CinemaId = 1,
                        ProdutorId = 5,
                        Categoria = ECategoriaFilme.Drama
                    }
                });
            context.SaveChanges();
        }
        // Atores e Filmes
        if (context?.AtoresFilmes != null && !context.AtoresFilmes.Any())
        {
            context.AtoresFilmes.AddRange(new List<AtorFilme>()
                {
                    new()
                    {
                        AtorId = 1,
                        FilmeId = 1
                    },
                    new()
                    {
                        AtorId = 3,
                        FilmeId = 1
                    },

                     new()
                    {
                        AtorId = 1,
                        FilmeId = 2
                    },
                     new()
                    {
                        AtorId = 4,
                        FilmeId = 2
                    },
                    new()
                    {
                        AtorId = 1,
                        FilmeId = 3
                    },
                    new()
                    {
                        AtorId = 2,
                        FilmeId = 3
                    },
                    new()
                    {
                        AtorId = 5,
                        FilmeId = 3
                    },
                    new()
                    {
                        AtorId = 2,
                        FilmeId = 4
                    },
                    new()
                    {
                        AtorId = 3,
                        FilmeId = 4
                    },
                    new()
                    {
                        AtorId = 4,
                        FilmeId = 4
                    },
                    new()
                    {
                        AtorId = 2,
                        FilmeId = 5
                    },
                    new()
                    {
                        AtorId = 3,
                        FilmeId = 5
                    },
                    new()
                    {
                        AtorId = 4,
                        FilmeId = 5
                    },
                    new()
                    {
                        AtorId = 5,
                        FilmeId = 5
                    },
                    new()
                    {
                        AtorId = 3,
                        FilmeId = 6
                    },
                    new()
                    {
                        AtorId = 4,
                        FilmeId = 6
                    },
                    new()
                    {
                        AtorId = 5,
                        FilmeId = 6
                    },
                });
            context.SaveChanges();
        }
    }
}