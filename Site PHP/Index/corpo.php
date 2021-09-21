
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
        <div class="empresa">
            <h2 class="titulo" >SOBRE A <span>EMPRESA</span></h2>
            <hr class="linha">
            <br>
            <div id="txt1">
                <p>
                    A Bit & Byte foi fundada no ano de 2019 por seis alunos da ETEC Basilides de Godoy.<br><br>
                    O intuito destes seis alunos era desenvolver um sistema de gerenciamento de um restaurante<br>
                    japonês para apresentação do trabalho de conclusão do módulo.<br>
                    <br>
                </p>
            </div>                                      
            <div id="p1">
                <img src="Image/Imag1.png" class="img-fluid" alt="Imagem um">
                <div id="txt2">
                    <p>
                        A idéia foi proposta pelo Professor Wellington<br>
                        Cidade, que ajudou este grupo de alunos durante<br>
                        todo o período de desenvolvimento do sistema.<br>
                    </p>
                    <br>
                    <h2 class="titulo" >NOSSA<span>VISÃO</span></h2>
                    <hr class="linha">
                    <br>
                    <p>
                        Atender às necessidades de nossos clientes com<br>
                            qualidade, rapidez, eficiência e eficácia.<br>
                    </p>
                </div>    
            </div>
            <br>
            <hr class="linha" style=" width:60%"> 
            <br>
            <div class="blocos">
                <div class="bloco1">
                    <div class="imagem img-fluid"> <img src="Image/Objetivo.png" alt="Visão"></div>
                    <div class="texto">
                        <h2 class="titulo" >NOSSO <span>OBJETIVO</span></h2>
                        <p>
                            Atender às necessidades de<br>
                            nossos clientes com<br>
                            qualidade, rapidez, eficiência<br>
                            e eficácia.<br>
                        </p>
                    </div>                      
                </div>
                <div class="bloco2">
                    <div class="imagem img-fluid"><img src="Image/Valores.png" alt="Valores"></div> 
                    <div class="texto">
                        <h2 class="titulo" >NOSSOS <span>VALORES</span></h2>
                        <p>
                            Transparência, Excelência,<br>
                            Ética profissional e<br>
                            Comprometimento.<br>
                        </p>
                    </div>                                          
                </div>                    
            </div>
        </div>     
        <a href="#"  id="transicao"></a>
        <div class="transicao">
            <img src="Image/Transicao.png" alt="transicao" class="fitBg2 img-fluid">
        </div>    
        <a href="#"  id="portifolio"></a>
        <div class="portifolio">
            <h2 class="titulo" >NOSSO <span>PORIFÓLIO</span></h2>
            <hr class="linha">
            <div class="slide">
                <div id="carouselExampleSlidesOnly" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">         
                        </div>
                        <div class="carousel-item">
                            <div class="carousel-caption d-none d-md-block img">
                                <h5>Gerenciador de restaurante japones</h5>
                                <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Sed, quisquam error 
                                    iure voluptate illum laborum ducimus mollitia et 
                                    cum sint voluptates, id libero repellat quos soluta perferendis sequi nisi consequatur?
                                </p>
                            </div>
                            <div class="carousel-caption d-none d-md-block img">
                                <h5>Gerenciador de restaurante japones</h5>
                                <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Sed, quisquam error 
                                    iure voluptate illum laborum ducimus mollitia et 
                                    cum sint voluptates, id libero repellat quos soluta perferendis sequi nisi consequatur?
                                </p>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img class="d-block w-100" src="Image/Slide1.png" alt="Third slide">
                            <div class="carousel-caption d-none d-md-block img">
                                <h5>Gerenciador de restaurante japones</h5>
                                <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Sed, quisquam error 
                                    iure voluptate illum laborum ducimus mollitia et 
                                    cum sint voluptates, id libero repellat quos soluta perferendis sequi nisi consequatur?
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <a href="#"  id="suporte"></a>
        <div class="suporte">
            <h2 class="titulo" style="">SUPORTE AO <span>CLIENTE</span></h2>
            <hr class="linha" width="50%">
            <div class="contender">
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
        <div class="rodape">
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
                <div class="col-md-2 logo">
                    <img src="Image/logo_R.png" alt="logo Rodape" class="logo_R">
                </div>
            </div>      
        </div>
    </div>   
    <script>PagLocal('#Home');</script>     
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</body>