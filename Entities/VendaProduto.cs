
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectFinal.Entities

{
    public class VendaProduto
    {
        [Key]
        public int Id { get; set; }
        public int VendaId { get; set; }
        public Venda venda { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        
    }
}