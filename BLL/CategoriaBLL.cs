using LojaVirtual.DTO;
using LojaVirtual.BLL;
using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaVirtual.BLL
{
    public class CategoriaBLL
    {

        private MySqldal con = new MySqldal();

        public void Inserir(CategoriaDTO produto)
        {
            string sql = string.Format($@"INSERT INTO produto VALUES (NULL, 
                                                '{produto.Nome}', 
                                                '{produto.Descricao};");
            con.ExecutarSQL(sql);
        }
        public void Excluir(CategoriaDTO produto)
        {
            string sql = string.Format($@"DELETE FROM produto WHERE id= {produto.Id};");
            con.ExecutarSQL(sql);
        }
        public void Alterar(CategoriaDTO produto)
        {
            string sql = string.Format($@"UPDATE produto SET nome= '{produto.Nome}',
                                                             descricao= '{produto.Descricao};");
            con.ExecutarSQL(sql);
        }
        public DataTable ConsultarID(int Id)
        {
            string sql = string.Format($@"SELECT * FROM produto WHERE id= {Id};");
            return con.ExecutarConsulta(sql);
        }
        public DataTable Pesquisar(string condicao)
        {

            string sql = string.Format($@"SELECT p.id , p.nome, p.descricao, p.valor, c.nome as categoria, f.nome as fornecedor, p.foto FROM produto p, categoria c, fornecedor f WHERE p.categoriaID = c.id and p.fornecedorID = f.id and " + condicao + " order by Id;");

            return con.ExecutarConsulta(sql);
        }

    }
}

    
