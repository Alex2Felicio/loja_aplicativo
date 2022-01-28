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
    public partial class frmPesquisaFuncionario : Form
    {
        public frmPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            using (var context = new DB_LOJAContext())
            {
                
                

                    if (txbPesquisa.Text == " ")
                    {


                    DB_LOJAContext dc = new DB_LOJAContext();

                    var stu = from TabFuncionario in dc.TabFuncionarios
                              select TabFuncionario;
                    dataGridView1.DataSource = stu.ToList();

                }
                 else if (rbCodigo.Checked==true) {
                    var nome = context.TabFuncionarios.Where(a => a.CdFuncionario == Convert.ToInt32(txbPesquisa.Text));
                    dataGridView1.DataSource = nome.ToList();
                }
                else if (rbRG.Checked == true)
                {
                    var nome = context.TabFuncionarios.Where(a => a.NrRg.Contains( txbPesquisa.Text));
                    dataGridView1.DataSource = nome.ToList();
                }
                else  {
                        
                    var nome = context.TabFuncionarios.Where(a => a.NmFuncionario.Contains(txbPesquisa.Text));
                    dataGridView1.DataSource = nome.ToList();




                }

            }

            /*  DB_LOJAContext dc = new DB_LOJAContext();

              var stu = from TabFuncionario in dc.TabFuncionarios
                        select TabFuncionario;
              dataGridView1.DataSource = stu.ToList();
            */

        }
    }
}
