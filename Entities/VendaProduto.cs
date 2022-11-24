
using System.ComponentModel.DataAnnotations;


namespace projectFinal.Entities

{
    public class VendaProduto
    {
        [Key]
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        
    }
}