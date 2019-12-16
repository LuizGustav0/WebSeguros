using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSeguros.Models;

namespace WebSeguros.Controllers
{
    public class CarrosController : Controller
    {
        private readonly WebSegurosContext _context;

        public CarrosController(WebSegurosContext context)
        {
            _context = context;
        }
        

        // GET: Carros/Create
        public IActionResult Create(int? id)
        {
        
            return View();
        }

        // POST: Carros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrabalhaVei,Garagem,TipoSeguro,Marca,Modelo,Ano,Placa,Cor,ValorVeiculo,ValorSeguro,IdCliente")] Carro carro)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(carro);
                await _context.SaveChangesAsync();
                //PARTE 2 - DESATIVADO
                return Redirect("https://automlsite.firebaseapp.com/?s=1");
            
            }

            return View();


        }

    




   
    }
}
