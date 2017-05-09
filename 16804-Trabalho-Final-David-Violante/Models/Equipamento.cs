using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16804_Trabalho_Final_David_Violante.Models
{
    public class Equipamento
    {
        [Key]
        public int EquipamentoID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        // **************************
        // criar a chave forasteira
        // relaciona o objeto ANIMAL com um objeto DONO
        public Equipamento Dono { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Equipamento")]
        public int EquipamentoFK { get; set; }
        

      

    }
}