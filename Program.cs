using System.Text.Json;
using API02;
using API02.Models;

HttpClient client = new HttpClient();

try
{
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta);

    FilmesFavoritos ListaDeFilmesFavoritosAurelio = new FilmesFavoritos("Aurélio");
    ListaDeFilmesFavoritosAurelio.CadastrarFilme(filmes[1]);
    ListaDeFilmesFavoritosAurelio.CadastrarFilme(filmes[3]);
    ListaDeFilmesFavoritosAurelio.CadastrarFilme(filmes[7]);

    ListaDeFilmesFavoritosAurelio.GerarArquivoDeFilmes();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorrreu um erro: {ex}");
}