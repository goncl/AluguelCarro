using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AluguelCarroTestes
{
    public class Carros
    {
        [Fact]
        public void Inserir()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(e => e.Inserir(It.IsAny<Carro>()));

            Carro carro = new Carro
            {
                CarroId = 1,
                Nome = "Abc",
                Marca = "Abc",
                Foto = "Abc",
                PrecoDiaria = 120
            };

            mock.Object.Inserir(carro);
            mock.Verify(c => c.Inserir(It.IsAny<Carro>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Atualizar()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(c => c.Atualizar(It.IsAny<Carro>()));

            Carro carro = new Carro
            {
                CarroId = 1,
                Nome = "Abc",
                Marca = "Abc",
                Foto = "Abc",
                PrecoDiaria = 120
            };

            mock.Object.Atualizar(carro);
            mock.Verify(c => c.Atualizar(It.IsAny<Carro>()), Times.Once);
        }

        [Fact]
        public void Excluir()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(c => c.Excluir(It.IsAny<int>()));
            mock.Object.Excluir(2);
            mock.Verify(c => c.Excluir(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void PegarPeloId()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(c => c.PegarPeloId(It.IsAny<int>()));
            mock.Object.PegarPeloId(1);
            mock.Object.PegarPeloId(2);
            mock.Object.PegarPeloId(3);
            mock.Object.PegarPeloId(4);
            mock.Verify(c => c.PegarPeloId(It.IsAny<int>()), Times.AtLeastOnce);
        }
    }
}
