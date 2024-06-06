using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model.Entidades;
using CelularCTI.Model;

namespace CelularCTI.Desktop
{
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> ap = new List<Aparelho>();
        private List<Fabricante> fab = new List<Fabricante>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            ap = Servico.BuscarAparelho();
            lstCelulares.DataSource = ap;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fab = Servico.BuscarFabricante();
            cmbFabricante.DataSource = fab;
            cmbFabricante.DisplayMember = "nome";
            cmbFabricante.ValueMember = "id_fabricante";
            cmbFabricante.SelectedIndex = 0;
        }



        private void btnPesquisarPreco_Click(object sender, EventArgs e)
        {
            ap = Servico.BuscarAparelho(numPrecoMinimo.Value, 
                                        numPrecoMaximo.Value);
            lstCelulares.DataSource = ap;   
        }

        private void btnPesquisarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante fabricante = new Fabricante();
            fabricante = fab[cmbFabricante.SelectedIndex];

            ap = Servico.BuscarAparelho(fabricante);
            lstCelulares.DataSource = ap;
        }

        private void btnPesquisarModelo_Click(object sender, EventArgs e)
        {
            ap = Servico.BuscarAparelho(txtModelo.Text);
            lstCelulares.DataSource = ap;
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            ap = Servico.BuscarAparelho();
            lstCelulares.DataSource = ap;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovoAparelho novo = new frmNovoAparelho();
            novo.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair do sistem ?",
                                        this.Text,
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Aparelho apSelecionado = new Aparelho();
            apSelecionado = ap[lstCelulares.SelectedIndex];
            if (apSelecionado.Quantidade > 0)
            {
                frmComprarAparelho comprarAparelho = new frmComprarAparelho(apSelecionado);
                comprarAparelho.ShowDialog();
            }
            else
            {
                MessageBox.Show("O Aparelho " + apSelecionado.Modelo + 
                                        " não tem quantidade disponível em estoque !!!",
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                lstCelulares.Focus();
            }          
        }
    }
}
