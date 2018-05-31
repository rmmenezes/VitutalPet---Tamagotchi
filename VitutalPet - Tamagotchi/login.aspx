<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="VitutalPet___Tamagotchi.login" %>

<!DOCTYPE html>

<audio autoplay loop id="audio">
  <source src="/Person/audio.mp3">
</audio>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>VIRTUAL PET</title>
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

</head>

<body runat="server" id="background" style="background-color: #ffd700;">
    <div class="container droppedHover" style="width: 350px">
        <h1 style="text-align: center; font-family: 'Chewy', cursive; font-size: 70px">Os Simpsons</h1>
        <h1 style="text-align: center; font-family: 'Chewy', cursive; font-size: 30px">Tamagotchi Game</h1>
        <form class="form-signin" role="form" runat="server">
            <p>Login:</p>
            <asp:TextBox runat="server" id="username" Text="" CssClass="form-control"  required="true"/>
            <p>Senha:</p>
          
            <asp:TextBox runat="server" id="password" CssClass="form-control" TextMode="Password" Text=""  required="true"/>
            <br />
            <asp:Button Text="Sign in" runat="server" CssClass="btn btn-lg btn-success btn-block" OnClick="Btn_Entrar" />
            <asp:Button Text="Create an account" runat="server" CssClass="btn btn-lg btn-primary btn-block" OnClick="Btn_Cadastrar"  />

        </form>

        <footer>
            <br />
            <p style="text-align: center;">Rafael Menezes Barboza e Jonas Felipe Alves UTFPR Campo Mourão Paraná</p>
        </footer>
    </div>

</body>
</html>
