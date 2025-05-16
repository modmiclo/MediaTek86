-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 16 mai 2025 à 22:53
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(5, '2024-05-27 00:00:00', '2026-03-17 00:00:00', 2),
(6, '2024-07-05 00:00:00', '2025-09-10 00:00:00', 2),
(1, '2024-12-25 00:00:00', '2025-08-14 00:00:00', 2),
(7, '2024-09-11 00:00:00', '2025-12-13 00:00:00', 3),
(7, '2025-06-30 00:00:00', '2026-02-15 00:00:00', 3),
(5, '2025-04-07 00:00:00', '2025-09-20 00:00:00', 2),
(5, '2025-10-08 00:00:00', '2026-02-10 00:00:00', 3),
(2, '2024-09-24 00:00:00', '2025-11-24 00:00:00', 2),
(5, '2024-05-16 00:00:00', '2026-01-27 00:00:00', 2),
(4, '2025-06-06 00:00:00', '2025-10-05 00:00:00', 3),
(1, '2024-05-05 00:00:00', '2025-07-25 00:00:00', 2),
(8, '2025-06-02 00:00:00', '2025-10-13 00:00:00', 2),
(1, '2024-03-18 00:00:00', '2025-04-19 00:00:00', 4),
(8, '2024-11-10 00:00:00', '2025-05-22 00:00:00', 3),
(9, '2025-05-03 00:00:00', '2025-09-24 00:00:00', 3),
(7, '2024-12-13 00:00:00', '2025-02-09 00:00:00', 4),
(9, '2024-12-17 00:00:00', '2025-11-12 00:00:00', 4),
(6, '2025-06-01 00:00:00', '2025-10-31 00:00:00', 2),
(2, '2024-12-20 00:00:00', '2025-10-13 00:00:00', 4),
(4, '2025-04-15 00:00:00', '2025-11-21 00:00:00', 3),
(8, '2025-09-01 00:00:00', '2026-03-30 00:00:00', 4),
(8, '2026-01-21 00:00:00', '2026-01-24 00:00:00', 2),
(3, '2024-09-19 00:00:00', '2026-01-04 00:00:00', 4),
(5, '2025-03-13 00:00:00', '2026-04-13 00:00:00', 2),
(8, '2024-09-06 00:00:00', '2025-02-19 00:00:00', 3),
(5, '2025-04-18 00:00:00', '2025-05-03 00:00:00', 1),
(6, '2025-07-22 00:00:00', '2026-03-01 00:00:00', 3),
(8, '2025-03-27 00:00:00', '2025-04-29 00:00:00', 4),
(5, '2024-08-27 00:00:00', '2025-06-18 00:00:00', 3),
(8, '2025-07-14 00:00:00', '2026-04-03 00:00:00', 3),
(9, '2024-05-06 00:00:00', '2024-08-14 00:00:00', 1),
(5, '2024-05-06 00:00:00', '2026-01-19 00:00:00', 2),
(8, '2024-10-09 00:00:00', '2025-01-23 00:00:00', 2),
(6, '2024-08-23 00:00:00', '2026-01-19 00:00:00', 3),
(6, '2025-01-07 00:00:00', '2025-07-21 00:00:00', 1),
(9, '2021-06-14 00:00:00', '2021-09-01 00:00:00', 3),
(9, '2024-08-19 00:00:00', '2025-07-28 00:00:00', 3),
(7, '2024-12-03 00:00:00', '2025-02-03 00:00:00', 3),
(4, '2024-09-22 00:00:00', '2025-08-06 00:00:00', 4),
(3, '2025-04-02 00:00:00', '2025-07-27 00:00:00', 1),
(10, '2024-11-05 00:00:00', '2024-12-19 00:00:00', 2),
(2, '2024-12-28 00:00:00', '2026-01-19 00:00:00', 3),
(8, '2025-04-10 00:00:00', '2025-05-01 00:00:00', 1),
(8, '2025-08-17 00:00:00', '2026-01-29 00:00:00', 2),
(4, '2024-05-08 00:00:00', '2024-06-12 00:00:00', 4),
(5, '2024-05-21 00:00:00', '2025-04-10 00:00:00', 3),
(2, '2024-11-17 00:00:00', '2025-01-04 00:00:00', 3),
(6, '2024-10-31 00:00:00', '2025-08-08 00:00:00', 2),
(9, '2026-05-15 00:00:00', '2026-05-17 00:00:00', 4),
(7, '2025-01-04 00:00:00', '2025-09-26 00:00:00', 4),
(3, '2025-05-31 21:20:14', '2025-06-12 21:20:14', 4),
(3, '2025-07-17 20:56:05', '2025-07-25 20:56:05', 2),
(3, '2025-05-31 20:56:05', '2025-06-12 20:56:05', 2),
(3, '2026-01-05 00:00:00', '2026-02-12 00:00:00', 1),
(3, '2027-12-18 00:00:00', '2027-12-19 00:00:00', 3);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Farley', 'Jason', '05 93 98 28 30', 'cum@icloud.couk', 2),
(2, 'Bradley', 'Xenos', '03 60 26 46 57', 'tellus.imperdiet@google.org', 3),
(3, 'Beach', 'Debra', '08 38 35 97 89', 'tincidunt.congue.turpis@yahoo.couk', 3),
(4, 'Silva', 'Bradley', '08 59 82 24 63', 'at@google.couk', 1),
(5, 'James', 'Chiquita', '06 97 04 86 10', 'amet.consectetuer@hotmail.net', 1),
(6, 'Carpenter', 'Bianca', '08 64 66 28 15', 'eu@aol.net', 2),
(7, 'Lang', 'Tyler', '05 36 48 23 23', 'non@protonmail.ca', 2),
(8, 'Adams', 'Bert', '08 80 08 12 84', 'et.netus.et@protonmail.ca', 2),
(9, 'Whitley', 'Deanna', '06 95 03 56 30', 'non.egestas@hotmail.edu', 2),
(10, 'Tillman', 'Evelyn', '07 96 62 59 72', 'gravida.non@hotmail.edu', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', 'f4f263e439cf40925e6a412387a9472a6773c2580212a4fb50d224d3a817de17');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
