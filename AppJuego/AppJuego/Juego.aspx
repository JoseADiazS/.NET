<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="AppJuego.Juego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Content/Site.css" rel="stylesheet" type="text/css">
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/jquery.signalR-2.2.0.min.js"></script>
    <script src="signalr/hubs"></script>
    <script src="app/app.js"></script>
</head>
<body>
    <div class="container">
        <div class="row">
            <!-- Chat users list -->
            <div class="col-xs-4 col-md-2">
                <div class="panel panel-default">
                    <div class="panel-heading" id="onlineUsersCount">Online users: 0</div>
                    <div class="panel-body panel-fixed-height">
                        <ul id="userList"></ul>
                    </div>
                </div>
            </div>

            <!--Chat window-->
            <div class="col-xs-8 col-md-10" id="chatPanel">
                <div class="panel panel-default">
                    <div class="panel-heading">Users' messages:</div>
                    <div class="panel-body panel-fixed-height">
                        <ul id="messagesArea"></ul>
                    </div>
                </div>
                <div class="input-group">
                    <input type="text" class="form-control" id="userMessage" placeholder="Write your message">
                    <span class="input-group-btn">
                        <a class="btn btn-default" id="btnSendMessage">Send!</a>
                    </span>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />

    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

        </div>
        <asp:UpdatePanel ID="updatepnl" runat="server">
            <ContentTemplate>
                <h1 class="display-3 text-center" style="width: 800 PX;">APP JUEGO .NET TERCER CORTE</h1>
                <h1 class="display-4 text-center">CODIFICADOR DE EXPRESIONES</h1>
                <div class="container bg-info">
                    <div class="table-responsive">
                        <table class="table">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">INGRESE LA EXPRESIÓN A CODIFICAR</td>
                                    <td style="width: 500px; padding: 12px;">
                                        <asp:TextBox ID="txtPalabraCodificar" runat="server" />

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">INGRESE LA LETRA PISTA:</td>
                                    <td>
                                        <!-- DataSource -->
                                        <asp:DropDownList runat="server" Width="43px" ID="dropListLetraPistaCod">
                                            <asp:ListItem Value="a" Selected="">a</asp:ListItem>
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
                                        <asp:Button ID="btnCodificarText" Text="Codificar Expresión" runat="server" OnClick="btnCodificarText_Click" autopostback="true" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnLimpiarCodificador" runat="server" Text="Limpiar el Decodificador" OnClick="btnLimpiarCodificador_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">MENSAJE CODIFICADO</td>
                                    <td>
                                        <asp:TextBox name="mensaje" ID="mensajeCodificado" Columns="1" MaxLength="30" runat="server" Height="139px" Width="467px"></asp:TextBox>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <h1 class="display-4 text-center">DECODIFICADOR DE EXPRESIONES</h1>
                <div class="container bg-info">
                    <div class="table-responsive">
                        <table class="table">
                            <tbody>
                                <tr>
                                    <td class="auto-style2">MENSAJE CODIFICADO</td>
                                    <td>
                                        <asp:TextBox name="mensaje" ID="cadenaADecodificar" Columns="1" MaxLength="200" runat="server" Height="139px" Width="467px"></asp:TextBox></td>
                                </tr>

                                <tr>
                                    <td class="auto-style2">INGRESE LA LETRA PISTA:</td>
                                    <td>
                                        <asp:DropDownList runat="server" Width="43px" ID="dropListLetraPistaDecod">
                                            <asp:ListItem Value="a" Selected="">a</asp:ListItem>
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
                                    <td class="auto-style2">
                                        <asp:Button ID="btnDecodificarText" Text="Decodificar Expresión" runat="server" OnClick="btnDecodificarText_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnLimpiarDeco" runat="server" Text="Limpiar el Decodificador" OnClick="btnLimpiarDeco_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">MENSAJE DECODIFICADO</td>
                                    <td style="width: 500px; padding: 12px;">
                                        <asp:TextBox ID="txtDecodificacion" runat="server" /></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
