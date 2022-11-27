namespace AlgoritmosOrdenacao.src
{
    internal class Ficha
    {
        public String Nome { get; private set; }
        public String Tipo { get; private set; }
        public int Tamanho { get; private set; }
        public long Tempo { get; private set;}

        public Ficha(String nome, String tipo, int tamanho, long tempo)
        {
            Nome = nome;
            Tipo = tipo;
            Tamanho = tamanho;
            Tempo = tempo;
        }

        public override string ToString()
        {
            return $"| {this.Nome} \t| caso : {this.Tipo} \t| tamanho : {this.Tamanho} \t| tempo : {this.Tempo} ms \t|";
        }
    }
}
