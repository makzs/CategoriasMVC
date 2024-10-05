using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CategoriasMVC.Models;

namespace CategoriasMVC.Services
{
    public class Autenticacao : IAutenticacao
    {
        private readonly IHttpClientFactory _clientFactory;
        private const string apiEndpoint = "/autoriza/login";
        private readonly JsonSerializerOptions _options;
        private TokenViewModel tokenUsuario;

        public Autenticacao(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
        }

        public async Task<TokenViewModel> AutenticaUsuario(UsuarioViewModel usuarioVM)
        {
            var client = _clientFactory.CreateClient("AutenticaApi");
            var usuario = JsonSerializer.Serialize(usuarioVM);

            StringContent content = new StringContent(usuario, Encoding.UTF8, "application/json");
            
            using (var response = await client.PostAsync(apiEndpoint, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStreamAsync();
                    tokenUsuario = await JsonSerializer
                        .DeserializeAsync<TokenViewModel>
                        (apiResponse, _options);
                }
                else
                {
                    return null;
                }
            }
            return tokenUsuario;
        }
    }
}