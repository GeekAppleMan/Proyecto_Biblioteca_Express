-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-01-2022 a las 19:12:50
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_escuela_express`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_alumno`
--

CREATE TABLE `tb_alumno` (
  `id_alumno` int(11) NOT NULL,
  `matricula` int(27) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `carrera` varchar(255) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_libro`
--

CREATE TABLE `tb_libro` (
  `id_libro` int(11) NOT NULL,
  `codigo` int(255) NOT NULL,
  `nombre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_alumno`
--
ALTER TABLE `tb_alumno`
  ADD PRIMARY KEY (`id_alumno`);

--
-- Indices de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  ADD PRIMARY KEY (`id_libro`);

--
-- Indices de la tabla `tb_prestamos`
--
ALTER TABLE `tb_prestamos`
  ADD PRIMARY KEY (`id_prestamo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_alumno`
--
ALTER TABLE `tb_alumno`
  MODIFY `id_alumno` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  MODIFY `id_libro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_prestamos`
--
ALTER TABLE `tb_prestamos`
  MODIFY `id_prestamo` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
