<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formTableCategoria.aspx.cs" Inherits="Loja_virtual.UI.formTableCategoria" %>


<!DOCTYPE html>  

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />

</head>
<body>
    <form id="form1" runat="server">
       <div>
             <asp:TextBox ID="TextBoxPesq" placeholder="Pesquisar por parte do nome" runat ="server"></asp:TextBox>
           <asp:Button ID="BtnPesquisar" Class="btn btn-lg btn-primary mb-4" runat="server" Text="Pesquisar" OnClick="BtnPesquisar_Click"/>
          <asp:Button ID="BtnNovo" Class="btn btn-lg btn-primary mb-4" runat="server" Text="Novo Produto" OnClick="BtnNovo_Click" />
        </div>
        
        <div>
            <asp:GridView ID="GridProdutos" AutoGenerateColumns="false"
                OnRowEditing="GridProdutos_RowEditing"
                OnRowCancelingEdit="GridProdutos_RowCancelingEdit"
               OnRowUpdating="GridProdutos_RowUpdating"
                DataKeyNames="id"
                OnRowDeleting="GridProdutos_RowDeleting" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Código">
                        <ItemTemplate>
                            <asp:Label ID="labelCod" runat="server" Text='<%# Eval("id")%>'>
                            </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <asp:Label ID="labelNome" runat="server" Text='<%# Eval("nome")%>'>
                            </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNome" Text='<%# Bind("nome")%>' runat="server">
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descrição">
                        <ItemTemplate>
                            <asp:Label ID="labelDescricao" runat="server" Text='<%# Eval("descricao")%>'>
                            </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textDesc" Text='<%# Bind("descricao")%>' runat="server">
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    

                 
               
                   <asp:CommandField ShowEditButton="true" ButtonType="Image" HeaderText="Editar" EditImageUrl="~/IMG/4.png" 
                       CancelImageUrl="~/IMG/cancelar.png" UpdateImageUrl="~/IMG/atualizar.png" runat="server">
                   </asp:CommandField>

                    <asp:CommandField ShowDeleteButton="true" ButtonType="Image" HeaderText="Excluir" DeleteImageUrl="~/IMG/5.png" runat="server">
                    </asp:CommandField>

                </Columns>

            </asp:GridView>

        </div>
    </form>
</body>
</html>