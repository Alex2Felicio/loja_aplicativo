using loja_aplicativo.Models;
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
    public partial class frmCadFuncionario : Form
    {

        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            string email;
            string rg;
            string tel;


            if (TxbCadEmailFun.Text == null)
            {
                email = null;
            }
            else
            {
                email = TxbCadEmailFun.Text;
            }

            while (txbCadRGFun.Text == null)
            {
                string message = "Favor preencher o campo: RG";
                string title = "BELSI - Loja";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            rg = txbCadRGFun.Text;

            if (txbCadTelFun.Text == null)
            {
                tel = null;
            }
            else
            {
                tel = txbCadTelFun.Text;
            }

                using (var context = new DB_LOJAContext())
                {



                    var std = new TabFuncionario()
                    {


                        NmFuncionario = txbCadNome.Text,
                        NrRg = rg,
                        DsEmail = email,
                        NrTelefone = tel,
                        DsDataNascimento = DateTime.Parse(mtbCadNascimento.Text),
                        IdTipoFuncionario = comboBox1.SelectedIndex + 1


                    };
                    context.TabFuncionarios.Add(std);

                    // or
                    // context.Add<Student>(std);

                    context.SaveChanges();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message,"Erro");
            }
            finally
            {
                MessageBox.Show("teste de finally");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            DB_LOJAContext dc = new DB_LOJAContext();
            var stu = from TabTipoFuncionario in dc.TabTipoFuncionarios
                      select TabTipoFuncionario;
            comboBox1.DataSource = dc.TabTipoFuncionarios.ToList();
            comboBox1.DisplayMember = "DsTipoFuncionario";
            

        }

        private void txbCadNome_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
