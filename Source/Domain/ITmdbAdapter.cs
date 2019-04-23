using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// TODO: REMOVER A PASTA "DOMAIN" E TODOS OS SEUS ARQUIVOS
/// Classe mockada apenas para referência do projeto.
/// </summary>
namespace ApiAdapter.Template.Domain
{
    public interface ITmdbAdapter
    {
        Task<IEnumerable<Filme>> GetFilmesAsync(Pesquisa pesquisa, string idioma);
    }
}
