using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormHerancaVisual.Model
{
    public class CRUDBase
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Data Cadastro")]
        [Column(Order = 1)]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data Alteração")]
        [Column(Order = 2)]
        public DateTime DataAlteracao { get; set; }
    }
}
