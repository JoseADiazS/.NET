<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="AppJuego.Juego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 358px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <h1 class="display-3 text-center" style="width: 800 PX;">APP JUEGO .NET TERCER CORTE</h1>

    <div class="container">
        <h1 class="display-4 text-center">CODIFICADOR DE EXPRESIONES</h1>
        <div class="table-responsive">
            <table class="table">
                <tbody>
                    <tr>
                        <td class="auto-style1">INGRESE LA EXPRESIÓN A CODIFICAR</td>
                        <td style="width: 500px;padding: 12px;">
                            <asp:TextBox ID="txtPalabraCodificar" runat="server" />

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">INGRESE LA LETRA PISTA:</td>
                        <td>
                            <asp:DropDownList runat="server" Width="43px" ID="dropListLetraPistaCod">
                                <asp:ListItem Value="a" selected="">a</asp:ListItem>
                                <asp:ListItem Value="b">b</asp:ListItem>
                                <asp:ListItem Value="c">c</asp:ListItem>
                                <asp:ListItem Value="d">d</asp:ListItem>
                                <asp:ListItem Value="e">e</asp:ListItem>
                                <asp:ListItem Value="f">f</asp:ListItem>
                                <asp:ListItem Value="g">g</asp:ListItem>
                                <asp:ListItem Value="h">h</asp:ListItem>
                                <asp:ListItem Value="i">i</asp:ListItem>
                                <asp:ListItem Value="j">j</asp:ListItem>
                                <asp:ListItem Value="k">k</asp:ListItem>
                                <asp:ListItem Value="l">l</asp:ListItem>
                                <asp:ListItem Value="m">m</asp:ListItem>
                                <asp:ListItem Value="n">n</asp:ListItem>
                                <asp:ListItem Value="ñ">ñ</asp:ListItem>
                                <asp:ListItem Value="o">o</asp:ListItem>
                                <asp:ListItem Value="p">p</asp:ListItem>
                                <asp:ListItem Value="q">q</asp:ListItem>
                                <asp:ListItem Value="r">r</asp:ListItem>
                                <asp:ListItem Value="s">s</asp:ListItem>
                                <asp:ListItem Value="t">t</asp:ListItem>
                                <asp:ListItem Value="u">u</asp:ListItem>
                                <asp:ListItem Value="v">v</asp:ListItem>
                                <asp:ListItem Value="w">w</asp:ListItem>
                                <asp:ListItem Value="x">x</asp:ListItem>
                                <asp:ListItem Value="y">y</asp:ListItem>
                                <asp:ListItem Value="z">z</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Button id="btnCodificarText" Text="Codificar Expresión" runat="server" OnClick="btnCodificarText_Click"/>
                        </td>
                        <td>
                            <button>Limpiar el Codificador</button>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">MENSAJE CODIFICADO</td>
                        <td>
                            <asp:TextBox name="mensaje" id="mensajeCodificado" Columns="1" MaxLength="30" runat="server" Height="139px" Width="467px"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class="container">
        <h1 class="display-4 text-center">CODIFICADOR DE EXPRESIONES</h1>
        <div class="table-responsive">
            <table class="table">
                <tbody>
                    <tr>
                        <td>MENSAJE CODIFICADO</td>
                        <td><asp:TextBox name="mensaje" id="cadenaADecodificar" Columns="1" MaxLength="200" runat="server" Height="139px" Width="467px"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td>INGRESE LA LETRA PISTA:</td>
                        <td>
                            <asp:DropDownList runat="server" Width="43px" ID="dropListLetraPistaDecod">  
                                <asp:ListItem Value="a" selected="">a</asp:ListItem>
                                <asp:ListItem Value="b">b</asp:ListItem>
                                <asp:ListItem Value="c">c</asp:ListItem>
                                <asp:ListItem Value="d">d</asp:ListItem>
                                <asp:ListItem Value="e">e</asp:ListItem>
                                <asp:ListItem Value="f">f</asp:ListItem>
                                <asp:ListItem Value="g">g</asp:ListItem>
                                <asp:ListItem Value="h">h</asp:ListItem>
                                <asp:ListItem Value="i">i</asp:ListItem>
                                <asp:ListItem Value="j">j</asp:ListItem>
                                <asp:ListItem Value="k">k</asp:ListItem>
                                <asp:ListItem Value="l">l</asp:ListItem>
                                <asp:ListItem Value="m">m</asp:ListItem>
                                <asp:ListItem Value="n">n</asp:ListItem>
                                <asp:ListItem Value="ñ">ñ</asp:ListItem>
                                <asp:ListItem Value="o">o</asp:ListItem>
                                <asp:ListItem Value="p">p</asp:ListItem>
                                <asp:ListItem Value="q">q</asp:ListItem>
                                <asp:ListItem Value="r">r</asp:ListItem>
                                <asp:ListItem Value="s">s</asp:ListItem>
                                <asp:ListItem Value="t">t</asp:ListItem>
                                <asp:ListItem Value="u">u</asp:ListItem>
                                <asp:ListItem Value="v">v</asp:ListItem>
                                <asp:ListItem Value="w">w</asp:ListItem>
                                <asp:ListItem Value="x">x</asp:ListItem>
                                <asp:ListItem Value="y">y</asp:ListItem>
                                <asp:ListItem Value="z">z</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button id="btnDecodificarText" Text="Decodificar Expresión" runat="server" OnClick="btnDecodificarText_Click" />
                        </td>
                        <td>
                            <button>Limpiar el Decodificador</button>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 500px;">MENSAJE DECODIFICADO</td>
                        <td style="width: 500px;padding: 12px;">
                            <asp:TextBox ID="txtDecodificacion" runat="server" /></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    </form>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
