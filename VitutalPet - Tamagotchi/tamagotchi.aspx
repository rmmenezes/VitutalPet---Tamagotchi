<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tamagotchi.aspx.cs" Inherits="VitutalPet___Tamagotchi.tamagotchi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>VIRTUAL PET</title>
     <!-- Latest compiled and minified CSS -->
 	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

 	<!-- Optional theme -->
 	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

 	<!-- Latest compiled and minified JavaScript -->
 	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
 	<link href="https://afeld.github.io/emoji-css/emoji.css" rel="stylesheet">
     
    <link href="https://fonts.googleapis.com/css?family=Kavivanar" rel="stylesheet"> 
    <link href="https://fonts.googleapis.com/css?family=Skranji" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <body>
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
                <div align="center">
                    <i class="em em-angry" style="font-size: 10em;"></i>
                </div>

                <div class="container">
                    <div class="row">
                        <div class="col-md-4" align="center">
                            <h3 align="center">Vida</h3>
                            <div class="progress">
                                <div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 100%;">
                                    <span class="sr-only">60% Complete</span>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-4" align="center">
                            <h3 align="center">Fome</h3>
                            <div class="progress">
                                <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 100%;">
                                    <span class="sr-only">60% Complete</span>
                                </div>
                            </div>
                            <button type="button" class="btn btn-warning">Comer :V</button>
                        </div>

                        <div class="col-md-4" align="center">
                            <h3 align="center">Sono</h3>
                            <div class="progress">
                                <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 50%;">
                                    <span class="sr-only">60% Complete</span>
                                </div>
                            </div>
                            <input type="type" name="name" value="" />
                            <button type="button" class="btn btn-primary">Dormir zZ</button>
                            <asp:Label Text="Professor" runat="server" ID="Subtitulo" />
                            <asp:Button Text="Dormir" runat="server" ID="bbtDormir" OnClick="bbtDormir_Click" />
                        </div>
                    </div>

                    <footer style="position: absolute; bottom: 0px;">
                        <p align="center">Rafael Menezes Barboza e Jonas Felipe Alves - UTFPR Campo Mourão Paraná - (Tamagotchi in Asp.Net C#)</p>
                    </footer>
                </div>
            </div>
            <div>
            </div>
    </form>
</body>
</html>
