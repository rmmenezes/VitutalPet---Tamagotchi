<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="VitutalPet___Tamagotchi.Ranking" %>

<!DOCTYPE html>

<audio autoplay loop id="audio5">
  <source src="/Person/audio5.mp3">
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
<body style="background-color: #ffd700;">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <asp:Button Text="Sair"  runat="server" CssClass="btn btn-danger btn-sm" style="text-align:right; float:right;" OnClick="Sair"/>
            <h1 style="font-family: 'Chewy', cursive; text-align:center; font-size:50px;">Os Melhores - Ranking</h1>
            <br />
        <div>
            <% var cursor = ListarRanking(); %>
            <% int cont = 0; %>
            <% if (cursor != null){ %>
            <% foreach (VitutalPet___Tamagotchi.Models.Tamagotchi pet in cursor)
                {%>
            <br />
            <div style="border-radius: 10px 20px; border-bottom-style: solid; padding-top: 0.7em; background-color: aliceblue; padding-bottom: 0.7em;">
                <div class="row">
                    <div class="col-md-2" style="text-align: center">
                        <a href="tamagotchi.aspx?tamagotchinome=<%= ReturnDado(cursor[cont].Nome_Tamagotchi)%>&personagem=<%= ReturnDado(cursor[cont].Personagem) %>">&nbsp;<img src="<%= ReturnCaminho(cursor[cont].Personagem)%>" alt="Kuriten" class="img-circle" style="width: 100px; height: 100px;" /></a>
                    </div> 
                    <div class="col-md-4">
                        <h4>Nome Tamagotchi: <%= ReturnDado(cursor[cont].Nome_Tamagotchi)%> - Nivel: <%= ReturnDado(cursor[cont].Nivel.ToString()) %></h4>
                        <h4>Usuario: <%= ReturnDado(cursor[cont].Nome_User)%></h4>
                        <p>Nome Personagem: <%= ReturnDado(cursor[cont].Personagem)%> </p>
                        <p>Estado: <%= ReturnDado(cursor[cont].Estado)%> </p>
                        <% cont = cont + 1; %>
                    </div>
                    <div class="col-md-4"></div>
                </div>
            </div>
            <% } %>
                

            <% } %>
            <% else
            { %>
            <h5>OPS, Parece que ainda nao temos ranking...</h5>
            <%} %>
        </div>
        </div>
    </form>
</body>
</html>
