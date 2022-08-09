<?php
    $NombreServidor = 'localhost';
    $NombreUsuario='root';
    $Contraseña = '12345678';
    $NombreBaseDatos = 'registro_usuarios';
//creamos la enlace de conexion a la MySql
$enlace = mysql_connect($NombreServidor, $NombreUsuario, $Contraseña );
    if (!$enlace) {
        die('No pudo conectarse: ' . mysql_error());
    }

//creamos la base de datos registro_usuarios
$sql = 'CREATE DATABASE registro_usuarios';

    if (mysql_query($sql, $enlace)) {
        echo "La base de datos registro_usuarios se creó correctamente <br>";
    } else {
        echo 'Error al crear la base de datos: ' . mysql_error() . "<br>";    
    }


$bd_seleccionada = mysql_select_db($NombreBaseDatos, $enlace);
    if (!$bd_seleccionada) {
        die ('No se puede usar foo : ' . mysql_error());
    }

//enviamos la secuencia SQL, para crear la tabla usuarios y prepararla para su uso
$sql = 'CREATE TABLE IF NOT EXISTS usuarios (
  id int(10) NOT NULL AUTO_INCREMENT,
  primer_nombre varchar(60) DEFAULT NULL,
  segundo_nombre varchar(60) DEFAULT NULL,
  primer_apellido varchar(60) DEFAULT NULL,
  segundo_apellido varchar(60) DEFAULT NULL,
  cedula varchar(30) DEFAULT NULL,
  usuario varchar(40) DEFAULT NULL,
  correo varchar(40) DEFAULT NULL,
  contrasena varchar(30) DEFAULT NULL,
  repetir_contrasena varchar(30) DEFAULT NULL,
  PRIMARY KEY (id)
  )';
    
if (mysql_query($sql, $enlace)) {
        echo "La tabla usuarios se creó correctamente <br>";
    } else {
        echo 'Error al crear la tabla: ' . mysql_error() . "<br>";    
    }
?>
