using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using projectFinal.DTO;
using projectFinal.Entities;

namespace projectFinal.Entities
{
    public class Venda
    {
        public Venda(){
            this.Status = Status.AguardandoPagamento;
            this.DataVenda = DateTime.Now;
        }
        public Venda(Vendedor vendedorId){

        }

        [Key]
        public int VendaId { get; set; }
        [ForeignKey("Vendedor")]
        public int VendedorId { get; set; }
        [ForeignKey("VendaId")]
        public List<VendaProduto> VendaProdutos { get; set; }

        [ForeignKey("Status")]
        public Status Status{ get; set; }
        public DateTime DataVenda { get; set; }


        public void Adicionar(VendaProduto produto)
        {
            VendaProdutos.Add(produto);
        }
    }

    
}