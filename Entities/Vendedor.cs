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
        public int VendedorId { get; set; }
        public string Cpf{ get; set; }
        public string NomeVendedor { get; set; }
        public string Telefone{get; set;}
        
    }
}