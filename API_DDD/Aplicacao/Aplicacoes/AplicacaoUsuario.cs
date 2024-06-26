﻿using Aplicacao.Interfaces;
using Dominio.Interfaces;

namespace Aplicacao.Aplicacoes;

public class AplicacaoUsuario : IAplicacaoUsuario
{
    IUsuario _IUsuario;

    public AplicacaoUsuario(IUsuario IUsuario)
    {
        _IUsuario = IUsuario;
    }

    public async Task<bool> AdicionarUsuario(string email, string senha, DateTime nascimento, string celular)
    {
        return await _IUsuario.AdicionarUsuario(email, senha, nascimento, celular);
    }

    public async Task<bool> ExisteUsuario(string email, string senha)
    {
        return await _IUsuario.ExisteUsuario(email, senha);
    }

    public async Task<string> RetornaIdUsuario(string email)
    {
        return await _IUsuario.RetornaIdUsuario(email);
    }
}
