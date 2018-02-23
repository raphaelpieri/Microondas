using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App.Controller;
using App.Queries;
using Domain.Commands.Input;
using Domain.Commands.Result;
using Domain.Handlers;
using Domain.ValueObject;
using Flunt.Notifications;
using Infra;
using Infra.Repositories;

namespace View
{
    public partial class Microondas : Form
    {
        private IList<Button> listaDeBotoes = new List<Button>();
        private AquecimentoModel model; 
        private readonly AquecimentoController _aquecimentoController;
        private readonly ProgramaController _programaController;
        public Microondas()
        {
            var contexto = new TesteContexto();
            var programaRepositorio = new ProgramaRepositorio(contexto);
            var programarHandler = new ProgramaHandler(programaRepositorio);
            _programaController = new ProgramaController(programarHandler, programaRepositorio);
            _aquecimentoController = new AquecimentoController();

            InitializeComponent();
            CriarProgramasPadroes();
            MontarProgramas();
            
        }

        private void MontarProgramas()
        {
            RemoverBotoes();
            var programas = _programaController.Get().OrderBy(x => x.Nome).ToArray();
            var posicaoX = 0;
            var posicaoY = 0;
            for (var i = 0; i < programas.Count(); i++)
            {
                MontarBotao(programas[i], i, ref posicaoX, ref posicaoY);
            }
        }

        private void RemoverBotoes()
        {
            listaDeBotoes.ToList().ForEach(x => Controls.Remove(x));
            listaDeBotoes.Clear();
        }

        private void MontarBotao(GetListProgramas programa, int contagem, ref int posicaoX, ref int posicaoY)
        {
            MudarPosicoesDoBotoesDoPrograma(contagem, ref posicaoX, ref posicaoY);

            var bt = new Button();
            bt.Location = new Point(posicaoX, posicaoY);
            bt.Name = programa.Nome;
            bt.Size = new Size(151, 54);
            bt.TabIndex = 1;
            bt.Text = programa.Nome;
            bt.UseVisualStyleBackColor = true;
            bt.Click += new EventHandler((o, args) =>
            {
                var button = o as Button;
                this.CarregarDados(button.Name);
            });
            Controls.Add(bt);
            listaDeBotoes.Add(bt);
        }

        private void MudarPosicoesDoBotoesDoPrograma(int contagem, ref int posicaoX, ref int posicaoY)
        {
            if (posicaoX == 0 && posicaoY == 0)
            {
                posicaoX = 0;
                posicaoY = 4;
            }
            if (contagem % 2 == 0)
            {
                posicaoX = 0;
                posicaoY += 54;
            }
            else
            {
                posicaoX += 155;
            }
        }

        private void CriarProgramasPadroes()
        {
            CriarNovoPrograma("Frango Grelhado", "#", "00:01:30", 5, "Frango",
                "Deve ser feito congelado");
            CriarNovoPrograma("Arroz", "%", "00:01:40", 6, "Arroz",
                "Deve ser feito ao dente");
            CriarNovoPrograma("Feijão", "#", "00:01:20", 8, "Feijão",
                "Cozido ate 1000 anos");
            CriarNovoPrograma("Peixe Frito", "!", "00:00:25", 5, "Peixe",
                "Esse é bom para sushi");
            CriarNovoPrograma("Polenta Cozida", "^", "00:01:25", 7, "Polenta",
                "Legal mas não gosto");
        }

        private void CarregarDados(string nome)
        {
            var programa = _programaController.Get(nome);
            txtNome.Text = programa.Nome;
            txtChave.Text = programa.Chave;
            txtTempo.Text = programa.Tempo;
            txtPotencia.Text = programa.Potencia.ToString();
            txtCaracter.Text = programa.Caracter;
            txtInstrucao.Text = programa.Instrucoes;

            AtualizarModel(programa.Tempo, programa.Potencia, programa.Caracter, programa.Chave);
        }

        private void CarregarParametros()
        {
            txtPTempo.Text = model.Tempo;
            txtPPotencia.Text = model.Potencia.ToString();
        }

        private void Microondas_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoPrograma_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var chave = txtChave.Text;
            var tempo = txtTempo.Text;
            var potencia = int.Parse(txtPotencia.Text);
            var caracter = txtCaracter.Text;
            var instrucao = txtInstrucao.Text;

            var retorno = CriarNovoPrograma(nome, caracter, tempo, potencia, chave, instrucao);
            if (retorno.Sucesso)
            {
                MessageBox.Show(retorno.Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AtualizarModel(tempo, potencia, caracter, chave);
                MontarProgramas();
            }
            else
            {
                MensagemDeErro(retorno.Mensagem, retorno.Data);
            }
            
        }

        private NovoProgramaResult CriarNovoPrograma(string nome, string caracter, string tempo, int potencia, string chave, string instrucao)
        {
            var novoPrograma = new NovoProgramaCommand(nome,caracter,tempo,potencia,chave,instrucao);
            return _programaController.Push(novoPrograma);
        }


        private void AtualizarModel(string tempo, int potencia, string caracter, string chave)
        {
            model = model == null ? 
                new AquecimentoModel(tempo, potencia, caracter, chave) : 
                model.AtualizarCampos(tempo, potencia, caracter, chave);
            CarregarParametros();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            var campoString = txtString.Text;
            var command = new AquecimentoCommand(model.Tempo, model.Potencia, model.Caracter, model.Chave, campoString);

            var result = _aquecimentoController.RealizarAquecimento(command);

            if (result.Sucesso)
            {
                MessageBox.Show(result.Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtString.Text = result.Data.ToString();
            }
            else
                MensagemDeErro(result.Mensagem, result.Data);
        }

        private void MensagemDeErro(string mensagem, object data)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var resul = data as IReadOnlyCollection<Notification>;
            var error = new StringBuilder();
            foreach (var notification in resul)
            {
                error.Append($"{notification.Property} -- {notification.Message}");
            }

            MessageBox.Show(error.ToString());
        }
        

        private void MudarModelPeloParametros()
        {
            var tempo = txtPTempo.Text;
            var potencia = string.IsNullOrEmpty(txtPPotencia.Text) ? 0 : int.Parse(txtPPotencia.Text);
            var caracter = "*";

            AtualizarModel(tempo,potencia,caracter,string.Empty);
        }
        
        private void txtPTempo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                MudarModelPeloParametros();
        }

        private void txtPPotencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                MudarModelPeloParametros();
        }
    }
}
