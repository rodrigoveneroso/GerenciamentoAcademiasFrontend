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
    public partial class FormAlunos : Form
    {
        //Fields
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        //Constructor
        public FormAlunos()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            refreshdata();
        }

        private async Task refreshdata()
        {
            try
            {
                IEnumerable<MAlunos> empobj = null;
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:5146/api/");

                var consumeapi = await hc.GetAsync("Alunos");
                consumeapi.EnsureSuccessStatusCode(); // Verifica se a requisição foi bem-sucedida

                var contentString = await consumeapi.Content.ReadAsStringAsync();
                var displaydata = JsonConvert.DeserializeObject<List<MAlunos>>(contentString);

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

        public string CpfAluno 
        {
            get => txtCpfAluno.Text;
            set => txtCpfAluno.Text = value;
        }
        public string DataNascimentoAluno
        { 
            get => txtDataNascimentoAluno.Text;
            set => txtDataNascimentoAluno.Text = value;
        }
        public string StatusAluno
        { 
            get => txtStatusAluno.Text;
            set => txtStatusAluno.Text = value;
        }
        public string TelefoneAluno
        { 
            get => txtTelefoneAluno.Text; 
            set => txtTelefoneAluno.Text = value; 
        }
        public string EmailAluno 
        { 
            get => txtEmailAluno.Text;
            set => txtEmailAluno.Text = value;
        }
        public string NomeAluno 
        { 
            get => txtNomeAluno.Text; 
            set => txtNomeAluno.Text = value;
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
            var aluno = new
            {
                cpF_aluno = CpfAluno,
                data_nascimento_aluno = DataNascimentoAluno,
                status = int.Parse(StatusAluno), // Você precisa definir como deseja obter o status do aluno
                telefone_aluno = TelefoneAluno,
                email_aluno = EmailAluno,
                nome_aluno = NomeAluno
            };

            try
            {
                // Converter o objeto para JSON
                var alunoJson = JsonConvert.SerializeObject(aluno);

                // Fazer a requisição POST para a API
                using (var httpClient = new HttpClient())
                {
                    // Configurar a base da URI da API
                    httpClient.BaseAddress = new Uri("http://localhost:5146/api/");

                    // Definir o cabeçalho de tipo de mídia
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Criar o conteúdo da requisição com os dados do aluno em formato JSON
                    var content = new StringContent(alunoJson, Encoding.UTF8, "application/json");

                    // Fazer a requisição POST e obter a resposta
                    var response = await httpClient.PostAsync("Alunos", content);

                    // Verificar se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Exibir mensagem de sucesso
                        MessageBox.Show("Aluno salvo com sucesso!");

                        // Atualizar a lista de alunos após o salvamento
                        await refreshdata();
                    }
                    else
                    {
                        // Exibir mensagem de falha com o código de status da resposta
                        MessageBox.Show($"Falha ao salvar o aluno. Código de status: {response.StatusCode}");
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
