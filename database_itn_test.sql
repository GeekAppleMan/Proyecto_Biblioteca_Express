-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-01-2022 a las 20:48:32
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 7.4.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `database_itn_test`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_carrera`
--

CREATE TABLE `tb_carrera` (
  `id_carrera` int(11) NOT NULL,
  `carrera` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_carrera`
--

INSERT INTO `tb_carrera` (`id_carrera`, `carrera`) VALUES
(1, 'LIC. EN ADMINISTRACIÓN'),
(2, 'CONTADOR PÚBLICO'),
(3, 'ING. CIVIL'),
(4, 'ING. ELECTRONICA'),
(5, 'ING. GESTION EMPRESARIAL'),
(6, 'ING. INDUSTRIAL'),
(7, 'ING. MECATRONICA'),
(8, 'ING. SISTEMAS COMPUTACIONALES'),
(9, 'MAESTRIA EN URBANISMO'),
(10, 'MAESTRIA EN SISTEMAS COMPUTACIONALES'),
(11, 'N/A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_conexion`
--

CREATE TABLE `tb_conexion` (
  `id_conexion` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `mac` varchar(255) NOT NULL,
  `ingreso` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_departamento`
--

CREATE TABLE `tb_departamento` (
  `id_departamento` int(11) NOT NULL,
  `departamento` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_departamento`
--

INSERT INTO `tb_departamento` (`id_departamento`, `departamento`) VALUES
(1, 'DEPARTAMENTO DE SISTEMAS Y COMPUTACIÓN'),
(2, 'DEPARTAMENTO DE INGENIERIA INDUSTRIAL'),
(3, 'DEPARTAMENTO DE INGENIERIA ELECTRICA Y ELECTRONICA'),
(4, 'DEPARTAMENTO DE DESARROLLO ACADEMICO'),
(5, 'DEPARTAMENTO DE CIENCIAS DE LA TIERRA'),
(6, 'DEPARTAMENTO DE CIENCIAS ECONÓMICO ADMINISTRATIVAS'),
(7, 'DIVISION DE ESTUDIOS PROFESIONALES'),
(8, 'DEPARTAMENTO DE CIENCIAS BÁSICAS'),
(9, 'DEPARTAMENTO DE METAL MECÁNICA'),
(10, 'DVISIÓN DE ESTUDIOS DE POSGRADO E INVESTIGACIÓN'),
(11, 'DEPARTAMENTO DE GESTIÓN TECNOLÓGICA Y VINCULACIÓN'),
(12, 'DEPARTAMENTO DE SERVICIOS ESCOLARES'),
(13, 'DEPARTAMENTO DE PLANEACIÓN, PROGRAMACIÓN Y PRESUPUESTACIÓN'),
(14, 'DEPARTAMENTO DE COMUNICACIÓN Y DIFUSIÓN'),
(15, 'DEPARTAMENTO DE ACTIVIDADES EXTRAESCOLARES'),
(16, 'CENTRO DE INFORMACIÓN'),
(17, 'DEPARTAMENTO DE RECURSOS HUMANOS'),
(18, 'DEPARTAMENTO DE RECURSOS FINANCIEROS'),
(19, 'CENTRO DE CÓMPUTO'),
(20, 'DEPARTAMENTO DE MANTENIMIENTO'),
(21, 'DEPARTAMENTO DE RECURSOS MATERIALES Y DE SERVICIOS'),
(22, 'DIRECTOR'),
(23, 'SUBDIRECTOR ACADÉMICO'),
(24, 'SUBDIRECTOR DE PLANEACIÓN Y VINCULACIÓN'),
(25, 'SUBDIRECTOR DE SERVICIOS ADMINISTRATIVOS'),
(26, 'N/A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estatus_conexion`
--

CREATE TABLE `tb_estatus_conexion` (
  `id_estatus_conexion` int(11) NOT NULL,
  `estatus_conexion` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estatus_conexion`
--

INSERT INTO `tb_estatus_conexion` (`id_estatus_conexion`, `estatus_conexion`) VALUES
(1, 'DESCONECTADO'),
(2, 'CONECTADO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estatus_mantenimiento`
--

CREATE TABLE `tb_estatus_mantenimiento` (
  `id_estatus` int(11) NOT NULL,
  `estatus` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estatus_mantenimiento`
--

INSERT INTO `tb_estatus_mantenimiento` (`id_estatus`, `estatus`) VALUES
(1, 'PENDIENTE'),
(2, 'FINALIZADO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_impresiones`
--

CREATE TABLE `tb_impresiones` (
  `id_impresiones` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `cantidad_disp` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_impresiones`
--

INSERT INTO `tb_impresiones` (`id_impresiones`, `id_usuario`, `cantidad_disp`) VALUES
(1, 1, 44),
(2, 2, 46),
(3, 3, 57);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_libro`
--

CREATE TABLE `tb_libro` (
  `id_libro` int(11) NOT NULL,
  `codigo` int(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `estatus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_libro`
--

INSERT INTO `tb_libro` (`id_libro`, `codigo`, `nombre`, `estatus`) VALUES
(1, 1, 'machupichu', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_login`
--

CREATE TABLE `tb_login` (
  `id_usuario` int(5) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `password` varchar(200) NOT NULL,
  `passw` varchar(100) NOT NULL,
  `id_privilegio` int(5) NOT NULL,
  `activacion` tinyint(1) DEFAULT 1,
  `correo` varchar(100) DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `last_session` datetime DEFAULT NULL,
  `token` varchar(40) NOT NULL,
  `token_password` varchar(100) NOT NULL,
  `password_request` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tb_login`
--

INSERT INTO `tb_login` (`id_usuario`, `usuario`, `password`, `passw`, `id_privilegio`, `activacion`, `correo`, `id_empleado`, `last_session`, `token`, `token_password`, `password_request`) VALUES
(1, '6319991985', '$2y$10$EcB1JaCB7iqH83RFMN4Uv.hOOQaBpJXsCXu0VdgxdVVG7si65OWW2', '1997', 1, 1, NULL, 1, '2021-11-24 09:23:40', '20be2528103c9275ee0bba4e6e05849e', '', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_prestamos`
--

CREATE TABLE `tb_prestamos` (
  `id_prestamo` int(11) NOT NULL,
  `id_alumno` int(11) NOT NULL,
  `id_libro` int(255) NOT NULL,
  `fecha_salida` varchar(255) NOT NULL,
  `fecha_devolucion` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_prestamos`
--

INSERT INTO `tb_prestamos` (`id_prestamo`, `id_alumno`, `id_libro`, `fecha_salida`, `fecha_devolucion`) VALUES
(4, 1, 1, '10/01/2022', '13/01/2022');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_puesto`
--

CREATE TABLE `tb_puesto` (
  `id_puesto` int(11) NOT NULL,
  `puesto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_puesto`
--

INSERT INTO `tb_puesto` (`id_puesto`, `puesto`) VALUES
(1, 'ALUMNO'),
(2, 'DOCENTE'),
(3, 'PERSONAL ADMINISTRATIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_recibos_inscripcion`
--

CREATE TABLE `tb_recibos_inscripcion` (
  `id_recibo_inscripcion` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `foto_recibo` varchar(255) NOT NULL,
  `fecha_captura` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_recibos_inscripcion`
--

INSERT INTO `tb_recibos_inscripcion` (`id_recibo_inscripcion`, `id_usuario`, `foto_recibo`, `fecha_captura`) VALUES
(5, 1, 'http://189.204.133.38:8081/EncuentrameApp/servicios/recibos_pago_alumnos/120211129.png', '2021-11-29 10:14:00'),
(6, 1, 'http://189.204.133.38:8081/EncuentrameApp/servicios/recibos_pago_alumnos/120211129.png', '2021-11-29 10:37:27'),
(7, 1, 'http://189.204.133.38:8081/EncuentrameApp/servicios/recibos_pago_alumnos/120211129.png', '2021-11-29 10:38:03'),
(8, 1, 'http://189.204.133.38:8081/EncuentrameApp/servicios/recibos_pago_alumnos/120211129.png', '2021-11-29 15:41:03');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_solicitud_mantenimiento`
--

CREATE TABLE `tb_solicitud_mantenimiento` (
  `id_solicitud_mantenimiento` int(11) NOT NULL,
  `area` varchar(255) NOT NULL,
  `nombre_solicitante` varchar(255) NOT NULL,
  `firma_solicitante` longblob NOT NULL,
  `descripcion_falla` varchar(255) NOT NULL,
  `fecha_inicio` datetime NOT NULL DEFAULT current_timestamp(),
  `id_estatus` int(11) NOT NULL DEFAULT 1,
  `nombre_tecnico` varchar(255) DEFAULT NULL,
  `descripcion_solucion` varchar(255) DEFAULT NULL,
  `fecha_finalizacion` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_solicitud_mantenimiento`
--

INSERT INTO `tb_solicitud_mantenimiento` (`id_solicitud_mantenimiento`, `area`, `nombre_solicitante`, `firma_solicitante`, `descripcion_falla`, `fecha_inicio`, `id_estatus`, `nombre_tecnico`, `descripcion_solucion`, `fecha_finalizacion`) VALUES
(1, 'GESTION TECNOLOGICA Y VINCULACION', 'LUIS SANCHEZ', '', 'ELABORACIÓN DE CABLE UTP DE 20 METROS PARA ATENDER CONEXIONES PARA INTERNET EN SALAS DEL CENTRO DE VINCULACIÓN.', '2021-11-04 09:22:20', 2, 'MIGUEL ROBLES', 'Creacion de cable.', '2021-11-11 00:00:00'),
(2, 'GESTION TECNOLOGICA Y VINCULACION', 'GIOVANNY ADRIAN SIQUEIROS LOPEZ', '', 'NO RESPONDEN LOS EQUIPOS.', '2021-11-11 10:15:56', 1, NULL, NULL, NULL),
(3, 'DESARROLLO ACADEMICO', 'JUAN FERNANDEZ JIMENEZ', '', 'EQUIPOS DE COMPUTO NO AGARRAN INTERNET Y NO RESPONDEN PERIFERICOS (RATON Y TECLADO).', '2021-11-09 10:16:33', 2, 'FERNANDO VAZQUEZ', 'Antena defectuosa', '2021-11-11 00:00:00'),
(4, 'SISTEMAS', 'JUAN FERNANDEZ JIMENEZ', '', 'EQUIPOS DE COMPUTO NO AGARRAN INTERNET Y NO RESPONDEN PERIFERICOS (RATON Y TECLADO).', '2021-11-09 10:16:33', 2, 'GIOVANNY ADRIAN SIQUEIROS LOPEZ', 'PROBLEMAS CON EL MODEM, SE LE REALIZO EL CAMBIO Y EN BREVE FUNCIONÓ EL INTERNET, Y LOS PERIFERICOS TENIAN PROBLEMAS CON CONTROLADORES, SE INSTALO Y QUEDARON FUNCIONANDO SIN PROBLEMAS.', '2021-11-11 10:16:33'),
(13, 'SISTEMAS', 'LUIS SANCHEZ', 0x687474703a2f2f3138392e3230342e3133332e33383a383038312f456e6375656e7472616d654170702f736572766963696f732f6669726d61735f6d616e74656e696d69656e746f2f53495354454d41532e6a7067, 'ocurre un problema', '2021-11-25 14:58:28', 1, NULL, NULL, NULL),
(16, 'TEST', 'GIOVANNY ADRIAN SIQUEIROS LOPEZ ', 0x687474703a2f2f3138392e3230342e3133332e33383a383038312f456e6375656e7472616d654170702f736572766963696f732f6669726d61735f6d616e74656e696d69656e746f2f544553542e6a7067, 'test, hay un problema de internet en el edificio', '2021-11-25 15:18:00', 2, 'JUAN GUTIERREZ', 'Se solucionó reiniciando el modem', '2021-11-26 00:00:00'),
(25, 'prueba', 'nombreprueba', '', 'asd', '2021-11-26 10:00:42', 1, 'asd', NULL, NULL),
(27, 'prueba', 'nombreprueba', '', 'asdqw', '2021-11-26 10:03:42', 1, 'tecnicoprueba', NULL, NULL),
(28, 'prueba', 'nombreprueba', '', 'dqwe', '2021-11-26 11:26:50', 1, 'qwe', NULL, NULL),
(29, 'prueba12312312', 'nombreprueba', '', 'dqwe', '2021-11-26 11:27:12', 1, 'qwe', NULL, NULL),
(30, 'prueba12312312', 'nombreprueba', '', 'dqwe', '2021-11-26 11:27:33', 1, 'qwe', NULL, NULL),
(31, 'asd', 'qweqw', '', 'qweas', '2021-11-26 11:27:39', 1, 'tecnicoprueba', NULL, NULL),
(32, 'prueba', 'nombreprueba', '', 'qweasd', '2021-11-26 11:27:53', 1, 'asd', NULL, NULL),
(33, 'prueba', 'asd', '', 'asdqw', '2021-11-26 13:03:27', 1, 'tecnicoprueba', NULL, NULL),
(34, 'prueba', 'nombreprueba', '', 'asdqws', '2021-11-26 13:03:46', 1, 'tecnicoprueba', NULL, NULL),
(35, 'prueba', 'nombreprueba', '', 'asdqs', '2021-11-26 13:05:46', 1, 'asd', NULL, NULL),
(36, 'prueba', 'llubia', '', 'asd', '2021-11-26 13:06:46', 1, 'asd', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `no_control` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `apellido_p` varchar(255) NOT NULL,
  `apellido_m` varchar(255) NOT NULL,
  `celular` varchar(255) NOT NULL,
  `qr` varchar(255) NOT NULL,
  `id_departamento` int(11) NOT NULL DEFAULT 26,
  `id_carrera` int(11) NOT NULL DEFAULT 11,
  `id_estatus_conexion` int(11) NOT NULL DEFAULT 1,
  `vigencia` datetime DEFAULT NULL,
  `id_puesto` int(11) NOT NULL DEFAULT 1,
  `foto_perfil` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `no_control`, `nombre`, `apellido_p`, `apellido_m`, `celular`, `qr`, `id_departamento`, `id_carrera`, `id_estatus_conexion`, `vigencia`, `id_puesto`, `foto_perfil`) VALUES
(1, 12340432, 'GIOVANNY ADRIAN', 'SIQUEIROS', 'LOPEZ', '6311906270', 'http://189.204.133.38:8081/EncuentrameApp/universidad/codigosqr/qr12340432.png', 8, 8, 1, '2021-11-26 15:36:15', 1, 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfil/12340432.jpeg'),
(2, 12340433, 'NOAN', 'HERNANDEZ', 'CORDOVA', '6313047163', 'http://189.204.133.38:8081/EncuentrameApp/universidad/codigosqr/qr12340433.png', 26, 7, 1, '2021-11-23 20:48:32', 1, 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfil/12340433.jpg'),
(3, 12340434, 'LLUBIA', 'BARRERA', 'URIAS', '6319991985', 'http://189.204.133.38:8081/EncuentrameApp/universidad/codigosqr/qr12340434.png', 26, 8, 1, NULL, 1, 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfil/qr12340432.png'),
(4, 15340370, 'MARIA', 'MORALES', 'GONZALEZ', '6319991981', 'http://189.203.133.38:8081/EncuentrameApp/universidad/codigosqr/15340370.png', 26, 5, 1, NULL, 1, 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfil/qr12340432.png'),
(5, 15340372, 'Juan', 'jimenez', '', '6318881975', 'http://189.203.133.38:8081/EncuentrameApp/universidad/codigosqr/15340372.png', 26, 2, 1, NULL, 1, 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfil/Fondo.png'),
(6, 18340340, 'GERONIMO JUAN SAMUEL', 'GARCIA', 'VALDEZ', '6311050643', '', 26, 8, 1, '2022-01-10 17:25:20', 1, 'http://localhost/CODE/BDGas/img-tablero/sonic1.png');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_visitantes`
--

CREATE TABLE `tb_visitantes` (
  `id_visita` int(11) NOT NULL,
  `nombre_visitante` varchar(255) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL,
  `fecha_registro` datetime NOT NULL DEFAULT current_timestamp(),
  `fecha_salida` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_visitantes`
--

INSERT INTO `tb_visitantes` (`id_visita`, `nombre_visitante`, `foto_perfil`, `fecha_registro`, `fecha_salida`) VALUES
(12, 'Giovany Adrian Siqueiros Lopez', 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfilvisita/Giovany Adrian Siqueiros Lopez.jpg', '2021-11-30 11:51:04', '0000-00-00 00:00:00'),
(14, 'Noan Alberto Hernandez Cordova', 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfilvisita/Noan Alberto Hernandez Cordova.jpg', '2021-12-02 16:19:18', '0000-00-00 00:00:00'),
(16, 'Juanito Martinez', 'http://189.204.133.38:8081/EncuentrameApp/universidad/fotosperfilvisita/Juanito Martinez.jpg', '2021-12-03 16:07:07', '0000-00-00 00:00:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_carrera`
--
ALTER TABLE `tb_carrera`
  ADD PRIMARY KEY (`id_carrera`);

--
-- Indices de la tabla `tb_conexion`
--
ALTER TABLE `tb_conexion`
  ADD PRIMARY KEY (`id_conexion`);

--
-- Indices de la tabla `tb_departamento`
--
ALTER TABLE `tb_departamento`
  ADD PRIMARY KEY (`id_departamento`);

--
-- Indices de la tabla `tb_estatus_conexion`
--
ALTER TABLE `tb_estatus_conexion`
  ADD PRIMARY KEY (`id_estatus_conexion`);

--
-- Indices de la tabla `tb_estatus_mantenimiento`
--
ALTER TABLE `tb_estatus_mantenimiento`
  ADD PRIMARY KEY (`id_estatus`);

--
-- Indices de la tabla `tb_impresiones`
--
ALTER TABLE `tb_impresiones`
  ADD PRIMARY KEY (`id_impresiones`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  ADD PRIMARY KEY (`id_libro`);

--
-- Indices de la tabla `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `user` (`usuario`),
  ADD KEY `id_privilegio` (`id_privilegio`),
  ADD KEY `tb_login_ibfk_2` (`id_empleado`);

--
-- Indices de la tabla `tb_prestamos`
--
ALTER TABLE `tb_prestamos`
  ADD PRIMARY KEY (`id_prestamo`);

--
-- Indices de la tabla `tb_puesto`
--
ALTER TABLE `tb_puesto`
  ADD PRIMARY KEY (`id_puesto`);

--
-- Indices de la tabla `tb_recibos_inscripcion`
--
ALTER TABLE `tb_recibos_inscripcion`
  ADD PRIMARY KEY (`id_recibo_inscripcion`);

--
-- Indices de la tabla `tb_solicitud_mantenimiento`
--
ALTER TABLE `tb_solicitud_mantenimiento`
  ADD PRIMARY KEY (`id_solicitud_mantenimiento`),
  ADD KEY `id_estatus` (`id_estatus`);

--
-- Indices de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `celular` (`celular`),
  ADD UNIQUE KEY `no_control` (`no_control`),
  ADD KEY `id_carrera` (`id_carrera`),
  ADD KEY `id_departamento` (`id_departamento`),
  ADD KEY `id_estatus_conexion` (`id_estatus_conexion`),
  ADD KEY `id_puesto` (`id_puesto`);

--
-- Indices de la tabla `tb_visitantes`
--
ALTER TABLE `tb_visitantes`
  ADD PRIMARY KEY (`id_visita`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_carrera`
--
ALTER TABLE `tb_carrera`
  MODIFY `id_carrera` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `tb_conexion`
--
ALTER TABLE `tb_conexion`
  MODIFY `id_conexion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_departamento`
--
ALTER TABLE `tb_departamento`
  MODIFY `id_departamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de la tabla `tb_estatus_conexion`
--
ALTER TABLE `tb_estatus_conexion`
  MODIFY `id_estatus_conexion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_estatus_mantenimiento`
--
ALTER TABLE `tb_estatus_mantenimiento`
  MODIFY `id_estatus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_impresiones`
--
ALTER TABLE `tb_impresiones`
  MODIFY `id_impresiones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  MODIFY `id_libro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_login`
--
ALTER TABLE `tb_login`
  MODIFY `id_usuario` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT de la tabla `tb_prestamos`
--
ALTER TABLE `tb_prestamos`
  MODIFY `id_prestamo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_puesto`
--
ALTER TABLE `tb_puesto`
  MODIFY `id_puesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_recibos_inscripcion`
--
ALTER TABLE `tb_recibos_inscripcion`
  MODIFY `id_recibo_inscripcion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `tb_solicitud_mantenimiento`
--
ALTER TABLE `tb_solicitud_mantenimiento`
  MODIFY `id_solicitud_mantenimiento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tb_visitantes`
--
ALTER TABLE `tb_visitantes`
  MODIFY `id_visita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tb_impresiones`
--
ALTER TABLE `tb_impresiones`
  ADD CONSTRAINT `tb_impresiones_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuarios` (`id_usuario`);

--
-- Filtros para la tabla `tb_solicitud_mantenimiento`
--
ALTER TABLE `tb_solicitud_mantenimiento`
  ADD CONSTRAINT `tb_solicitud_mantenimiento_ibfk_1` FOREIGN KEY (`id_estatus`) REFERENCES `tb_estatus_mantenimiento` (`id_estatus`);

--
-- Filtros para la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD CONSTRAINT `tb_usuarios_ibfk_1` FOREIGN KEY (`id_carrera`) REFERENCES `tb_carrera` (`id_carrera`),
  ADD CONSTRAINT `tb_usuarios_ibfk_2` FOREIGN KEY (`id_departamento`) REFERENCES `tb_departamento` (`id_departamento`),
  ADD CONSTRAINT `tb_usuarios_ibfk_3` FOREIGN KEY (`id_estatus_conexion`) REFERENCES `tb_estatus_conexion` (`id_estatus_conexion`),
  ADD CONSTRAINT `tb_usuarios_ibfk_4` FOREIGN KEY (`id_puesto`) REFERENCES `tb_puesto` (`id_puesto`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
