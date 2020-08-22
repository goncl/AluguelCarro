﻿using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Repositorios
{
    public class NivelAcessoRepositorio : RepositorioGenerico<NiveisAcesso>, INivelAcessoRepositorio
    {
        private readonly RoleManager<NiveisAcesso> _gerenciadorNiveisAcesso;
        private readonly Contexto _contexto;

        public NivelAcessoRepositorio(Contexto contexto, RoleManager<NiveisAcesso> gerenciadorNiveisAcesso) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorNiveisAcesso = gerenciadorNiveisAcesso;
        }

        public async Task<bool> NivelAcessoExiste(string nivelAcesso)
        {
            return await _gerenciadorNiveisAcesso.RoleExistsAsync(nivelAcesso);
        }

        public new async Task Atualizar(NiveisAcesso niveisAcesso)
        {
            var nv = await _contexto.NiveisAcessos.FindAsync(niveisAcesso.Id);
            nv.Name = niveisAcesso.Name;
            nv.NormalizedName = niveisAcesso.NormalizedName;
            nv.Descricao = niveisAcesso.Descricao;
            await _gerenciadorNiveisAcesso.UpdateAsync(nv);
        }
    }
}
