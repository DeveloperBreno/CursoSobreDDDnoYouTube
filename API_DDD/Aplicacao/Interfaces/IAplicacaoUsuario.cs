namespace Aplicacao.Interfaces;

public interface IAplicacaoUsuario
{
    Task<bool> AdicionarUsuario(string email, string senha, DateTime nascimento, string celular);

}
