using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using projectFinal.Entities;

namespace projectFinal.DTO
{
    public class ProdutoDto
    {
        [Key]
        public int IdProduct { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        
    }
}