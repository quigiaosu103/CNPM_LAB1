-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 01, 2024 at 08:22 PM
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
-- Database: `teacherassistant`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `CourseId` varchar(255) NOT NULL,
  `CourseName` longtext DEFAULT NULL,
  `Price` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`CourseId`, `CourseName`, `Price`) VALUES
('ART101', 'Introduction to Arts', 180000),
('BIO101', 'Biology Basics', 170000),
('BUS101', 'Introduction to Business', 190000),
('CHEM201', 'Organic Chemistry', 280000),
('Cs01', 'Basic C# Programing', 200000),
('CS02', 'OOP', 120000),
('CS101', 'Computer Science Basics', 140000),
('CS3', 'Name', 123000),
('CSE101', 'Introduction to CSE', 150000),
('ECON101', 'Microeconomics', 210000),
('EDU101', 'Introduction to Education', 200000),
('ENG101', 'English Communication', 120000),
('ENVI101', 'Environmental Science', 130000),
('GEOL101', 'Geology Fundamentals', 290000),
('HIST201', 'World History', 220000),
('LANG201', 'Advanced Language Study', 240000),
('MATH201', 'Advanced Mathematics', 250000),
('MKTG101', 'Marketing Principles', 160000),
('PHIL201', 'Philosophy of Mind', 230000),
('PHYS101', 'Physics Fundamentals', 200000),
('PSYC201', 'Psychology of Behavior', 260000),
('SOC101', 'Introduction to Sociology', 150000),
('STAT201', 'Statistics for Data Analysis', 270000);

-- --------------------------------------------------------

--
-- Table structure for table `schedules`
--

CREATE TABLE `schedules` (
  `Id` int(11) NOT NULL,
  `Duration` int(11) NOT NULL,
  `dateTime` datetime(6) NOT NULL,
  `IsCanceled` tinyint(1) NOT NULL,
  `IsCompleted` tinyint(1) NOT NULL,
  `Room` longtext DEFAULT NULL,
  `TeacherId` int(11) DEFAULT NULL,
  `CourseId` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`Id`, `Duration`, `dateTime`, `IsCanceled`, `IsCompleted`, `Room`, `TeacherId`, `CourseId`) VALUES
(1, 3, '2024-04-02 00:05:55.000000', 0, 1, 'F1202', 1, 'ART101'),
(2, 3, '2024-04-10 00:05:55.000000', 0, 1, '2312DNS', 1, 'CS02'),
(3, 3, '2024-04-10 00:05:55.000000', 0, 1, 'F1202', 1, 'ART101'),
(4, 4, '2024-04-17 00:05:55.000000', 0, 1, 'F1202', 1, 'PHYS101'),
(5, 2, '2024-04-02 00:05:55.000000', 0, 1, 'F1202', 1, 'ART101'),
(6, 3, '2024-04-09 00:05:55.000000', 0, 1, 'F1202', 1, 'CSE101'),
(7, 3, '2024-04-10 00:05:55.000000', 0, 1, '2312DNS', 1, 'CS02');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `TeacherId` int(11) NOT NULL,
  `TeacherName` longtext DEFAULT NULL,
  `UserName` longtext DEFAULT NULL,
  `HashPassword` longtext DEFAULT NULL,
  `Email` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`TeacherId`, `TeacherName`, `UserName`, `HashPassword`, `Email`) VALUES
(1, 'Harry Maguire', 'M5CbIT2024', 'xsdasod08sd8d9sdsah98', 'harry@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20240401102008_initdb', '8.0.0'),
('20240401102046_reInitdb', '8.0.0'),
('20240401163908_updateCourseField', '7.0.16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`CourseId`);

--
-- Indexes for table `schedules`
--
ALTER TABLE `schedules`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Schedules_CourseId` (`CourseId`),
  ADD KEY `IX_Schedules_TeacherId` (`TeacherId`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`TeacherId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `schedules`
--
ALTER TABLE `schedules`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `TeacherId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `schedules`
--
ALTER TABLE `schedules`
  ADD CONSTRAINT `FK_Schedules_Courses_CourseId` FOREIGN KEY (`CourseId`) REFERENCES `courses` (`CourseId`),
  ADD CONSTRAINT `FK_Schedules_Teachers_TeacherId` FOREIGN KEY (`TeacherId`) REFERENCES `teachers` (`TeacherId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
