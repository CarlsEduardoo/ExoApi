//Controle de API
using Exo.WebApi.Context;
using Exo.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using Exo.WebApi.Repositories;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public  ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository; 
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }
    }
}