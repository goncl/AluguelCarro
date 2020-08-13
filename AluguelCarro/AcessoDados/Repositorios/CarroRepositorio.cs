using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Repositorios
{
    public class CarroRepositorio : RepositorioGenerico<Carro>, ICarroRepositorio
    {
        public CarroRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
