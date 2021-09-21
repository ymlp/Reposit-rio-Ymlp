<link rel="stylesheet" href="Css/corpo_style.css">
<div class="corpo">
    <?php
        include 'conexao.php';
    ?>
    <div class="conteudo">
        <div class="box">           
            <div class="cima">
                <div class="titulo1"><h3 id="tit1" ><a href='JanelCalen/index.php' target='_blank'>CALENDARIO</a></h3> <h3><a href="Suporte/suporte.php">SUPORTE</a></h3></div>
                <div class="blocos1">
                    <div class="bloc1">
                        <iframe  src="JanelCalen/index_iframe.php" heigth="80%" width="50%"></iframe>
                    </div>
                    <div class="bloc2">
                        <div class="bloc2_interno">
                            <?php
                                $consulta = $cn->query('select nome_sup, descricao_sup from  tbl_suporte');                        
                            ?>
                            <div class="labels">
                                <label for="nome" id="lblNome">Nome</label>
                                <label for="texto" id="lblTexto">Texto</label>
                            </div>

                            <?php 
                             while($exibe = $consulta->fetch(PDO::FETCH_ASSOC))
                                {  
                            ?>
                                <a href="#" >
                                    <div class="row" onclick="">
                                        <div class="col-md-1">
                                            
                                            <div class="nome">
                                                <p>
                                                    <?php echo mb_strimwidth($exibe['nome_sup'],0,10,'...');?>
                                                </p>   
                                            </div>
                                        </div>
                                        <div class="col-md-9">
                                        
                                            <div class="texto">
                                                <p>
                                                    <?php echo mb_strimwidth ($exibe['descricao_sup'],0,40,'....');?>
                                                </p>         
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            <?php } ?> 
                        </div>
                    </div>
                </div>
            </div>
            <div class="baixo">
                <div class="titulo2"><h3 id="tit1"> <a href="#">SERVIÇOS</a></h3> <h3> <a href="#">DEMANDAS</a></h3></div>
                <div class="busca">
                    <input type="text" id="txt_busc_Servico"> <input type="button" value="BUSCAR" class="botao">
                    <input type="text" id="txt_busc_Demanda">  <input type="button" value="BUSCAR" class="botao">
                </div>
                <div class="blocos2">       
                    <div class="bloc1">
                        <div class="bloc1_interno">
                            <!--parada do banco-->
                        </div>   
                    </div>
                    <div class="bloc2"  style="width: 25rem;">
                        <div class="bloc2_interno">
                            <!--parada do banco-->
                        </div>                  
                    </div>
            </div>     
        </div>    
    </div>
</div>


