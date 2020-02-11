-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 11, 2020 at 05:22 PM
-- Server version: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventoryicto`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_Borrowers` (IN `EMPNO` INT(50), IN `OFFICE` INT(11), IN `ITEM` INT(11), IN `QTY` INT(11), IN `ISSUED` TIMESTAMP, IN `BORROWEE` INT(50), IN `RETURNED` DATE, IN `EMPNAME` VARCHAR(50))  NO SQL
BEGIN 

	INSERT INTO tblborrowers (borrowersEmpNo, borrowersName, officeID, itemID, qty, dateIssued, dateReturned,  issuedBy) VALUES (EMPNO, EMPNAME, OFFICE, ITEM, QTY, ISSUED, RETURNED, BORROWEE);

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_CATEGORIES` (IN `ID` INT(50), IN `NAME` VARCHAR(50))  NO SQL
BEGIN 

	INSERT INTO tblcategories (categoryID, categoryName) VALUES (ID, NAME);
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_ITEMS` (IN `SKU` VARCHAR(10), IN `NAME` VARCHAR(50), IN `CATID` INT(50), IN `EXPD` VARCHAR(50), IN `QTY` INT(11))  NO SQL
BEGIN 
	INSERT INTO tblitems ( sku, itemName, categoryID, expiryDate) VALUES ( SKU, NAME, CATID, EXPD);
    
    INSERT INTO tblstocks (itemName, quantity) VALUES ( NAME, QTY);
   
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_REQUEST` (IN `QTY` INT, IN `ID` INT, IN `offID` INT, IN `REQ` DATE, IN `REM` TEXT, IN `CATID` INT)  NO SQL
BEGIN

	INSERT INTO tblrequests ( qty, itemID, officeID, categoryID, requestDate, remarks) VALUES (QTY, ID, offID, CATID, REQ, REM);

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_USER` (IN `uname` VARCHAR(50), IN `pass` VARCHAR(50), IN `fnam` VARCHAR(50), IN `rol` VARCHAR(50), IN `lnam` VARCHAR(50), IN `EMPID` INT)  BEGIN 
	insert into tblusers (EmpNo, username, pword, firstName, lastName, role) VALUES (EMPID, uname, pass, fnam, lnam, rol);
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_ITEMS` (IN `ID` INT(5))  NO SQL
BEGIN 

	DELETE FROM tblitems WHERE itemID = ID;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_REQUEST` (IN `ID` INT(50))  NO SQL
DELETE FROM tblrequests WHERE requestID = ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_USERS` (IN `ID` INT(50))  NO SQL
DELETE FROM tblusers WHERE EmpNo = ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_USERS` (IN `ID` INT(50))  NO SQL
SELECT * FROM tblusers WHERE EmpNo = ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_BORROWERS` (IN `ID` INT, IN `STAT` VARCHAR(50), IN `REM` VARCHAR(50))  NO SQL
BEGIN

UPDATE tblborrowers SET stat = STAT, remarks = REM WHERE borrowersID = ID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_ITEMS` (IN `SKU` VARCHAR(10), IN `ITEM` VARCHAR(50), IN `CATID` INT(50), IN `EXPDATE` DATE, IN `ID` INT)  NO SQL
BEGIN

	UPDATE tblitems SET sku = SKU, itemName = ITEM, categoryID = CATID, expiryDate = EXPDATE WHERE itemID = ID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_REQUEST` (IN `ID` INT(50), IN `QTY` INT(50), IN `OFFID` INT(50), IN `REQDATE` TIMESTAMP, IN `REM` VARCHAR(50))  NO SQL
UPDATE tblrequests SET qty = QTY, officeID = ID, requestDate = REQDATE, remarks = REM WHERE requestID = ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_STOCKS` (IN `ID` INT, IN `QTY` INT)  NO SQL
BEGIN 

	UPDATE tblstocks SET quantity = qty  WHERE stockID = ID;
 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VIEW_BORROWERS` ()  NO SQL
BEGIN
	SELECT * FROM tblborrowers;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VIEW_REQUEST` ()  NO SQL
