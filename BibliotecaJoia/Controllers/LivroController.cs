﻿using BibliotecaJoia.Models.Contracts.Services;
using BibliotecaJoia.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaJoia.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() 
        {
            try
            {
            var livros = _livroService.Listar();
                return View(livros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Recurso de Segurança (Ataque CSRF)
        public IActionResult Create([Bind("Nome, Autor, Editora")]LivroDto livro)
        {
            try
            {
                _livroService.Cadastrar(livro);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
