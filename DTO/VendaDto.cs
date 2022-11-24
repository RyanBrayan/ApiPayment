using projectFinal.Entities;




namespace projectFinal.DTO
{
    public class VendaDto
    {

        public int IdVendedor { get; set; }
        public List<VendaProduto> VendaProdutos { get; set; }
    }
}