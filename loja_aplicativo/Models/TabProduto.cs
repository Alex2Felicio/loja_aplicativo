using System;
using System.Collections.Generic;

#nullable disable

namespace loja_aplicativo.Models
{
    public partial class TabProduto
    {
        public int CdProduto { get; set; }
        public string NmProduto { get; set; }
        public string NmCor { get; set; }
        public int? IdFornecedor { get; set; }
        public int? DsQuantidade { get; set; }
        public int? DsValor { get; set; }
        public int? DsMargem { get; set; }
        public int? DsValorVenda { get; set; }
        public string DsTamanho { get; set; }
        public DateTime? DsDataEntrada { get; set; }

        public virtual TabFornecedor IdFornecedorNavigation { get; set; }
    }
}
