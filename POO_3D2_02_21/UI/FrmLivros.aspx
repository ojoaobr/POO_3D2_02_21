<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLivros.aspx.cs" Inherits="POO_3D2_02_21.FrmLivros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Livraria A&J</title>
    <link href="../Contents/bootstrap.css" rel="stylesheet" />
    <link href="../Contents/signin.css" rel="stylesheet" />
</head>
<body class="align-content-center">
    <form id="form1" runat="server">
            <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Livraria Arthur E. & João P</h1>

             <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
              <br />
             <asp:Label ID="lblAutor" runat="server" Text="Autor: "></asp:Label>
             <asp:TextBox ID="txtAutor" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblEditora" runat="server" Text="Editora: "></asp:Label>
             <asp:TextBox ID="txtEditora" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblTitulo" runat="server" Text="Título: "></asp:Label>
             <asp:TextBox ID="txtTitulo" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblData" runat="server" Text="Data de Cadastro: "></asp:Label>
             <asp:TextBox ID="txtData" type="date" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblPaginas" runat="server" Text="Número de Páginas: "></asp:Label>
             <asp:TextBox ID="txtPaginas" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

              <asp:Label ID="lblPreco" runat="server" Text="Preço do Livro: "></asp:Label>
              <asp:TextBox ID="txtPreco" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

                <asp:Button ID="btnGravar" class="btn btn-md btn-primary" runat="server" Text="Gravar" OnClick="btnGravar_Click" />

       <br />
                <asp:GridView ID="GridLivros"  CssClass="table-responsive-sm" runat="server" OnRowDeleting="GridLivros_RowDeleting" OnRowCancelingEdit="GridLivros_RowCancelingEdit" OnRowEditing="GridLivros_RowEditing" OnRowUpdating="GridLivros_RowUpdating" AllowPaging="True" OnPageIndexChanging="GridLivros_PageIndexChanging" PageSize="5">

                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" UpdateText="Gravar" />
                    </Columns>
                    <PagerSettings Position="TopAndBottom" />
                </asp:GridView>
      
        </div>
  
    </form>
</body>
</html>
