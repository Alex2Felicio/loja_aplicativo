using System;
using System.Collections.Generic;

#nullable disable

namespace loja_aplicativo.Models
{
    public partial class TabFuncionario
    {
        public int CdFuncionario { get; set; }
        public string NmFuncionario { get; set; }
        public string NrRg { get; set; }
        public DateTime? DsDataNascimento { get; set; }
        public string DsEmail { get; set; }
        public string NrTelefone { get; set; }
        public int? IdTipoFuncionario { get; set; }

        public virtual TabTipoFuncionario IdTipoFuncionarioNavigation { get; set; }

      
    }
}
