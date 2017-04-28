<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarDatos.aspx.cs" Inherits="Mapas.IngresarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblNombre" runat="server">Nombre</asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TxtNombre" runat="server">Nombre</asp:TextBox>        
        </div>
        <div>
            <asp:Label ID="LabPais" runat="server">Pais</asp:Label>
            <asp:DropDownList ID="DrlPais" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DrlPais_SelectedIndexChanged" ></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="LabCiudad" runat="server">Ciudad</asp:Label>
            <asp:DropDownList ID="DrlCiudad" runat="server" ></asp:DropDownList>
            <%--Ojo POstback--%>
        </div>
        <div>
            <asp:Button  Id="BtnGuardar" Text="Guardar" runat="server" OnClick="BtnGuardar_Click"/>}
            <asp:Button  Id="BtnConsultar" Text="Consultar" runat="server" OnClick="BtnConsultar_Click"/>
        </div>
        <asp:GridView ID="GvUsuarios" runat="server" OnRowCommand="GvUsuarios_RowCommand">
            <Columns>
                <asp:CommandField SelectText="Eliminar" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
