﻿using LojaVirtual.DTO;
using LojaVirtual.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaVirtual.UI
{
    public partial class formCadCliente : System.Web.UI.Page
    {

        ClienteDTO clienteDTO = new ClienteDTO();
        ClienteBLL clienteBLL = new ClienteBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteDTO.Nome = nome.Text;
                clienteDTO.Endereco = endereco.Text;
                clienteDTO.Email = email.Text;
                clienteDTO.Senha = senha.Text;

                clienteBLL.Inserir(clienteDTO);


                // alert
                string mensagem = "categoria inserida com sucesso!";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "')", true);

            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            {
                nome.Text = "";
                endereco.Text = "";
                cpf.Text = "";
                email.Text = "";
                senha.Text = "";
                telefone.Text = "";
            }

        }
































    }
}