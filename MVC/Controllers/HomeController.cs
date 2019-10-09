using AutoMapper;
using DTO.DTOLibary;
using Entity.Domain;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private IMapper _mapper;
        public HomeController(IMapper mapper)
        {
            this._mapper = mapper;
        }
        public IActionResult Index()
        {
           
            var customer = new Customer()
            {
                id = 1,
                firstName = "Pasindu",
                lastName = "Umayanga",
                isActive = true
            };
            CustomerDTO customerDTO = _mapper.Map<CustomerDTO>(customer);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
