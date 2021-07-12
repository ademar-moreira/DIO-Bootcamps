using System;

namespace ACM.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Elenco { get; set; }
        private string Nacionalidade { get; set; }
        private bool Excluido {get; set;}

        // Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano, string elenco, string nacionalidade)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Elenco = elenco;
            this.Nacionalidade = nacionalidade;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Elenco: " + this.Elenco + Environment.NewLine;
            retorno += "Nacionalidade: " + this.Nacionalidade + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}