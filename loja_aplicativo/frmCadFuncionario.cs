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
            
                using (var context = new DB_LOJAContext())
            {
                

                
                var std = new TabFuncionario()
                {
                  
                    
                    NmFuncionario = txbCadNome.Text,
                    NrRg = txbCadRGFun.Text,                   
                   // DsEmail = TxbCadEmailFun.Text,
                    //NrTelefone = txbCadTelFun.Text,
                    //DsDataNascimento = DateTime.Parse(mtbCadNascimento.Text)
                    IdTipoFuncionario= comboBox1.SelectedIndex


                };
                context.TabFuncionarios.Add(std);

                // or
                // context.Add<Student>(std);

                context.SaveChanges();
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
