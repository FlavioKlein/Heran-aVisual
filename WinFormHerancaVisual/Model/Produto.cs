using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormHerancaVisual.Model
{
    [Table("Produto")]
    public class Produto : CRUDBase
    {      
        [Required(ErrorMessage = "Digite a descrição do produto."), Column(Order = 3)]
        [StringLength(40, ErrorMessage = "O tamanho máximo são 40 caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Quantidade")]
        [Column(Order = 4)]
        public double Quantidade { get; set; }

        [Display(Name = "VlrProduto")]
        [Column(Order = 5)]
        public double VlrProduto{ get; set; }        
    }
}
