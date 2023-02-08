using Api_MercadoLivre_NetCore.Models;

namespace Api_MercadoLivre_NetCore.Repository
{
    public interface IRepositoryCelular
    {
        Task<Products> FindAll();
    }
}
