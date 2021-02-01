using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DDD.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.UrnaServices;

namespace ProjetoUrnaEletronica.Controllers
{
    public class CandidatosController : Controller
    {
        //private readonly ICandidatosRepository candidatosRepository;
        private readonly ICandidatosService candidatosService;
        
        public CandidatosController(ICandidatosService candidatos)
        {

            candidatosService = candidatos;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult IncluirCandidato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IncluirCandidato(Candidatos candidato)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                candidatosService.AdicionarCandidato(candidato);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return View("Error.cshtml");
            }
        }




    }
}
