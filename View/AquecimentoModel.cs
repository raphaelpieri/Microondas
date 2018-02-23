namespace View
{
    public class AquecimentoModel
    {
        public AquecimentoModel(string tempo, int potencia, string caracter, string chave)
        {
            Tempo = tempo;
            Potencia = potencia;
            Caracter = caracter;
            Chave = chave;
        }

        public AquecimentoModel AtualizarCampos(string tempo, int potencia, string caracter, string chave)
        {
            return new AquecimentoModel(tempo, potencia, caracter, chave);
        }

        public string Tempo { get; private set; }
        public int Potencia { get; private set; }
        public string Caracter { get; private set; }
        public string Chave { get; private set; }

        public void AlterarTempo(string tempo)
        {
            Tempo = tempo;
        }

        public void AlterarPotencia(int potencia)
        {
            Potencia = potencia;
        }

        public void AlterarChave(string chave)
        {
            Chave = chave;
        }
    }
}