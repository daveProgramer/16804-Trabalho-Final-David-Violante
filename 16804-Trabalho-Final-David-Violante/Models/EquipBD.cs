using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16804_Trabalho_Final_David_Violante.Models
{
    public class EquipBD : DbContext
    {
            // descrever as 'tabelas' que estão na BD
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<Modalidade> Modalidade { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<NovosProdutos> NovosProdutos { get; set; }

       
    }
}