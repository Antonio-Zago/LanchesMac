using LanchesMac.Repositories;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository) //Como IlancheRepository e IcategoriaRepository estão registrados como serviços, na chamada do controlador, dará uma instancia de LancheRepository e CategoriaRepository
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List()
        {
            /*var lanches = _lancheRepository.Lanches;
            return View(lanches);*/

            var lanchesListViewModel = new LancheListViewModel();

            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "";
            return View(lanchesListViewModel);
        }
    }
}
