<?php 

    $servidor = 'Localhost';
    $usuario = 'Php';
    $senha = '12345678';
    $banco = 'db_Php';

    $cn = new PDO("mysql:host=$servidor;dbname=$banco", $usuario, $senha);

?>