using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectFinal.Context;
using projectFinal.DTO;
using projectFinal.Entities;


namespace projectFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly EccomerceContext _context;


        public VendaController(EccomerceContext context){
            _context = context;
        }


        [HttpPost]
        public IActionResult Criar(VendaDto vendaDto){
            
            var dadosVendedor = _context.Vendedors.Find(vendaDto.idVendedor);
            var dadosProduto = _context.Produtos.Find(vendaDto.idProduto);
            
            Venda venda = new Venda();

            if(dadosVendedor == null || dadosProduto == null) throw new ArgumentNullException("Campos não podem ser nulos.");
            
            venda.IdVendedor = vendaDto.idVendedor;
            venda.idProduto = vendaDto.idProduto;
            venda.NomeVendedor = dadosVendedor.Nome;
            venda.NomeProduto = dadosProduto.NomeProduto;

            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }


        [HttpPut("{id}")]
        public IActionResult Editar(int id, Status status){
            var vendaBanco = _context.Vendas.Find(id);

            if(vendaBanco == null) 
                return NotFound("Venda não encontrada");

            if (vendaBanco.Status == Status.AguardandoPagamento){
                if(status == Status.PagamentoAprovado){
                    vendaBanco.Status = status;
                }else if(status == Status.Cancelada) vendaBanco.Status = status;
                else return NotFound("Deu ruim meno, corre e tiro");
            }

            if (vendaBanco.Status ==  Status.PagamentoAprovado){
                if(status == Status.EnviadoParaTransportadora){
                    vendaBanco.Status = status;
                }else if(status == Status.Cancelada) vendaBanco.Status = status;
                else return NotFound("Deu ruim meno, corre e tiro");
            }

            if (vendaBanco.Status == Status.EnviadoParaTransportadora){
                vendaBanco.Status = Status.Entregue;
            }

            if (vendaBanco.Status == Status.Cancelada){
                 throw new Exception($"A venda está cancelada, portanto não pode avançar");;
            }

            // vendaBanco.Status = status;

            _context.Vendas.Update(vendaBanco);
            _context.SaveChanges();

            return Ok(vendaBanco);
        }


        [HttpGet("{id}")]
        public IActionResult BuscarPorID(int id){
            var vendaBanco = _context.Vendas.Find(id);

            if(vendaBanco == null) 
                return NotFound();

            return Ok(vendaBanco);
        }


        [HttpGet("ListarVendas")]
        public IActionResult ListarVenda(){
            var vendas = _context.Vendas;
            return Ok(vendas);

        }


        class Excecao : Exception
        {
            public Excecao(string mensagem) : base(mensagem)
            {
                // Construtor que chama o construtor da classe genérica
            }
        }
    }
}