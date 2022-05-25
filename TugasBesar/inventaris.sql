-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Bulan Mei 2022 pada 07.57
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventaris`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`username`, `password`, `role`) VALUES
('admin', '1234', 1),
('kasir', '1111', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `daftar_service`
--

CREATE TABLE `daftar_service` (
  `id_service` varchar(8) NOT NULL,
  `nama_service` varchar(30) NOT NULL,
  `biaya` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `daftar_service`
--

INSERT INTO `daftar_service` (`id_service`, `nama_service`, `biaya`) VALUES
('27963898', 'Bongkar mesin', 1000000),
('81454723', 'Ganti oli', 20000),
('79922971', 'Pasang gear', 10000),
('32773834', 'Ganti ban', 10000),
('32773834', 'Pasang shockbreaker', 40000),
('93899178', 'Ganti ban', 20000),
('93899178', 'Cat velg', 600000),
('05141767', 'Cat body', 1200000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `daftar_transaksi`
--

CREATE TABLE `daftar_transaksi` (
  `id_transaksi` varchar(8) NOT NULL,
  `kode_barang` varchar(10) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `kuantitas_beli` int(11) NOT NULL,
  `harga_satuan` int(11) NOT NULL,
  `harga_total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `daftar_transaksi`
--

INSERT INTO `daftar_transaksi` (`id_transaksi`, `kode_barang`, `nama_barang`, `kuantitas_beli`, `harga_satuan`, `harga_total`) VALUES
('07185790', 'brg07', 'Gear Set', 1, 120000, 120000),
('07185790', 'brg09', 'Shockbreaker Depan', 1, 600000, 120000),
('07185790', 'brg13', 'Ban R17 120/90', 1, 430000, 120000),
('07444960', 'brg07', 'Gear Set', 1, 120000, 120000),
('07444960', 'brg01', 'Oli Repsol', 1, 50000, 120000),
('07444960', 'brg13', 'Ban R17 120/90', 2, 430000, 860000),
('63037761', 'brg01', 'Oli Repsol', 1, 50000, 50000),
('63037761', 'brg07', 'Gear Set', 1, 120000, 50000),
('33779021', 'brg01', 'Oli Repsol', 1, 50000, 50000),
('33779021', 'brg04', 'Spion', 1, 25000, 50000),
('20978732', 'brg01', 'Oli Repsol', 1, 50000, 50000),
('20978732', 'brg09', 'Shockbreaker Depan', 1, 600000, 50000),
('72565334', 'brg09', 'Shockbreaker Depan', 1, 600000, 600000),
('72565334', 'brg04', 'Spion', 1, 25000, 600000),
('87468510', 'brg04', 'Spion', 1, 25000, 25000),
('87468510', 'brg09', 'Shockbreaker Depan', 1, 600000, 25000),
('11509413', 'brg07', 'Gear Set', 1, 120000, 120000),
('11509413', 'brg04', 'Spion', 1, 25000, 120000),
('11509413', 'brg13', 'Ban R17 120/90', 1, 430000, 120000),
('88925615', 'brg04', 'Spion', 1, 25000, 25000),
('52698923', 'brg04', 'Spion', 1, 25000, 25000),
('52698923', 'brg09', 'Shockbreaker Depan', 1, 600000, 25000),
('86797353', 'brg01', 'Oli Repsol', 1, 50000, 50000),
('86797353', 'brg04', 'Spion', 2, 25000, 50000),
('86797353', 'brg07', 'Gear Set', 1, 120000, 120000),
('86797353', 'brg09', 'Shockbreaker Depan', 1, 600000, 120000),
('86797353', 'brg13', 'Ban R17 120/90', 2, 430000, 860000),
('51819971', 'brg04', 'Spion', 4, 25000, 100000),
('51819971', 'brg09', 'Shockbreaker Depan', 1, 600000, 600000),
('07364119', 'brg01', 'Oli Repsol', 1, 50000, 50000),
('07364119', 'brg09', 'Shockbreaker Depan', 1, 600000, 600000),
('07364119', 'brg04', 'Spion', 2, 25000, 50000),
('68297725', 'brg04', 'Spion', 3, 25000, 75000),
('68297725', 'brg13', 'Ban R17 120/90', 2, 430000, 860000),
('48553244', 'brg04', 'Spion', 2, 25000, 50000),
('48553244', 'brg13', 'Ban R17 120/90', 2, 430000, 860000),
('26713546', 'brg04', 'Spion', 4, 25000, 100000),
('26713546', 'brg13', 'Ban R17 120/90', 2, 430000, 860000),
('51436576', 'brg01', 'Oli Repsol', 3, 50000, 150000),
('51436576', 'brg07', 'Gear Set', 1, 120000, 120000),
('51436576', 'brg09', 'Shockbreaker Depan', 1, 600000, 120000),
('51436576', 'brg04', 'Spion', 1, 25000, 120000),
('92593539', 'brg09', 'Shockbreaker Depan', 3, 600000, 1800000),
('92593539', 'brg07', 'Gear Set', 2, 120000, 240000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_barang`
--

CREATE TABLE `data_barang` (
  `id_barang` int(10) NOT NULL,
  `kode_barang` varchar(10) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `kuantitas_barang` int(11) NOT NULL,
  `kuantitas_jual` int(11) NOT NULL,
  `satuan_barang` enum('pcs','pak','dus','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `data_barang`
--

INSERT INTO `data_barang` (`id_barang`, `kode_barang`, `nama_barang`, `harga_beli`, `harga_jual`, `kuantitas_barang`, `kuantitas_jual`, `satuan_barang`) VALUES
(1, 'brg01', 'Oli Repsol', 45000, 50000, 33, 3, 'pcs'),
(3, 'brg04', 'Spion', 20000, 25000, 31, 7, 'pak'),
(4, 'brg07', 'Gear Set', 100000, 120000, 28, 3, 'pcs'),
(5, 'brg09', 'Shockbreaker Depan', 500000, 600000, 33, 4, 'pcs'),
(6, 'brg13', 'Ban R17 120/90', 400000, 430000, 26, 4, 'pcs');

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_pegawai`
--

CREATE TABLE `data_pegawai` (
  `id_pegawai` int(11) NOT NULL,
  `nama_pegawai` varchar(30) NOT NULL,
  `tempat_lahir` varchar(30) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `agama` enum('Islam','Katholik','Protestan','Budha','Hindu','Konghucu') NOT NULL,
  `alamat` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `data_pegawai`
--

INSERT INTO `data_pegawai` (`id_pegawai`, `nama_pegawai`, `tempat_lahir`, `tanggal_lahir`, `agama`, `alamat`) VALUES
(1, 'Ricky Maulana', 'Tebing Tinggi', '2002-04-01', 'Islam', 'Jambi'),
(2, 'Hajuen Ega', 'Padang', '2002-09-11', 'Islam', 'Simpang Rimbo'),
(3, 'Ricardo Ronaldo', 'Maluku', '1998-12-17', 'Katholik', 'Pijoan'),
(10, 'Ahmad Dahlan', 'Jakarta', '2003-02-05', 'Islam', 'Jelutung'),
(11, 'Dani Rahmat', 'Bulian', '2022-05-16', 'Islam', 'Jambi'),
(12, 'Sukarni Jaya', 'Surabaya', '1997-10-23', 'Islam', 'Handil Jaya'),
(13, 'Adam Maulana', 'Sarolangun', '2004-12-02', 'Islam', 'Kerinci'),
(14, 'Ucok Baba Siregar', 'Karo', '1999-07-22', 'Katholik', 'Simp. Rimbo'),
(15, 'Gede Krisna', 'Bali', '2000-08-26', 'Hindu', 'Pattimura'),
(18, 'Xi Luan', 'Surabaya', '2003-05-28', 'Konghucu', 'Thehok'),
(20, 'Irwan Maulana', 'Tebo', '2000-08-29', 'Islam', 'Tungkal'),
(22, 'Amir', 'Papua', '2001-08-18', 'Islam', 'Jambi');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `id_transaksi` varchar(8) NOT NULL,
  `tgl_jual` date NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`id_transaksi`, `tgl_jual`, `total`) VALUES
('07185790', '2022-05-17', 360000),
('07364119', '2022-05-18', 700000),
('07444960', '2022-05-17', 1100000),
('11509413', '2022-05-17', 360000),
('20978732', '2022-05-17', 100000),
('26713546', '2022-05-18', 960000),
('33779021', '2022-05-17', 100000),
('48553244', '2022-05-18', 910000),
('51436576', '2022-05-18', 510000),
('51819971', '2022-05-17', 700000),
('52698923', '2022-05-17', 50000),
('63037761', '2022-05-17', 100000),
('68297725', '2022-05-18', 935000),
('72565334', '2022-05-17', 1200000),
('86797353', '2022-05-17', 1200000),
('87468510', '2022-05-17', 50000),
('88925615', '2022-05-17', 385000),
('92593539', '2022-05-20', 2040000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `service`
--

CREATE TABLE `service` (
  `id_service` varchar(8) NOT NULL,
  `tgl_service` date NOT NULL,
  `total_biaya` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `service`
--

INSERT INTO `service` (`id_service`, `tgl_service`, `total_biaya`) VALUES
('05141767', '2022-05-18', 1200000),
('32773834', '2022-05-18', 50000),
('79922971', '2022-05-18', 10000),
('81454723', '2022-05-18', 20000),
('93899178', '2022-05-18', 620000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('admin', '1234');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`username`);

--
-- Indeks untuk tabel `data_barang`
--
ALTER TABLE `data_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `data_pegawai`
--
ALTER TABLE `data_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indeks untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indeks untuk tabel `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`id_service`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `data_barang`
--
ALTER TABLE `data_barang`
  MODIFY `id_barang` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT untuk tabel `data_pegawai`
--
ALTER TABLE `data_pegawai`
  MODIFY `id_pegawai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
