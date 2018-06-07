<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="game1.aspx.cs" Inherits="VitutalPet___Tamagotchi.game1" %>

<!DOCTYPE html>

<audio autoplay loop id="audio4">
  <source src="/Person/audio4.mp3">
</audio>
<html>
    <head>
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
		<style type="text/css">
			canvas {
			  border: 1px solid #000000;
			}
		</style>

    </head>   
    <body onload="inicializar()" style="background-image: url('/Person/wallpaper.jpg'); background-size: cover; background-attachment: fixed;">
		<canvas id="canvas" width="400" height="500">
			Navegador não suporta HTML5
		</canvas>
		
		<script type="text/javascript">
		
			var barraAltura, barraLargura, jogadorPosicaoX, velocidadeJogador, pontosJogador;
		
			var diametros = new Array(
				{'diametro' : 7, 'pontos' : 1},
				{'diametro' : 10, 'pontos' : 2},
				{'diametro' : 15, 'pontos' : 3}
			);
			
			function bola()
			{
				var index = Math.round(Math.random() * (3 - 1) + 1) - 1;
                this.bolaDiametro = diametros[index]['diametro'];
				this.pontos = diametros[index]['pontos'];
				
                this.bolaPosX = Math.random() * 600;
                this.bolaPosY = -10;
				this.velocidadeBola = Math.random() * (10 - 6) + 6;
				this.colisao = false;
			}
		
			function inicializar()
			{
				barraAltura = 15;
				barraLargura = 110;
				
				pontosJogador = 0;
				jogadorPosicaoX = (canvas.width - barraLargura) / 2;
				velocidadeJogador = 30;
				
				canvas = document.getElementById("canvas");
				context = canvas.getContext("2d");				
				
				primeira = new bola()
				bolas = new Array(primeira);
				
				document.addEventListener('keydown', keyDown);
				
				setInterval(gameLoop, 30);
			}
			
			function keyDown(e) 
			{
				if(e.keyCode == 37)
				{
					if(jogadorPosicaoX > 0)
					{
						jogadorPosicaoX -= velocidadeJogador;
					}
				}
				
				if(e.keyCode == 39)
				{
					if(jogadorPosicaoX < (canvas.width - barraLargura))
					{
						jogadorPosicaoX += velocidadeJogador;
					}
				}
			}
			
			function gameLoop()
			{
				//Limpa Tela
				context.clearRect(0, 0, canvas.width, canvas.height);
				
				// Checar bolas
				if(bolas.length <= 0)
				{
					bolas.push(new bola());
				}
				
				// Bolas				
				bolas.forEach(function(b, index)
				{
					context.beginPath();
	                context.arc(b.bolaPosX, b.bolaPosY, b.bolaDiametro, 0, Math.PI * 2, true);
	                context.fill();
					
					// Criar nova bola?
					if(b.bolaPosY >= 50 && bolas.length <= 2)
					{
						bolas.push(new bola());
					}
					
					if(b.bolaPosY <= canvas.height)
					{
						b.bolaPosY += b.velocidadeBola;
					}
					else
					{
						bolas.splice(index, 1);
					}
					
					// Checar Colisão
					if((b.bolaPosX > jogadorPosicaoX && b.bolaPosX < jogadorPosicaoX + barraLargura) && b.bolaPosY >= canvas.height - barraAltura && b.colisao == false)
					{
						pontosJogador += b.pontos;
						b.colisao = true;
					}
				});
				
				// Escreve placar
                context.font = "32pt Tahoma";
				context.fillText(pontosJogador, canvas.width - 70, 50);
				
				// Jogador
				context.fillRect(jogadorPosicaoX, canvas.height - barraAltura, barraLargura, barraAltura);
			}
			
		</script>
		
	</body>
</html>
