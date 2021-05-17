using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class ClienteDTO
    {
        private int id, cpf, telefone;
        private string nome, endereco , email, senha ;

        public int Id { get => id; set => id = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.nome; }
            
        }

        public int Cpf
        {
            set
            {
                if (value != 0)
                {
                    this.cpf = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.cpf; }

        }

        public int Telefone
        {
            set
            {
                if (value != 0)
                {
                    this.telefone = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.telefone; }

        }
        public string Endereco
        {
            set
            {
                if (value != string.Empty)
                {
                    this.endereco = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.endereco; }

        }
       
        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.email; }

        }
        
        public string Senha
        {
            set
            {
                if (value != string.Empty)
                {
                    this.senha = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.senha; }

        }

















    }
}