-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Ott 20, 2023 alle 16:34
-- Versione del server: 8.0.29
-- Versione PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tombola`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `cartelle`
--

CREATE TABLE `cartelle` (
  `id` int NOT NULL COMMENT 'ID della cartella',
  `id_giocatore` int NOT NULL COMMENT 'ID del giocatore che possiede la cartella',
  `id_partita` int NOT NULL COMMENT 'ID della partita',
  `primo_numero` smallint NOT NULL COMMENT 'Primo numero della cartella',
  `secondo_numero` smallint NOT NULL COMMENT 'Secondo numero della cartella',
  `terzo_numero` smallint NOT NULL COMMENT 'Terzo numero della cartella',
  `quarto_numero` smallint NOT NULL COMMENT 'Quarto numero della cartella',
  `quinto_numero` smallint NOT NULL COMMENT 'Quinto numero della cartella',
  `sesto_numero` smallint NOT NULL COMMENT 'Sesto numero della cartella',
  `settimo_numero` smallint NOT NULL COMMENT 'Settimo numero della cartella',
  `ottavo_numero` smallint NOT NULL COMMENT 'Ottavo numero della cartella',
  `nono_numero` smallint NOT NULL COMMENT 'Nono numero della cartella',
  `decimo_numero` smallint NOT NULL COMMENT 'Decimo numero della cartella',
  `undicesimo_numero` smallint NOT NULL COMMENT 'Undicesimo numero della cartella',
  `dodicesimo_numero` smallint NOT NULL COMMENT 'Dodicesimo numero della cartella',
  `tredicesimo_numero` smallint NOT NULL COMMENT 'Tredicesimo numero della cartella',
  `quattordicesimo_numero` smallint NOT NULL COMMENT 'Quattordicesimo numero della cartella',
  `quindicesimo_numero` smallint NOT NULL COMMENT 'Quindicesimo numero della cartella',
  `primo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il primo numero è stato estratto',
  `secondo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il secondo numero è stato estratto',
  `terzo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il terzo numero è stato estratto',
  `quarto_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il quarto numero è stato estratto',
  `quinto_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il quinto numero è stato estratto',
  `sesto_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il sesto numero è stato estratto',
  `settimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il settimo numero è stato estratto',
  `ottavo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se l''ottavo numero è stato estratto',
  `nono_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il nono numero è stato estratto',
  `decimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il decimo numero è stato estratto',
  `undicesimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se l''undicesimo numero è stato estratto',
  `dodicesimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il dodicesimo numero è stato estratto',
  `tredicesimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il tredicesimo numero è stato estratto',
  `quattordicesimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il quattordicesimo numero è stato estratto',
  `quindicesimo_numero_estratto` int NOT NULL COMMENT 'Booleano che indica se il quindicesimo numero è stato estratto'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `estrazioni`
--

CREATE TABLE `estrazioni` (
  `id` int NOT NULL,
  `id_partita` int NOT NULL,
  `numero_estratto` smallint NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `giocatori`
--

CREATE TABLE `giocatori` (
  `id` int NOT NULL COMMENT 'ID del giocatore',
  `nome` varchar(50) NOT NULL COMMENT 'Nome del giocatore',
  `cognome` varchar(50) NOT NULL COMMENT 'Cognome del giocatore',
  `nickname` varchar(50) NOT NULL COMMENT 'Nickname del giocatore'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Struttura della tabella `partite`
--

CREATE TABLE `partite` (
  `id` int NOT NULL COMMENT 'ID della partita',
  `prezzo` decimal(3,2) DEFAULT NULL COMMENT 'Prezzo della partita',
  `valore_ambo` decimal(3,2) DEFAULT NULL COMMENT 'Valore dell''ambo',
  `valore_terna` decimal(3,2) DEFAULT NULL COMMENT 'Valore della terna',
  `valore_quaterna` decimal(3,2) DEFAULT NULL COMMENT 'Valore della quaterna',
  `valore_cinquina` decimal(3,2) DEFAULT NULL COMMENT 'Valore della cinquina',
  `valore_tombola` decimal(3,2) DEFAULT NULL COMMENT 'Valore della tombola'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `cartelle`
--
ALTER TABLE `cartelle`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_partita` (`id_partita`),
  ADD KEY `id_giocatore` (`id_giocatore`);

--
-- Indici per le tabelle `estrazioni`
--
ALTER TABLE `estrazioni`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_partita_2` (`id_partita`);

--
-- Indici per le tabelle `giocatori`
--
ALTER TABLE `giocatori`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `partite`
--
ALTER TABLE `partite`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `cartelle`
--
ALTER TABLE `cartelle`
  MODIFY `id` int NOT NULL AUTO_INCREMENT COMMENT 'ID della cartella';

--
-- AUTO_INCREMENT per la tabella `estrazioni`
--
ALTER TABLE `estrazioni`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT per la tabella `giocatori`
--
ALTER TABLE `giocatori`
  MODIFY `id` int NOT NULL AUTO_INCREMENT COMMENT 'ID del giocatore';

--
-- AUTO_INCREMENT per la tabella `partite`
--
ALTER TABLE `partite`
  MODIFY `id` int NOT NULL AUTO_INCREMENT COMMENT 'ID della partita';

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `cartelle`
--
ALTER TABLE `cartelle`
  ADD CONSTRAINT `id_giocatore` FOREIGN KEY (`id_giocatore`) REFERENCES `giocatori` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `id_partita` FOREIGN KEY (`id_partita`) REFERENCES `partite` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limiti per la tabella `estrazioni`
--
ALTER TABLE `estrazioni`
  ADD CONSTRAINT `id_partita_2` FOREIGN KEY (`id_partita`) REFERENCES `partite` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
