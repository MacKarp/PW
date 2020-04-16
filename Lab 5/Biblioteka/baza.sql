-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Wersja serwera:               8.0.19 - MySQL Community Server - GPL
-- Serwer OS:                    Win64
-- HeidiSQL Wersja:              10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Zrzut struktury bazy danych bibliotekadb
CREATE DATABASE IF NOT EXISTS `bibliotekadb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bibliotekadb`;

-- Zrzut struktury tabela bibliotekadb.ksiazki
CREATE TABLE IF NOT EXISTS `ksiazki` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nazwa` varchar(50) NOT NULL DEFAULT '0',
  `Autor` varchar(50) NOT NULL DEFAULT '0',
  `Gatunek` varchar(50) DEFAULT '0',
  `ISBN` bigint DEFAULT NULL,
  `Wydawnictwo` varchar(50) DEFAULT NULL,
  `Sektor` int DEFAULT '0',
  `Regał` int DEFAULT '0',
  `Pozycja` int DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Zrzucanie danych dla tabeli bibliotekadb.ksiazki: ~0 rows (około)
/*!40000 ALTER TABLE `ksiazki` DISABLE KEYS */;
INSERT INTO `ksiazki` (`ID`, `Nazwa`, `Autor`, `Gatunek`, `ISBN`, `Wydawnictwo`, `Sektor`, `Regał`, `Pozycja`) VALUES
	(1, 'Gra Endera', 'Orson Scott Card', 'Fantastyka', 9788376482514, 'Prószyński i S-ka', 3, 5, 23),
	(2, 'Mówca umarłych', 'Orson Scott Card', 'Fantastyka', 9788376483443, 'Prószyński i S-ka', 3, 5, 24),
	(3, 'Ksenocyd', 'Orson Scott Card', 'Fantastyka', 9788376483580, 'Prószyński i S-ka', 3, 5, 25),
	(4, 'Dzieci umysłu', 'Orson Scott Card', 'Fantastyka', 9788376483917, 'Prószyński i S-ka', 3, 5, 26),
	(5, 'Serce gangstera', 'Anna Wolf', 'Literatura obyczajowa', 9788381782012, 'NieZwykłe', 2, 1, 12),
	(6, 'Zemsta gangstera', 'Anna Wolf', 'Literatura obyczajowa', 9788381782982, 'NieZwykłe', 2, 1, 13),
	(8, 'Pacjentka', 'Alex Michaelides', 'Kryminał', 9788328061477, 'W.A.B.', 4, 3, 6),
	(9, 'Gdzie śpiewają raki', 'Delia Owens', 'Literatura piękna', 9788381392686, 'Świat Książki', 1, 1, 12),
	(10, 'Pakt z diabłem', 'Meghan March', 'Literatura obyczajowa', 9788328362154, 'Editio', 2, 2, 1),
	(11, 'Córka gliniarza', 'Kristen Ashley', 'Literatura obyczajowa', 9788328713567, 'Akurat', 2, 2, 15);
/*!40000 ALTER TABLE `ksiazki` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
