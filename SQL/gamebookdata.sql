/*
 Navicat Premium Data Transfer

 Source Server         : Demo
 Source Server Type    : MySQL
 Source Server Version : 100414
 Source Host           : 127.0.0.1:3306
 Source Schema         : gamebookdata

 Target Server Type    : MySQL
 Target Server Version : 100414
 File Encoding         : 65001

 Date: 13/12/2020 22:04:25
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for account
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account`  (
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Password` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ID_quyen` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`Email`) USING BTREE,
  INDEX `keyquyen`(`ID_quyen`) USING BTREE,
  INDEX `Email`(`Email`) USING BTREE,
  CONSTRAINT `keyquyen` FOREIGN KEY (`ID_quyen`) REFERENCES `quyen` (`ID_quyen`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('admin', '21232f297a57a5a743894a0e4a801fc3', '1');
INSERT INTO `account` VALUES ('camdalavip@gmail.com', '1', '2');
INSERT INTO `account` VALUES ('caonam123@gmail.com', '2', '2');
INSERT INTO `account` VALUES ('chauvv@gmail.com', '21232f297a57a5a743894a0e4a801fc3', '3');
INSERT INTO `account` VALUES ('khanhnt@gmail.com', '21232f297a57a5a743894a0e4a801fc3', '3');
INSERT INTO `account` VALUES ('noobkhach2', '2', '3');

-- ----------------------------
-- Table structure for chi tiet hoa don
-- ----------------------------
DROP TABLE IF EXISTS `chi tiet hoa don`;
CREATE TABLE `chi tiet hoa don`  (
  `ID_cthd` int(20) NOT NULL AUTO_INCREMENT,
  `MAHD` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ID_sp` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Don gia` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ID_tinhtrang` int(10) NOT NULL DEFAULT 1,
  PRIMARY KEY (`ID_cthd`) USING BTREE,
  INDEX `cthd_hd`(`MAHD`) USING BTREE,
  INDEX `cthd_sp`(`ID_sp`) USING BTREE,
  INDEX `cthd_ttsp`(`ID_tinhtrang`) USING BTREE,
  CONSTRAINT `cthd_hd` FOREIGN KEY (`MAHD`) REFERENCES `hoa don` (`MAHD`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `cthd_sp` FOREIGN KEY (`ID_sp`) REFERENCES `san pham` (`ID_sp`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `cthd_ttsp` FOREIGN KEY (`ID_tinhtrang`) REFERENCES `tinh trang don hang` (`ID_tinhtrang`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of chi tiet hoa don
-- ----------------------------
INSERT INTO `chi tiet hoa don` VALUES (3, 'HD02', 'SP02', '0', 1);
INSERT INTO `chi tiet hoa don` VALUES (4, 'HD02', 'SP03', '0', 1);

-- ----------------------------
-- Table structure for hoa don
-- ----------------------------
DROP TABLE IF EXISTS `hoa don`;
CREATE TABLE `hoa don`  (
  `MAHD` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `MAKH` int(10) NOT NULL,
  `Ngay Mua` date NOT NULL,
  `Tong Tien` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`MAHD`) USING BTREE,
  INDEX `hd_kh`(`MAKH`) USING BTREE,
  CONSTRAINT `hd_kh` FOREIGN KEY (`MAKH`) REFERENCES `khach hang` (`MAKH`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of hoa don
-- ----------------------------
INSERT INTO `hoa don` VALUES ('HD02', 2, '2020-12-14', '');
INSERT INTO `hoa don` VALUES ('HD04', 6, '2020-12-21', '');

-- ----------------------------
-- Table structure for khach hang
-- ----------------------------
DROP TABLE IF EXISTS `khach hang`;
CREATE TABLE `khach hang`  (
  `MAKH` int(10) NOT NULL AUTO_INCREMENT,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `SĐT` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Họ Tên` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`MAKH`) USING BTREE,
  INDEX `kh_acc`(`Email`) USING BTREE,
  CONSTRAINT `kh_acc` FOREIGN KEY (`Email`) REFERENCES `account` (`Email`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of khach hang
-- ----------------------------
INSERT INTO `khach hang` VALUES (2, 'chauvv@gmail.com', '18888888', 'Vũ Vương Châu');
INSERT INTO `khach hang` VALUES (3, 'khanhnt@gmail.com', '12332444', 'Nguyễn Thu Khanh');
INSERT INTO `khach hang` VALUES (6, 'noobkhach2', '', 'Nooby2');

-- ----------------------------
-- Table structure for nhan vien
-- ----------------------------
DROP TABLE IF EXISTS `nhan vien`;
CREATE TABLE `nhan vien`  (
  `MANV` int(10) NOT NULL AUTO_INCREMENT,
  `Họ Tên` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`MANV`) USING BTREE,
  INDEX `nv_acc`(`Email`) USING BTREE,
  CONSTRAINT `nv_acc` FOREIGN KEY (`Email`) REFERENCES `account` (`Email`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of nhan vien
-- ----------------------------
INSERT INTO `nhan vien` VALUES (1, 'Admin', 'admin');
INSERT INTO `nhan vien` VALUES (4, 'Cam Da', 'camdalavip@gmail.com');
INSERT INTO `nhan vien` VALUES (5, 'Nam', 'caonam123@gmail.com');

-- ----------------------------
-- Table structure for quyen
-- ----------------------------
DROP TABLE IF EXISTS `quyen`;
CREATE TABLE `quyen`  (
  `ID_quyen` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Ten quyen` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID_quyen`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of quyen
-- ----------------------------
INSERT INTO `quyen` VALUES ('1', 'Admin');
INSERT INTO `quyen` VALUES ('2', 'Nhân Viên');
INSERT INTO `quyen` VALUES ('3', 'Khách Hàng');

-- ----------------------------
-- Table structure for san pham
-- ----------------------------
DROP TABLE IF EXISTS `san pham`;
CREATE TABLE `san pham`  (
  `ID_sp` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `title` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `category` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `version` varchar(35) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `img_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `price` float(10, 2) NOT NULL,
  `date release` date NOT NULL,
  `img_path` varchar(125) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID_sp`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of san pham
-- ----------------------------
INSERT INTO `san pham` VALUES ('SP01', 'Half Life 3', 'AAA', '3.0', 'SP01', 67.00, '2020-01-25', NULL);
INSERT INTO `san pham` VALUES ('SP02', 'Grand Theft Auto VI', 'AAA', '4.125', 'SP02', 30.00, '2020-10-15', NULL);
INSERT INTO `san pham` VALUES ('SP03', 'Star Citizen', 'AAA', '2.16', 'SP03', 1.91, '2020-07-23', NULL);
INSERT INTO `san pham` VALUES ('SP04', 'Star Wars Jedi: Fallen Order 2', 'AAA', '2.0.1', 'SP04', 0.00, '2020-10-25', NULL);
INSERT INTO `san pham` VALUES ('SP05', 'Project Athia', 'AAA', '2.638', 'SP05', 0.00, '2020-08-03', NULL);
INSERT INTO `san pham` VALUES ('SP06', 'The Elder Scrolls 6', 'AAA', '6.0.1', 'SP06', 44.97, '2020-05-13', NULL);
INSERT INTO `san pham` VALUES ('SP07', 'Homeworld 3', 'AAA', '3.1.12', 'SP07', 6.99, '2020-09-01', NULL);
INSERT INTO `san pham` VALUES ('SP08', 'Fable 2020', 'AAA', '1.3.25', 'SP08', 0.00, '2020-06-01', NULL);
INSERT INTO `san pham` VALUES ('SP09', 'Dragon Age 4 The Dread Wolf Rise', 'AAA', '4.1.1', 'SP09', 10.00, '2020-07-20', NULL);
INSERT INTO `san pham` VALUES ('SP10', 'Suicide Squad: Kill the Justice League', 'AAA', '2.3.5', 'SP10', 0.00, '2020-03-27', NULL);

-- ----------------------------
-- Table structure for tinh trang don hang
-- ----------------------------
DROP TABLE IF EXISTS `tinh trang don hang`;
CREATE TABLE `tinh trang don hang`  (
  `ID_tinhtrang` int(10) NOT NULL AUTO_INCREMENT,
  `TenTinhTrang` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID_tinhtrang`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tinh trang don hang
-- ----------------------------
INSERT INTO `tinh trang don hang` VALUES (1, 'Chưa xử lý');
INSERT INTO `tinh trang don hang` VALUES (2, 'Đã chốt đơn');
INSERT INTO `tinh trang don hang` VALUES (3, 'Hủy');

-- ----------------------------
-- View structure for userkhach
-- ----------------------------
DROP VIEW IF EXISTS `userkhach`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `userkhach` AS SELECT account.Email , `khach hang`.`Họ Tên`, quyen.`Ten quyen`
From account, `khach hang` , quyen
WHERE account.Email = `khach hang`.Email and account.ID_quyen = quyen.ID_quyen
GROUP BY account.Email ;

-- ----------------------------
-- View structure for usernv
-- ----------------------------
DROP VIEW IF EXISTS `usernv`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `usernv` AS SELECT account.Email , `nhan vien`.`Họ Tên`, quyen.`Ten quyen`
From account, `nhan vien` , quyen
WHERE account.Email = `nhan vien`.Email and account.ID_quyen = quyen.ID_quyen
GROUP BY account.Email ;

-- ----------------------------
-- View structure for vhoadon
-- ----------------------------
DROP VIEW IF EXISTS `vhoadon`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vhoadon` AS SELECT
`hoa don`.MAHD,
`khach hang`.Email,
`hoa don`.`Ngay Mua`,
`hoa don`.`Tong Tien` 
FROM
	`hoa don`,
	`khach hang` 
WHERE
	`hoa don`.MAKH = `khach hang`.MAKH 
GROUP BY
	`hoa don`.MAHD ;

-- ----------------------------
-- Procedure structure for chitiethd
-- ----------------------------
DROP PROCEDURE IF EXISTS `chitiethd`;
delimiter ;;
CREATE PROCEDURE `chitiethd`(IN `mahd` VARCHAR(15))
  NO SQL 
SELECT
		`chi tiet hoa don`.ID_sp AS 'ID Sản Phẩm', `san pham`.title AS 'Tên Sản Phẩm',`san pham`.price AS 'Đơn Giá',`tinh trang don hang`.TenTinhTrang AS 'Trạng Thái' 
	FROM
		`chi tiet hoa don`,
		`hoa don`,
		`san pham`,
		`tinh trang don hang` 
	WHERE
		`chi tiet hoa don`.MAHD = `hoa don`.MAHD 
		AND `chi tiet hoa don`.ID_sp = `san pham`.ID_sp 
		AND `tinh trang don hang`.ID_tinhtrang 
		AND `chi tiet hoa don`.ID_tinhtrang 
		AND `chi tiet hoa don`.MAHD = mahd
	GROUP BY
		`chi tiet hoa don`.ID_sp
;;
delimiter ;

-- ----------------------------
-- Procedure structure for cthdon2
-- ----------------------------
DROP PROCEDURE IF EXISTS `cthdon2`;
delimiter ;;
CREATE PROCEDURE `cthdon2`(IN `mahd` VARCHAR ( 15 ))
SELECT
		`chi tiet hoa don`.ID_sp AS 'ID Sản Phẩm', `san pham`.title AS 'Tên Sản Phẩm',`san pham`.price AS 'Đơn Giá',`tinh trang don hang`.TenTinhTrang AS 'Trạng Thái' 
	FROM
		`chi tiet hoa don`,
		`hoa don`,
		`san pham`,
		`tinh trang don hang` 
	WHERE
		`chi tiet hoa don`.MAHD = `hoa don`.MAHD 
		AND `chi tiet hoa don`.ID_sp = `san pham`.ID_sp 
		AND `tinh trang don hang`.ID_tinhtrang 
		AND `chi tiet hoa don`.ID_tinhtrang 
		AND `chi tiet hoa don`.MAHD = mahd
	GROUP BY
		`chi tiet hoa don`.ID_sp
;;
delimiter ;

-- ----------------------------
-- Procedure structure for xoanv
-- ----------------------------
DROP PROCEDURE IF EXISTS `xoanv`;
delimiter ;;
CREATE PROCEDURE `xoanv`(In `A` varchar(100))
BEGIN
DELETE from `nhan vien` WHERE `nhan vien`.Email = A ;
DELETE from account WHERE account.Email = A;
end
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
