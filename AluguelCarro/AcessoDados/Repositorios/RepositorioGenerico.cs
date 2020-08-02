using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Repositorios
{
    public class RepositorioGenerico<IEntity> : IRepositorioGenerico<IEntity> where IEntity : class
    {
        private readonly Contexto _contexto;

        public RepositorioGenerico (Contexto contexto) 
        {
            _contexto = contexto;
        }

        public async Task Atualizar(IEntity entity)
        {
            try
            {
                _contexto.Set<IEntity>().Update(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _contexto.Set<IEntity>().Remove(entity);
                await _contexto.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(string id)
        {
            try
            {
                var entity = await PegarPeloId(id);
                _contexto.Set<IEntity>().Remove(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Inserir(IEntity entity)
        {
            try
            {
                await _contexto.Set<IEntity>().AddAsync(entity);
                await _contexto.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEntity> PegarPeloId(int id)
        {
            try
            {
                return await _contexto.Set<IEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEntity> PegarPeloId(string id)
        {
            try
            {
                return await _contexto.Set<IEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<IEntity> PegarTodos()
        {
            try
            {
                return _contexto.Set<IEntity>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
