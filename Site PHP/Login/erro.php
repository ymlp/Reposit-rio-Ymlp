<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="resp.css">
    <script src="script.js"></script>
    <link rel="stylesheet" href="Css/styles_login.css">
</head>
<body>
<?php
    include 'nav.php';
?>
    <section class="banner">
        <img src="Image/Fund.png" alt="banner" class="fitBg">
        <div class="box">
        <div class="container-fluid">	
                <div class="row">
                
                    <div class="col-sm-4 col-sm-offset-4 text-center" style="flex:auto;max-width:100%;">
                        
                        <h4 style="color:#fff; ">Usuário ou senha incorreto!!</h4>
                        
                        <a href="login.php" style="color:#fff;text-decoration:none;"class="btn btn-block btn-default" role="button">Tentar Novamente</a>                       
                                    
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
</html>
