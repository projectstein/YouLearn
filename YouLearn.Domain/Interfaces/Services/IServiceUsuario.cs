using YouLearn.Domain.Arguments.Usuario;

namespace YouLearn.Domain.Interfaces.Services
{
  public interface IServiceUsuario
  {
    AdicionarUsuarioResponse adicionarUsuario(AdicionarUsuarioRequest request);
    AutenticarUsuarioResponse autenticarUsuario(AutenticarUsuarioRequest request);

   
  }
}
