<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tamagotchi.aspx.cs" Inherits="VitutalPet___Tamagotchi.tamagotchi" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="15">
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
    <link rel="stylesheet" href="css/bart.css" />

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


            <div id="bart">
                <div class="head">
                    <div class="no-border body hair hair1"></div>
                    <div class="no-border body hair hair2"></div>
                    <div class="no-border body hair hair3"></div>
                    <div class="no-border body hair hair4"></div>
                    <div class="no-border body hair hair5"></div>
                    <div class="no-border body hair hair6"></div>
                    <div class="no-border body hair hair7"></div>
                    <div class="no-border body hair hair8"></div>
                    <div class="no-border body hair hair9"></div>
                    <div class="body mouth-lip2"></div>
                    <div class="no-border body head-left1"></div>
                    <div class="no-border body head-left2"></div>
                    <div class="no-border body head-left3"></div>
                    <div class="no-border body head-left4"></div>
                    <div class="no-border body head-left5"></div>
                    <div class="no-border body head-left6"></div>
                    <div class="no-border body head-left7"></div>
                    <div class="body eyelid"></div>
                    <div class="no-border body mouth"></div>
                    <div class="body mouth-lip"></div>
                    <div class="no-border body head-right2"></div>
                    <div class="no-border body head-right1"></div>
                    <div class="no-border body head-right3"></div>

                    <!-- The ear -->
                    <div class="body ear">
                        <div class="no-border inner1"></div>
                        <div class="no-border inner2"></div>
                        <div class="no-border body clip"></div>
                    </div>

                    <!-- The right eye -->
                    <div class="right-eye">
                        <div class="no-border right-eye-pupil"></div>
                        <div class="no-border body eyelid-top"></div>
                        <div class="no-border body eyelid-bottom"></div>
                    </div>

                    <!-- The nose -->
                    <div class="no-border body nose"></div>
                    <div class="body nose-tip"></div>

                    <!-- The left eye -->
                    <div class="left-eye">
                        <div class="no-border left-eye-pupil"></div>
                        <div class="no-border body eyelid-top"></div>
                        <div class="no-border body eyelid-bottom"></div>
                    </div>

                    <div class="no-border mouth-smile"></div>
                </div>
            </div>


            <div class="container">
                <div class="row">


                    <div class="col-md-4">
                        <h3>Vida</h3>
                        <div class="progress">
                            <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 100%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <button type="button" class="btn btn-warning">Comer :V</button>
                    </div>

                    <div class="col-md-4">
                        <h3>Fome</h3>
                        <div class="progress">
                            <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 100%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <button type="button" class="btn btn-warning">Comer :V</button>
                    </div>

                    <div class="col-md-4">
                        <h3>Sono</h3>
                        <div class="progress">

                            <div runat="server" id="barraSono" class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 50%;">
                                <span class="sr-only">60% Complete</span>
                            </div>
                        </div>
                        <asp:Button Text="Dormir" runat="server" ID="bbtDormir" OnClick="BT_dormir" CssClass="btn btn-primary" />
                    </div>
                </div>

                <footer style="position: absolute; bottom: 0px;">
                    <p>Rafael Menezes Barboza e Jonas Felipe Alves - UTFPR Campo Mourão Paraná - (Tamagotchi in Asp.Net C#)</p>
                </footer>
            </div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
