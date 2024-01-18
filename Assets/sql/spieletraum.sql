-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 18. Jan 2024 um 09:02
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `spieletraum`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE `artikel` (
  `Art_Nr` int(6) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Beschreibung` varchar(30) NOT NULL,
  `Vk_Preis` varchar(30) NOT NULL,
  `Wg_Nr` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`Art_Nr`, `Name`, `Beschreibung`, `Vk_Preis`, `Wg_Nr`) VALUES
(1, 'Lego Bausatz', 'LEGO NINJAGO Egalt der Meister', '49.99€', 101),
(2, 'Carrera Bahn', 'Carrera 20030011 GT Race Battl', '298.49€', 102),
(3, 'Nerf Gun', 'Nerf Elite 2.0 Shockwave', '24.99€', 103),
(4, 'Hot Wheels', 'Hot Wheels 54886 ', '14.99€', 104),
(5, 'Beyblade Burst Set', 'Beyblade Burst QuadStrike Batt', '39.99€', 105);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel_lieferant`
--

CREATE TABLE `artikel_lieferant` (
  `Art_Nr` int(6) NOT NULL,
  `L_Nr` int(6) NOT NULL,
  `Ekpreis` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikel_lieferant`
--

INSERT INTO `artikel_lieferant` (`Art_Nr`, `L_Nr`, `Ekpreis`) VALUES
(1, 2, '40.49€'),
(2, 3, '241.78€'),
(3, 4, '20.24€'),
(4, 5, '12.14€'),
(5, 1, '32.39€');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `auftrag`
--

CREATE TABLE `auftrag` (
  `Auf_NR` int(6) NOT NULL,
  `Auf_Datum` varchar(10) NOT NULL,
  `K_Nr` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `auftrag`
--

INSERT INTO `auftrag` (`Auf_NR`, `Auf_Datum`, `K_Nr`) VALUES
(1, '2023-10-24', 3),
(2, '2023-07-07', 4),
(3, '2023-04-25', 2),
(4, '2023-10-11', 1),
(5, '2023-08-03', 5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kategorie`
--

CREATE TABLE `kategorie` (
  `Kat_Nr` int(6) NOT NULL,
  `Kategorie` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kategorie`
--

INSERT INTO `kategorie` (`Kat_Nr`, `Kategorie`) VALUES
(1, 'Normal'),
(2, 'VIP'),
(3, 'Premium');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunden`
--

CREATE TABLE `kunden` (
  `K_NR` int(6) NOT NULL,
  `Anrede` varchar(30) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Vorname` varchar(30) NOT NULL,
  `Straße` varchar(30) NOT NULL,
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Tel_Nr` int(15) NOT NULL,
  `Kat_Nr` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kunden`
--

INSERT INTO `kunden` (`K_NR`, `Anrede`, `Name`, `Vorname`, `Straße`, `PLZ`, `Ort`, `Email`, `Tel_Nr`, `Kat_Nr`) VALUES
(1, 'Herr', 'Klink', 'Viktor', 'Am Hang 2', 57462, 'Olpe', 'Viktor.Klink@gmail.com', 2147483647, 1),
(2, 'Frau', 'Maura', 'Tamara', 'Leostraße 5', 57392, 'Schmallenberg', 'Tamara.Maura@gmail.com', 2147483647, 1),
(3, 'Herr', 'Burow', 'Volker', 'Heidenstraße 16', 57392, 'Schmallenberg', 'Volker.Burow@gmail.com', 2147483647, 2),
(4, 'Frau', 'Muhr', 'Manuela', 'Lindenweg 8', 57319, 'Bad Berleburg', 'Manuela.Muhr@gmail.com', 2147483647, 3),
(5, 'Herr', 'Hubner', 'Oliver', 'Ulmenweg 9', 57319, 'Bad Berleburg', 'Oliver.Hubner@gmail.com', 2147483647, 2);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lieferant`
--

CREATE TABLE `lieferant` (
  `L_Nr` int(6) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Straße` varchar(30) NOT NULL,
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Tel_Nr` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `lieferant`
--

INSERT INTO `lieferant` (`L_Nr`, `Name`, `Straße`, `PLZ`, `Ort`, `Email`, `Tel_Nr`) VALUES
(1, 'Müller', 'Musterstraße 123', 12345, 'Musterstadt', 'mueller@example.com', 2147483647),
(2, 'Myer', 'Beispielweg 456', 56789, 'Beispielstadt', 'myer@example.com', 2147483647),
(3, 'Schmit', 'Testgasse 789', 23456, 'Teststadt', 'schmit@example.com', 2147483647),
(4, 'Schutzt', 'Probestraße 101', 78901, 'Probewohnort', 'schutzt@example.com', 2147483647),
(5, 'Glom', 'Musterallee 202', 34567, 'Musterstadt', 'glom@example.com', 2147483647);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE `mitarbeiter` (
  `M_Nr` varchar(30) NOT NULL,
  `Anrede` varchar(30) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Vorname` varchar(30) NOT NULL,
  `passwort` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `mitarbeiter`
--

INSERT INTO `mitarbeiter` (`M_Nr`, `Anrede`, `Name`, `Vorname`, `passwort`) VALUES
('user', '', '', '', 'user');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `positionen`
--

CREATE TABLE `positionen` (
  `P_Nr` int(6) NOT NULL,
  `Auf_Nr` int(6) NOT NULL,
  `Art_Nr` int(6) NOT NULL,
  `Menge` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `positionen`
--

INSERT INTO `positionen` (`P_Nr`, `Auf_Nr`, `Art_Nr`, `Menge`) VALUES
(1, 2, 4, 5),
(2, 3, 5, 6),
(3, 4, 3, 4),
(4, 5, 1, 3),
(5, 1, 2, 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `warengruppe`
--

CREATE TABLE `warengruppe` (
  `Wg_Nr` int(6) NOT NULL,
  `warengruppe` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `warengruppe`
--

INSERT INTO `warengruppe` (`Wg_Nr`, `warengruppe`) VALUES
(101, 'Klemmbausteine'),
(102, 'Renn-Bahn'),
(103, 'Spielzeug Waffe'),
(104, 'Spielzeug Autos'),
(105, 'Spielzeug Kreisel');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `artikel`
--
ALTER TABLE `artikel`
  ADD PRIMARY KEY (`Art_Nr`),
  ADD KEY `Wg_Nr` (`Wg_Nr`);

--
-- Indizes für die Tabelle `artikel_lieferant`
--
ALTER TABLE `artikel_lieferant`
  ADD PRIMARY KEY (`Art_Nr`,`L_Nr`),
  ADD KEY `L_Nr` (`L_Nr`);

--
-- Indizes für die Tabelle `auftrag`
--
ALTER TABLE `auftrag`
  ADD PRIMARY KEY (`Auf_NR`),
  ADD KEY `K_Nr` (`K_Nr`);

--
-- Indizes für die Tabelle `kategorie`
--
ALTER TABLE `kategorie`
  ADD PRIMARY KEY (`Kat_Nr`);

--
-- Indizes für die Tabelle `kunden`
--
ALTER TABLE `kunden`
  ADD PRIMARY KEY (`K_NR`),
  ADD KEY `Kat_Nr` (`Kat_Nr`);

--
-- Indizes für die Tabelle `lieferant`
--
ALTER TABLE `lieferant`
  ADD PRIMARY KEY (`L_Nr`);

--
-- Indizes für die Tabelle `positionen`
--
ALTER TABLE `positionen`
  ADD PRIMARY KEY (`P_Nr`),
  ADD KEY `Auf_Nr` (`Auf_Nr`),
  ADD KEY `Art_Nr` (`Art_Nr`);

--
-- Indizes für die Tabelle `warengruppe`
--
ALTER TABLE `warengruppe`
  ADD PRIMARY KEY (`Wg_Nr`);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `artikel`
--
ALTER TABLE `artikel`
  ADD CONSTRAINT `artikel_ibfk_1` FOREIGN KEY (`Wg_Nr`) REFERENCES `warengruppe` (`Wg_Nr`);

--
-- Constraints der Tabelle `artikel_lieferant`
--
ALTER TABLE `artikel_lieferant`
  ADD CONSTRAINT `artikel_lieferant_ibfk_1` FOREIGN KEY (`Art_Nr`) REFERENCES `artikel` (`Art_Nr`),
  ADD CONSTRAINT `artikel_lieferant_ibfk_2` FOREIGN KEY (`L_Nr`) REFERENCES `lieferant` (`L_Nr`);

--
-- Constraints der Tabelle `auftrag`
--
ALTER TABLE `auftrag`
  ADD CONSTRAINT `auftrag_ibfk_1` FOREIGN KEY (`K_Nr`) REFERENCES `kunden` (`K_NR`);

--
-- Constraints der Tabelle `kunden`
--
ALTER TABLE `kunden`
  ADD CONSTRAINT `kunden_ibfk_1` FOREIGN KEY (`Kat_Nr`) REFERENCES `kategorie` (`Kat_Nr`);

--
-- Constraints der Tabelle `positionen`
--
ALTER TABLE `positionen`
  ADD CONSTRAINT `positionen_ibfk_1` FOREIGN KEY (`Auf_Nr`) REFERENCES `auftrag` (`Auf_NR`),
  ADD CONSTRAINT `positionen_ibfk_2` FOREIGN KEY (`Art_Nr`) REFERENCES `artikel` (`Art_Nr`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
