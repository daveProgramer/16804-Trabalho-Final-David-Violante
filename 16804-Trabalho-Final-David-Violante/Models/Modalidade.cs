using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16804_Trabalho_Final_David_Violante.Models
{
    public class Modalidade
    {
        public int EquipamentoFK { get; internal set; }
        public int ModaID { get; internal set; }
        public string Nome { get; internal set; }
    }

    [Key]
    public int ModaID { get; set; }

    [Required]
    [StringLength(30)]
    public string DataProduto { get; set; }

    [Required]
    [StringLength(30)]
    public string Equipamento { get; set; }
    

    // **************************
    // criar a chave forasteira
    public Modalidade Moda { get; set; }

    // cria um atributo para funcionar como FK, na BD
    // e relaciona-o com o atributo anterior
    [ForeignKey("Equipamento")]
    public int ModalidadeFK { get; set; }

    
}
