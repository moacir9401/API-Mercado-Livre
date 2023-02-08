using Api_MercadoLivre_NetCore.Models;
using Api_MercadoLivre_NetCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api_MercadoLivre_NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IRepositoryCelular _repository;

        public ProductController(IRepositoryCelular repository)
        {
            _repository= repository;
        }

        [HttpGet(Name = "testeProduct")]
        public async Task<Products> Teste()
        {
            var products = await _repository.FindAll();

            return products;
        }
    }
}
