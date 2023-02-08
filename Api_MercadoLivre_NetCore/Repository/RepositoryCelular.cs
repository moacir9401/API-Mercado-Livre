using Api_MercadoLivre_NetCore.Models;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Api_MercadoLivre_NetCore.Repository
{
    public class RepositoryCelular: IRepositoryCelular
    {

        public async Task<Products> FindAll()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://api.mercadolibre.com/sites/MLB/search?q=celular/");

            var json = await result.Content.ReadAsStringAsync();

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.WriteAsString
            };
              
            var product = JsonSerializer.Deserialize<Products>(json);
             
            return product;
        }
    }
}
