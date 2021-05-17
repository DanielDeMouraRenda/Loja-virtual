using LojaVirtual.BLL;
using LojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loja_virtual.UI
{
    public partial class formCadFornecedor : System.Web.UI.Page
    {
        FornecedorDTO fornecedorDTO = new FornecedorDTO();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedorDTO.Nome = nome.Text;               
                fornecedorDTO.Email = email.Text;
                fornecedorDTO.NomeRepresentante = nomeRepresentante.Text;

                fornecedorBLL.Inserir(fornecedorDTO);


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
                cnpj.Text = "";
                email.Text = "";
                nomeRepresentante.Text = "";
                telefone.Text = "";
                telefoneRepresentante.Text = "";
            }

        }
    }
}
    