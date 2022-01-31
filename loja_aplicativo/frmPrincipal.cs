using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_aplicativo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //ANIMAÇÃO PAINEL
        private void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            if (pnlSubCadastro.Height == 0)
            {
                pnlSubCadastro.Height = 271;
                pnlSubPesquisar.Height = 0;
                pnlSubProduto.Height = 0;
                imgDireita.Visible = false;
                imgEsquerda.Visible = true;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
            else if (pnlSubProduto.Height == 55)
            {
                pnlSubProduto.Height = 0;
                pnlSubCadastro.Height = 271;
                imgDireita.Visible = false;
                imgEsquerda.Visible = true;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
            else if (pnlSubPesquisar.Height == 271)
            {
                pnlSubPesquisar.Height = 0;
                pnlSubCadastro.Height = 271;
                imgDireita.Visible = false;
                imgEsquerda.Visible = true;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
            else
            {
                pnlSubCadastro.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }

        }
        //ANIMAÇÃO PAINEL
        private void btnMenuPesquisar_Click(object sender, EventArgs e)
        {

            if (pnlSubPesquisar.Height == 0)
            {
                pnlSubCadastro.Height = 0;
                pnlSubPesquisar.Height = 271;
                pnlSubProduto.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = false;
                imgEsquerda2.Visible = true;
            }
            else if (pnlSubProduto.Height == 55)
            {
                pnlSubPesquisar.Height = 271;
                pnlSubProduto.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = false;
                imgEsquerda2.Visible = true;
            }
            else if (pnlSubCadastro.Height == 271)
            {
                pnlSubCadastro.Height = 0;
                pnlSubPesquisar.Height = 271;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = false;
                imgEsquerda2.Visible = true;
            }
            else
            {
                pnlSubPesquisar.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
        }
        //ANIMAÇÃO PAINEL
        private void btnMenuProduto_Click(object sender, EventArgs e)
        {
            if (pnlSubProduto.Height == 0)
            {
                pnlSubCadastro.Height = 0;
                pnlSubPesquisar.Height = 0;
                pnlSubProduto.Height = 55;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = false;
                imgEsquerda1.Visible = true;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;

            }
            else if (pnlSubProduto.Height == 0)
            {
                pnlSubProduto.Height = 55;
                pnlSubCadastro.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = false;
                imgEsquerda1.Visible = true;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
            else if (pnlSubPesquisar.Height == 271)
            {
                pnlSubPesquisar.Height = 0;
                pnlSubProduto.Height = 55;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = false;
                imgEsquerda1.Visible = true;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
            else
            {
                pnlSubProduto.Height = 0;
                imgDireita.Visible = true;
                imgEsquerda.Visible = false;
                imgDireita1.Visible = true;
                imgEsquerda1.Visible = false;
                imgDireita2.Visible = true;
                imgEsquerda2.Visible = false;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text= DateTime.Now.ToString("HH:mm");
        }
    }
}
