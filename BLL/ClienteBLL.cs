using LojaVirtual.DAL;
using LojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaVirtual.BLL
{
    public class ClienteBLL
    {
        private MySqldal con = new MySqldal();

        public Boolean Autenticar(string email, string senha)
        {
            string sql = string.Format($@"SELECT * FROM cliente WHERE email= '{email}' and senha='{senha}';");
            DataTable dt = con.ExecutarConsulta(sql);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {
            string sql = string.Format($@"SELECT * FROM cliente WHERE email= '{email}';");
            DataTable dt = con.ExecutarConsulta(sql);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha"].ToString();
            }
            else
            {
                return "Usuário não encontrado!";
            }
        }

        internal void Inserir(ClienteDTO clienteDTO)
        {
            throw new NotImplementedException();
        }
    }
}