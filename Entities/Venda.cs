using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using projectFinal.DTO;

namespace projectFinal.Entities
{
    public class Venda
    {
        public Venda(){
            this.Status = Status.AguardandoPagamento;
            this.DataVenda = DateTime.Now;
        }

        [Key]
        public int IdVenda { get; set; }
        [ForeignKey("Vendedor")]
        public int IdVendedor { get; set; }
        [ForeignKey("Produto")]
         public string NomeVendedor{ get; set; }
        public int idProduto { get; set; }
        [ForeignKey("Status")]
        public string NomeProduto{ get; set; }
        public Status Status{ get; set; }
        public DateTime DataVenda { get; set; }
    }
    
}