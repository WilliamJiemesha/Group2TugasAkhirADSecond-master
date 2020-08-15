-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.11-MariaDB


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema movie_theatre
--

CREATE DATABASE IF NOT EXISTS movie_theatre;
USE movie_theatre;

--
-- Definition of table `administration`
--

DROP TABLE IF EXISTS `administration`;
CREATE TABLE `administration` (
  `Username` varchar(40) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `administration`
--

/*!40000 ALTER TABLE `administration` DISABLE KEYS */;
INSERT INTO `administration` (`Username`,`Password`) VALUES 
 ('bulubebek','123456');
/*!40000 ALTER TABLE `administration` ENABLE KEYS */;


--
-- Definition of table `device`
--

DROP TABLE IF EXISTS `device`;
CREATE TABLE `device` (
  `device_id` varchar(10) NOT NULL,
  `device_name` varchar(40) NOT NULL,
  `filepath` varchar(200) NOT NULL,
  PRIMARY KEY (`device_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `device`
--

/*!40000 ALTER TABLE `device` DISABLE KEYS */;
INSERT INTO `device` (`device_id`,`device_name`,`filepath`) VALUES 
 ('D001','WilliamLaptop','C:\\Users\\user\\source\\repos\\Group2TugasAkhirADSecond\\Resources');
/*!40000 ALTER TABLE `device` ENABLE KEYS */;


--
-- Definition of table `dtheatre`
--

DROP TABLE IF EXISTS `dtheatre`;
CREATE TABLE `dtheatre` (
  `theatre_id` varchar(10) NOT NULL,
  `screening_id` varchar(10) NOT NULL,
  `film_id` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dtheatre`
--

/*!40000 ALTER TABLE `dtheatre` DISABLE KEYS */;
INSERT INTO `dtheatre` (`theatre_id`,`screening_id`,`film_id`) VALUES 
 ('T000000001','S001','F2019001'),
 ('T000000001','S007','F2017001');
/*!40000 ALTER TABLE `dtheatre` ENABLE KEYS */;


--
-- Definition of table `film`
--

DROP TABLE IF EXISTS `film`;
CREATE TABLE `film` (
  `film_id` varchar(10) NOT NULL,
  `film_name` varchar(45) NOT NULL,
  `pg_id` varchar(10) NOT NULL,
  `genre_id` varchar(10) NOT NULL,
  `release_date` date NOT NULL,
  `duration` varchar(5) NOT NULL,
  `film_status` varchar(10) NOT NULL,
  `delete_status` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`film_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `film`
--

/*!40000 ALTER TABLE `film` DISABLE KEYS */;
INSERT INTO `film` (`film_id`,`film_name`,`pg_id`,`genre_id`,`release_date`,`duration`,`film_status`,`delete_status`) VALUES 
 ('F2017001','Kerdokodu','P005','G004','2017-05-11','14','Available',0),
 ('F2019001','Sembarangjo','P002','G002','2019-05-23','355','Available',0),
 ('F2020001','saadfaasda','P001','G002','2020-05-06','10','Available',1),
 ('F2020002','Saia','P001','G002','2020-05-06','20','Available',0),
 ('F2020003','SSSSSSSSSSSSSS','P001','G001','2020-05-07','50','Available',0),
 ('F2020004','SSSSSSSSSSSSSSasas','P001','G001','2020-05-08','51','Available',0);
/*!40000 ALTER TABLE `film` ENABLE KEYS */;


--
-- Definition of table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE `genre` (
  `genre_id` varchar(10) NOT NULL,
  `genre_name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`genre_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `genre`
--

/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` (`genre_id`,`genre_name`) VALUES 
 ('G001','Drama'),
 ('G002','Action'),
 ('G003','Komedi'),
 ('G004','Horror'),
 ('G005','Romance'),
 ('G006','Fantasy'),
 ('G007','Adventure'),
 ('G008','Thriller'),
 ('G009','Sci-Fi'),
 ('G010','Mistery'),
 ('G011','Western'),
 ('G012','War'),
 ('G013','Crime'),
 ('G014','Sport'),
 ('G015','Documenter'),
 ('G016','Biography'),
 ('G017','Musical'),
 ('G018','Animation');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;


--
-- Definition of table `pg`
--

DROP TABLE IF EXISTS `pg`;
CREATE TABLE `pg` (
  `pg_id` varchar(10) NOT NULL,
  `rating` varchar(10) NOT NULL,
  `minimum_age` int(5) NOT NULL,
  PRIMARY KEY (`pg_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pg`
--

/*!40000 ALTER TABLE `pg` DISABLE KEYS */;
INSERT INTO `pg` (`pg_id`,`rating`,`minimum_age`) VALUES 
 ('P001','G',0),
 ('P002','PG',0),
 ('P003','PG-13',13),
 ('P004','R',17),
 ('P005','NC-17',18);
/*!40000 ALTER TABLE `pg` ENABLE KEYS */;


--
-- Definition of table `sales`
--

DROP TABLE IF EXISTS `sales`;
CREATE TABLE `sales` (
  `date` date NOT NULL,
  `tickets` int(11) NOT NULL,
  `ammount` int(11) NOT NULL,
  `film_id` varchar(10) NOT NULL,
  KEY `film_id` (`film_id`),
  CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`film_id`) REFERENCES `film` (`film_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` (`date`,`tickets`,`ammount`,`film_id`) VALUES 
 ('2020-05-10',14,700000,'F2019001'),
 ('2020-05-11',1,50000,'F2017001');
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;


--
-- Definition of table `screening`
--

DROP TABLE IF EXISTS `screening`;
CREATE TABLE `screening` (
  `screening_id` varchar(10) NOT NULL,
  `screening_name` varchar(45) NOT NULL,
  `starting_time` time NOT NULL,
  `ending_time` time NOT NULL,
  `screening_status` varchar(45) NOT NULL,
  `delete_status` tinyint(4) NOT NULL,
  PRIMARY KEY (`screening_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `screening`
--

/*!40000 ALTER TABLE `screening` DISABLE KEYS */;
INSERT INTO `screening` (`screening_id`,`screening_name`,`starting_time`,`ending_time`,`screening_status`,`delete_status`) VALUES 
 ('S001','Monday1','09:00:00','12:00:00','Open',0),
 ('S002','Monday2','10:00:00','13:00:00','Open',0),
 ('S003','Monday3','11:00:00','14:00:00','Open',0),
 ('S004','Monday4','12:00:00','15:00:00','Open',0),
 ('S005','Monday5','13:00:00','16:00:00','Open',0),
 ('S006','Monday6','14:00:00','17:00:00','Open',0),
 ('S007','Monday7','15:00:00','18:00:00','Open',0),
 ('S008','Monday8','16:00:00','19:00:00','Open',0),
 ('S009','Monday9','17:00:00','20:00:00','Open',0),
 ('S010','Monday10','18:00:00','21:00:00','Open',0),
 ('S011','Monday11','19:00:00','22:00:00','Open',0),
 ('S012','Monday12','20:00:00','23:00:00','Open',0),
 ('S013','Monday13','21:00:00','00:00:00','Open',0),
 ('S014','Tuesday1','09:00:00','12:00:00','Open',0),
 ('S015','Tuesday2','10:00:00','13:00:00','Open',0),
 ('S016','Tuesday3','11:00:00','14:00:00','Open',0),
 ('S017','Tuesday4','12:00:00','15:00:00','Open',0),
 ('S018','Tuesday5','13:00:00','16:00:00','Open',0),
 ('S019','Tuesday6','14:00:00','17:00:00','Open',0),
 ('S020','Tuesday7','15:00:00','18:00:00','Open',0),
 ('S021','Tuesday8','16:00:00','19:00:00','Open',0),
 ('S022','Tuesday9','17:00:00','20:00:00','Open',0),
 ('S023','Tuesday10','18:00:00','21:00:00','Open',0),
 ('S024','Tuesday11','19:00:00','22:00:00','Open',0),
 ('S025','Tuesday12','20:00:00','23:00:00','Open',0),
 ('S026','Tuesday13','21:00:00','00:00:00','Open',0),
 ('S027','Wednesday1','09:00:00','12:00:00','Open',0),
 ('S028','Wednesday2','10:00:00','13:00:00','Open',0),
 ('S029','Wednesday3','11:00:00','14:00:00','Open',0),
 ('S030','Wednesday4','12:00:00','15:00:00','Open',0),
 ('S031','Wednesday5','13:00:00','16:00:00','Open',0),
 ('S032','Wednesday6','14:00:00','17:00:00','Open',0),
 ('S033','Wednesday7','15:00:00','18:00:00','Open',0),
 ('S034','Wednesday8','16:00:00','19:00:00','Open',0),
 ('S035','Wednesday9','17:00:00','20:00:00','Open',0),
 ('S036','Wednesday10','18:00:00','21:00:00','Open',0),
 ('S037','Wednesday11','19:00:00','22:00:00','Open',0),
 ('S038','Wednesday12','20:00:00','23:00:00','Open',0),
 ('S039','Wednesday13','21:00:00','00:00:00','Open',0),
 ('S040','Thursday1','09:00:00','12:00:00','Open',0),
 ('S041','Thursday2','10:00:00','13:00:00','Open',0),
 ('S042','Thursday3','11:00:00','14:00:00','Open',0),
 ('S043','Thursday4','12:00:00','15:00:00','Open',0),
 ('S044','Thursday5','13:00:00','16:00:00','Open',0),
 ('S045','Thursday6','14:00:00','17:00:00','Open',0),
 ('S046','Thursday7','15:00:00','18:00:00','Open',0),
 ('S047','Thursday8','16:00:00','19:00:00','Open',0),
 ('S048','Thursday9','17:00:00','20:00:00','Open',0),
 ('S049','Thursday10','18:00:00','21:00:00','Open',0),
 ('S050','Thursday11','19:00:00','22:00:00','Open',0),
 ('S051','Thursday12','20:00:00','23:00:00','Open',0),
 ('S052','Thursday13','21:00:00','00:00:00','Open',0),
 ('S053','Friday1','09:00:00','12:00:00','Open',0),
 ('S054','Friday2','10:00:00','13:00:00','Open',0),
 ('S055','Friday3','11:00:00','14:00:00','Open',0),
 ('S056','Friday4','12:00:00','15:00:00','Open',0),
 ('S057','Friday5','13:00:00','16:00:00','Open',0),
 ('S058','Friday6','14:00:00','17:00:00','Open',0),
 ('S059','Friday7','15:00:00','18:00:00','Open',0),
 ('S060','Friday8','16:00:00','19:00:00','Open',0),
 ('S061','Friday9','17:00:00','20:00:00','Open',0),
 ('S062','Friday10','18:00:00','21:00:00','Open',0),
 ('S063','Friday11','19:00:00','22:00:00','Open',0),
 ('S064','Friday12','20:00:00','23:00:00','Open',0),
 ('S065','Friday13','21:00:00','00:00:00','Open',0),
 ('S066','Saturday1','09:00:00','12:00:00','Open',0),
 ('S067','Saturday2','10:00:00','13:00:00','Open',0),
 ('S068','Saturday3','11:00:00','14:00:00','Open',0),
 ('S069','Saturday4','12:00:00','15:00:00','Open',0),
 ('S070','Saturday5','13:00:00','16:00:00','Open',0),
 ('S071','Saturday6','14:00:00','17:00:00','Open',0),
 ('S072','Saturday7','15:00:00','18:00:00','Open',0),
 ('S073','Saturday8','16:00:00','19:00:00','Open',0),
 ('S074','Saturday9','17:00:00','20:00:00','Open',0),
 ('S075','Saturday10','18:00:00','21:00:00','Open',0),
 ('S076','Saturday11','19:00:00','22:00:00','Open',0),
 ('S077','Saturday12','20:00:00','23:00:00','Open',0),
 ('S078','Saturday13','21:00:00','00:00:00','Open',0),
 ('S079','Sunday1','09:00:00','12:00:00','Open',0),
 ('S080','Sunday2','10:00:00','13:00:00','Open',0),
 ('S081','Sunday3','11:00:00','14:00:00','Open',0),
 ('S082','Sunday4','12:00:00','15:00:00','Open',0),
 ('S083','Sunday5','13:00:00','16:00:00','Open',0),
 ('S084','Sunday6','14:00:00','17:00:00','Open',0),
 ('S085','Sunday7','15:00:00','18:00:00','Open',0),
 ('S086','Sunday8','16:00:00','19:00:00','Open',0),
 ('S087','Sunday9','17:00:00','20:00:00','Open',0),
 ('S088','Sunday10','18:00:00','21:00:00','Open',0),
 ('S089','Sunday11','19:00:00','22:00:00','Open',0),
 ('S090','Sunday12','20:00:00','23:00:00','Open',0),
 ('S091','Sunday13','21:00:00','00:00:00','Open',0);
/*!40000 ALTER TABLE `screening` ENABLE KEYS */;


--
-- Definition of table `seat`
--

DROP TABLE IF EXISTS `seat`;
CREATE TABLE `seat` (
  `seat_id` varchar(10) NOT NULL,
  `seat_status` tinyint(4) NOT NULL,
  `theatre_id` varchar(45) NOT NULL,
  `screening_id` varchar(45) NOT NULL,
  `film_id` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `seat`
--

/*!40000 ALTER TABLE `seat` DISABLE KEYS */;
INSERT INTO `seat` (`seat_id`,`seat_status`,`theatre_id`,`screening_id`,`film_id`) VALUES 
 ('D01',1,'T000000001','S001','F2019001'),
 ('D02',1,'T000000001','S001','F2019001'),
 ('D03',1,'T000000001','S001','F2019001'),
 ('D04',1,'T000000001','S001','F2019001'),
 ('D05',1,'T000000001','S001','F2019001'),
 ('D06',1,'T000000001','S001','F2019001'),
 ('D07',1,'T000000001','S001','F2019001'),
 ('D08',1,'T000000001','S001','F2019001'),
 ('D09',1,'T000000001','S001','F2019001'),
 ('D10',1,'T000000001','S001','F2019001'),
 ('D11',1,'T000000001','S001','F2019001'),
 ('D12',1,'T000000001','S001','F2019001'),
 ('D13',1,'T000000001','S001','F2019001'),
 ('D14',1,'T000000001','S001','F2019001'),
 ('D15',1,'T000000001','S001','F2019001'),
 ('D16',1,'T000000001','S001','F2019001'),
 ('D17',1,'T000000001','S001','F2019001'),
 ('D18',1,'T000000001','S001','F2019001'),
 ('D19',1,'T000000001','S001','F2019001'),
 ('D20',1,'T000000001','S001','F2019001'),
 ('D21',1,'T000000001','S001','F2019001'),
 ('D22',1,'T000000001','S001','F2019001'),
 ('D23',1,'T000000001','S001','F2019001'),
 ('D24',1,'T000000001','S001','F2019001'),
 ('D25',1,'T000000001','S001','F2019001'),
 ('D26',1,'T000000001','S001','F2019001'),
 ('D27',1,'T000000001','S001','F2019001'),
 ('D28',1,'T000000001','S001','F2019001'),
 ('D29',1,'T000000001','S001','F2019001'),
 ('D30',1,'T000000001','S001','F2019001'),
 ('D31',1,'T000000001','S001','F2019001'),
 ('D32',1,'T000000001','S001','F2019001'),
 ('D33',1,'T000000001','S001','F2019001'),
 ('D34',1,'T000000001','S001','F2019001'),
 ('D35',1,'T000000001','S001','F2019001'),
 ('D36',1,'T000000001','S001','F2019001'),
 ('D37',1,'T000000001','S001','F2019001'),
 ('D38',1,'T000000001','S001','F2019001'),
 ('D39',1,'T000000001','S001','F2019001'),
 ('D40',1,'T000000001','S001','F2019001'),
 ('D41',1,'T000000001','S001','F2019001'),
 ('D42',1,'T000000001','S001','F2019001'),
 ('D43',1,'T000000001','S001','F2019001'),
 ('D44',1,'T000000001','S001','F2019001'),
 ('D45',1,'T000000001','S001','F2019001'),
 ('D46',1,'T000000001','S001','F2019001'),
 ('D47',1,'T000000001','S001','F2019001'),
 ('D48',1,'T000000001','S001','F2019001'),
 ('D01',0,'T000000001','S007','F2017001'),
 ('D02',1,'T000000001','S007','F2017001'),
 ('D03',1,'T000000001','S007','F2017001'),
 ('D04',1,'T000000001','S007','F2017001'),
 ('D05',1,'T000000001','S007','F2017001'),
 ('D06',1,'T000000001','S007','F2017001'),
 ('D07',1,'T000000001','S007','F2017001'),
 ('D08',1,'T000000001','S007','F2017001'),
 ('D09',1,'T000000001','S007','F2017001'),
 ('D10',1,'T000000001','S007','F2017001'),
 ('D11',1,'T000000001','S007','F2017001'),
 ('D12',1,'T000000001','S007','F2017001'),
 ('D13',1,'T000000001','S007','F2017001'),
 ('D14',1,'T000000001','S007','F2017001'),
 ('D15',1,'T000000001','S007','F2017001'),
 ('D16',1,'T000000001','S007','F2017001'),
 ('D17',1,'T000000001','S007','F2017001'),
 ('D18',1,'T000000001','S007','F2017001'),
 ('D19',1,'T000000001','S007','F2017001'),
 ('D20',1,'T000000001','S007','F2017001'),
 ('D21',1,'T000000001','S007','F2017001'),
 ('D22',1,'T000000001','S007','F2017001'),
 ('D23',1,'T000000001','S007','F2017001'),
 ('D24',1,'T000000001','S007','F2017001'),
 ('D25',1,'T000000001','S007','F2017001'),
 ('D26',1,'T000000001','S007','F2017001'),
 ('D27',1,'T000000001','S007','F2017001'),
 ('D28',1,'T000000001','S007','F2017001'),
 ('D29',1,'T000000001','S007','F2017001'),
 ('D30',1,'T000000001','S007','F2017001'),
 ('D31',1,'T000000001','S007','F2017001'),
 ('D32',1,'T000000001','S007','F2017001'),
 ('D33',1,'T000000001','S007','F2017001'),
 ('D34',1,'T000000001','S007','F2017001'),
 ('D35',1,'T000000001','S007','F2017001'),
 ('D36',1,'T000000001','S007','F2017001'),
 ('D37',1,'T000000001','S007','F2017001'),
 ('D38',1,'T000000001','S007','F2017001'),
 ('D39',1,'T000000001','S007','F2017001'),
 ('D40',1,'T000000001','S007','F2017001'),
 ('D41',1,'T000000001','S007','F2017001'),
 ('D42',1,'T000000001','S007','F2017001'),
 ('D43',1,'T000000001','S007','F2017001'),
 ('D44',1,'T000000001','S007','F2017001'),
 ('D45',1,'T000000001','S007','F2017001'),
 ('D46',1,'T000000001','S007','F2017001'),
 ('D47',1,'T000000001','S007','F2017001'),
 ('D48',1,'T000000001','S007','F2017001');
/*!40000 ALTER TABLE `seat` ENABLE KEYS */;


--
-- Definition of table `theatre`
--

DROP TABLE IF EXISTS `theatre`;
CREATE TABLE `theatre` (
  `theatre_id` varchar(10) NOT NULL,
  `theatre_name` varchar(45) NOT NULL,
  `seat_ammount` int(10) NOT NULL,
  `theatre_status` varchar(45) NOT NULL,
  `delete_status` tinyint(4) NOT NULL,
  PRIMARY KEY (`theatre_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `theatre`
--

/*!40000 ALTER TABLE `theatre` DISABLE KEYS */;
INSERT INTO `theatre` (`theatre_id`,`theatre_name`,`seat_ammount`,`theatre_status`,`delete_status`) VALUES 
 ('T000000001','TheatreOne',48,'Available',0),
 ('T000000002','TheatreTwo',48,'Available',0),
 ('T000000003','TheatreThree',72,'Available',0),
 ('T000000004','TheatreFour',24,'Available',0),
 ('T000000005','TheatreFive',24,'Available',0),
 ('T000000006','PremiereOne',24,'Available',0),
 ('T007','PremiereTwo',48,'Available',0),
 ('T008','PremiereThree',24,'Available',0);
/*!40000 ALTER TABLE `theatre` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
