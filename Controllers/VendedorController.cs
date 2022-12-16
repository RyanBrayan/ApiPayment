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
            vendedorBanco.NomeVendedor = vendedor.NomeVendedor;
            vendedorBanco.Telefone = vendedor.Telefone;

            _context.Vendedors.Update(vendedorBanco);
            _context.SaveChanges();

            return Ok(vendedorBanco);
        }

        
        [HttpGet("ListarVendedores")]
        public IActionResult ListarVendedor(){
            var vendedors = _context.Vendedors;
            return Ok(vendedors);
        }

        [HttpGet("ListarQuantidadeVendasDoVendedor{id}")]
        public IActionResult ListarQuantidadeVendasDoVendedor(int id)
        {
            var quantidadeVendas = (from vp in _context.VendaProdutos
                                    join vd in _context.Vendas
                                    on vp.VendaId equals vd.VendaId 
                                    join ve in _context.Vendedors 
                                    on vd.VendedorId equals ve.VendedorId 
                                    select new {ve.NomeVendedor, vd.VendedorId});
            int totVendas = 0;
            string nome = "";
            foreach (var item in quantidadeVendas)
            {
                if(item.VendedorId == id){
                    nome = item.NomeVendedor;
                    totVendas += 1;
                }
            }
            return Ok("O vendedor/a: "+nome +" Tem " + totVendas + " Vendas");

        }
    }
}