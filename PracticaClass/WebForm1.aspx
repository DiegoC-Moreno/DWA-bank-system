<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PracticaClass.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <h1 class="display-4 text-center">Bienvenido al sistema bancario </h1>
    <form id="form1" runat="server">
        <div class="pl-3 py-3 my-3 container border border-dark">
            Nombre &nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; numero de Cuenta&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="162px"></asp:TextBox>
&nbsp; fecha de vencimiento:&nbsp; mes
            <asp:TextBox ID="TextBox3" runat="server" Width="72px"></asp:TextBox>
&nbsp;&nbsp; año
            <asp:TextBox ID="TextBox4" runat="server" Width="77px"></asp:TextBox>
            <br />
            <br />
            <asp:Label Text="saldo" runat="server" />
            <asp:TextBox ID="TextBox5" runat="server" />
            &nbsp;<asp:Button ID="Button1" CssClass="btn btn-outline-info rounded" runat="server" OnClick="Button1_Click" Text="Crear Cuenta" />
 
            <br />
        </div>

        <div class="container border border-dark p-3">
            <asp:Label CssClass="text-center h3" Text="Movimientos" runat="server" />
            <br />
            <br />
            <asp:TextBox ID="monto" runat="server" />
            <asp:Button Text="Retiro" CssClass="btn btn-outline-danger rounded" ID="RetiroBtn" runat="server" OnClick="RetiroBtn_Click" />
            &nbsp;<asp:Button Text="Abono" CssClass="btn btn-outline-success rounded"  ID ="AbonoBtn" runat="server" />
            &nbsp;<asp:Label CssClass="dropdown-menu" Text="Otro movimiento" runat="server" />
            <asp:DropDownList runat="server">
                <asp:ListItem Text="cobro de cheques" />
                <asp:ListItem Text="pago a cuenta de luz" />
                <asp:ListItem Text="Transferencia" />
            </asp:DropDownList>
            &nbsp;<asp:Button Text="Realizar Transaccion" CssClass="btn btn-outline-info rounded" runat="server" OnClick="Unnamed5_Click" />
        &nbsp;</div>
        <br />
        <br />

        <div class="container border border-dark p-3">

            <asp:Label CssClass="text-center h3" ID="Label1" runat="server" Text="Estado de la Cuenta"></asp:Label>

            <br />
            <br />
            Nombre :&nbsp;
              Nombre :&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            saldo:&nbsp;<asp:Label ID="saldo" Text="$0.00"  runat="server" />
            <br />
            <asp:Label Text="Interes:" runat="server" />
            &nbsp;<asp:TextBox ID="Interes" runat="server" />

        </div>
        <br />
        <div class="container border border-dark p-3 my-3">
            <asp:Label CssClass="text-center h3" Text="Historial de acciones" runat="server" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="64px" Width="151px">
                <Columns>
                    <asp:BoundField HeaderText="Fecha y Hora" />
                    <asp:BoundField HeaderText="accion" />
                </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
