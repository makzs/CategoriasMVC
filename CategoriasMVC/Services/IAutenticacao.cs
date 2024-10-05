using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CategoriasMVC.Models;

namespace CategoriasMVC.Services
{
    public interface IAutenticacao
    {
        Task<TokenViewModel> AutenticaUsuario(UsuarioViewModel usuarioVM);
    }
}