<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fomrPerfilAdm.aspx.cs" Inherits="Loja_virtual.UI.fomrPerfilAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <nav>
        <div>
            <ul>
                <li>
                    <asp:HyperLink ID="HyperLinkInicial" NavigateUrl="~/UI/index.aspx" Text="Inicial" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkProdutos" NavigateUrl="~/UI/formTableProdutos.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                </li>
              <li>
                    <asp:HyperLink ID="Hyperclientes" NavigateUrl="~/UI/formTableClientes.aspx" Text="Clientes" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperCategoria" NavigateUrl="~/UI/formTableCategoria.aspx" Text="Categoria" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkfornecedores" NavigateUrl="~/UI/formTableFornecedores.aspx" Text="Fornecedores" runat="server"></asp:HyperLink>
                </li>
            </ul>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
