using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo(string nome, int numTimes = 1)
        {
            // Trabalha com HTML
            // var retorno = HtmlEncoder.Default.Encode($"Olá {nome}, ID: {ID}");
            ViewData["Message"] = $"Olá Lucas";
            ViewData["NumTimes"] = 10;
            return View();
            // corrige acentuacao com do HTML com UTF-8
            // retorno = System.Net.WebUtility.HtmlDecode(retorno);
            // return retorno;
        }

        public string Oi()
        {
            return "Oi!";
        }
    }
}