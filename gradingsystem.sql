-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 16, 2024 at 01:55 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gradingsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `cc104grades`
--

CREATE TABLE `cc104grades` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `cc104_mg` varchar(7) NOT NULL,
  `cc104_fg` varchar(7) NOT NULL,
  `cc104_eqg` varchar(7) NOT NULL,
  `cc104_remarks` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cc104grades`
--

INSERT INTO `cc104grades` (`std_list`, `std_num`, `cc104_mg`, `cc104_fg`, `cc104_eqg`, `cc104_remarks`) VALUES
(4, '22-0000', '0', '0', '0', ''),
(6, '22-1111', '80', '90', '85', 'PASSED'),
(9, '', '90', '90', '90', ''),
(10, '22-1111', '98', '99', '98.5', 'PASSED');

-- --------------------------------------------------------

--
-- Table structure for table `im101grades`
--

CREATE TABLE `im101grades` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `im101_mg` varchar(7) NOT NULL,
  `im101_fg` varchar(7) NOT NULL,
  `im101_eqg` varchar(7) NOT NULL,
  `im101_remarks` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `im101grades`
--

INSERT INTO `im101grades` (`std_list`, `std_num`, `im101_mg`, `im101_fg`, `im101_eqg`, `im101_remarks`) VALUES
(4, '22-0000', '0', '0', '0', ''),
(6, '22-1111', '60', '80', '70', 'FAILED'),
(8, '', '90', '90', '90', ''),
(9, '22-1111', '70', '70', '70', 'FAILED');

-- --------------------------------------------------------

--
-- Table structure for table `net101grades`
--

CREATE TABLE `net101grades` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `net101_mg` varchar(7) NOT NULL,
  `net101_fg` varchar(7) NOT NULL,
  `net101_eqg` varchar(7) NOT NULL,
  `net101_remarks` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `net101grades`
--

INSERT INTO `net101grades` (`std_list`, `std_num`, `net101_mg`, `net101_fg`, `net101_eqg`, `net101_remarks`) VALUES
(4, '22-0000', '0', '0', '0', ''),
(6, '22-1111', '85', '95', '90', 'PASSED'),
(8, '', '90', '90', '90', ''),
(9, '22-1111', '80', '80', '80', 'PASSED');

-- --------------------------------------------------------

--
-- Table structure for table `pf101grades`
--

CREATE TABLE `pf101grades` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `pf101_mg` varchar(7) NOT NULL,
  `pf101_fg` varchar(7) NOT NULL,
  `pf101_eqg` varchar(7) NOT NULL,
  `pf101_remarks` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pf101grades`
--

INSERT INTO `pf101grades` (`std_list`, `std_num`, `pf101_mg`, `pf101_fg`, `pf101_eqg`, `pf101_remarks`) VALUES
(4, '22-0000', '0', '0', '0', ''),
(6, '22-1111', '70', '80', '75', 'PASSED'),
(8, '', '90', '90', '90', ''),
(9, '22-1111', '70', '80', '75', 'PASSED');

-- --------------------------------------------------------

--
-- Table structure for table `sadgrades`
--

CREATE TABLE `sadgrades` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `sad_mg` varchar(7) NOT NULL,
  `sad_fg` varchar(7) NOT NULL,
  `sad_eqg` varchar(10) NOT NULL,
  `sad_remarks` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sadgrades`
--

INSERT INTO `sadgrades` (`std_list`, `std_num`, `sad_mg`, `sad_fg`, `sad_eqg`, `sad_remarks`) VALUES
(14, '22-4444', '90', '90', '90', 'PASSED'),
(15, '22-1111', '90', '90', '90', 'PASSED'),
(21, '', '76', '70', '73', 'FAILED'),
(22, '22-1111', '90', '90', '90', 'PASSED');

-- --------------------------------------------------------

--
-- Table structure for table `studentinformation`
--

CREATE TABLE `studentinformation` (
  `std_list` int(11) NOT NULL,
  `std_num` varchar(7) NOT NULL,
  `std_ln` varchar(50) NOT NULL,
  `std_fn` varchar(50) NOT NULL,
  `std_mn` varchar(50) NOT NULL,
  `std_department` varchar(100) NOT NULL,
  `std_gender` varchar(50) DEFAULT NULL,
  `std_cnum` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studentinformation`
--

INSERT INTO `studentinformation` (`std_list`, `std_num`, `std_ln`, `std_fn`, `std_mn`, `std_department`, `std_gender`, `std_cnum`) VALUES
(19, '22-0000', 'ex', 'xample', 'etc', 'INFORMATION TECHNOLOGY', 'MALE', '9199991999'),
(30, '22-1111', 'Majima', 'Goro', 'Montefalco', 'Information Technology', 'male', '09199991999');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cc104grades`
--
ALTER TABLE `cc104grades`
  ADD PRIMARY KEY (`std_list`);

--
-- Indexes for table `im101grades`
--
ALTER TABLE `im101grades`
  ADD PRIMARY KEY (`std_list`);

--
-- Indexes for table `net101grades`
--
ALTER TABLE `net101grades`
  ADD PRIMARY KEY (`std_list`);

--
-- Indexes for table `pf101grades`
--
ALTER TABLE `pf101grades`
  ADD PRIMARY KEY (`std_list`);

--
-- Indexes for table `sadgrades`
--
ALTER TABLE `sadgrades`
  ADD PRIMARY KEY (`std_list`);

--
-- Indexes for table `studentinformation`
--
ALTER TABLE `studentinformation`
  ADD PRIMARY KEY (`std_list`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cc104grades`
--
ALTER TABLE `cc104grades`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `im101grades`
--
ALTER TABLE `im101grades`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `net101grades`
--
ALTER TABLE `net101grades`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `pf101grades`
--
ALTER TABLE `pf101grades`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `sadgrades`
--
ALTER TABLE `sadgrades`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `studentinformation`
--
ALTER TABLE `studentinformation`
  MODIFY `std_list` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
