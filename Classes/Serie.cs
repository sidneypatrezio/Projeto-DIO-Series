using System;

namespace Projeto_Dio_Series
{
    public class Serie : EntidadeBase
    {
        
        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private Genero Genero { get; set; }

        private int Ano { get; set; }

        private bool Excluido {get; set;}


        public Serie(int id, string titulo, string descricao, Genero genero, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Environment.NewLine;
            retorno += "Título:" + this.Titulo + Environment.NewLine;
            retorno += "Descrição:" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento:" + this.Ano + Environment.NewLine;
            retorno += "Excluído:" + this.Excluido;
            return retorno;
        }

        public string retornaTitulo(){
            
            return this.Titulo;
        }

        public int retornaID(){
            
            return this.Id;
        }

        public string retornaGenero(){

            return this.Genero+"";
        }

        public bool retornaExcluido(){

            return this.Excluido;
        }

        public void Excluir(){

            this.Excluido = true;
        }
    }
    
}