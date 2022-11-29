create database Club;
use Club;


create table Actividades(
    ID int AUTO_INCREMENT, 
    Nombre varchar(60),
    precio int,

    CONSTRAINT pk_ID primary key (ID)
);

create table Socios(
    DNI int,
    Nombre varchar(60),
    Apellido varchar(60),
    fechaNac date,
    Sexo varchar(1),
    Categoria varchar(80),
    Estado boolean, 
    fechaIngr date, 
    Domicilio varchar(60),
    codPostal varchar(4),
    Telefono int,
    Actividad int,

    CONSTRAINT pk_dni primary key (DNI),
    CONSTRAINT fk_Actividad foreign key (Actividad) references Actividades(ID)
);

create table Factura(
    Actividades int,
    Socio int,
    Pago int not null,
    ultimaVez date, 
    caduca date,

    
    CONSTRAINT pk_actSocio primary key (Actividades, Socio),
    CONSTRAINT fk_Actividades foreign key (Actividades) references Actividades(ID),
    CONSTRAINT fk_Socio foreign key (Socio) references Socios (DNI)
);


--PROCEDIMIENTOS:

    --INGRESAR UN NUEVO SOCIO
        DELIMITER $$
            CREATE PROCEDURE NuevoSocio(IN dniS int, nombreS varchar(60), apellidoS varchar(60), fechaNacS date, sexoS varchar (1), categoriaS varchar(80), estadoS boolean, fechaIngrS date, domicilioS varchar(60), codPostalS varchar(4), telefonoS int, ActividadS int)
            BEGIN
                INSERT INTO Socios (DNI, Nombre, Apellido, fechaNac, Sexo, Categoria, Estado, fechaIngr, Domicilio, codPostal, Telefono, Actividad)
                            VALUES (dniS, nombreS, apellidoS, fechaNacS, sexoS, categoriaS, estadoS, fechaIngrS, domicilioS, codPostalS, telefonoS, ActividadS);
                INSERT INTO Factura (Actividades, Socio, ultimaVez, caduca)
                        VALUES (Actividad, dniS, 1, CURDATE(), CURDATE());
                UPDATE Factura SET caduca = date_add(caduca, interval 1 Month);
            END $$
        DELIMITER ;

    --CONSULTAR ESTADO DE LA FACTURA
        DELIMITER $$
            CREATE PROCEDURE EstadoFactura(IN dniS int)
            BEGIN
                IF (SELECT DNI from Socios where DNI = dniS) then
                    SELECT DNI, Socios.Nombre, Apellido, Actividades.Nombre, Pago, ultimaVez, Caduca from Factura
                        INNER JOIN Socios ON DNI = Factura.Socio
                        INNER JOIN Actividades ON ID = Socios.Actividad;

                ELSE select "No se encontro el socio" as "Mensaje";
                END IF ;
            END $$
        DELIMITER ;

    --ACTUALIZAR CUOTA (PAGADA) INCOMPLETO
        DELIMITER $$
            CREATE PROCEDURE ActualizarCuota(IN dniS int, fechaIngr date)
            BEGIN
                IF exists (SELECT DNI from Socios where DNI = dniS) then
                    UPDATE Factura set ultimaVez = CURDATE();
                    UPDATE Factura set caduca = date_add(ultimaVez, interval 1 Month);
                    SELECT "Actualizada la cuota con exito" as "Mensaje";

                ELSE SELECT "No se encuentra al Socio" as "Mensaje";
                END IF ;
            END $$ 
        DELIMITER ;


    --CONSULTAR DATOS DEL SOCIO
        DELIMITER $$
            CREATE PROCEDURE DatosSocio (IN dniS int)
            BEGIN
                IF exists (SELECT DNI FROM Socios WHERE DNI = dniS) then
                    SELECT *, Actividades.Nombre from Socios
                    INNER JOIN Actividades ON ID = Actividad ;

                ELSE SELECT "No se encontro el socio" as "Mensaje";
                END IF ;
            END $$

        DELIMITER ;

    --CONSULTAR DATOS DE LA ACTIVIDAD
        DELIMITER $$
            CREATE PROCEDURE DatosActividad ()
            BEGIN
                SELECT *, COUNT(*) as "Total de Socios" from Actividades group by ID ;
            END $$
        DELIMITER ;

    --MODIFICAR ACTIVIDAD
        DELIMITER $$
            CREATE PROCEDURE ModificarActividad(IN dni int, act varchar(60))
            BEGIN
                UPDATE socios SET Actividad = act 
                WHERE DNI = dni;
            END $$
        DELIMITER ;
        
    --DESASOCIAR COMPLETAMENTE
        DELIMITER $$
            CREATE PROCEDURE
        DELIMITER ;

    --DESASOCIAR CON EL BOOLEANO
        DELIMITER $$
            CREATE PROCEDURE Desasociar(IN dni int)
            BEGIN
                UPDATE Socios SET Estado = false
                WHERE DNI = dni;
            END $$
        DELIMITER ;
 
    --ASOCIAR SOCIO INACTIVO (completar)
    
        DELIMITER $$
            CREATE PROCEDURE Asociar(IN dniS in)
            BEGIN
                IF exists(SELECT DNI from Socios )
            END $$
        DELIMITER ;




