using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; } //Defini a relação entre as tabelas lanches e categorias, informando que é uma relação 1 para n, ou seja, 1 categoria pode ter n lanches 
    }
}
