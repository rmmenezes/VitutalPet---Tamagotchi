﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tamagotchi.aspx.cs" Inherits="VitutalPet___Tamagotchi.tamagotchi" %>

<!DOCTYPE html>

<audio autoplay loop id="audio3">
  <source src="/Person/audio3.mp3">
</audio>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="refresh" content="500" />
    <title>VIRTUAL PET</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="https://afeld.github.io/emoji-css/emoji.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Kavivanar" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Skranji" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Chewy" rel="stylesheet" />
    <!-- font-family: 'Chewy', cursive; -->
    <link href="https://fonts.googleapis.com/css?family=Fredoka+One" rel="stylesheet" />
    <!-- font-family: 'Fredoka One', cursive; -->
    <link rel="stylesheet" href="css/homer.css" />
    <link rel="stylesheet" href="css/lisa.css" />
    <link rel="stylesheet" href="css/bart.css" />
    <link rel="stylesheet" href="css/marge.css" />
    <link rel="stylesheet" href="css/maggie.css" />
    <link rel="stylesheet" href="css/ned-flanders.css" />
    <link rel="stylesheet" href="css/normalize.css" />


</head>
<body runat="server" id="ola" style="background-image: url(/Person/background_dia.jpg)">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <asp:Label Text="text" ID="perso" runat="server" style="font-size:20px"/>
            <asp:Button Text="Voltar"  runat="server" CssClass="btn btn-danger btn-sm" style="text-align:right; float:right;" OnClick="Voltar" />
            <asp:Button Text="Remover"  runat="server" CssClass="btn btn-warning btn-sm" style="text-align:right; float:right;" OnClick="RemoverTamagotchi" />
            <br />
            <%= Homer() %>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="container">
                                <asp:Label Text="estado_label" ID="estado_label" Style="font-family: 'Fredoka One', cursive; font-size: 20px;" runat="server" />
                        <br />
                        <div class="row">
                            <div class="col-md-3" style="text-align: center">
                                <h3 style="font-family: 'Fredoka One', cursive; font-size: 22px;">Vitalidade</h3>
                                <div class="progress">
                                    <div class="progress-bar progress-bar-success" id="barra_vida" runat="server" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                                </div>
                                <asp:ImageButton ImageUrl="/Person/Life/life1.png" runat="server" OnClick="Remedio" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Life/life2.png" runat="server" OnClick="Banho" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Life/life3.png" runat="server" OnClick="Malhar" CssClass="img-circle active" Width="50" Height="50" />
                            </div>

                            <div class="col-md-3" style="text-align: center">
                                <h3 style="font-family: 'Fredoka One', cursive; font-size: 22px;">Alimentação</h3>
                                <div class="progress">
                                    <div class="progress-bar progress-bar-danger" id="barra_fome" runat="server" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                                </div>
                                <asp:ImageButton ImageUrl="/Person/Foods/food1.png" runat="server" OnClick="Donuts" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Foods/food2.png" runat="server" OnClick="Frango" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Foods/food3.png" runat="server" OnClick="Cerveja" CssClass="img-circle active" Width="50" Height="50" />
                            </div>

                            <div class="col-md-3" style="text-align: center">
                                <h3 style="font-family: 'Fredoka One', cursive; font-size: 22px;">Energia</h3>
                                <div class="progress">
                                    <div runat="server" class="progress-bar progress-bar-warning" id="barra_sono" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                                </div>
                                <asp:ImageButton ImageUrl="/Person/Sleep/sleep1.png" id="dormir" runat="server" OnClick="Cama" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Sleep/sleep2.png" runat="server" OnClick="Sofa" CssClass="img-circle active" Width="50" Height="50" />
                            </div>

                            <div class="col-md-3" style="text-align: center">
                                <h3 style="font-family: 'Fredoka One', cursive; font-size: 22px;">Felicidade</h3>
                                <div class="progress">
                                    <div runat="server" id="barra_felicidade" class="progress-bar " role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                                </div>
                                <asp:ImageButton ImageUrl="/Person/Play/play1.png" runat="server" OnClick="OpenGameBoll" CssClass="img-circle active" Width="50" Height="50" />
                                <asp:ImageButton ImageUrl="/Person/Play/play2.png" runat="server" OnClick="WatchYoutube" CssClass="img-circle active" Width="50" Height="50" />
                            </div>
                        </div>
                        &nbsp;
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div style="text-align: center; position: absolute; bottom: 0; width: 100%;">
            <p id="foot">Rafael Menezes Barboza e Jonas Felipe Alves - UTFPR Campo Mourão Paraná - (Tamagotchi in Asp.Net C#)</p>
        </div>
    </form>
</body>
</html>
