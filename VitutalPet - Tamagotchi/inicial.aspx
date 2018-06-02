<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicial.aspx.cs" Inherits="VitutalPet___Tamagotchi.inicial" %>

<!DOCTYPE html>

<audio autoplay loop id="audio2">
    <source src="/Person/audio2.mp3">
</audio>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="https://afeld.github.io/emoji-css/emoji.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Kavivanar" rel="stylesheet" />
    <!-- Latest compiled and minified JavaScript -->
    <link href="https://fonts.googleapis.com/css?family=Skranji" rel="stylesheet" />
    <!-- Latest compiled and minified JavaScript -->
    <link href="https://fonts.googleapis.com/css?family=Chewy" rel="stylesheet" />
    <!-- font-family: 'Chewy', cursive; -->
    <link href="https://fonts.googleapis.com/css?family=Baloo+Bhai" rel="stylesheet" />
    <!-- font-family: 'Baloo Bhai', cursive; -->
    <link href="https://fonts.googleapis.com/css?family=Fredoka+One" rel="stylesheet" />
    <!-- font-family: 'Fredoka One', cursive; -->
</head>
<body runat="server" id="background" style="background-color: #ffd700;">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <asp:Label ID="bemvindo" runat="server" Style="font-family: 'Fredoka One', cursive; font-size: 20px; text-align: center" />
            <br />
            <div style="text-align: center">
                <asp:ImageButton ImageUrl="/Person/Homer.jpg" runat="server" ID="homer" CssClass="img-circle active" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <asp:ImageButton ImageUrl="/Person/Bart.jpg" runat="server" ID="bart" CssClass="img-circle" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <asp:ImageButton ImageUrl="/Person/Lisa.jpg" runat="server" ID="lisa" CssClass="img-circle" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <asp:ImageButton ImageUrl="/Person/Maggie.jpg" runat="server" ID="maggie" CssClass="img-circle" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <asp:ImageButton ImageUrl="/Person/Marge.jpg" runat="server" ID="marge" CssClass="img-circle" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <asp:ImageButton ImageUrl="/Person/Ned.jpg" runat="server" ID="ned" CssClass="img-circle" BorderStyle="None" BorderWidth="5" Width="100" Height="100" OnClick="SelectPersonagem" />
                <br />
                <asp:Label runat="server" Text="[ Selecione um personagem ]" ID="personagem" Style="font-family: 'Fredoka One', cursive; font-size: 20px" />
            </div>
            <h3 style="font-family: 'Fredoka One', cursive;">Nome do Tamagotchi:</h3>
            <asp:TextBox runat="server" ID="nomePet" Text="" CssClass="form-control" />
            <br />
            <asp:Button Text="+ Adicionar +" runat="server" ID="addTamagotchi" CssClass="btn btn-lg btn-success btn-block" OnClick="Tamagotchiadd" />
            <br />

            <% var cursor = Ranking(); %>
            <% int cont = 0; %>
            <% foreach (VitutalPet___Tamagotchi.Models.Tamagotchi pet in cursor)
                {%>

            <div class="card">
                <div class="row" style="border: solid 2px; padding-top: 0.7em; padding-bottom: 0.7em;">
                    <div class="col-md-2">
                        <a href='<%= ReturnDado(cursor[cont].Nome_Tamagotchi)%>'>
                            <img src="<%= ReturnCaminho(cursor[cont].Personagem)%>" alt="Kuriten" class="img-circle" style="width: 100px; height: 100px;" />
                        </a>
                    </div>
                    <div class="col-md-4">
                        <h4>Nome Tamagotchi: <%= ReturnDado(cursor[cont].Nome_Tamagotchi)%> </h4>
                        <p>Nome User: <%= ReturnDado(cursor[cont].Nome_User)%> </p>
                        <p>Nome Personagem: <%= ReturnDado(cursor[cont].Personagem)%> </p>
                        <% cont = cont + 1; %>
                    </div>
                </div>
                <br />
            </div>

            <% } %>
        </div>
    </form>
</body>
</html>
