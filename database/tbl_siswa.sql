-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Waktu pembuatan: 31. Maret 2011 jam 07:58
-- Versi Server: 5.1.41
-- Versi PHP: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_crud`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_siswa`
--

CREATE TABLE IF NOT EXISTS `tbl_siswa` (
  `no_induk` int(10) NOT NULL,
  `nama_siswa` varchar(100) NOT NULL,
  `kelahiran` varchar(100) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`no_induk`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_siswa`
--

INSERT INTO `tbl_siswa` (`no_induk`, `nama_siswa`, `kelahiran`, `alamat`, `password`) VALUES
(1101, 'Gede Suma Wijaya', 'Denpasar, 04 Februari 1991', 'Denpasar, Balii', '1101'),
(1102, 'Ayus Rampage', 'Banyuwangi, 21 Desember 1987', 'Rogojampi, Banyuwangi', '1102'),
(1103, 'Willy Witanto', 'Banyuwangi, 06 Juli 1991', 'Purwoharjo, Banyuwangi', '1103'),
(1104, 'Puji Agustian A.W.', 'Banyuwangi, 18 Juli 1990', 'Rogojampi, Banyuwangi', '1104'),
(1105, 'Okky Hadi Wibawa', 'Banyuwangi, 07 Oktober 1989', 'Banyuwangi, Jawa Timur', '1105'),
(1106, 'Untung Jasuli', 'Situbondo, 27 Desember 1989', 'Situbondo Rock City', '1106'),
(1107, 'Nur Alimin', 'Banyuwangi, 12 Juli 1988', 'Glagah, Banyuwangi', '1107'),
(1108, 'Ferry Agung', 'Pacitan, 10 November 1988', 'Pacitan, Jawa Timur', '1108');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
