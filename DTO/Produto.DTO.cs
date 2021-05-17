using LojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class ProdutoDTO
    {
        private int id, categoriaID, fornecedorID;
        private string nome, descricao, foto;
        private double valor;

        public int Id { get => id; set => id = value; }
        public int FornecedorID { get => FornecedorID1; set => FornecedorID1 = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Foto { get => foto; set => foto = value; }

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

        public string Descricao
        {
            set
            {
                if (value != string.Empty)
                {
                    this.descricao = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.descricao; }

        }

        public int CategoriaID
        {
            set
            {
                if (value != 0)
                {
                    this.CategoriaID1 = value;
                }
                else
                {

                    throw new Exception("Este campo é obrigatório!");
                }

            }
            get { return this.CategoriaID1; }

        }

        public int CategoriaID1 { get => CategoriaID2; set => CategoriaID2 = value; }
        public int CategoriaID2 { get => CategoriaID3; set => CategoriaID3 = value; }
        public int CategoriaID3 { get => categoriaID; set => categoriaID = value; }
        public int FornecedorID1 { get => fornecedorID; set => fornecedorID = value; }

        public static implicit operator ProdutoDTO(ClienteDTO v)
        {
            throw new NotImplementedException();
        }
    }
}