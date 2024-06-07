using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace API02.Models
{
    public class FilmesFavoritos
    {

        public string Nome { get; set; }
        public List<Filme> ListaFilmes { get; }
        public FilmesFavoritos(string nome)
        {
            Nome = nome;
            ListaFilmes = new List<Filme>();
        }

        public void CadastrarFilme(Filme filme)
        {
            ListaFilmes.Add(filme);
        }

        public void ExibirFilmesFavoritos()
        {
            Console.WriteLine($"Os filmes favoritos de {Nome} são:");
            foreach (Filme filme in ListaFilmes)
            {
                Console.WriteLine($"- {filme.Titulo}");
            }
        }

        public void GerarArquivoDeFilmes()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                filmes = ListaFilmes
            });

            string nomeArquivo = $"filmes - {Nome}";
            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine("Arquivo criado com sucesso.");
        }
    }
}