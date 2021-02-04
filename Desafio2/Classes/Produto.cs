using System;

namespace Desafio2
{
    public class Produto
    {
        private string nome { get; set; }
		private double preco { get; set; }
		private int qtd { get; set; }
		
        public Produto (string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }

    }

    public class Livro : Produto
    {
        private string autor { get; set; }
		private string tema { get; set; }
		private int qtdPag { get; set; }

        public Livro (string autor, string tema, int qtdPag)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }
    }

    public class VideoGame : Produto
    {
        private string marca { get; set; }
		private string modelo { get; set; }
		private boolean isUsado { get; set; }

        public Livro (string marca, string modelo, boolean isUsado)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }
    }
}