SELECT * FROM tblrequests$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VIEW_STOCKS` ()  NO SQL
SELECT itemName, quantity, stat FROM tblitems, tblstocks$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VIEW_USERS` ()  NO SQL
SELECT * FROM tblusers$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tblborrowers`
--

CREATE TABLE `tblborrowers` (
  `borrowersID` int(11) NOT NULL,
  `borrowersEmpNo` int(50) NOT NULL,
  `borrowersName` varchar(50) NOT NULL,
  `officeID` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `dateIssued` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `dateReturned` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `stat` varchar(50) NOT NULL DEFAULT '0000-00-00 00:00:00',
  `issuedBy` varchar(50) NOT NULL,
  `recievedBy` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblcategories`
--

CREATE TABLE `tblcategories` (
  `categoryID` int(50) NOT NULL,
  `categoryName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategories`
--

INSERT INTO `tblcategories` (`categoryID`, `categoryName`) VALUES
(1, 'Appliances'),
(2, 'Papers');

-- --------------------------------------------------------

--
-- Table structure for table `tblemployees`
--

CREATE TABLE `tblemployees` (
  `borrowersEmpNo` int(50) NOT NULL,
  `EmployeeName` varchar(50) NOT NULL,
  `officeID` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `itemID` int(50) NOT NULL,
  `sku` varchar(10) NOT NULL,
  `itemName` varchar(50) NOT NULL,
  `categoryID` int(50) NOT NULL,
  `expiryDate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`itemID`, `sku`, `itemName`, `categoryID`, `expiryDate`) VALUES
(1, 'QWER', 'Microwave', 1, '2020-01-21'),
(2, 'FGH', 'Dell Monitor', 2, '2020-02-21'),
(4, 'ASD', 'Bond Paper', 0, '0000-00-00'),
(5, 'ASD', 'Bond Paper', 0, '0000-00-00'),
(6, 'ASDASDASD', 'PAPER', 0, '0000-00-00'),
(7, 'ASD', 'Paper Bond A4 Short', 2, '0000-00-00'),
(8, 'ASDASD', 'Samsung Microwave', 1, '0000-00-00'),
(9, 'adcr', '4dftgyhu', 1, '0000-00-00'),
(10, 'sr', 'derftgy', 2, '0000-00-00'),
(11, 'sfg', 'fgh', 2, 'Thursday, 2 January 2020'),
(12, 'ASDASD', 'Dell CPU', 1, 'Wednesday, 26 February 2020'),
(13, 'ghjkrtl', 'Short Bond Paper', 2, 'Thursday, 20 February 2020');

-- --------------------------------------------------------

--
-- Table structure for table `tbloffices`
--

CREATE TABLE `tbloffices` (
  `officeID` int(11) NOT NULL,
  `officeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbloffices`
--

INSERT INTO `tbloffices` (`officeID`, `officeName`) VALUES
(1, 'ICTO'),
(2, 'HR');

-- --------------------------------------------------------

--
-- Table structure for table `tblrequests`
--

CREATE TABLE `tblrequests` (
  `requestID` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `officeID` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `categoryID` int(50) NOT NULL,
  `requestDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `remarks` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblrequests`
--

INSERT INTO `tblrequests` (`requestID`, `qty`, `officeID`, `itemID`, `categoryID`, `requestDate`, `remarks`) VALUES
(1, 0, 1, 7, 2, '0000-00-00 00:00:00', 'System.Windows.Forms.RichTextBox, Text: For printing purposes');

-- --------------------------------------------------------

--
-- Table structure for table `tblstocks`
--

CREATE TABLE `tblstocks` (
  `stockID` int(11) NOT NULL,
  `itemName` varchar(50) NOT NULL,
  `quantity` int(11) NOT NULL,
  `datein` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstocks`
--

INSERT INTO `tblstocks` (`stockID`, `itemName`, `quantity`, `datein`) VALUES
(6, 'Samsung Microwave', 0, '2020-01-31 05:03:32'),
(7, '4dftgyhu', 0, '2020-01-31 05:05:44'),
(8, 'derftgy', 0, '2020-01-31 05:07:07'),
(9, 'fgh', 0, '2020-01-31 05:07:56'),
(10, 'Dell CPU', 0, '2020-02-05 00:28:11'),
(11, 'Short Bond Paper', 4, '2020-02-05 00:38:37');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `EmpNo` int(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `pword` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`EmpNo`, `username`, `pword`, `firstName`, `lastName`, `role`) VALUES
(1, 'ASD', '123', '', 'test', 'ADMIN'),
(2, 'testuser', 'qwerty', '', 'test', 'User'),
(24, 'blacky', 'kobe', 'Kobe', 'Bryant', 'User'),
(824, 'Pogiako', '123', 'Ken', 'Pogi', 'User'),
(1234, 'raygun', '1234', 'Jhon Rey', 'Lore', 'User'),
(2015, 'kensuperpogi', 'ken', 'Ken', 'Lavina', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblborrowers`
--
ALTER TABLE `tblborrowers`
  ADD PRIMARY KEY (`borrowersID`),
  ADD KEY `tblborrowers_ibfk_1` (`issuedBy`),
  ADD KEY `itemID` (`itemID`);

--
-- Indexes for table `tblcategories`
--
ALTER TABLE `tblcategories`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `tblemployees`
--
ALTER TABLE `tblemployees`
  ADD KEY `officeID` (`officeID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`itemID`),
  ADD KEY `categoryID` (`categoryID`);

--
-- Indexes for table `tbloffices`
--
ALTER TABLE `tbloffices`
  ADD PRIMARY KEY (`officeID`);

--
-- Indexes for table `tblrequests`
--
ALTER TABLE `tblrequests`
  ADD PRIMARY KEY (`requestID`),
  ADD KEY `itemID` (`itemID`),
  ADD KEY `categoryID` (`categoryID`);

--
-- Indexes for table `tblstocks`
--
ALTER TABLE `tblstocks`
  ADD PRIMARY KEY (`stockID`),
  ADD KEY `tblstocks_ibfk_1` (`itemName`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`EmpNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblborrowers`
--
ALTER TABLE `tblborrowers`
  MODIFY `borrowersID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblitems`
--
ALTER TABLE `tblitems`
  MODIFY `itemID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbloffices`
--
ALTER TABLE `tbloffices`
  MODIFY `officeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tblrequests`
--
ALTER TABLE `tblrequests`
  MODIFY `requestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tblstocks`
--
ALTER TABLE `tblstocks`
  MODIFY `stockID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblborrowers`
--
ALTER TABLE `tblborrowers`
  ADD CONSTRAINT `tblborrowers_ibfk_2` FOREIGN KEY (`itemID`) REFERENCES `tblitems` (`itemID`) ON UPDATE CASCADE;

--
-- Constraints for table `tblcategories`
--
ALTER TABLE `tblcategories`
  ADD CONSTRAINT `tblcategories_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `tblitems` (`categoryID`) ON UPDATE CASCADE;

--
-- Constraints for table `tblemployees`
--
ALTER TABLE `tblemployees`
  ADD CONSTRAINT `tblemployees_ibfk_1` FOREIGN KEY (`officeID`) REFERENCES `tbloffices` (`officeID`);

--
-- Constraints for table `tblrequests`
--
ALTER TABLE `tblrequests`
  ADD CONSTRAINT `tblrequests_ibfk_1` FOREIGN KEY (`itemID`) REFERENCES `tblitems` (`itemID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `tblrequests_ibfk_2` FOREIGN KEY (`categoryID`) REFERENCES `tblcategories` (`categoryID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
