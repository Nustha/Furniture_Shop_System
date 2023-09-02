-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2022 at 08:01 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `furnitureshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `Bill_ID` varchar(10) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Price` double NOT NULL,
  `Billing_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employee_detailstbl`
--

CREATE TABLE `employee_detailstbl` (
  `Emp_ID` varchar(5) NOT NULL,
  `Emp_Name` varchar(50) NOT NULL,
  `Phone_No` varchar(10) NOT NULL,
  `Position` varchar(50) NOT NULL,
  `Description` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_detailstbl`
--

INSERT INTO `employee_detailstbl` (`Emp_ID`, `Emp_Name`, `Phone_No`, `Position`, `Description`) VALUES
('Em001', 'Sajana', '0754268145', 'Seller', '');

-- --------------------------------------------------------

--
-- Table structure for table `item_entrytbl`
--

CREATE TABLE `item_entrytbl` (
  `Item_ID` int(10) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Price` double NOT NULL,
  `Category` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item_entrytbl`
--

INSERT INTO `item_entrytbl` (`Item_ID`, `Item_Name`, `Price`, `Category`) VALUES
(1, 'Steal Table', 5000, 'Table');

-- --------------------------------------------------------

--
-- Table structure for table `manage_order`
--

CREATE TABLE `manage_order` (
  `Order_ID` int(5) NOT NULL,
  `Customer_Name` varchar(50) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Advanced_Payment` double NOT NULL,
  `Payment_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `stock_detailstbl`
--

CREATE TABLE `stock_detailstbl` (
  `Stock_NO` int(10) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Item_ID` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stock_detailstbl`
--

INSERT INTO `stock_detailstbl` (`Stock_NO`, `Item_Name`, `Quantity`, `Category`, `Item_ID`) VALUES
(4, 'Steel table', 25, 'Table', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing`
--
ALTER TABLE `billing`
  ADD PRIMARY KEY (`Bill_ID`),
  ADD UNIQUE KEY `Item_Name` (`Item_Name`);

--
-- Indexes for table `employee_detailstbl`
--
ALTER TABLE `employee_detailstbl`
  ADD PRIMARY KEY (`Emp_ID`) USING BTREE;

--
-- Indexes for table `item_entrytbl`
--
ALTER TABLE `item_entrytbl`
  ADD PRIMARY KEY (`Item_ID`);

--
-- Indexes for table `manage_order`
--
ALTER TABLE `manage_order`
  ADD PRIMARY KEY (`Order_ID`),
  ADD UNIQUE KEY `Item_Name` (`Item_Name`);

--
-- Indexes for table `stock_detailstbl`
--
ALTER TABLE `stock_detailstbl`
  ADD PRIMARY KEY (`Stock_NO`),
  ADD UNIQUE KEY `Item_ID` (`Item_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `item_entrytbl`
--
ALTER TABLE `item_entrytbl`
  MODIFY `Item_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `stock_detailstbl`
--
ALTER TABLE `stock_detailstbl`
  MODIFY `Stock_NO` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
