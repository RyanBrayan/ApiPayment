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
    public class ProdutoController : ControllerBase
    {
        private readonly EccomerceContext _context;
        public ProdutoController(EccomerceContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(Produto produto){
            _context.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }





    }
}