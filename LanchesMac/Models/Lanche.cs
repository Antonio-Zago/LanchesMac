using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; } //Com o Id na frente do nome da propriedade, o entity framework, na criação das tabelas já entende que se trata de uma chave primária

        [StringLength(100)] //Data anotation que defini o tamanho do varchar da coluna da tabela que o entity framework criará no banco
        public string Nome { get; set; }

        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }


        [StringLength(200)]
        public string ImagemUrl { get; set; }


        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; } //Defini para o entity framework na geração da tabela, que as tabelas lanches e categorias possuem relação

    }
}
