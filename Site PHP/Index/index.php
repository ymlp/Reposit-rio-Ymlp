<!DOCTYPE html>
<html lang="pt-br">

<head>
	<meta charset="UTF-8">

	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <link rel="stylesheet" href="Css/s_Nav.css">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
    <script src="https://unpkg.com/aos@2.3.1/dist/aos.js"></script>

	<script type="text/javascript" src="script.js" ></script>
	<title> BitByte </title>
	<link rel="stylesheet" href="Css/index_style.css">
    <script src="JS/script.js"></script>

	<?php 
		include 'conexao.php';
	?>
</head>

<body>

<header>
	<div>
		<a href="#" class="logo"><img src="Image/Bit&Byte_Branco.png" style="margin-left:65px; margin-top:20px;"  alt="Logo"></a>
	</div>
	<div class="itens" style="margin-top:3%;">
		<ul>
			<div>
				<li><a id="Home" href="http://localhost/TCM/Index/index.php" data-selected="true" data-label-id="0">Home</a> </li>
				
			</div>	
			<div>
				<li><a id="Empresa" href="#empresa" data-selected="true" data-label-id="0">Empresa</a> </li> 
			</div>
			<div>
				<li><a id="Portifólio" href="#portifolio" data-selected="true" data-label-id="0">Portifólio</a> </li>
			</div>
			<div>
				<li><a id="Suporte" href="#suporte" data-selected="true" data-label-id="0">Suporte</a> </li>
			</div>
			<div>
				<li><a id="Contato" href="#rodape" data-selected="true" data-label-id="0">Contato</a> </li>
			</div>
			<div>
				<li><a id="Login" href="http://localhost/TCM/Login/Login.php" data-selected="true" data-label-id="0">Login</a> </li>
			</div>
		</ul>
	
	</div>
</header>

<head>

    <script src="JS/jquery-3.2.1.slim.min.js"></script>
    <script type="text/javascript" src="JS/jquery.mask.min.js"></script>
    <script type="text/javascript">			
        $(document).ready(function()
        {
            $('.ddd_tel').mask('(00) 0000-0000');				
        });
    </script>

