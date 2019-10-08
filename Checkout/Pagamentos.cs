using Checkout.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Checkout
{
    public partial class frmPagamentos : Form
    {
        private int _idCli;
        private string _nomeCli;
        private string Url = "https://localhost:44352/api/v1/PaymentsData";

        public frmPagamentos(int id_Clie, string nome_Cli)
        {
            InitializeComponent();
            _idCli = id_Clie;
            _nomeCli = nome_Cli;
        }

        private void frmPagamentos_Load(object sender, System.EventArgs e)
        {
            txtClient.Text = _nomeCli;
        }

        private void btnPagamentos_Click(object sender, System.EventArgs e)
        {
            if (!Valida())
                return;

            AddPayment();
            this.Close();
        }

        private async void AddPayment()
        {

             DateTime data;
             DateTime.TryParse(mtbExpData.Text, out data);
            
            Payment payment = new Payment();

            payment.Id_Client = _idCli;
            payment.Name_Buyer = txtNameBuyer.Text.Trim();
            payment.Email = txtEmailBuyer.Text.Trim();
            payment.CPF = mtbCPF.Text.Trim();
            payment.Amount = decimal.Parse(txtAmount.Text);
            payment.Type = cboCard.Text.Trim();
            payment.Card = txtBandeira.Text.Trim();
            payment.Holder_name = txtNomeCard.Text.Trim();
            payment.Number = mtbCard.Text.Trim();
            payment.Expiration_date = data;
            payment.CVV = mtbCVV.Text.Trim();
            
            using (var client = new System.Net.Http.HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(payment);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(Url, content);


            }
        }

        private bool Valida()
        {
            if (txtNameBuyer.Text == "")
            {
                MessageBox.Show("Nome do Buyer é obrigatório");
                txtNameBuyer.Focus();
                return false;
            }

            if (txtEmailBuyer.Text == "")
            {
                MessageBox.Show("Email do Buyer é obrigatório");
                txtEmailBuyer.Focus();
                return false;
            }

            if (mtbCPF.Text == "")
            {
                MessageBox.Show("CPF do Buyer é obrigatório");
                mtbCPF.Focus();
                return false;
            }
            else if(!IsCpf(mtbCPF.Text))
            {
                MessageBox.Show("CPF do Buyer é inválido");
                mtbCPF.Focus();
                return false;
            }

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Amount é obrigatório");
                txtAmount.Focus();
                return false;
            }
            
            if (cboCard.Text == "")
            {
                MessageBox.Show("Type é obrigatório");
                cboCard.Focus();
                return false;
            }
            
            if (cboCard.Text != "Boleto")
            {
                if (txtBandeira.Text == "")
                {
                    MessageBox.Show("Card é obrigatório");
                    txtBandeira.Focus();
                    return false;
                }

                if (txtNomeCard.Text == "")
                {
                    MessageBox.Show("Name é obrigatório");
                    txtNomeCard.Focus();
                    return false;
                }

                if (mtbCard.Text == "")
                {
                    MessageBox.Show("Number é obrigatório");
                    mtbCard.Focus();
                    return false;
                }

                if (mtbExpData.Text == "")
                {
                    MessageBox.Show("Expiration Date é obrigatório");
                    mtbExpData.Focus();
                    return false;
                }

                DateTime resultado = DateTime.MinValue;
                if (!DateTime.TryParse(this.mtbExpData.Text.Trim(), out resultado))
                {
                    MessageBox.Show("Data inválida");
                    mtbExpData.Focus();
                }

                if (mtbCVV.Text == "")
                {
                    MessageBox.Show("Expiration Date é obrigatório");
                    mtbCVV.Focus();
                    return false;
                }
            }

            return true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                if (txtAmount.Text.Contains(","))
                {
                    e.Handled = true; 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cboCard_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCard.Text == "Boleto")
                Limpa(false);
            else
                Limpa(true);
        }

        private void Limpa(bool Enibe)
        {
            txtBandeira.Text = "";
            txtNomeCard.Text = "";
            mtbCard.Text = "";
            mtbExpData.Text = "";
            mtbCVV.Text = "";

            txtBandeira.Enabled = Enibe;
            txtNomeCard.Enabled = Enibe;
            mtbCard.Enabled = Enibe;
            mtbExpData.Enabled = Enibe;
            mtbCVV.Enabled = Enibe;
        }

        private bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
