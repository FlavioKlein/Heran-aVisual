using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WinFormHerancaVisual.Enums;

namespace WinFormHerancaVisual.Model
{
    [Table("Cliente")]
    public class Cliente : CRUDBase
    {
        [Required(ErrorMessage = "Digite o nome do cliente."), Column(Order = 3)]
        [StringLength(40, ErrorMessage = "O tamanho máximo são 40 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Fone")]
        [Column(Order = 4)]
        public string Fone { get; set; }

        [Display(Name = "Sexo")]
        [Column(Order = 5)]
        public Sexo Sexo { get; set; }
    }
}
