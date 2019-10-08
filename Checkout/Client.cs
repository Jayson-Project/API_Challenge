using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Checkout.Model;

namespace Checkout
{
    public partial class frmClient : Form
    {

        string Url = "https://localhost:44352/api/v1/Client";

        Cliente cli = new Cliente();

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, System.EventArgs e)
        {
            GetAllClients();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtualizaCampos();
            if (!Valida(true))
                return;
            UpdateCliente();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            AtualizaCampos();
            DeleteCliente();
            Limpa();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AtualizaCampos();
            if (!Valida(false))
                return;
            AddCliente();
            Limpa();
        }

        private async void UpdateCliente()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(Url + "/" + cli.Id, cli);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
            GetAllClients();
        }

        private async void GetAllClients()
        {

            using (var client = new System.Net.Http.HttpClient())
            {
                using (var response = await client.GetAsync(Url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ClientJsonString = await response.Content.ReadAsStringAsync();
                        dgvClient.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente[]>(ClientJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o client : " + response.StatusCode);
                    }
                }
            }
            if (dgvClient.SelectedRows.Count > 0)
            {
                int index = dgvClient.SelectedRows[0].Index;

                if (index >= 0)
                    dgvClient.Rows[index].Selected = false;
            }
        }

        private async void DeleteCliente()
        {
            if (cli.Id == null)
            {
                MessageBox.Show("Cliente não existe!");
                return;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", Url, cli.Id));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o Cliente  : " + responseMessage.StatusCode);
                }
            }
            GetAllClients();
        }

        private async void AddCliente()
        {
            if (cli.Id != null) {
                MessageBox.Show("Cliente já existe");
                return;
            }

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(cli);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(Url, content);
            }
            txtId.Text = cli.Id.ToString();
            GetAllClients();
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClient.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtName.Text = dgvClient.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtEmail.Text = dgvClient.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            AtualizaCampos();
        }

        private void AtualizaCampos()
        {
            if (txtId.Text == "")
                cli.Id = null;
            else
                cli.Id = Convert.ToInt64(txtId.Text);
            cli.Nome = txtName.Text;
            cli.Email = txtEmail.Text;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void Limpa()
        {
            cli.Id = null;
            cli.Nome = null;
            cli.Email = null;
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtName.Focus();
        }

        private bool Valida(bool validaId)
        {
            if (validaId && txtId.Text == "")
            {
                MessageBox.Show("Clinte não existe");
                return false;
            }
            
            if (txtName.Text == "")
            {
                MessageBox.Show("O nome é obrigatório");
                txtName.Focus();
                return false;
            }
                
            if (txtEmail.Text == "")
            {
                MessageBox.Show("O email é obrigatório");
                txtEmail.Focus();
                return false;
            }
                
            return true;
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um cliente para realizar o pagamento");
                return;
            }
            Form formPagamento = new frmPagamentos(Convert.ToInt32(txtId.Text), txtName.Text);
            formPagamento.ShowDialog();

            if (formPagamento.Modal == false)
            {
                formPagamento.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                formPagamento.TopLevel = false;
            }

        }

        private void btnPagtosCartoes_Click(object sender, EventArgs e)
        {
            frmPagtosRealizados pgatosRealizados = new frmPagtosRealizados();

            pgatosRealizados.ShowDialog();
            if (pgatosRealizados.Modal == false)
            {
                pgatosRealizados.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                pgatosRealizados.TopLevel = false;
            }
        }
    }
}
