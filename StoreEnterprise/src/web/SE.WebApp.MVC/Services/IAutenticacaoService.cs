using System.Threading.Tasks;
using static SE.WebApp.MVC.Models.UsuarioViewModel;

namespace SE.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        Task<string> Login(UsuarioLogin usuarioLogin);
        Task<string> Registro(UsuarioRegistro usuarioRegistro);
    }
}