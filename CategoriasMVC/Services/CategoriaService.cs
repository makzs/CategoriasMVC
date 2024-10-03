using CategoriasMVC.Models;
using System.Text.Json;

namespace CategoriasMVC.Services
{
    public class CategoriaService : ICategoriaService
    {
        private const string apiEndpoint = "/api/1/categorias";
        private readonly JsonSerializerOptions _options;
        private readonly IHttpClientFactory _clientFactory;

        private CategoriaViewModel categoriaVM;
        private IEnumerable<CategoriaViewModel> categoriasVM;

        public CategoriaService(IHttpClientFactory clientFactory)
        {
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _clientFactory = clientFactory;
        }

        public async Task<bool> AtualizaCategoria(int id, CategoriaViewModel categoriaVM)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaViewModel> CriaCategoria(CategoriaViewModel categoriaVM)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletaCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaViewModel> GetCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoriaViewModel>> GetCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
