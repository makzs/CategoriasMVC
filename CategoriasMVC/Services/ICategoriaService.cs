﻿using CategoriasMVC.Models;

namespace CategoriasMVC.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaViewModel>> GetCategorias();
        Task<CategoriaViewModel> GetCategoriaPorId(int id);
        Task<CategoriaViewModel> CriaCategoria(CategoriaViewModel categoriaVM);
        Task<bool> AtualizaCategoria(int id, CategoriaViewModel categoriaVM);
        Task<bool> DeletaCategoria(int id);

    }
}
