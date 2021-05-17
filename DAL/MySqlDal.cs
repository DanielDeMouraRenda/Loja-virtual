using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;



namespace LojaVirtual.DAL
{
    public class MySqldal
    {
        private static string server = "localhost";
        private static string database = "lojavirtual";
        private static string user = "root";
        private static string password = "";

        private string stringConexao = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + user + "; PWD=" + password;

        public MySqlConnection conexao;
    

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Não foi possível conectar ao banco de dados. Erro: " + e.Message);
            }

        }       
        public void ExecutarSQL(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível executar a instrução no banco de dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
      
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível executar a consulta no banco de dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();

            }
        }

    }
}