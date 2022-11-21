using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projectFinal.Entities;

namespace projectFinal.Context
{
    public class EccomerceContext : DbContext
    {
        public EccomerceContext(DbContextOptions<EccomerceContext> options) : base(options)
        {

        }

        public DbSet<Vendedor> Vendedors{get;set;}
        public DbSet<Venda> Vendas{get;set;}
        public DbSet<Produto> Produtos {get;set;}

        

}
}