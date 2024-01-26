-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 26. Jan 2024 um 12:35
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
-- Datenbank: `spieletraum-db`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE `artikel` (
  `Art_Nr` int(6) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Beschreibung` varchar(255) NOT NULL,
  `Vk_Preis` varchar(255) NOT NULL,
  `Wg_Nr` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`Art_Nr`, `Name`, `Beschreibung`, `Vk_Preis`, `Wg_Nr`) VALUES
(1, 'Lego Bausatz', 'LEGO NINJAGO Egalt der Meisterdrache', '49.99€', 101),
(2, 'Carrera Bahn', 'Carrera 20030011 GT Race Battle', '298.49€', 102),
(3, 'Nerf Gun', 'Nerf Elite 2.0 Shockwave', '24.99€', 103),
(4, 'Hot Wheels', 'Hot Wheels 54886 ', '14.99€', 104),
(5, 'Beyblade Burst Set', 'Beyblade Burst QuadStrike Battle Set', '39.99€', 105),
(6, 'Buch', 'Flora und der Bär im Zauberwald', '12.00€', 106),
(7, 'Regenbogen-Stapeltürme', 'Bunte Stapeltürme für kreatives Spielen', '24.99€', 206),
(8, 'Lern-Tablet', 'Interaktives Tablet für spielerisches Lernen', '39.99€', 107),
(9, 'Plüsch-Elefant', 'Kuscheliger Elefant aus hochwertigem Plüsch', '19.99€', 108),
(10, 'Holzbausteine-Set', 'Set mit 50 bunten Holzbausteinen', '29.99€', 109),
(11, 'Malbuch-Set', 'Kreatives Malbuch-Set mit Farbstiften', '14.99€', 110),
(12, 'Puzzle-Spiel', 'Tierpuzzle mit 100 Teilen für kniffligen Spaß', '17.99€', 111),
(13, 'Musik-Mobile', 'Buntes Musik-Mobile für das Kinderbett', '22.99€', 112),
(14, 'Fisher-Price Spielzeugauto', 'Robustes Spielzeugauto für kleine Abenteurer', '9.99€', 113),
(15, 'Teddybär mit Herz', 'Kuscheliger Teddybär mit Herzapplikation', '18.99€', 114),
(16, 'Kinderküchen-Set', 'Miniatur-Küchenset für angehende Köche', '32.99€', 115),
(17, 'Bauernhof-Spielset', 'Detailreiches Bauernhof-Spielset mit Tieren', '27.99€', 116),
(18, 'Buntes Kreisel-Set', 'Set mit bunten Kreiseln für lustige Drehungen', '14.99€', 117),
(19, 'Kinderkamera', 'Digitale Kinderkamera für erste Fotoabenteuer', '33.99€', 118),
(20, 'Puppenhaus', 'Zauberhaftes Puppenhaus mit Möbeln und Figuren', '49.99€', 119),
(21, 'Bastel-Set', 'Kreatives Bastel-Set für kleine Künstler', '19.99€', 120),
(22, 'Roboter-Bausatz', 'Bausatz für einen kleinen Roboterkameraden', '28.99€', 121),
(23, 'Kinder-Smartwatch', 'Smartwatch für Kinder mit Spielen und Uhrfunktionen', '36.99€', 122),
(24, 'Stofftier-Dinosaurier', 'Weiches Stofftier in Dinosaurierform', '15.99€', 123),
(25, 'Kinder-Schaukel', 'Stabile Schaukel für den Garten oder das Kinderzimmer', '42.99€', 124),
(26, 'Malen-nach-Zahlen-Set', 'Malen-nach-Zahlen-Set mit verschiedenen Motiven', '21.99€', 125);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel_lieferant`
--

CREATE TABLE `artikel_lieferant` (
  `Art_Nr` int(6) NOT NULL,
  `L_Nr` int(6) NOT NULL,
  `Ekpreis` varchar(255) NOT NULL
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
  `Auf_Datum` varchar(255) NOT NULL,
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
  `Kategorie` varchar(255) NOT NULL
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
  `Anrede` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Vorname` varchar(255) NOT NULL,
  `Straße` varchar(255) NOT NULL,
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
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
(5, 'Herr', 'Hubner', 'Oliver', 'Ulmenweg 9', 57319, 'Bad Berleburg', 'Oliver.Hubner@gmail.com', 2147483647, 2),
(6, 'Frau', 'Becker', 'Julia', 'Ahornweg 3', 57462, 'Olpe', 'Julia.Becker@gmail.com', 2147483647, 3),
(7, 'Herr', 'Schulz', 'Markus', 'Buchenstraße 12', 57392, 'Schmallenberg', 'Markus.Schulz@gmail.com', 2147483647, 2),
(8, 'Frau', 'Lorenz', 'Isabell', 'Erlenweg 7', 57392, 'Schmallenberg', 'Isabell.Lorenz@gmail.com', 2147483647, 1),
(9, 'Herr', 'Bach', 'Christian', 'Fichtenweg 4', 57319, 'Bad Berleburg', 'Christian.Bach@gmail.com', 2147483647, 1),
(10, 'Frau', 'Fischer', 'Lena', 'Kiefernstraße 11', 57319, 'Bad Berleburg', 'Lena.Fischer@gmail.com', 2147483647, 2),
(11, 'Frau', 'Wagner', 'Sophie', 'Tannenweg 6', 57072, 'Siegen', 'Sophie.Wagner@gmail.com', 2147483647, 3),
(12, 'Herr', 'Koch', 'Dominik', 'Birkenstraße 15', 57250, 'Netphen', 'Dominik.Koch@gmail.com', 2147483647, 2),
(13, 'Frau', 'Schmidt', 'Anna', 'Kastanienweg 7', 57074, 'Siegen', 'Anna.Schmidt@gmail.com', 2147483647, 1),
(14, 'Herr', 'Müller', 'Martin', 'Eichenallee 9', 57290, 'Neunkirchen', 'Martin.Mueller@gmail.com', 2147483647, 1),
(15, 'Frau', 'Schneider', 'Laura', 'Ahornstraße 22', 57078, 'Wilnsdorf', 'Laura.Schneider@gmail.com', 2147483647, 2),
(21, 'Frau', 'Richter', 'Lisa', 'Ahornallee 14', 57462, 'Olpe', 'Lisa.Richter@gmail.com', 2147483647, 3),
(22, 'Herr', 'Weiss', 'Sebastian', 'Erlenstraße 10', 57462, 'Olpe', 'Sebastian.Weiss@gmail.com', 2147483647, 2),
(23, 'Frau', 'Lang', 'Mia', 'Buchenweg 7', 57462, 'Olpe', 'Mia.Lang@gmail.com', 2147483647, 1),
(24, 'Herr', 'Fuchs', 'David', 'Kiefernweg 5', 57462, 'Olpe', 'David.Fuchs@gmail.com', 2147483647, 1),
(25, 'Frau', 'Bergmann', 'Jana', 'Lindenstraße 12', 57462, 'Olpe', 'Jana.Bergmann@gmail.com', 2147483647, 2),
(26, 'Herr', 'Stein', 'Alexander', 'Birkenallee 18', 57462, 'Olpe', 'Alexander.Stein@gmail.com', 2147483647, 3);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lieferant`
--

CREATE TABLE `lieferant` (
  `L_Nr` int(6) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Straße` varchar(255) NOT NULL,
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
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
(5, 'Glom', 'Musterallee 202', 34567, 'Musterstadt', 'glom@example.com', 2147483647),
(6, 'Becker', 'Lindenstraße 15', 59555, 'Lippstadt', 'becker@example.com', 2147483647),
(7, 'Weber', 'Eichenweg 28', 33333, 'Geseke', 'weber@example.com', 2147483647),
(8, 'Schulz', 'Buchenallee 42', 44444, 'Erwitte', 'schulz@example.com', 2147483647),
(9, 'Fischer', 'Ahornplatz 7', 59555, 'Lippstadt', 'fischer@example.com', 2147483647),
(10, 'Schneider', 'Kiefernweg 10', 33333, 'Geseke', 'schneider@example.com', 2147483647),
(11, 'Koch', 'Erlenstraße 21', 44444, 'Erwitte', 'koch@example.com', 2147483647),
(12, 'Schulze', 'Ulmenweg 33', 59555, 'Lippstadt', 'schulze@example.com', 2147483647),
(13, 'Bauer', 'Lärchenplatz 12', 33333, 'Geseke', 'bauer@example.com', 2147483647),
(14, 'Hoffmann', 'Kastanienallee 8', 44444, 'Erwitte', 'hoffmann@example.com', 2147483647),
(15, 'Wagner', 'Eschenweg 5', 59555, 'Lippstadt', 'wagner@example.com', 2147483647),
(16, 'Schäfer', 'Birkenstraße 19', 33333, 'Geseke', 'schaefer@example.com', 2147483647),
(17, 'Maier', 'Tannenweg 14', 44444, 'Erwitte', 'maier@example.com', 2147483647),
(18, 'Kühn', 'Lindenplatz 26', 59555, 'Lippstadt', 'kuehn@example.com', 2147483647),
(19, 'Hartmann', 'Eichenstraße 31', 33333, 'Geseke', 'hartmann@example.com', 2147483647),
(20, 'Zimmermann', 'Buchenweg 3', 44444, 'Erwitte', 'zimmermann@example.com', 2147483647),
(21, 'Lange', 'Ahornweg 17', 59555, 'Lippstadt', 'lange@example.com', 2147483647),
(22, 'Schmitt', 'Kiefernpfad 22', 33333, 'Geseke', 'schmitt@example.com', 2147483647),
(23, 'Wolf', 'Ulmenstraße 13', 44444, 'Erwitte', 'wolf@example.com', 2147483647),
(24, 'Schulz', 'Lindenplatz 7', 59555, 'Lippstadt', 'schulz2@example.com', 2147483647),
(25, 'Koch', 'Kastanienweg 18', 33333, 'Geseke', 'koch2@example.com', 2147483647),
(26, 'Bauer', 'Erlenplatz 29', 44444, 'Erwitte', 'bauer2@example.com', 2147483647);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE `mitarbeiter` (
  `M_Nr` varchar(255) NOT NULL,
  `Anrede` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Vorname` varchar(255) NOT NULL,
  `passwort` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `mitarbeiter`
--

INSERT INTO `mitarbeiter` (`M_Nr`, `Anrede`, `Name`, `Vorname`, `passwort`) VALUES
('user', '', '', '', 'user'),
('M_A001', 'Herr', 'Jauch', 'Günter', 'JG123'),
('M_A002', 'Frau', 'Müller', 'Bergitte', 'MB123');

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
  `warengruppe` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `warengruppe`
--

INSERT INTO `warengruppe` (`Wg_Nr`, `warengruppe`) VALUES
(101, 'Klemmbausteine'),
(102, 'Renn-Bahn'),
(103, 'Spielzeug Waffe'),
(104, 'Spielzeug Autos'),
(105, 'Spielzeug Kreisel'),
(106, 'Bücher'),
(107, 'Lernspielzeug'),
(108, 'Plüschtiere'),
(109, 'Holzspielzeug'),
(110, 'Malutensilien'),
(111, 'Puzzle'),
(112, 'Mobiles'),
(113, 'Fahrzeuge'),
(114, 'Kuscheltiere'),
(115, 'Spielküchen'),
(116, 'Bauernhofspielzeug'),
(117, 'Kreisel'),
(118, 'Elektronisches Spielzeug'),
(119, 'Puppenhäuser'),
(120, 'Bastelsets'),
(121, 'Bausätze'),
(122, 'Kinderuhren'),
(123, 'Stofftiere'),
(124, 'Schaukeln'),
(125, 'Malen-nach-Zahlen'),
(206, 'Kreatives Spielzeug');

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
