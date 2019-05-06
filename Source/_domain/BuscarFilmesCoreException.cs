using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// TODO: REMOVER A PASTA "DOMAIN" E TODOS OS SEUS ARQUIVOS
/// Classe mockada apenas para referência do projeto.
/// </summary>
namespace ApiAdapter.Template.Domain
{
    public class BuscarFilmesCoreException : Exception
    {
        public BuscarFilmesCoreException(BuscarFilmesCoreError buscarFilmesCoreError)
        {

        }
    }

    public class BuscarFilmesCoreError
    {
        public static BuscarFilmesCoreError LimiteDeRequisicoesAtingido =>
           new BuscarFilmesCoreError("LimiteDeRequisicoesAtingido", "O limite de requisições ao provedor de filmes foi atingido, tente novamente mais tarde.");

        protected BuscarFilmesCoreError(string key, string message)
        {
        }
    }
}
