using Domain.Dto;
using Domain.Enumeradores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;
using System.Linq;

namespace Data.Provider
{
    internal class GerenciadorConfiguracao
    {
        private const string NomeArquivoConfig = "parametros.json";
        private readonly string _caminhoCompletoArquivo;

        public GerenciadorConfiguracao()
        {
            string diretorioBase = AppDomain.CurrentDomain.BaseDirectory;
            _caminhoCompletoArquivo = Path.Combine(diretorioBase, NomeArquivoConfig);
        }

        /// <summary>
        /// Obtém o primeiro parâmetro de configuração ativo do arquivo JSON.
        /// Se o arquivo não existir, cria um com dados de exemplo e retorna a primeira configuração ativa.
        /// </summary>
        /// <returns>O objeto ParametrosConfiguracao ativo ou null se nenhum for encontrado.</returns>
        public ParametrosConfiguracao ObterParametrosAtivos()
        {
            if (!File.Exists(_caminhoCompletoArquivo))
            {
                Console.WriteLine("Arquivo de configuração não encontrado. Criando um novo...");
                CriarArquivoConfiguracaoPadrao();
            }

            try
            {
                string jsonContent = File.ReadAllText(_caminhoCompletoArquivo);
                var listaParametros = JsonConvert.DeserializeObject<List<ParametrosConfiguracao>>(jsonContent);

                if (listaParametros == null || !listaParametros.Any())
                {
                    throw new Exception("O arquivo de configuração está vazio ou em um formato inválido.");
                }

                return listaParametros.FirstOrDefault(p => p.Ativo);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao ler ou processar o arquivo de configuração '{NomeArquivoConfig}'. Detalhes: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cria um arquivo parametros.json com uma coleção de configurações de exemplo.
        /// </summary>
        private void CriarArquivoConfiguracaoPadrao()
        {
            var listaPadrao = new List<ParametrosConfiguracao>
            {
                new ParametrosConfiguracao
                {
                    Ativo = true,
                    TipoBanco = eTipoBancoDados.SQLServer,
                    NomeAplicacao = "Meu App Principal",
                    StringConexao = "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=SEU_USUARIO;Password=SUA_SENHA;TrustServerCertificate=True;"
                },
                new ParametrosConfiguracao
                {
                    Ativo = false,
                    TipoBanco = eTipoBancoDados.SQLite,
                    NomeAplicacao = "Configuracao Alternativa SQLite",
                    StringConexao = "Data Source=C:\\Temp\\MeuBanco.db;Version=3;"
                }
            };

            string jsonString = JsonConvert.SerializeObject(listaPadrao, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(_caminhoCompletoArquivo, jsonString);
        }
    }
}
