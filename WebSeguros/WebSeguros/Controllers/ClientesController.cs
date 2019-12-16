using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using WebSeguros.Models;

namespace WebSeguros.Controllers
{
    public class ClientesController : Controller
    {
        private readonly WebSegurosContext _context;

        public ClientesController(WebSegurosContext context)
        {
            _context = context;
        }

      

        // GET: Clientes/Create
        public IActionResult Create()
        {
           
           return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Cpf,Sexo,EstadoCivil,Celular,Email,Cep,Logradouro,Numero,Bairro,Uf")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                var id = cliente.Id;

                //Calcula idade
                var nascimento = cliente.DataNascimento;
                DateTime dob = Convert.ToDateTime(nascimento);         
                int idade = CalculaIdade(dob);

                //Sexo
                var sexo = cliente.Sexo;

                //Estado Civil
                var EstadoCivil = cliente.EstadoCivil;

                return RedirectToAction("Create", "Carros", new { id = id, c=id, i=idade, s=sexo,e=EstadoCivil });
            }
            return View(cliente);
        }

    

          private static int CalculaIdade(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
