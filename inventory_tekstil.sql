-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2018 at 06:01 AM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_tekstil`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_benang`
--

CREATE TABLE `tbl_benang` (
  `no_barang` int(11) NOT NULL,
  `jenis` varchar(20) NOT NULL,
  `supplier` varchar(200) NOT NULL,
  `harga_beli` bigint(20) NOT NULL,
  `no_lot` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_benang`
--

INSERT INTO `tbl_benang` (`no_barang`, `jenis`, `supplier`, `harga_beli`, `no_lot`, `stok`) VALUES
(1, 'Gintir', 'PT Benang Utama', 10000, 111, 100),
(2, 'Filament', 'PT Tik', 2000, 222, 20),
(3, 'Filament', 'PT. Radius', 10000, 2201, 20);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_in`
--

CREATE TABLE `tbl_in` (
  `id` int(11) NOT NULL,
  `kd_item` int(11) NOT NULL,
  `jenis` varchar(200) NOT NULL,
  `tgl_masuk` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_in`
--

INSERT INTO `tbl_in` (`id`, `kd_item`, `jenis`, `tgl_masuk`, `stok`) VALUES
(1, 0, 'kain', '2018-02-03 02:58:54', 10),
(2, 0, 'kain', '2018-02-03 02:59:07', 10),
(3, 1, 'kain', '2018-02-03 02:59:19', 100),
(4, 0, 'kain', '2018-02-03 03:00:02', 100),
(5, 0, 'kain', '2018-02-03 04:06:02', 9),
(6, 0, 'kain', '2018-02-03 04:10:03', 30),
(7, 0, 'kain', '2018-02-03 04:13:16', 100),
(8, 8, 'kain', '2018-02-03 04:17:51', 10),
(9, 1, 'semical', '2018-02-03 04:24:30', 100),
(10, 2, 'semical', '2018-02-03 04:24:47', 20),
(11, 1, 'semical', '2018-02-03 04:25:10', 20),
(12, 3, 'benang', '2018-02-03 04:26:47', 20);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jenis_kain`
--

CREATE TABLE `tbl_jenis_kain` (
  `kd_jenis` int(11) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `deskripsi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_jenis_kain`
--

INSERT INTO `tbl_jenis_kain` (`kd_jenis`, `nama`, `deskripsi`) VALUES
(1, 'Wools', 'Jenis kain yang cukup berat dan biasa digunakan sebagai bahan dasar pakaian hangat atau sweater. Jika dirawat dengan benar, kain wools memiliki keunggulan tertentu, yaitu lebih awet.'),
(2, 'Polyester', 'kain yang memiliki kesamaan dengan kain katun. Namun, dari segi kualitas, jenis kain ini masih satu tingkat dibawah kain katun. Bahan dasar kain PE adalah benang polyester. Kain Akrilit merupakan salah satu jenis bahan yang biasa digunakan untuk membuat kemeja.'),
(3, 'Chiffon ', 'bahan yang sangat lembut, halus, transparan, dan ‘jatuh’ mengikuti bentuk badan. Karenanya kain ini tidak disarankan untuk digunakan oleh orang yang berbadan gemuk. Bahan ini terkadang sangat panas bila digunakan namun memberikan kesan yang anggun pada si pemakai. Biasanya bahan ini digunakan sebagai dress, blouse, selendang, bahkan pelengkap kebaya ataupun tudung kepala.\r\n\r\n\r\n'),
(4, 'Flannel ', 'jenis kain yang dibuat dari bahan dasar serat wol, tanpa ditenun. Kain ini memiliki tekstur yang agak tebal, namun sangat lembut dan lentur sehingga mudah dibentuk apa saja. Kain Satin merupakan jenis kain yang memiliki permukaan mengkilap serta licin, namun bagian belakangnya suram. ');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kain`
--

CREATE TABLE `tbl_kain` (
  `kd_kain` int(11) NOT NULL,
  `kd_jenis` int(11) NOT NULL,
  `lot` int(11) NOT NULL,
  `panjang` double NOT NULL,
  `gramasi` double NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kain`
--

INSERT INTO `tbl_kain` (`kd_kain`, `kd_jenis`, `lot`, `panjang`, `gramasi`, `stok`) VALUES
(1, 1, 1101, 10, 2, 110),
(2, 2, 2202, 20, 5, 10),
(3, 3, 3303, 10, 10, 100),
(4, 1, 12900, 10, 10, 9),
(5, 2, 1999, 20, 2, 30),
(6, 2, 10, 10, 100, 100),
(7, 3, 111, 10, 2, 5),
(8, 1, 1111, 10, 100, 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_out`
--

CREATE TABLE `tbl_out` (
  `id` int(11) NOT NULL,
  `kd_item` int(11) NOT NULL,
  `jenis` varchar(10) NOT NULL,
  `tgl_keluar` datetime NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='t';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_semical`
--

CREATE TABLE `tbl_semical` (
  `no_barang` int(11) NOT NULL,
  `kd_jenis` varchar(200) NOT NULL,
  `supplier` varchar(200) NOT NULL,
  `harga_beli` bigint(20) NOT NULL,
  `no_lot` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_semical`
--

INSERT INTO `tbl_semical` (`no_barang`, `kd_jenis`, `supplier`, `harga_beli`, `no_lot`, `stok`) VALUES
(1, 'Sodium Nitrit (NaNO2)', 'PT UP', 20000, 1111, 20);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `username`, `firstname`, `lastname`, `password`, `role`) VALUES
(1, 'admin', 'admin', 'admin', 'password', 'admin'),
(2, 'staff', 'staff', 'staff', 'password', 'staff'),
(3, 'manager', 'manager', 'manager', 'password', 'manager');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_benang`
--
ALTER TABLE `tbl_benang`
  ADD PRIMARY KEY (`no_barang`);

--
-- Indexes for table `tbl_in`
--
ALTER TABLE `tbl_in`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_jenis_kain`
--
ALTER TABLE `tbl_jenis_kain`
  ADD PRIMARY KEY (`kd_jenis`);

--
-- Indexes for table `tbl_kain`
--
ALTER TABLE `tbl_kain`
  ADD PRIMARY KEY (`kd_kain`);

--
-- Indexes for table `tbl_out`
--
ALTER TABLE `tbl_out`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_semical`
--
ALTER TABLE `tbl_semical`
  ADD PRIMARY KEY (`no_barang`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_benang`
--
ALTER TABLE `tbl_benang`
  MODIFY `no_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_in`
--
ALTER TABLE `tbl_in`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_jenis_kain`
--
ALTER TABLE `tbl_jenis_kain`
  MODIFY `kd_jenis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_kain`
--
ALTER TABLE `tbl_kain`
  MODIFY `kd_kain` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_out`
--
ALTER TABLE `tbl_out`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_semical`
--
ALTER TABLE `tbl_semical`
  MODIFY `no_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
