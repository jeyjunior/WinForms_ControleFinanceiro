﻿using Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Obter(int id);
        IEnumerable<TEntity> ObterLista(string condition = "", object parameters = null);
        int Adicionar(TEntity entity);
        int Atualizar(TEntity entity);
        int Deletar(object id);
        bool CriarTabela(string query);
        int ExecutarQuery(string query);
    }
}
