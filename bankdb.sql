drop database if exists bankdb;
create DATABASE bankdb;
use bankdb;
-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Nov 14, 2024 at 04:08 PM
-- Server version: 5.7.24
-- PHP Version: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bankdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(100) NOT NULL,
  `registered_by` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `registered_by`) VALUES
('user1', 'user3');

-- --------------------------------------------------------

--
-- Table structure for table `bankaccount`
--

CREATE TABLE `bankaccount` (
  `accountNumber` int(11) NOT NULL,
  `nationalID` varchar(20) NOT NULL,
  `balance` decimal(12,2) NOT NULL DEFAULT '0.00',
  `interestRate` decimal(5,2) NOT NULL DEFAULT '0.00',
  `accountType` varchar(50) NOT NULL,
  `customer_username` varchar(100) DEFAULT NULL,
  `admin_username` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bankaccount`
--

INSERT INTO `bankaccount` (`accountNumber`, `nationalID`, `balance`, `interestRate`, `accountType`, `customer_username`, `admin_username`) VALUES
(1, '1103701234571', '1000.00', '1.50', 'savings', 'user5', 'user1'),
(2, '1103701234570', '1100.00', '1.50', 'savings', 'user4', 'user1'),
(3, '1103701234571', '960.00', '1.50', 'current', 'user5', 'user1'),
(4, '1103701234572', '2100.00', '1.50', 'savings', 'user6', 'user1'),
(5, '123123122', '500.00', '0.03', 'Savings', NULL, 'user1');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `username` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`username`) VALUES
('user2'),
('user4'),
('user5'),
('user6');

-- --------------------------------------------------------

--
-- Table structure for table `debt`
--

CREATE TABLE `debt` (
  `debtID` int(11) NOT NULL,
  `loanRequestID` int(11) NOT NULL,
  `accountNumber` int(11) NOT NULL,
  `currentAmount` decimal(12,2) NOT NULL,
  `approvalDate` datetime NOT NULL 
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `debt`
--

INSERT INTO `debt` (`debtID`, `loanRequestID`, `accountNumber`, `currentAmount`, `approvalDate`) VALUES
(1, 2, 3, '3499989.50', '2024-11-14 00:00:00'),
(3, 1, 1, '3423234.00', '2024-11-14 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `debtlog`
--

CREATE TABLE `debtlog` (
  `repayID` int(11) NOT NULL,
  `accountNumber` int(11) NOT NULL,
  `amount` double NOT NULL,
  `repayDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `debtlog`
--

INSERT INTO `debtlog` (`repayID`, `accountNumber`, `amount`, `repayDate`) VALUES
(1, 3, 10, '2024-11-14 22:52:25'),
(2, 3, 30, '2024-11-14 22:52:58');

-- --------------------------------------------------------

--
-- Table structure for table `developer`
--

CREATE TABLE `developer` (
  `username` varchar(100) NOT NULL,
  `registered_by` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `developer`
--

INSERT INTO `developer` (`username`, `registered_by`) VALUES
('user3', 'user3');

-- --------------------------------------------------------

--
-- Table structure for table `loanrequest`
--

CREATE TABLE `loanrequest` (
  `loanRequestID` int(11) NOT NULL,
  `approved_admin` varchar(100) DEFAULT NULL,
  `accountNumber` int(11) NOT NULL,
  `loanTypeID` int(11) NOT NULL,
  `deedItem` varchar(200) DEFAULT NULL,
  `requestDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `approvalStatus` varchar(25) NOT NULL DEFAULT 'pending' CHECK (approvalStatus = 'pending' || approvalStatus = 'denied' || approvalStatus = 'approved')
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `loanrequest`
--

INSERT INTO `loanrequest` (`loanRequestID`, `approved_admin`, `accountNumber`, `loanTypeID`, `deedItem`, `requestDate`) VALUES
(1, NULL, 3, 1, 'test', '2024-11-14 21:11:29'),
(2, 'user1', 3, 5, 'house', '2024-11-14 21:11:50'),
(3, NULL, 1, 5, 'House', '2024-11-14 21:12:39');

-- --------------------------------------------------------

--
-- Table structure for table `loantype`
--

CREATE TABLE `loantype` (
  `loanTypeID` int(11) NOT NULL,
  `loanName` varchar(200) NOT NULL,
  `loanAmount` decimal(12,2) NOT NULL,
  `durationYears` int(11) NOT NULL,
  `interestRate` decimal(5,3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `loantype`
--

INSERT INTO `loantype` (`loanTypeID`, `loanName`, `loanAmount`, `durationYears`, `interestRate`) VALUES
(1, 'Home Loan', '8000000.00', 30, '3.500'),
(2, 'Car Loan', '500000.00', 5, '4.200'),
(3, 'Personal Loan', '150000.00', 3, '7.000'),
(4, 'Student Loan', '1300000.00', 10, '4.800'),
(5, 'Business Loan', '3500000.00', 7, '5.500'),
(6, 'Mortgage Loan', '10000000.00', 25, '3.000'),
(7, 'Vacation Loan', '100000.00', 2, '6.500'),
(8, 'Medical Loan', '700000.00', 4, '5.700'),
(9, 'Debt Consolidation Loan', '400000.00', 3, '6.000'),
(10, 'Green Energy Loan', '1600000.00', 15, '3.900');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `nationalID` varchar(20) NOT NULL,
  `userType` varchar(50) NOT NULL,
  `occupation` varchar(100) DEFAULT NULL,
  `phoneNumber` varchar(20) NOT NULL,
  `fName` varchar(100) NOT NULL,
  `lName` varchar(100) NOT NULL,
  `addressLine1` varchar(200) DEFAULT NULL,
  `addressLine2` varchar(200) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `province` varchar(50) DEFAULT NULL,
  `postalCode` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `nationalID`, `userType`, `occupation`, `phoneNumber`, `fName`, `lName`, `addressLine1`, `addressLine2`, `city`, `province`, `postalCode`) VALUES
('user1', 'pass123', '1103701234567', 'admin', 'Software Engineer', '0812345678', 'Somchai', 'Suwan', '123 Sukhumvit Rd', 'Apt 12B', 'Bangkok', 'Bangkok', '10110'),
('user2', 'password321', '1103701234568', 'user', 'Teacher', '0818765432', 'Suda', 'Thongchai', '456 Rama IX Rd', 'Floor 4', 'Bangkok', 'Bangkok', '10310'),
('user3', 'qwerty123', '1103701234569', 'developer', 'Web Developer', '0812341234', 'Aran', 'Kaew', '789 Silom Rd', 'Unit 24', 'Bangkok', 'Bangkok', '10500'),
('user4', 'abc12345', '1103701234570', 'user', 'Bank Teller', '0823456789', 'Nid', 'Chai', '321 Phayathai Rd', 'Suite 5A', 'Bangkok', 'Bangkok', '10400'),
('user5', 'mypassword', '1103701234571', 'user', 'Engineer', '0834567890', 'Wichai', 'Phong', '12 Sathorn Rd', '', 'Bangkok', 'Bangkok', '10120'),
('user6', 'securepass', '1103701234572', 'user', 'Accountant', '0856784321', 'Preecha', 'Sirikul', '88 Charoen Krung Rd', 'Building 7', 'Bangkok', 'Bangkok', '10150');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `from_account` int(11) NOT NULL,
  `to_account` int(11) NOT NULL,
  `amount` decimal(12,2) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`from_account`, `to_account`, `amount`, `date`) VALUES
(1, 3, '300.00', '2024-11-14 15:35:21'),
(1, 3, '300.00', '2024-11-14 15:44:42'),
(3, 1, '300.00', '2024-11-14 15:36:10'),
(3, 1, '300.00', '2024-11-14 15:39:56'),
(3, 1, '300.00', '2024-11-14 15:40:24'),
(4, 2, '100.00', '2024-11-14 13:18:53'),
(4, 3, '1000.00', '2024-11-06 00:03:04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `tbAdmin_fkregistered_by` (`registered_by`);

--
-- Indexes for table `bankaccount`
--
ALTER TABLE `bankaccount`
  ADD PRIMARY KEY (`accountNumber`),
  ADD UNIQUE KEY `accountNumber` (`accountNumber`),
  ADD KEY `tbBankAccount_fkcustomer_username` (`customer_username`),
  ADD KEY `tbBankAccount_fkadmin_username` (`admin_username`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `debt`
--
ALTER TABLE `debt`
  ADD PRIMARY KEY (`debtID`,`loanRequestID`,`accountNumber`),
  ADD UNIQUE KEY `debtID` (`debtID`),
  ADD KEY `tbdebt_fkloanRequest` (`loanRequestID`),
  ADD KEY `tbDebt_fkaccountNumber` (`accountNumber`);

--
-- Indexes for table `debtlog`
--
ALTER TABLE `debtlog`
  ADD PRIMARY KEY (`repayID`),
  ADD KEY `fk_debtlogbankaccount` (`accountNumber`);

--
-- Indexes for table `developer`
--
ALTER TABLE `developer`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `tbDeveloper_fkregistered_by` (`registered_by`);

--
-- Indexes for table `loanrequest`
--
ALTER TABLE `loanrequest`
  ADD PRIMARY KEY (`loanRequestID`) USING BTREE,
  ADD UNIQUE KEY `loanRequestID` (`loanRequestID`),
  ADD KEY `tbLoanRequest_fkloanType` (`loanTypeID`),
  ADD KEY `tbLoanRequest_fkapproved_admin` (`approved_admin`),
  ADD KEY `tbLoanRequest_fkaccountNumber` (`accountNumber`);

--
-- Indexes for table `loantype`
--
ALTER TABLE `loantype`
  ADD PRIMARY KEY (`loanTypeID`),
  ADD UNIQUE KEY `loanTypeID` (`loanTypeID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `nationalID` (`nationalID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`from_account`,`to_account`,`date`) USING BTREE,
  ADD KEY `tbTransaction_fkto_account` (`to_account`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bankaccount`
--
ALTER TABLE `bankaccount`
  MODIFY `accountNumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `debt`
--
ALTER TABLE `debt`
  MODIFY `debtID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `debtlog`
--
ALTER TABLE `debtlog`
  MODIFY `repayID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `loanrequest`
--
ALTER TABLE `loanrequest`
  MODIFY `loanRequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `loantype`
--
ALTER TABLE `loantype`
  MODIFY `loanTypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `tbAdmin_fkregistered_by` FOREIGN KEY (`registered_by`) REFERENCES `developer` (`username`);

--
-- Constraints for table `bankaccount`
--
ALTER TABLE `bankaccount`
  ADD CONSTRAINT `tbBankAccount_fkadmin_username` FOREIGN KEY (`admin_username`) REFERENCES `admin` (`username`),
  ADD CONSTRAINT `tbBankAccount_fkcustomer_username` FOREIGN KEY (`customer_username`) REFERENCES `customer` (`username`);

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `tbCustomer_fkusername` FOREIGN KEY (`username`) REFERENCES `login` (`username`);

--
-- Constraints for table `debt`
--
ALTER TABLE `debt`
  ADD CONSTRAINT `tbDebt_fkaccountNumber` FOREIGN KEY (`accountNumber`) REFERENCES `bankaccount` (`accountNumber`),
  ADD CONSTRAINT `tbdebt_fkloanRequest` FOREIGN KEY (`loanRequestID`) REFERENCES `loanrequest` (`loanRequestID`) on update cascade;

--
-- Constraints for table `debtlog`
--
ALTER TABLE `debtlog`
  ADD CONSTRAINT `fk_debtlogbankaccount` FOREIGN KEY (`accountNumber`) REFERENCES `bankaccount` (`accountNumber`);

--
-- Constraints for table `developer`
--
ALTER TABLE `developer`
  ADD CONSTRAINT `tbDeveloper_fkregistered_by` FOREIGN KEY (`registered_by`) REFERENCES `developer` (`username`),
  ADD CONSTRAINT `tbDeveloper_fkusername` FOREIGN KEY (`username`) REFERENCES `login` (`username`);

--
-- Constraints for table `loanrequest`
--
ALTER TABLE `loanrequest`
  ADD CONSTRAINT `tbLoanRequest_fkaccountNumber` FOREIGN KEY (`accountNumber`) REFERENCES `bankaccount` (`accountNumber`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tbLoanRequest_fkapproved_admin` FOREIGN KEY (`approved_admin`) REFERENCES `admin` (`username`),
  ADD CONSTRAINT `tbLoanRequest_fkloanType` FOREIGN KEY (`loanTypeID`) REFERENCES `loantype` (`loanTypeID`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `tbTransaction_fkfrom_account` FOREIGN KEY (`from_account`) REFERENCES `bankaccount` (`accountNumber`),
  ADD CONSTRAINT `tbTransaction_fkto_account` FOREIGN KEY (`to_account`) REFERENCES `bankaccount` (`accountNumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
