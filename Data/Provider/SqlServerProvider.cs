using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Domain.Dto;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;

namespace Data.Provider
{
    internal static class SqlServerProvider
    {
        private static readonly GerenciadorConfiguracao _gerenciadorConfig = new GerenciadorConfiguracao();

        /// <summary>
        /// Cria uma conexão com o banco de dados SQL Server com base na configuração ativa
        /// encontrada no arquivo 'parametros.json'.
        /// </summary>
        /// <returns>Uma instância de IDbConnection pronta para ser aberta.</returns>
        /// <exception cref="InvalidOperationException">Lançada se nenhuma configuração ativa for encontrada.</exception>
        public static IDbConnection CriarConexao() 
        {
            ParametrosConfiguracao parametros = _gerenciadorConfig.ObterParametrosAtivos();

            if (parametros == null)
            {
                throw new InvalidOperationException("Nenhuma configuração de banco de dados ativa foi encontrada no arquivo 'parametros.json'.");
            }

            if (parametros.TipoBanco != Domain.Enumeradores.TipoBancoDados.SQLServer)
            {
                throw new InvalidOperationException("A configuração ativa encontrada não é para o tipo de banco de dados SQL Server.");
            }

            if (string.IsNullOrWhiteSpace(parametros.StringConexao))
            {
                throw new InvalidOperationException("A string de conexão na configuração ativa não pode ser vazia.");
            }

            return new SqlConnection(parametros.StringConexao);
        }
    }
}
