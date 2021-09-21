<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="resp.css">
    <script src="script.js"></script>
</head>
<body>
<?php
    include 'conexao.php';
?>
    <section class="banner">
        <img src="Image/Fund.png" alt="banner" class="fitBg">
        <div class="box">
            <div class="labels">
                <h2>Login</h2>
            </div>    
            <form method="post" action="validarUser.php">
                <div class="inputs">
                    <div class="inputBox">
                        <div class="inputUsu">
                            <input name="txt_usu" autocomplete="off" type="text" required>   
                            <label>Usuário</label> 
                        </div>  
                    </div>                
                    <div class="inputBox">
                        <div class="inputSenha">
                            <input name="txt_senha" type="password" required>  
                            <label id="lbl_senha">Senha</label>
                        </div>
                    </div>
                    <div class="btn">
                        <input type="submit" value="Entrar">   
                    </div>
                </div>
            </form>
        </div>
    </section>
</body>
</html>
