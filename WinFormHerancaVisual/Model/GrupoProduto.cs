using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormHerancaVisual.Model
{
    [Table("GrupoProduto")]
    public class GrupoProduto : CRUDBase
    {
        [Required(ErrorMessage = "Digite o nome do grupo."), Column(Order = 3)]
        [StringLength(40, ErrorMessage = "O tamanho máximo são 40 caracteres.")]
        [Display(Name = "Nome grupo")]
        public string Nome { get; set; }
    }
}
