using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace projectFinal.Entities
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco{ get; set; }

    }
}