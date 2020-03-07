/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50624
Source Host           : localhost:3306
Source Database       : dbase_kelasc3

Target Server Type    : MYSQL
Target Server Version : 50624
File Encoding         : 65001

Date: 2018-10-02 15:21:27
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tablestudent`
-- ----------------------------
DROP TABLE IF EXISTS `tablestudent`;
CREATE TABLE `tablestudent` (
  `ID` varchar(9) NOT NULL DEFAULT '',
  `name` varchar(50) DEFAULT NULL,
  `address` varchar(60) DEFAULT NULL,
  `contact` varchar(12) DEFAULT NULL,
  `level` varchar(20) DEFAULT NULL,
  `course` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tablestudent
-- ----------------------------
INSERT INTO `tablestudent` VALUES ('172101850', 'Amalia Dwi', 'Dr Sutomo', '081256637637', 'Class Levels', 'Choice Your Cources');
INSERT INTO `tablestudent` VALUES ('172101860', 'Elistya', 'Purnama', '784124891', 'Class Levels', 'Choice Your Cources');
INSERT INTO `tablestudent` VALUES ('172101890', 'Amalia', 'Sutomo', '6123784234', 'Class Levels', 'Choice Your Cources');
