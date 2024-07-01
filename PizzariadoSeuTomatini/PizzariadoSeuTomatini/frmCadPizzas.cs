using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariadoSeuTomatini.modelo;

namespace PizzariadoSeuTomatini
{
    public partial class frmCadPizzas : Form
    {
        private List<Pizza> listadepizzas;
        public frmCadPizzas()
        {
            InitializeComponent();
            listadepizzas = new List<Pizza>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipoPizza = "", saborPizza = "", composicaoPizza = "", bordasPizza = "";
            bool permiteBorda = false;
            double valorPizzaPequena = 0, valorPizzaFamilia = 0;
            
            if (validacao())
            {
                //Recuperação dos Dados
                tipoPizza = cmbTipoPizzas.Text;
                saborPizza = txtSabor.Text;
                composicaoPizza = txtComposicao.Text;
                permiteBorda = rdBordaSim.Checked;
                if (permiteBorda == true)
                {
                    if (chkBordaCheddar.Checked == true)
                    {
                        bordasPizza = "Borda de Cheddar";
                    }
                    if (chkBordaCatupiry.Checked == true)
                    {
                        bordasPizza = bordasPizza + " Borda de Catupiry";
                    }
                    if (chkBordaMista.Checked == true)
                    {
                        bordasPizza = bordasPizza + " Borda Mista";
                    }
                    if (chkBordaVulcao.Checked == true)
                    {
                        bordasPizza = bordasPizza + " Borda Vulcão";
                    }
                }
                if (chkTamanhoPequena.Checked == true)
                {
                    valorPizzaPequena = Convert.ToDouble(txtValorTamanhoPequena.Text);
                }
                if (chkTamanhoFamilia.Checked == true)
                {
                    valorPizzaFamilia = Convert.ToDouble(txtValorTamanhoFamilia.Text);
                }
                //Criar um objeto Pizza com os dados da Tela
                Pizza minhapizza = new Pizza(tipoPizza, saborPizza, composicaoPizza, permiteBorda, bordasPizza, valorPizzaPequena, valorPizzaFamilia);
                //Adicionando o objeto criado dentro da nossa lista
                listadepizzas.Add(minhapizza);
                MessageBox.Show("Dados Salvos com Sucesso!!!");
                //Deixando a Tela pronta para um novo cadastro
                limpacampos();
            }
        }

        private void limpacampos()
        {
            cmbTipoPizzas.SelectedIndex = -1;
            txtSabor.Text = "";
            txtComposicao.Text = "";
            rdBordaSim.Checked = true;
            chkBordaCheddar.Checked = false;
            chkBordaCatupiry.Checked = false;
            chkBordaMista.Checked = false;
            chkBordaVulcao.Checked = false;
            chkTamanhoPequena.Checked = false;
            chkTamanhoFamilia.Checked = false;
            txtValorTamanhoPequena.Text = "";
            txtValorTamanhoFamilia.Text = "";
            txtValorTamanhoPequena.Enabled = false;
            txtValorTamanhoFamilia.Enabled = false;
        }
        private void rdBordaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBordaSim.Checked == true)
            {
                grpbTipoBordas.Enabled = true;
            }
        }

        private void rdBordaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBordaNao.Checked == true)
            {
                grpbTipoBordas.Enabled = false;
                chkBordaCheddar.Checked = false;
                chkBordaCatupiry.Checked = false;
                chkBordaMista.Checked = false;
                chkBordaVulcao.Checked = false;
            }
        }

        private void chkTamanhoPequena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTamanhoPequena.Checked == true)
            {
                lblValorPequena.Enabled = true;
                txtValorTamanhoPequena.Enabled = true;
                txtValorTamanhoPequena.Focus();
            }
            else
            {
                lblValorPequena.Enabled = false;
                txtValorTamanhoPequena.Enabled = false;
                txtValorTamanhoPequena.Text = "";
            }
        }

        private void chkTamanhoFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTamanhoFamilia.Checked == true)
            {
                lblValorFamilia.Enabled = true;
                txtValorTamanhoFamilia.Enabled = true;
                txtValorTamanhoFamilia.Focus();
            }
            else
            {
                lblValorFamilia.Enabled = false;
                txtValorTamanhoFamilia.Enabled = false;
                txtValorTamanhoFamilia.Text = "";
            }
        }

        private bool validacao()
        {
            //Verifica se foi informado o Tipo da Pizza
            if (cmbTipoPizzas.SelectedIndex == -1)
            {
                MessageBox.Show("Você deve informar o Tipo da Pizza!!!");
                return false;
            }
            //Verifica se o sabor da Pizza foi informado
            if (txtSabor.Text == "")
            {
                MessageBox.Show("Você deve informar o Sabor da Pizza!!!");
                txtSabor.Focus();
                return false;
            }
            //Verifica se a composição da Pizza foi informada
            if (txtComposicao.Text == "")
            {
                MessageBox.Show("Você deve informar a Composição da Pizza!!!");
                txtComposicao.Focus();
                return false;
            }
            //Se a Pizza permite borda, pelo menos um tem de ser selecionada
            if (rdBordaSim.Checked == true)
            {
                if ((chkBordaCheddar.Checked == false) && (chkBordaCatupiry.Checked == false) && (chkBordaMista.Checked == false) && (chkBordaVulcao.Checked == false))
                {
                    MessageBox.Show("A Pizza permite adicionar Borda. Por favor, informe uma Borda!!!");
                    return false;
                }
            }
            //Verifica se pelo menos um tamanho de Pizza foi informado
            if ((chkTamanhoPequena.Checked == false) && (chkTamanhoFamilia.Checked == false))
            {
                MessageBox.Show("Pelo menos um tamanho de Pizza, deve ser informado!!!");
                return false;
            }
            //Verfica se foi informado os valores da Pizza
            if (chkTamanhoPequena.Checked == true)
            {
                if (txtValorTamanhoPequena.Text == "")
                {
                    MessageBox.Show("Por favor, informe o valor da Pizza Pequena!!!");
                    txtValorTamanhoPequena.Focus();
                    return false;
                }
            }

            if (chkTamanhoFamilia.Checked == true)
            {
                if (txtValorTamanhoFamilia.Text == "")
                {
                    MessageBox.Show("Por favor, informe o valor da Pizza Família!!!");
                    txtValorTamanhoFamilia.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnListarPizzas_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            if (listadepizzas.Count == 0)
            {
                MessageBox.Show("A Lista de Pizzas está vazia. Por favor cadastre novas Pizzas!!!");
            }
            else
            {
                foreach (Pizza p in listadepizzas)
                {
                    mensagem = "Tipo da Pizza:" + p.getTipo() + "\n";
                    mensagem = mensagem + "Sabor da Pizza:" + p.getSabor() + "\n";
                    mensagem = mensagem + "Composição da Pizza:" + p.getComposicao() + "\n";
                    mensagem = mensagem + "Permite Borda:" + (p.isPermiteBordas() ? "Sim" : "Não") + "\n";
                    mensagem = mensagem + "Borda(s):" + p.getBordas() + "\n";
                    mensagem = mensagem + "Valor da Pizza Pequena:" + p.getValorPequena().ToString() + "\n";
                    mensagem = mensagem + "Valor da Pizza Família:" + p.getValorFamilia().ToString();
                    MessageBox.Show(mensagem);
                }
            }
        }
    }
}
