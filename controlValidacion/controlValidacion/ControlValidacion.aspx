<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ControlValidacion.aspx.vb" Inherits="controlValidacion.ControlValidacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Controles de validación</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="alert alert-primary ">
                <div class="row ">
                    <div class="col-4"></div>
                    <div class="col-1"></div>
                    <div class="col-3">
                        <asp:Label ID="NombrePagina" runat="server" Text="Controles de validación" BorderColor="Black" Font-Size="16pt" ForeColor="Black"></asp:Label>
                    </div>
                    <div class="col-4"></div>
                </div>
            </div>
            
            <div class="row">
                <div class="col-12">
                    <p class="text-center">Llene el formulario con los siguientes datos</p>
                </div>
                <div class="col-2"></div>
                <div class="col-4">
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Nombre" Font-Size="12px"></asp:Label>
                    <asp:TextBox ID="TxtNombre" runat="server" Font-Size="12px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Apellido" Font-Size="12px"></asp:Label>
                    <asp:TextBox ID="TxtApellido" runat="server" Font-Size="12px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Nacionalidad" Font-Size="12px"></asp:Label>

                    <asp:DropDownList ID="CbxNcionalidad" runat="server" Font-Size="12px">
                        <asp:ListItem>colombia</asp:ListItem>
                        <asp:ListItem>Mexico</asp:ListItem>
                        <asp:ListItem>EEUU</asp:ListItem>
                        <asp:ListItem>Canada</asp:ListItem>
                        <asp:ListItem>brazil</asp:ListItem>
                        <asp:ListItem>argentina</asp:ListItem>
                    </asp:DropDownList>

                </div>
                <div class="col-5">
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="correo electronico" Font-Size="12px"></asp:Label>
                    <asp:TextBox ID="TxtCorreo" runat="server" Font-Size="12px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Estado civil" Font-Size="12px"></asp:Label>

                    <asp:DropDownList ID="Cbxestado" runat="server" Font-Size="12px">
                        <asp:ListItem>soltero</asp:ListItem>
                        <asp:ListItem>union libre</asp:ListItem>
                        <asp:ListItem>casado</asp:ListItem>

                    </asp:DropDownList>
                </div>

                <div class="col-1"></div>
                <br />
                <br />
                <div class="col-5"></div>
                <div class="col-2">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" class="alert-dark" />
                </div>
                <div class="col-5"></div>
                <br />
                <br />
                <br />  
                <br />
                <div class="col-3"></div>
                <div class="col-6">


                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="617px">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                            <asp:BoundField DataField="Nacionalidad" HeaderText="Nacionalidad" SortExpression="Nacionalidad" />
                            <asp:BoundField DataField="Estadocivil" HeaderText="Estadocivil" SortExpression="Estadocivil" />
                            <asp:BoundField DataField="CorreoElectronico" HeaderText="CorreoElectronico" SortExpression="CorreoElectronico" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:controlValidacion.My.MySettings.Conexion %>" SelectCommand="SELECT * FROM [Persona]"></asp:SqlDataSource>
                    


                 </div>
                <div class="col-3"></div>
            </div>        
        </form>
    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
