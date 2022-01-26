using System;
using System.Collections.Generic;

#nullable disable

namespace loja_aplicativo.Models
{
    public partial class TabFornecedor
    {
        public TabFornecedor()
        {
            TabProdutos = new HashSet<TabProduto>();
        }

        public int CdFornecedor { get; set; }
        public string NmFornecedor { get; set; }
        public string NrCnpj { get; set; }
        public string NmResponsavel { get; set; }
        public string DsRamo { get; set; }
        public string DsEmailContato { get; set; }
        public string NrTelefoneEmpresa { get; set; }
        public string NrRamal { get; set; }

        public virtual ICollection<TabProduto> TabProdutos { get; set; }
    }
}
