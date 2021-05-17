using LojaVirtual.DTO;
using LojaVirtual.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaVirtual.BLL
{
    public class FornecedorBLL
    {

        private MySqldal con = new MySqldal();

        public void Inserir(FornecedorDTO produto)
        {
            string sql = string.Format($@"INSERT INTO produto VALUES (NULL, 
                                                '{produto.Nome}', 
                                                '{produto.Cnpj}', 
                                                '{produto.Telefone}', 
                                                '{produto.TelefoneRepresentante}', 
                                                '{produto.Email}', 
                                                '{produto.NomeRepresentante};");
            con.ExecutarSQL(sql);
        }
        public void Excluir(FornecedorDTO produto)
        {
            string sql = string.Format($@"DELETE FROM produto WHERE id= {produto.Id};");
            con.ExecutarSQL(sql);
        }
        public void Alterar(FornecedorDTO produto)
        {
            string sql = string.Format($@"UPDATE produto SET nome= '{produto.Nome}',
                                                             '{produto.Nome}', 
                                                             '{produto.Cnpj}', 
                                                             '{produto.Telefone}', 
                                                             '{produto.TelefoneRepresentante}', 
                                                             '{produto.Email}', 
                                                             '{produto.NomeRepresentante};");
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


    