</head>
<body>     
    <div class="banner">
            <img src="image/Fund2.png" alt="Banner" class='bgFit img-fluid'>
            <div class="cabecalho">
                <h2 >BEM VINDO Á<br> BIT&BYTE TECHNOLOGY.</h2>
            </div>
    </div>
    <div class="corpo">
        <div class="empresa" >
            <h2 class="titulo "  >SOBRE A <span>EMPRESA</span></h2>
            <hr class="linha" >
            <br>
            <div id="txt1" >
                <p >
                    A Bit & Byte foi fundada no ano de 2019 por seis alunos da ETEC Basilides de Godoy.<br><br>
                    O intuito destes seis alunos era desenvolver um sistema de gerenciamento de um restaurante<br>
                    japonês para apresentação do trabalho de conclusão do módulo.<br>
                    <br>
                </p>
            </div>                                      
            <div id="p1" data-aos="fade-up">
                <img src="Image/Imag1.png" class="img-fluid" alt="Imagem um" data-aos="fade-up">
                <div id="txt2" data-aos="fade-up">
                    <p data-aos="fade-up">
                        A idéia foi proposta pelo Professor Wellington<br>
                        Cidade, que ajudou este grupo de alunos durante<br>
                        todo o período de desenvolvimento do sistema.<br>
                    </p>
                    <br>
                    <h2 class="titulo" data-aos="fade-up" >NOSSA<span>VISÃO</span></h2>
                    <hr class="linha" data-aos="fade-up">
                    <br>
                    <p data-aos="fade-up">
                        Atender às necessidades de nossos clientes com<br>
                            qualidade, rapidez, eficiência e eficácia.<br>
                    </p>
                </div>    
            </div>
            <br>
            <hr class="linha" style=" width:60%" data-aos="fade-up"> 
            <br>
            <div class="blocos" data-aos="fade-up">
                <div class="bloco1">
                    <div class="imagem img-fluid"> <img src="Image/Objetivo.png" alt="Visão" ></div>
                    <div class="texto">
                        <h2 class="titulo"  >NOSSO <span>OBJETIVO</span></h2>
                        <p >
                            Atender às necessidades de<br>
                            nossos clientes com<br>
                            qualidade, rapidez, eficiência<br>
                            e eficácia.<br>
                        </p>
                    </div>                      
                </div>
                <div class="bloco2" data-aos="fade-up">
                    <div class="imagem img-fluid"><img src="Image/Valores.png" alt="Valores" ></div> 
                    <div class="texto" >
                        <h2 class="titulo"  >NOSSOS <span>VALORES</span></h2>
                        <p >
                            Transparência, Excelência,<br>
                            Ética profissional e<br>
                            Comprometimento.<br>
                        </p>
                    </div>                                          
                </div>                    
            </div>
        </div>     
        <a href="#"  id="transicao"></a>
        <div class="transicao" data-aos="fade-up">
            <img src="Image/Transicao.png" alt="transicao" class="fitBg2 img-fluid">
        </div>    
        <a href="#"  id="portifolio"></a>
        <div class="portifolio" data-aos="fade-up">
            <h2 class="titulo" >NOSSO <span>PORIFÓLIO</span></h2>
            <hr class="linha">
            <div class="slide">
            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner" style=" background:#000;">
                    <div class="carousel-item active">
                    <img src="Image/flayer.png" class="d-block w-5" style="margin:5px 20%; border:1px solid #fff;">
                    </div>
                    <div class="carousel-item">
                    <img src="Image/Slide1.png" class="d-block w-100">
                    </div>
                    <div class="carousel-item">
                    <img src="Image/mobile.jpeg" class="d-block w-5" style="margin:5px 20%; border:1px solid #fff;">
                    </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
                </div>
			</div>
		</div>
        <a href="#"  id="suporte"></a>
        <div class="suporte">
            <h2 class="titulo"  data-aos="fade-up" style="">SUPORTE AO <span>CLIENTE</span></h2>
            <hr class="linha" width="50%">
            <div class="contender"  data-aos="fade-up">
                <div class="form">
                    <form action="suporte.php" method="post">
                        <div class="nome">
                            <h5>Nome:</h5>
                            <input type="text" name="txtNome" class="form-control" id="txtNome">                    
                        </div>
                        <div class="email">
                            <h5>E-mail:</h5>
                            <input type="email" name="txtEmail" class="form-control" id="txtEmail">                       
                        </div>
                        <div class="tels">
                            <h5 >Telefone: </h5>
                            <input type="text" name="ddd_tel" id="ddd_tel" class="ddd_tel  form-control"  />                    
                        </div>
                        <div class="texto">
                            <h5>Como podemos ajudar:</h5>
                            <textarea row="50" col="150" class="form-control" name="txtNome" id="txtNome"></textarea>                   
                        </div>  
                        <div>
                            <input type="submit" value="ENVIAR" class="botao">
                        </div>                        
                    </form>
                </div>
                <div class="texto_sup">
                    <p>
                        A Bit & Byte disponibiliza para todos os seus clientes uma central de atendimento telefônico dás 12:00 ás 18:00 de segunda a sexta.
                        Nossa equipe de analista, consultores e programadores são altamente capacitados para sulucionar os mais diversos tipos de problemas que nossos clientes possam ter.
                        Dispomos de planos de manutenção e update para todos os nossos sistemas.
                        Nossos sistemas são customizados para atender as necessidades de nossos clientes.
                    </p>
                </div>
            </div>
        </div> 
        <a href="#"  id="rodape"></a>
        <div class="rodape" >
            <img src='Image/fundo_rodape.png' class="img-fluid bgFit3" alt="fundo Rodapé">
            <div class="row">
                <div class="col-md-3 faleConosco ">
                    <h1>FALE CONOSCO:</h1>
                    <h4>(11) 9774-8773 </h4>
                    <h3>bitandbytetec@gmail.com</h3>
                </div>
                    <hr class="linha2">
                <div class="col-md-3 redesocial">
                    <h1>CONHEÇA NOSSA <br>REDES SOCIAIS: </h1>
                    <img src="Image/FB.png" class="img_rede1" >
                    <img src="Image/IN.png" class="img_rede2" >
                    <img src="Image/ISNT.png" class="img_rede3" >
                </div>     
                    <hr class="linha3">
                <div class="col-md-2 logo" >
                    <img src="Image/logo_R.png" alt="logo Rodape" id="logo_rod" >
                </div>
            </div>      
        </div>
    </div>   
<script>
    PagLocal('#Home');
</script>
<script>    
	var x = window.matchMedia("(max-width: 700px)");
	px970(x);
	x.addListener(px970);
</script>
<script>
    $(window).scroll(function () {
        if ($(this).scrollTop() > 180) {
            $('.itens').css("background", "url(Image/Fund2.png)")
            $('.itens').css("height", "40px")
            $('.itens').css("box-shadow", "-4px 13px 30px -6px rgba(0,0,0,0.90)")
            $('header .logo').css("display", "none")
            $('.itens').css("margin-top", "-5px")
            $('.itens').css("transition", "0.3s")  
            $('.itens li').css("margin-top", "8px")
            $('.itens li').css("margin-left", "100%")
            $('.itens').css("width", "100%")
        } else {
            $('.itens li').css("margin-top", "0")
            $('.itens li').css("margin-left", "0")
            $('.itens').css("height", "0")
            $('.itens').css("background", "#0084ff00")
            $('.itens').css("box-shadow", "-4px 13px 30px -6px rgba(0,0,0,0.0)")
            $('header .logo').css("display", "flex")  
        }
    });
    $(window).scroll(function () {
        if ($(this).scrollTop() > 90) {
            $('.cabecalho').css("display", "none")
            $('.cabecalho').css("transition", "0.8s")
            $('.bgFit').css("height", "250px")
        } else {
            $('.cabecalho').css("display", "flex")
            $('.cabecalho').css("transition", "0.8s")
            $('.bgFit').css("height", "400px")
        }
    });
</script>
<script>
  AOS.init();
</script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>

  
</body>
</html>


