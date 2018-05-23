<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicial.aspx.cs" Inherits="VitutalPet___Tamagotchi.inicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
</head>
<body runat="server" id="background" style="background-color: #ffd700;">
    <form id="form1" runat="server">
        <div class="container" >
            <h1 style="font-family: 'Chewy';"> Adcionar e Editar</h1>

            <img src="/Person/Homer.jpg " class="img-circle" width="100" height="100"/> 
            <img src="/Person/Bart.jpg " class="img-circle" width="100" height="100"/> 
            <img src="/Person/Lisa.jpg " class="img-circle" width="100" height="100"/> 
            <img src="/Person/Maggie.jpg " class="img-circle" width="100" height="100"/> 
            <img src="/Person/Marge.jpg " class="img-circle" width="100" height="100"/> 
            <img src="/Person/Ned.jpg " class="img-circle" width="100" height="100"/> 
            <br />
            <h3>Nome do Tamagotchi:</h3>
            <asp:TextBox runat="server" id="nomePet" Text="" CssClass="form-control"/>
            <br />
            <asp:Button Text="+" runat="server" id="addTamagotchi" CssClass="btn btn-lg btn-success btn-block" OnClick="Tamagotchiadd"/>

            <h1 style="font-family: 'Chewy';"> Ranking</h1>
            <br />


        </div>
    </form>
</body>
</html>
