using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectFinal.Context;
using projectFinal.Entities;

namespace projectFinal.Controllers
{
[ApiController]
[Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly EccomerceContext _context;
        public VendedorController(EccomerceContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(Vendedor vendedor){
            _context.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Vendedor vendedor){
            var vendedorBanco = _context.Vendedors.Find(id);
            if(vendedorBanco == null) 
                return NotFound();

            vendedorBanco.Cpf = vendedor.Cpf;
            vendedorBanco.Nome = vendedor.Nome;
            vendedorBanco.Telefone = vendedor.Telefone;

            _context.Vendedors.Update(vendedorBanco);
            _context.SaveChanges();

            return Ok(vendedorBanco);
        }


    }
}