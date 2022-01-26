using System;
using System.Collections.Generic;

#nullable disable

namespace loja_aplicativo.Models
{
    public partial class TabTipoFuncionario
    {
        public TabTipoFuncionario()
        {
            TabFuncionarios = new HashSet<TabFuncionario>();
        }

        public int IdTipoFuncionario { get; set; }
        public string DsTipoFuncionario { get; set; }

        public virtual ICollection<TabFuncionario> TabFuncionarios { get; set; }
    }
}
