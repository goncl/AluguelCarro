using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Repositorios
{
    public class AluguelRepositorio : RepositorioGenerico<Aluguel>, IAluguelRepositorio
    {
        private readonly Contexto _contexto;

        public AluguelRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> VerificarReserva(string usuarioId, int carroId, string dataInicio, string dataFim)
        {
            return await _contexto.Alugueis.AnyAsync(a => a.UsuarioId == usuarioId && a.CarroId == carroId && a.Inicio == dataInicio && a.Fim == dataFim);
        }
    }
}
