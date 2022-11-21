using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace projectFinal.Entities
{
    public class Vendedor
    {
        [Key]
        public int IdVendedor { get; set; }
        public string Cpf{ get; set; }
        public string Nome { get; set; }
        public string Telefone{get; set;}
        
    }
}