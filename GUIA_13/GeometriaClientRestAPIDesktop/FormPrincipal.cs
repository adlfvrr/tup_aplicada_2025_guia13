using GeometriaClientRestAPIDesktop.DTOs;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace GeometriaClientRestAPIDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        async private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:7198/api/Geometria2";

                using var client = new HttpClient();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url)
                };

                var response = await client.SendAsync(request);

                lsbConsultas.Items.Clear();
                if (response.IsSuccessStatusCode)
                {
                    var lista = response.Content.ReadFromJsonAsync<List<FiguraDTO>>();
                    lsbConsultas.DataSource = lista.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
