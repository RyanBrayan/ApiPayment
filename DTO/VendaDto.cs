using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectFinal.Entities;
using System.ComponentModel.DataAnnotations;


namespace projectFinal.DTO
{
    public class VendaDto
    {
        
        public int IdVendedor { get; set; }
        public List<ProdutoDto> ProdutoDto{ get; set; }
    }
}