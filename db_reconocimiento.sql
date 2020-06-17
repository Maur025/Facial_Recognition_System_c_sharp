-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-11-2019 a las 00:08:46
-- Versión del servidor: 10.1.39-MariaDB
-- Versión de PHP: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_reconocimiento`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `buscar`
--

CREATE TABLE `buscar` (
  `cib` int(9) NOT NULL,
  `nombreb` varchar(30) NOT NULL,
  `ubicacionimage` varchar(200) NOT NULL,
  `apepatb` varchar(15) DEFAULT NULL,
  `apematb` varchar(15) DEFAULT NULL,
  `edadb` int(3) DEFAULT NULL,
  `generob` varchar(1) DEFAULT NULL,
  `id_us` varchar(8) NOT NULL,
  `buscado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `buscar`
--

INSERT INTO `buscar` (`cib`, `nombreb`, `ubicacionimage`, `apepatb`, `apematb`, `edadb`, `generob`, `id_us`, `buscado`) VALUES
(13693505, 'mauro', '/TrainedFaces/face1.bmp', '', '', 0, '', '1369mau', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_us` varchar(8) NOT NULL,
  `nombre_p` varchar(30) NOT NULL,
  `ap_pat` varchar(15) DEFAULT NULL,
  `ap_mat` varchar(15) DEFAULT NULL,
  `nuci` int(9) NOT NULL,
  `nombre_us` varchar(25) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `nivel` int(1) NOT NULL,
  `cargo` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_us`, `nombre_p`, `ap_pat`, `ap_mat`, `nuci`, `nombre_us`, `pass`, `nivel`, `cargo`) VALUES
('1369mau', 'Mauro Eduardo', 'Moya', 'Palli', 13693505, 'mauro', '827ccb0eea8a706c4c34a16891f84e7b', 0, 'empleado');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `buscar`
--
ALTER TABLE `buscar`
  ADD PRIMARY KEY (`cib`),
  ADD KEY `id_us` (`id_us`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_us`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `buscar`
--
ALTER TABLE `buscar`
  ADD CONSTRAINT `buscar_ibfk_1` FOREIGN KEY (`id_us`) REFERENCES `usuario` (`id_us`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
