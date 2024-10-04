using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CategoriasMVC.Views.Categorias
{
    public class DeletarCategoria : PageModel
    {
        private readonly ILogger<DeletarCategoria> _logger;

        public DeletarCategoria(ILogger<DeletarCategoria> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}