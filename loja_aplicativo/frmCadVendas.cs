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
    public partial class frmCadVendas : Form
    {
        public frmCadVendas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                imgDinheiro.Visible = true;
                imgCartao.Visible = false;
                imgDebito.Visible = false;
                imgPix.Visible = false;
            } else if (comboBox1.SelectedIndex == 1)
            {
                imgDinheiro.Visible = false;
                imgCartao.Visible = true;
                imgDebito.Visible = false;
                imgPix.Visible = false;
            }else if (comboBox1.SelectedIndex == 2)
            {
                imgDinheiro.Visible = false;
                imgCartao.Visible = false;
                imgDebito.Visible = true;
                imgPix.Visible = false;
            }else if(comboBox1.SelectedIndex == 3)
            {
                imgDinheiro.Visible = false;
                imgCartao.Visible = false;
                imgDebito.Visible = false;
                imgPix.Visible = true;
            }
            else
            {
                imgDinheiro.Visible = false;
                imgCartao.Visible = false;
                imgDebito.Visible = false;
                imgPix.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
