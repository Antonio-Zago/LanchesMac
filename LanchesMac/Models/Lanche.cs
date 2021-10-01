namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; } //Com o Id na frente do nome da propriedade, o entity framework, na criação das tabelas já entende que se trata de uma chave primária

        public string Nome { get; set; }

        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; } //Defini para o entity framework na geração da tabela, que as tabelas lanches e categorias possuem relação

    }
}
