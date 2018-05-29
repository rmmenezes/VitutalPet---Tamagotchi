<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="youtube.aspx.cs" Inherits="VitutalPet___Tamagotchi.youtube" %>

<!DOCTYPE html>
<html>
<head>
    <!-- Late   st compiled and minified CSS -->
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
    <meta charset="utf-8" />

    <title>YouTube Simpsons</title>
</head>

<body style="background-image: url(/Person/background_cine.jpg);">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">   

                <div class="col-sm-2"></div>
                <div class="col-sm-8">

                    <h2 style="text-align: center; font-size: 65px; color: white; font-family: 'Chewy', cursive;">Cine Os Simpsons</h2>
                    <div class="embed-responsive embed-responsive-16by9">
                        <iframe width="560" height="315" src="https://www.youtube.com/embed/Espoimcjqgk" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
                    </div>
                </div>
                <div class="col-sm-2"></div>

            </div>
        </div>
    </form>
</body>
</html>
