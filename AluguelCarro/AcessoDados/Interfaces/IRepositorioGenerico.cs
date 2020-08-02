using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Interfaces
{
    public interface IRepositorioGenerico<IEntity> where IEntity : class
    {
        IQueryable<IEntity> PegarTodos();
        Task<IEntity> PegarPeloId(int id);
        Task<IEntity> PegarPeloId(string id);
        Task Inserir(IEntity entity);
        Task Atualizar(IEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);
    }
}
