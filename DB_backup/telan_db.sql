-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2026 at 11:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `telan_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllogin`
--

CREATE TABLE `tbllogin` (
  `LoginID` int(11) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `userID` int(11) NOT NULL,
  `is_active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllogin`
--

INSERT INTO `tbllogin` (`LoginID`, `user_username`, `user_password`, `userID`, `is_active`) VALUES
(1, 'admin', 'admin', 1, 1),
(4, 'asd', 'asd', 4, 1),
(5, 'asdf', 'asdf', 5, 0),
(6, 'asdf', 'asdf', 6, 1),
(7, 'asdfg', 'asdfg', 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinfo`
--

CREATE TABLE `tbluserinfo` (
  `userID` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `emailAddress` varchar(255) NOT NULL,
  `homeAddress` varchar(255) NOT NULL,
  `birthDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinfo`
--

INSERT INTO `tbluserinfo` (`userID`, `firstname`, `middlename`, `lastname`, `emailAddress`, `homeAddress`, `birthDate`) VALUES
(1, 'Lauren James', 'Tesoro', 'Telan', 'ljttelan@pcu.edu.ph', 'General Trias', '2005-01-16'),
(4, 'asd', 'asd', 'asd', 'asd', 'asd', '2026-05-19'),
(5, 'asd', 'asd', 'asd', 'asd', 'asd', '2026-05-19'),
(6, 'asd', 'asd', 'asd', 'asd', 'asd', '2026-05-19'),
(7, 'asd', 'asd', 'asd', 'asd', 'asd', '2026-05-19');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllogin`
--
ALTER TABLE `tbllogin`
  ADD PRIMARY KEY (`LoginID`);

--
-- Indexes for table `tbluserinfo`
--
ALTER TABLE `tbluserinfo`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllogin`
--
ALTER TABLE `tbllogin`
  MODIFY `LoginID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbluserinfo`
--
ALTER TABLE `tbluserinfo`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
