using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CategoriasMVC.Views.Categorias
{
    public class CriarNovaCategoria : PageModel
    {
        private readonly ILogger<CriarNovaCategoria> _logger;

        public CriarNovaCategoria(ILogger<CriarNovaCategoria> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}