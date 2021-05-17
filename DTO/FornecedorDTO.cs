using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class FornecedorDTO
    {
        private int id, cnpj,telefone, telefoneRepresentante;
        private string nome, email, nomeRepresentante;

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

        public string NomeRepresentante
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeRepresentante = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.nomeRepresentante; }

        }

        public int Cnpj
        {
            set
            {
                if (value != 0)
                {
                    this.cnpj = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.cnpj; }

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

        public int TelefoneRepresentante
        {
            set
            {
                if (value != 0)
                {
                    this.telefoneRepresentante = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.telefoneRepresentante; }

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




    }
}