using LojaVirtual.DTO;
using LojaVirtual.BLL;
using System;

namespace LojaVirtual.UI
{
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar o objeto ClienteDTO
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Email = txtEmail.Text;
                clienteDTO.Senha = txtSenha.Text;
                //Instanciar o objeto ClienteBLL
                ClienteBLL clienteBLL = new ClienteBLL();
                if (clienteBLL.Autenticar(clienteDTO.Email, clienteDTO.Senha))
                {
                    Session["emailUsuario"] = clienteDTO.Email;
                    msgOK.Visible = true;
                    msgOK.Text = "Seja bem-vindo!";
                    Response.Redirect("formMeuPerfil.aspx");
                }
                else
                {

                    msgErro.Visible = true;
                    msgErro.Text = "Cliente não encontrado!";

                }
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;

            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCadCliente.aspx");
        }

        protected void BtnEsqueciSenha_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar o objeto ClienteDTO
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Email = txtEmail.Text;
                clienteDTO.Senha = txtSenha.Text;
                //Instanciar o objeto ClienteBLL
                ClienteBLL clienteBLL = new ClienteBLL();
                msgOK.Visible = true;
                string senha = clienteBLL.RecuperarSenha(clienteDTO.Email);
                msgOK.Text = senha;

                txtSenha.Text = senha;
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;

            }
        }
    }
}