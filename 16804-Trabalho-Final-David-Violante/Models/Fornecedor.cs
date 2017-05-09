using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16804_Trabalho_Final_David_Violante.Models
{
    public class Fornecedor
    {
        public int FornecID { get; internal set; }
    }

    [Key]
    public int ModaID { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }



    // **************************
    // criar a chave forasteira
    // relaciona o objeto ANIMAL com um objeto DONO
    public Fornecedor Fornec { get; set; }

 

}