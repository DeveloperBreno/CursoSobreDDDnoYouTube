using System.ComponentModel.DataAnnotations;

namespace Dominio.Interfaces;

public interface IUsuario
{
    Task<bool> AdicionarUsuario(string email, string senha, DateTime nascimento, string celular);
}
