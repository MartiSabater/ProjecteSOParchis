DROP DATABASE IF EXISTS M4_BBDDParchis

CREATE DATABASE M4_BBDDParchis;
USE M4_BBDDParchis;

CREATE TABLE contrincantes (
    ID_Contrincante INTEGER PRIMARY KEY NOT NULL AUTO_INCREMENT,
    NombreUsuarioContrincante VARCHAR(255),
    VecesJugado INTEGER,
    EsAmigo BOOLEAN
)ENGINE=InnoDB;


CREATE TABLE partidas (
    ID_partida INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATE,
    duracion TIME,
    puestos INT,
    puntuacion FLOAT
)ENGINE=InnoDB;

CREATE TABLE amigos (
    ID_Amigo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre_de_Usuario_Amistad VARCHAR(255),
    fecha_solicitud_amistad DATE
)ENGINE = InnoDB;

CREATE TABLE usuario (
    ID_Usuario INT AUTO_INCREMENT PRIMARY KEY,
    Nombre_Usuario VARCHAR(50),
    Fecha_Registro DATE,
    Correo VARCHAR(100),
    Contraseña VARCHAR(50),
    ELO_Actual INT,
    ELO_Mas_Alto INT,
    Num_Partidas INT,
    Porcentaje_1er_Puesto FLOAT,
    Porcentaje_2do_Puesto FLOAT,
    Porcentaje_3er_Puesto FLOAT,
    Porcentaje_4to_Puesto FLOAT,
    Puntuacion_Media_Por_Partida FLOAT,
    Racha_Victorias INT,
    Partidas_ID INT,
    Contrincantes_ID INT,
    Amigos_ID INT,
    Num_Amigo INT,
    FOREIGN KEY (Partidas_ID) REFERENCES partidas(ID_Partida),
    FOREIGN KEY (Contrincantes_ID) REFERENCES contrincantes(ID_Contrincante),
    FOREIGN KEY (Amigos_ID) REFERENCES amigos(ID_Amigo)
)ENGINE=InnoDB;

CREATE TABLE conectados (
    ID_Usuario INT AUTO_INCREMENT PRIMARY KEY,
    Nombre_Usuario VARCHAR(50)
)ENGINE=InnoDB;

INSERT INTO usuario (Nombre_Usuario, Fecha_Registro, Correo, Contraseña, ELO_Actual, ELO_Mas_Alto, Num_Partidas, Porcentaje_1er_Puesto, Porcentaje_2do_Puesto, Porcentaje_3er_Puesto, Porcentaje_4to_Puesto, Puntuacion_Media_Por_Partida, Racha_Victorias, Num_Amigo) VALUES ('Usuario1', '2024-03-10', 'usuario1@example.com', '1', 1200, 1300, 50, 25.0, 30.0, 20.0, 25.0, 7.5, 3, 123);

INSERT INTO usuario (Nombre_Usuario, Fecha_Registro, Correo, Contraseña, ELO_Actual, ELO_Mas_Alto, Num_Partidas, Porcentaje_1er_Puesto, Porcentaje_2do_Puesto, Porcentaje_3er_Puesto, Porcentaje_4to_Puesto, Puntuacion_Media_Por_Partida, Racha_Victorias, Num_Amigo) VALUES ('Usuario2', '2024-03-11', 'usuario2@example.com', '2', 1100, 1200, 40, 20.0, 25.0, 30.0, 25.0, 8.0, 4, 456);

INSERT INTO usuario (Nombre_Usuario, Fecha_Registro, Correo, Contraseña, ELO_Actual, ELO_Mas_Alto, Num_Partidas, Porcentaje_1er_Puesto, Porcentaje_2do_Puesto, Porcentaje_3er_Puesto, Porcentaje_4to_Puesto, Puntuacion_Media_Por_Partida, Racha_Victorias, Num_Amigo) VALUES ('Usuario3', '2024-03-12', 'usuario3@example.com', '3', 1300, 1400, 60, 30.0, 20.0, 25.0, 25.0, 7.0, 5, 789);

INSERT INTO amigos (Nombre_de_Usuario_Amistad, fecha_solicitud_amistad) VALUES ('Amigo1', '2024-03-10'), ('Amigo2', '2024-03-11'), ('Amigo3', '2024-03-12');

INSERT INTO partidas (fecha, duracion, puestos, puntuacion) VALUES ('2024-03-10', '01:30:00', 4, 1000.0),('2024-03-11', '02:15:00', 3, 1200.5),('2024-03-12', '01:45:00', 4, 900.75);

INSERT INTO contrincantes (NombreUsuarioContrincante, VecesJugado, EsAmigo) VALUES ('Usuario1', 10, true),('Usuario2', 5, false),('Usuario3', 20, true);
