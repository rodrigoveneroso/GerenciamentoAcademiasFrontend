using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.SqlClient;
using Academia_GUI.Models;
using System.Net.Http.Headers;

namespace Academia_GUI.Forms
{
    public partial class FormPlanos : Form
    {
        //Fields
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        //Constructor
        public FormPlanos()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            refreshdata();
        }

        private async Task refreshdata()
        {
            try
            {
                IEnumerable<MPlanos> empobj = null;
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:5146/api/");

                var consumeapi = await hc.GetAsync("Planos");
                consumeapi.EnsureSuccessStatusCode(); // Verifica se a requisição foi bem-sucedida

                var contentString = await consumeapi.Content.ReadAsStringAsync();
                var displaydata = JsonConvert.DeserializeObject<List<MPlanos>>(contentString);

                if (displaydata != null && displaydata.Any())
                {
                    empobj = displaydata;

                    dataGridView1.DataSource = empobj;
                    lblError.Visible = false;
                }
                else
                {
                    lblError.Text = "No data received from the API.";
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Please check whether Web API is running or not!";
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            
        }

        //Properts

        public string DescricaoPlano 
        {
            get => txtDescricaoPlano.Text;
            set => txtDescricaoPlano.Text = value;
        }
        public string ValorPlano
        { 
            get => txtValorPlano.Text;
            set => txtValorPlano.Text = value;
        }
        public string DiasPlano
        { 
            get => txtDuracaoPlano.Text;
            set => txtDuracaoPlano.Text = value;
        }
       
        public string SearchValue
        { 
            get => txtSearch.Text;
            set => txtSearch.Text = value; 
        }
        public bool IsEdit 
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessfull
        { 
            get => isSuccessfull;
            set => isSuccessfull = value;
        }
        public string Message 
        { 
            get => message;
            set => message = value;
        }


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void FormAlunos_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            // Construir o objeto JSON com os dados do formulário
            var plano = new
            {
                Descricao_plano = DescricaoPlano,
                Valor_plano = float.Parse(ValorPlano),
                Dias_plano = int.Parse(DiasPlano),
                
            };

            try
            {
                // Converter o objeto para JSON
                var planoJson = JsonConvert.SerializeObject(plano);

                // Fazer a requisição POST para a API
                using (var httpClient = new HttpClient())
                {
                    // Configurar a base da URI da API
                    httpClient.BaseAddress = new Uri("http://localhost:5146/api/");

                    // Definir o cabeçalho de tipo de mídia
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Criar o conteúdo da requisição com os dados do aluno em formato JSON
                    var content = new StringContent(planoJson, Encoding.UTF8, "application/json");

                    // Fazer a requisição POST e obter a resposta
                    var response = await httpClient.PostAsync("Planos", content);

                    // Verificar se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Exibir mensagem de sucesso
                        MessageBox.Show("Plano salvo com sucesso!");

                        // Atualizar a lista de alunos após o salvamento
                        await refreshdata();
                    }
                    else
                    {
                        // Exibir mensagem de falha com o código de status da resposta
                        MessageBox.Show($"Falha ao salvar o plano. Código de status: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro genérico
                MessageBox.Show($"Ocorreu um erro ao salvar o aluno: {ex.Message}");
            }

        }
            //Methods
            public void SetAlunoListBindingSource(BindingSource alunoList)
        {
            dataGridView1.DataSource = alunoList;
        }
    }
}
