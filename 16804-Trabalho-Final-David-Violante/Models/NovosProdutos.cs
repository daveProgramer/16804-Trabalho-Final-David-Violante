using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16804_Trabalho_Final_David_Violante.Models
{
    public class NovosProdutos
    {
        public DateTime DataProduto { get; internal set; }
        public int FornecedorFK { get; internal set; }
        public int NovosProdID { get; internal set; }
    }

    [Key]
    public int NovosProdID { get; set; }

    [Required]
    [StringLength(30)]
    public string DataProduto { get; set; }

    
}