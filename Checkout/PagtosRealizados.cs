using Checkout.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout
{
    public partial class frmPagtosRealizados : Form
    {

        private string Url = "https://localhost:44352/api/v1/PaymentsData";

        public frmPagtosRealizados()
        {
            InitializeComponent();
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
                        dgvDados.DataSource = Newtonsoft.Json.JsonConvert.DeserializeObject<MadePayment[]>(ClientJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o client : " + response.StatusCode);
                    }
                }
            }
            if (dgvDados.SelectedRows.Count > 0)
            {
                int index = dgvDados.SelectedRows[0].Index;

                if (index >= 0)
                    dgvDados.Rows[index].Selected = false;
            }
        }
    }
}
