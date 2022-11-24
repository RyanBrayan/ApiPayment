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
            
            var vendedor = _context.Vendedors.Find(vendaDto.IdVendedor);

            if(vendaDto.IdVendedor == null) throw new ArgumentNullException("Campo IdVendedor não podem ser nulo.");
            if(vendedor == null) return NotFound("Vendedor não encontrado!");
            
            
            var venda = new Venda();
            
            venda.VendedorId = vendaDto.IdVendedor;
            venda.ProdutosDto = new List<VendaProduto>();
            foreach (var item in vendaDto.VendaProdutos)
            {
                if(item.ProdutoId == null) throw new ArgumentNullException("Campo IdProduto não podem ser nulo.");
                var produto = _context.Produtos.Find(item.ProdutoId);
                if(produto == null) return NotFound("Produto não encontrado!");


                VendaProduto vendaProduto = new VendaProduto();
                vendaProduto.ProdutoId = item.ProdutoId;
                vendaProduto.Quantidade = item.Quantidade;
                venda.Adicionar(vendaProduto);
            }

            _context.Add(venda); 
            _context.SaveChanges();
            return Ok(venda);
        }


        [HttpPut("Atualizar_Status{id}")]
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


        [HttpGet("Buscar_Por{id}")]
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