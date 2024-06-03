using Dominio.Interfaces.Genericos;
using Endidades.Entidades;
using Enditades.Notificacoes;
using System.Linq.Expressions;

namespace Dominio.Interfaces;

public interface INoticia : IGenericos<Noticia>
{
    Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia, bool>> exNoticia);



}
