using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using AppService;
using Microsoft.AspNetCore.Mvc;
using Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HW17_ParnianRafie_m91.Controllers
{
    public class heController : Controller
    {

        private readonly Repository _repository;


        public heController(Repository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

