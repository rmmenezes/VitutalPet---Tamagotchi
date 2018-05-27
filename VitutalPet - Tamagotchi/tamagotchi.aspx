<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tamagotchi.aspx.cs" Inherits="VitutalPet___Tamagotchi.tamagotchi" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="15"/>
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
    <link href="https://fonts.googleapis.com/css?family=Skranji" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Chewy" rel="stylesheet" />
    <!-- font-family: 'Chewy', cursive; -->
    <link rel='stylesheet' href='css/normalize.css'/>
    <link rel="stylesheet" href="css/homer.css" />
    <link rel='stylesheet' href='css/bart.css' />

</head>
<body id="background" runat="server">
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-default">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" style="float: right;" class="btn btn-default navbar-btn">Sign out</button>
                        <a class="navbar-brand" href="#">Tamagotchi</a>
                    </div>
                </div>
                <!-- /.container-fluid -->
            </nav>

           <%= Homer() %>

            <div class="container">
                <div class="row">

                    <div class="col-md-3" style="text-align:center">
                        <h3>Vitalidade</h3>
                        <div class="progress">
                            <div runat="server" class="progress-bar progress-bar-warning" id="barra_vida" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-3"  style="text-align:center">
                        <h3>Fome</h3>
                        <div class="progress">
                            <div runat="server" class="progress-bar progress-bar-warning" id="barra_fome" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <asp:ImageButton ImageUrl="/Person/food1.png" runat="server" ID="food1" OnClick="GiveFood" CssClass="img-circle active" width="50" height="50" />
                        <asp:ImageButton ImageUrl="/Person/food2.png" runat="server" ID="food2" OnClick="GiveFood" CssClass="img-circle active" width="50" height="50" />
                        <asp:ImageButton ImageUrl="/Person/food3.gif" runat="server" ID="food3" OnClick="GiveFood" CssClass="img-circle active" width="50" height="50" />
                        
                    </div>

                    <div class="col-md-3"  style="text-align:center">
                         <h3>Sono</h3>
                        <div class="progress">
                            <div runat="server" class="progress-bar" id="barra_sono" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <asp:ImageButton ImageUrl="/Person/sleep1.jpg" runat="server" CssClass="img-circle active" width="50" height="50" />                    
                        <asp:ImageButton ImageUrl="/Person/sleep2.png" runat="server" CssClass="img-circle active" width="50" height="50" />  
                   </div>

                    <div class="col-md-3"  style="text-align:center">
                        <h3>Felicidade</h3>
                        <div class="progress">
                            <div runat="server" id="barra_felicidade" class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 0%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <asp:ImageButton ImageUrl="/Person/play1.jpg" runat="server" CssClass="img-circle active" width="50" height="50" />
                        <asp:ImageButton ImageUrl="/Person/play2.jpg" runat="server" CssClass="img-circle active" width="50" height="50" />
                        <asp:ImageButton ImageUrl="/Person/play3.jpg" runat="server" OnClick="OpenGameBoll" CssClass="img-circle active" width="50" height="50" />
                    </div>
                </div>

                <footer style="position: absolute; bottom: 0px;">
                </footer>
            </div>
        </div>
        <div>
                    <p id="foot">Rafael Menezes Barboza e Jonas Felipe Alves - UTFPR Campo Mourão Paraná - (Tamagotchi in Asp.Net C#)</p>
        </div>
    </form>
</body>
</html>
