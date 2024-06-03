using Dominio.Interfaces;
using Endidades.Entidades;
using Insfraestrutura.Configuracoes;
using Insfraestrutura.Repositorio.Genericos;
using Microsoft.EntityFrameworkCore;

namespace Insfraestrutura.Repositorio;

public class RepositorioUsuario : RepositorioGenerico<ApplicationUser>, IUsuario
{
    private readonly Contexto _context;
    public RepositorioUsuario()
    {
        _context = new Contexto(new DbContextOptionsBuilder<Contexto>().Options);
    }

    public async Task<bool> AdicionarUsuario(string email, string senha, DateTime nascimento, string celular)
    {

        try
        {
            var usuario = new ApplicationUser()
            {
                Celular = celular,
                PasswordHash = senha,
                DataDeNascimento = nascimento,
                Email = email
            };

            await _context.AddAsync(usuario);
            await _context.SaveChangesAsync();

        }
        catch (Exception e)
        {
            return false;
        }

        return true;

    }
}
