<?php
    include 'conexao.php'; 
    

    $Vusu = $_POST['txt_usu'];
    $Vsenha = $_POST['txt_senha'];

    $consulta = $cn->query("select nm_usu, senha_usu from tbl_usuario where nm_usu = '$Vusu' and senha_usu = '$Vsenha'");

    if($consulta->rowCount() == 1)
    {
         header('location:Pag_princ\Pag_princ.php');
     }
     else
     {
         header('location:erro.php');
     }

?>