using System;

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
            this.Nome = nome;
            this.Tipo = tipo;
            this.Tamanho= tamanho;
            this.Tempo = tempo;
        }

        public override string ToString()
        {
            return $"| {this.Nome} | caso : {this.Tipo} | tamanho : {this.Tamanho} | tempo : {this.Tempo} ms |";
        }
    }
}
