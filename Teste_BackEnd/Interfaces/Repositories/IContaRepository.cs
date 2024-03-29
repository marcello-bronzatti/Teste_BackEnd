﻿using Teste_BackEnd.Models;

namespace Teste_BackEnd.Interfaces.Repository
{
    public interface IContaRepository
    {
        Task<List<Conta>> CadastrarContaAsync(Conta conta);
        Task<List<Conta>> GetAsync();
        Task<bool> VerificarSeNumeroFoiUtilizado(int num);
        Task<Conta> GetByUserAsync(string email, string senha);
        Task<string> ObterSaldo(string email);
        Task<Conta> GetByNumero(int numero);
        Task<Conta> GetByUserIdentity(string Id);
        Task SaveChangesAsync();
        Task RegistrarTransacao(int entrada, int saida, decimal valor);
        Task<List<Transacao>> GetExtratoAsync(int id);

    }
}
