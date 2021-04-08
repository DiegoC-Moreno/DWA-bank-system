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
            &nbsp;<asp:Button Text="Abono" CssClass="btn btn-outline-success rounded"  ID ="AbonoBtn" runat="server" OnClick="AbonoBtn_Click1" />
            &nbsp;<asp:Label CssClass="dropdown-menu" Text="Otro movimiento" runat="server" />
            <asp:DropDownList  ID="transacciones" runat="server">
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
            
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            saldo:&nbsp;<asp:Label ID="saldo" Text="$0.00"  runat="server" />
            <br />
            numero de Cuenta:
            <asp:Label ID="Cuentalbl" runat="server" Text="Label"></asp:Label>
            <br />
            fecha de vencimiento:<asp:Label ID="fechaVencimiento" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Monto:
            <asp:TextBox ID="montoInteres" runat="server"></asp:TextBox>
            <br />
            tiempo<asp:DropDownList ID="tiempo" runat="server">
                <asp:ListItem>dia</asp:ListItem>
                <asp:ListItem>mes </asp:ListItem>
                <asp:ListItem>año</asp:ListItem>
            </asp:DropDownList>
&nbsp; <asp:Label Text="cantidad" runat="server" />:
            <asp:TextBox ID="cantidadDays" runat="server" Width="57px"></asp:TextBox>
            &nbsp;
            <br />
            <asp:Label Text="Interes:" runat="server" />
            &nbsp;<asp:TextBox ID="Interes" runat="server" Width="188px" />

            <asp:Button CssClass="btn btn-outline-info rounded" ID="Button2" runat="server" Text="Button" Width="59px" OnClick="Button2_Click" />

            <br />
            <asp:Label ID="calcInteres" Text="Calculo de interes es de: " runat="server" />
        </div>
        <br />
        <div class="container border border-dark p-3 my-3">
            <asp:Label CssClass="text-center h3" Text="Historial de acciones" runat="server" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="64px" Width="335px">
                <Columns>
                    <asp:BoundField HeaderText="Fecha y Hora" DataField="Fecha y hora" />
                    <asp:BoundField HeaderText="accion" DataField="accion" />
                </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
