using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMeuChef
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
            LimpaTxts();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDados();
            DesmarcaRbs();
        }

        private void CarregarDados()
        {
            using (SqlConnection conn = DataBase.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM ProdutoCardapio";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dgvReceitas.DataSource = dt;
                    dgvReceitas.Columns["PesoFinal"].DefaultCellStyle.Format = "N2"; // Exibe duas casas decimais

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            VerificaTxts();
            AdicionaDados();
        }

        private void VerificaTxts()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDescricao.Text) ||
                String.IsNullOrEmpty(txtIngredientes.Text) || String.IsNullOrEmpty(txtModoPreparo.Text) ||
                String.IsNullOrEmpty(txtPesoFinal.Text))
            {
                MessageBox.Show("Verifique os campos de preenchimento obrigatório!");
            }
        }

        private void AdicionaDados()
        {
            using (SqlConnection conn = DataBase.GetConnection())
            {
                try
                {
                    decimal pesoFinal;

                    if (!decimal.TryParse(txtPesoFinal.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out pesoFinal))
                    {
                        MessageBox.Show("Peso final inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    conn.Open();
                    string query = "INSERT INTO ProdutoCardapio (nomeCardapio, descricaoCardapio, ingredientesCardapio, preparoCardapio, observacaoCardapio, pesoFinal) VALUES (@nomeCardapio, @descricaoCardapio, @ingredientesCardapio, @preparoCardapio, @observacaoCardapio, @pesoFinal)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeCardapio", txtNome.Text);
                        cmd.Parameters.AddWithValue("@descricaoCardapio", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@ingredientesCardapio", txtIngredientes.Text);
                        cmd.Parameters.AddWithValue("@preparoCardapio", txtModoPreparo.Text);
                        cmd.Parameters.AddWithValue("@observacaoCardapio", txtObservacoes.Text);
                        cmd.Parameters.AddWithValue("@pesoFinal", pesoFinal);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cardápio adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDados();
                    LimpaTxts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar: " + ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditaDados();
        }

        private void EditaDados()
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvReceitas.SelectedRows[0].Cells[0].Value); // Supondo que a 1ª coluna seja o ID
                using (SqlConnection conn = DataBase.GetConnection())
                {
                    try
                    {
                        decimal pesoFinal;

                        if (!decimal.TryParse(txtPesoFinal.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out pesoFinal))
                        {
                            MessageBox.Show("Peso final inválido! Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        conn.Open();
                        string query = "UPDATE ProdutoCardapio SET nomeCardapio = @nomeCardapio, descricaoCardapio = @descricaoCardapio, ingredientesCardapio = @ingredientesCardapio, preparoCardapio = @preparoCardapio, observacaoCardapio = @observacaoCardapio, pesoFinal = @pesoFinal WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@nomeCardapio", txtNome.Text);
                            cmd.Parameters.AddWithValue("@descricaoCardapio", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@ingredientesCardapio", txtIngredientes.Text);
                            cmd.Parameters.AddWithValue("@preparoCardapio", txtModoPreparo.Text);
                            cmd.Parameters.AddWithValue("@observacaoCardapio", txtObservacoes.Text);
                            cmd.Parameters.AddWithValue("@pesoFinal", pesoFinal);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cardápio editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarDados();
                        dgvReceitas.Refresh();
                        LimpaTxts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao editar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluiDados();
        }

        private void ExcluiDados()
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvReceitas.SelectedRows[0].Cells[0].Value);
                using (SqlConnection conn = DataBase.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM ProdutoCardapio WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarDados();
                        LimpaTxts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpaTxts()
        {
            txtNome.Text = txtDescricao.Text = txtIngredientes.Text = txtModoPreparo.Text = txtObservacoes.Text = txtPesoFinal.Text = "";
        }

        private void DesmarcaRbs()
        {
            rbNome.Checked = rbObservacao.Checked = false;
        }

        private void dgvReceitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                txtNome.Text = dgvReceitas.SelectedRows[0].Cells["nomeCardapio"].Value.ToString();
                txtDescricao.Text = dgvReceitas.SelectedRows[0].Cells["descricaoCardapio"].Value.ToString();
                txtIngredientes.Text = dgvReceitas.SelectedRows[0].Cells["ingredientesCardapio"].Value.ToString();
                txtModoPreparo.Text = dgvReceitas.SelectedRows[0].Cells["preparoCardapio"].Value.ToString();
                txtObservacoes.Text = dgvReceitas.SelectedRows[0].Cells["observacaoCardapio"].Value.ToString();
                txtPesoFinal.Text = dgvReceitas.SelectedRows[0].Cells["pesoFinal"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim(); // Obtém o texto digitado no campo de busca
            if (string.IsNullOrWhiteSpace(filtro))
            {
                MessageBox.Show("Digite um termo para buscar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string colunaFiltro = "";

            // Verifica qual RadioButton está selecionado
            if (rbNome.Checked)
            {
                colunaFiltro = "nomeCardapio";
            }
            else if (rbObservacao.Checked)
            {
                colunaFiltro = "observacaoCardapio"; // Ajuste conforme o nome da coluna na dgvReceitas
            }
            else
            {
                MessageBox.Show("Selecione um critério de busca (Nome ou Observação).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aplica o filtro na DataGridView
            (dgvReceitas.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", colunaFiltro, filtro);
        }

        private void btnLimpaBusca_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            (dgvReceitas.DataSource as DataTable).DefaultView.RowFilter = ""; // Remove o filtro e exibe todos os dados
        }
    }
}
