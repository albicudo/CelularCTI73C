using CelularCTI.Model;
using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI.Desktop
{
    public partial class frmNovoAparelho : Form
    {
        private List<Fabricante> fab = new List<Fabricante>();
        public frmNovoAparelho()
        {
            InitializeComponent();
        }

        private void frmNovoAparelho_Load(object sender, EventArgs e)
        {
            fab = Servico.BuscarFabricante();
            cmbFabricante.DataSource = fab;
            cmbFabricante.DisplayMember = "nome";
            cmbFabricante.ValueMember = "id_fabricante";
            cmbFabricante.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente cancelar o cadastro do aparelho ?",
                                        this.Text,
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Testes de consistência - regras de negócio
            
            if (String.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Você deve informar o modelo do aparelho !!!",
                                        this.Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                txtModelo.Focus();
                return;
            }
            if (numPreco.Value <= 0 )
            {
                    MessageBox.Show("O preço do aparelho não pode ser menor ou igual a zero !!!",
                                            this.Text,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    numPreco.Focus();
                    return;
            }
            // usar try ... catch

            Aparelho ap = new Aparelho();

            ap.Fabricante = fab[cmbFabricante.SelectedIndex];
            ap.Modelo = txtModelo.Text;
            ap.Largura = Convert.ToDouble(numLargura.Value);
            ap.Espessura = Convert.ToDouble(numLargura.Value);
            ap.Altura = Convert.ToDouble(numAltura.Value);
            ap.Peso = Convert.ToDouble(numPeso.Value);
            ap.Quantidade = Convert.ToDouble(numQuantidade.Value);
            ap.Preco = Convert.ToDecimal(numPreco.Value);
            ap.Desconto = Convert.ToDecimal(numDesconto.Value); 
            
            Servico.Salvar(ap);

            MessageBox.Show("Aparelho " + txtModelo.Text + " cadastrado com sucesso !!!",
                                            this.Text,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
            this.Close();

        }
    }
}
