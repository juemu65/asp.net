# Host: localhost  (Version 5.7.16-log)
# Date: 2016-12-27 22:33:40
# Generator: MySQL-Front 5.4  (Build 3.36)
# Internet: http://www.mysqlfront.de/

/*!40101 SET NAMES utf8 */;

#
# Structure for table "chanpinkucun"
#

CREATE TABLE `chanpinkucun` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `chanpinbianhao` varchar(255) DEFAULT NULL,
  `chanpinmingcheng` varchar(255) DEFAULT NULL,
  `guigexinhao` varchar(255) DEFAULT NULL,
  `leibie` varchar(255) DEFAULT NULL,
  `kucunshuliang` varchar(255) DEFAULT NULL,
  `danweimingcheng` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

#
# Data for table "chanpinkucun"
#

INSERT INTO `chanpinkucun` VALUES (1,'1','A','1','1','80','44444'),(6,'6','B','1','1','160','5555'),(7,'7','cc','1','1','100','ioio'),(8,'8','gggg','1','1','164','日日日日日');

#
# Structure for table "chukumingxi"
#

CREATE TABLE `chukumingxi` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `zhubiaoid` varchar(50) DEFAULT NULL,
  `chanpinbianhao` varchar(50) DEFAULT NULL,
  `guigexinhao` varchar(50) DEFAULT NULL,
  `leixin` varchar(50) DEFAULT NULL,
  `chukushuliang` varchar(50) DEFAULT NULL,
  `danweimingcheng` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

#
# Data for table "chukumingxi"
#

INSERT INTO `chukumingxi` VALUES (1,'1','1','1','1','1','1'),(2,'2','2','2','2','3','斯维尔'),(3,'2','2','','','2','2');

#
# Structure for table "chukuzhubiao"
#

CREATE TABLE `chukuzhubiao` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `shangjiamingcheng` varchar(50) DEFAULT NULL,
  `zongjiae` varchar(50) DEFAULT NULL,
  `songhuodizhi` varchar(50) DEFAULT NULL,
  `chukushijian` datetime DEFAULT NULL,
  `chukuren` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "chukuzhubiao"
#

INSERT INTO `chukuzhubiao` VALUES (1,'1','1','1','2016-11-08 22:43:42','1'),(2,'1','3','3','2016-11-15 15:27:34','32');

#
# Structure for table "com_buttongroup"
#

CREATE TABLE `com_buttongroup` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ButtonName` varchar(50) NOT NULL,
  `BtnCode` varchar(50) DEFAULT NULL,
  `Icon` varchar(50) DEFAULT NULL,
  `Sort` int(11) DEFAULT NULL,
  `Remark` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=gb2312 COMMENT='com_页面功能按钮';

#
# Data for table "com_buttongroup"
#

INSERT INTO `com_buttongroup` VALUES (1,'功能1','ljxfun1','icon icon-add',1,'添加'),(2,'功能2','ljxfun2','icon icon-edit',2,'编辑'),(3,'功能3','ljxfun3','icon icon-delete2',3,'删除'),(5,'功能4','ljxfun4','icon icon-magic',4,'查询'),(6,'功能5','ljxfun5','icon icon-nav',5,'浏览'),(10,'全部','3','icon icon-role',7,'全部'),(11,'功能6','ljxfun6','icon icon-users',6,'功能6');

#
# Structure for table "com_loginlog"
#

CREATE TABLE `com_loginlog` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Userid` char(10) NOT NULL,
  `LoginIP` char(15) NOT NULL,
  `LoginDate` datetime NOT NULL,
  `Status` char(1) NOT NULL,
  `username` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=208 DEFAULT CHARSET=gb2312 COMMENT='com_登录日志表';

#
# Data for table "com_loginlog"
#

INSERT INTO `com_loginlog` VALUES (87,'admin','::1','2016-08-27 00:00:00','0','admin'),(88,'admin','::1','2016-08-27 00:00:00','0','admin'),(89,'admin','::1','2016-08-27 00:00:00','0','admin'),(90,'admin','::1','2016-08-27 00:00:00','0','admin'),(91,'admin','::1','2016-08-27 00:00:00','0','admin'),(92,'admin','::1','2016-08-27 00:00:00','0','admin'),(93,'admin','::1','2016-08-27 00:00:00','0','admin'),(94,'admin','::1','2016-08-27 00:00:00','0','admin'),(95,'admin','::1','2016-08-27 00:00:00','0','admin'),(96,'admin','::1','2016-08-27 00:00:00','0','admin'),(97,'admin','::1','2016-08-27 00:00:00','0','admin'),(98,'admin','::1','2016-08-27 00:00:00','0','admin'),(99,'admin','::1','2016-08-27 00:00:00','0','admin'),(100,'admin','::1','2016-08-27 00:00:00','0','admin'),(101,'admin','::1','2016-08-27 00:00:00','0','admin'),(102,'admin','::1','2016-08-27 00:00:00','0','admin'),(103,'admin','::1','2016-08-27 00:00:00','0','admin'),(104,'admin','::1','2016-08-27 00:00:00','0','admin'),(105,'admin','::1','2016-08-27 00:00:00','0','admin'),(106,'admin','::1','2016-08-27 00:00:00','0','admin'),(107,'admin','::1','2016-08-27 00:00:00','0','admin'),(108,'admin','::1','2016-08-27 00:00:00','0','admin'),(109,'admin','::1','2016-08-27 00:00:00','0','admin'),(110,'admin','::1','2016-08-27 00:00:00','0','admin'),(111,'admin','::1','2016-08-27 00:00:00','0','admin'),(112,'admin','::1','2016-08-28 00:00:00','0','admin'),(113,'admin','::1','2016-08-30 00:00:00','0','admin'),(114,'admin','::1','2016-08-30 00:00:00','0','admin'),(115,'admin','::1','2016-08-30 00:00:00','0','admin'),(116,'admin','::1','2016-08-30 00:00:00','0','admin'),(117,'admin','::1','2016-08-30 00:00:00','0','admin'),(118,'admin','::1','2016-08-30 00:00:00','0','admin'),(119,'admin','::1','2016-08-30 00:00:00','0','admin'),(120,'admin','::1','2016-08-30 00:00:00','0','admin'),(121,'admin','::1','2016-08-30 00:00:00','0','admin'),(122,'admin','::1','2016-08-30 00:00:00','0','admin'),(123,'admin','::1','2016-08-30 00:00:00','0','admin'),(124,'admin','::1','2016-08-30 00:00:00','0','admin'),(125,'admin','::1','2016-08-30 00:00:00','0','admin'),(126,'admin','::1','2016-08-30 00:00:00','0','admin'),(127,'admin','::1','2016-08-30 00:00:00','0','admin'),(128,'admin','::1','2016-08-30 00:00:00','0','admin'),(129,'admin','::1','2016-08-30 00:00:00','0','admin'),(130,'test','::1','2016-08-30 00:00:00','0','test'),(131,'test','::1','2016-08-30 00:00:00','0','test'),(132,'admin','::1','2016-08-30 00:00:00','0','admin'),(133,'test','::1','2016-08-30 00:00:00','0','张二丫'),(134,'test','::1','2016-08-30 00:00:00','0','张二丫'),(135,'test','::1','2016-08-30 00:00:00','0','张二丫'),(136,'test','::1','2016-08-30 00:00:00','0','张二丫'),(137,'test','::1','2016-08-30 00:00:00','0','张二丫'),(138,'test','::1','2016-08-30 00:00:00','0','张二丫'),(139,'admin','::1','2016-08-30 00:00:00','0','admin'),(140,'admin','::1','2016-08-31 00:00:00','0','admin'),(141,'test','::1','2016-08-31 00:00:00','0','张二丫'),(142,'admin','::1','2016-08-31 00:00:00','0','admin'),(143,'test','::1','2016-08-31 00:00:00','0','张二丫'),(144,'test','::1','2016-08-31 00:00:00','0','张二丫'),(145,'test','::1','2016-08-31 00:00:00','0','张二丫'),(146,'admin','::1','2016-08-31 00:00:00','0','admin'),(147,'admin','::1','2016-08-31 00:00:00','0','admin'),(148,'admin','::1','2016-08-31 00:00:00','0','admin'),(149,'admin','::1','2016-08-31 00:00:00','0','admin'),(150,'admin','::1','2016-08-31 00:00:00','0','admin'),(151,'admin','::1','2016-08-31 00:00:00','0','admin'),(152,'test','::1','2016-08-31 00:00:00','0','张二丫'),(153,'test','::1','2016-08-31 00:00:00','0','张二丫'),(154,'test','::1','2016-08-31 00:00:00','0','张二丫'),(155,'admin','::1','2016-09-01 00:00:00','0','admin'),(156,'admin','::1','2016-09-01 00:00:00','0','admin'),(157,'admin','::1','2016-09-01 00:00:00','0','admin'),(158,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(159,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(160,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(161,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(162,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(163,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(164,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(165,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(166,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(167,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(168,'aa','::1','2016-09-01 00:00:00','0','牛二虎'),(169,'admin','::1','2016-09-01 00:00:00','0','admin'),(170,'admin','::1','2016-09-01 00:00:00','0','admin'),(171,'admin','::1','2016-09-01 00:00:00','0','admin'),(172,'admin','::1','2016-09-04 00:00:00','0','admin'),(173,'admin','::1','2016-09-04 00:00:00','0','admin'),(174,'admin','::1','2016-09-04 00:00:00','0','admin'),(175,'admin','::1','2016-09-05 00:00:00','0','admin'),(176,'admin','::1','2016-09-05 00:00:00','0','admin'),(177,'admin','::1','2016-09-05 00:00:00','0','admin'),(178,'admin','::1','2016-09-05 00:00:00','0','admin'),(179,'admin','::1','2016-09-05 00:00:00','0','admin'),(180,'admin','::1','2016-09-05 00:00:00','0','admin'),(181,'admin','::1','2016-09-05 00:00:00','0','admin'),(182,'admin','::1','2016-09-05 00:00:00','0','admin'),(183,'admin','::1','2016-09-05 00:00:00','0','admin'),(184,'admin','::1','2016-09-06 00:00:00','0','admin'),(185,'admin','::1','2016-09-07 00:00:00','0','admin'),(186,'admin','::1','2016-09-14 00:00:00','0','admin'),(187,'admin','::1','2016-10-11 00:00:00','0','admin'),(188,'admin','::1','2016-10-11 00:00:00','0','admin'),(189,'admin','::1','2016-10-11 00:00:00','0','admin'),(190,'admin','::1','2016-10-11 00:00:00','0','admin'),(191,'admin','::1','2016-10-11 00:00:00','0','admin'),(192,'admin','::1','2016-10-11 00:00:00','0','admin'),(193,'admin','::1','2016-10-11 00:00:00','0','admin'),(194,'admin','::1','2016-10-11 00:00:00','0','admin'),(195,'admin','::1','2016-10-11 00:00:00','0','admin'),(196,'admin','::1','2016-10-12 00:00:00','0','admin'),(197,'admin','::1','2016-10-13 00:00:00','0','admin'),(198,'admin','::1','2016-12-11 00:00:00','0','admin'),(199,'admin','::1','2016-12-11 00:00:00','0','admin'),(200,'admin','::1','2016-12-11 00:00:00','0','admin'),(201,'admin','::1','2016-12-11 00:00:00','0','admin'),(202,'admin','::1','2016-12-11 00:00:00','0','admin'),(203,'admin','::1','2016-12-11 00:00:00','0','admin'),(204,'admin','::1','2016-12-11 00:00:00','0','admin'),(205,'admin','::1','2016-12-11 00:00:00','0','admin'),(206,'admin','::1','2016-12-12 00:00:00','0','admin'),(207,'admin','::1','2016-12-12 00:00:00','0','admin');

#
# Structure for table "com_navigationandbutton"
#

CREATE TABLE `com_navigationandbutton` (
  `NavigationId` int(11) NOT NULL,
  `ButtonId` int(11) NOT NULL,
  `buttonstr` varchar(16) DEFAULT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=64 DEFAULT CHARSET=gb2312;

#
# Data for table "com_navigationandbutton"
#

INSERT INTO `com_navigationandbutton` VALUES (260,1,'添加',1),(260,2,'',2),(260,3,'',3),(260,5,'',4),(260,6,'',5),(260,11,'',6),(260,10,NULL,7),(322,1,'添加',8),(322,2,'',9),(322,3,'',10),(322,5,'',11),(322,6,'',12),(322,11,'',13),(322,10,NULL,14),(285,1,'添加',15),(285,2,'',16),(285,3,'',17),(285,5,'',18),(285,6,'',19),(285,11,'',20),(285,10,NULL,21),(293,1,'添加',22),(293,2,'',23),(293,3,'',24),(293,5,'',25),(293,6,'',26),(293,11,'',27),(293,10,NULL,28),(263,1,'添加',29),(263,2,'',30),(263,3,'',31),(263,5,'',32),(263,6,'',33),(263,11,'',34),(263,10,NULL,35),(331,1,'添加',36),(331,2,'',37),(331,3,'',38),(331,5,'',39),(331,6,'',40),(331,11,'',41),(331,10,NULL,42),(332,1,'添加',43),(332,2,'',44),(332,3,'',45),(332,5,'',46),(332,6,'',47),(332,11,'',48),(332,10,NULL,49),(334,1,'添加',50),(334,2,'编辑',51),(334,3,'删除',52),(334,5,'查询',53),(334,6,'浏览',54),(334,11,'',55),(334,10,NULL,56),(338,1,'添加',57),(338,2,'编辑',58),(338,3,'删除',59),(338,5,'查询',60),(338,6,'浏览',61),(338,11,'',62),(338,10,NULL,63);

#
# Structure for table "com_orgadduser"
#

CREATE TABLE `com_orgadduser` (
  `OrgId` int(11) NOT NULL,
  `UserId` varchar(10) NOT NULL DEFAULT '',
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=gb2312 COMMENT='com_用户部门关联表';

#
# Data for table "com_orgadduser"
#

INSERT INTO `com_orgadduser` VALUES (1,'1000000000',1),(1103000000,'1000000002',2),(1102000000,'1000000006',3),(1100000000,'1000000001',4),(1103002000,'1000000005',5),(1103001000,'1000000003',6),(1103002000,'1000000004',7);

#
# Structure for table "com_organization"
#

CREATE TABLE `com_organization` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `orgid` varchar(10) DEFAULT NULL COMMENT '部门编号',
  `Agency` varchar(50) NOT NULL,
  `ParentId` int(11) NOT NULL,
  `Sort` int(11) DEFAULT NULL,
  `Person` char(10) DEFAULT NULL,
  `Remark` varchar(50) DEFAULT NULL,
  `gongsibianhao` varchar(30) DEFAULT NULL COMMENT '企业代码或公司编号',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=gb2312 COMMENT='com_部门信息表';

#
# Data for table "com_organization"
#

INSERT INTO `com_organization` VALUES (1,'1100000000','T公司',0,0,'周**',NULL,NULL),(12,'1101000000','采购部',1,1,'',NULL,NULL),(13,'1102000000','人事部',1,3,'',NULL,NULL),(14,'1103000000','研发部',1,2,'',NULL,NULL),(15,'1101001000','原材料采购',12,1,'ff 22','sdfdsf',''),(16,'1101001001','原材采1部',15,1,'天睛','sdfsdf22',''),(17,'1103001000','硬件部门',14,2,'abc','323',''),(18,'1103002000','软件部门',14,1,'李三','2',NULL),(21,'1103001001','测试11',17,2,'仍','地',''),(22,'1103002001','测试12',18,1,'21','朋',''),(23,'1103001002','测试21',17,1,'s','2',NULL);

#
# Structure for table "com_user"
#

CREATE TABLE `com_user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '序号',
  `userid` varchar(10) NOT NULL DEFAULT '' COMMENT '用户编号',
  `logincount` varchar(30) DEFAULT NULL COMMENT '登录帐号',
  `username` varchar(30) DEFAULT NULL COMMENT '用户姓名',
  `orgid` varchar(10) DEFAULT NULL COMMENT '部门编号',
  `password` varchar(30) DEFAULT NULL COMMENT '密码',
  `usertype` varchar(10) DEFAULT NULL COMMENT '类别',
  `status` varchar(10) DEFAULT NULL COMMENT '状态',
  `gongsibianhao` varchar(30) DEFAULT NULL COMMENT '企业代码或公司编号',
  `orgname` varchar(30) DEFAULT NULL COMMENT '部门名称',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=gb2312 COMMENT='用户信息表';

#
# Data for table "com_user"
#

INSERT INTO `com_user` VALUES (1,'1000000001','admin','admin','1100000000','732965E9EDEB1791','1','1','','T公司'),(2,'1000000002','abc','abc','1103000000','732965E9EDEB1791','2','','','研发部'),(3,'1000000003','bb','bb','1103001000','732965E9EDEB1791','1','','','硬件部门'),(4,'1000000004','aa','牛二虎','1103002000','57F7160187224D02','22','','1221','软件部门'),(5,'1000000005','test','张二丫','1103002000','732965E9EDEB1791','1','','1212','软件部门'),(6,'1000000006','aa','sadf','1102000000','732965E9EDEB1791','1','正常','11','人事部');

#
# Structure for table "com_userlogin"
#

CREATE TABLE `com_userlogin` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` char(10) NOT NULL,
  `LoginName` varchar(20) NOT NULL,
  `LoginPassword` varchar(20) NOT NULL,
  `Status` int(11) NOT NULL,
  `LastLoginIP` char(15) DEFAULT NULL,
  `LastLoginDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=gb2312 COMMENT='com_登录状态表';

#
# Data for table "com_userlogin"
#


#
# Structure for table "com_zidian"
#

CREATE TABLE `com_zidian` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '序号',
  `xianshizhi` varchar(30) DEFAULT NULL COMMENT '显示值',
  `xuanzezhi` varchar(30) DEFAULT NULL COMMENT '选择值',
  `leibie` varchar(30) DEFAULT NULL COMMENT '类别',
  `beifen` varchar(30) DEFAULT NULL COMMENT '备份',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=gb2312 COMMENT='T_字典表';

#
# Data for table "com_zidian"
#

INSERT INTO `com_zidian` VALUES (1,'aa','aa','llbb','333'),(2,'abd','dd','llbb','af'),(3,'dsf','df','fd','fd'),(4,'审核','审核','公司状态',''),(5,'正常','正常','公司状态',''),(6,'关闭','关闭','公司状态',''),(7,'工人','','岗位',''),(8,'科长','','岗位',''),(9,'经理','','岗位',''),(10,'男','','性别',''),(11,'女','','性别',''),(12,'test','1','test2','2'),(13,'正常','正常','人员状态',''),(14,'离职','离职','人员状态','');

#
# Structure for table "cpckmx"
#

CREATE TABLE `cpckmx` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `zbid` int(11) DEFAULT NULL COMMENT '主表id',
  `cpmc` varchar(50) DEFAULT NULL COMMENT '产品名称',
  `cpbh` varchar(255) DEFAULT NULL COMMENT '产品编号',
  `lb` varchar(255) DEFAULT NULL COMMENT '类别',
  `cpsl` varchar(11) DEFAULT NULL COMMENT '产品数量',
  `dwmc` varchar(255) DEFAULT NULL COMMENT '单位名称',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

#
# Data for table "cpckmx"
#

INSERT INTO `cpckmx` VALUES (1,1,'产品1','编号1','类别1','100','千克'),(2,2,'产品1','编号1','类别1','100','千克'),(3,2,'产品1','编号1','类别1','50','千克'),(4,1,'产品2','2','2','50','千克'),(5,1,'产品1','编号1','类别1','50','千克'),(6,1,'产品1','编号1','类别1','50','千克');

#
# Structure for table "cpckz"
#

CREATE TABLE `cpckz` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sjmc` varchar(255) DEFAULT NULL COMMENT '商家名称',
  `zje` decimal(10,2) DEFAULT NULL COMMENT '总金额',
  `shdz` varchar(50) DEFAULT NULL COMMENT '送货地址',
  `cksj` datetime DEFAULT NULL COMMENT '出库时间',
  `ckr` varchar(255) DEFAULT NULL COMMENT '出库人',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "cpckz"
#

INSERT INTO `cpckz` VALUES (1,'2',111.00,'11','2016-11-30 00:07:56','admin'),(2,'1',100.00,'22','2016-11-10 08:26:08','admin');

#
# Structure for table "cpkc"
#

CREATE TABLE `cpkc` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `cpmc` varchar(100) DEFAULT NULL COMMENT '产品名称',
  `cpbh` varchar(100) DEFAULT NULL COMMENT '产品编号',
  `ggxh` varchar(100) DEFAULT NULL COMMENT '规格型号',
  `lb` varchar(50) DEFAULT NULL COMMENT '类别',
  `cpsl` varchar(24) DEFAULT NULL COMMENT '产品数量',
  `dwmc` varchar(50) DEFAULT NULL COMMENT '单位名称',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "cpkc"
#

INSERT INTO `cpkc` VALUES (1,'产品1','编号1','规格1','类别1','10','千克'),(2,'产品2','2','2','2','100','千克');

#
# Structure for table "cprk"
#

CREATE TABLE `cprk` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sjmc` varchar(100) DEFAULT NULL COMMENT '商家名称',
  `lxdh` varchar(255) DEFAULT NULL COMMENT '联系电话',
  `lxr` varchar(255) DEFAULT NULL COMMENT '联系人',
  `rksj` datetime DEFAULT NULL COMMENT '入库时间',
  `rkr` varchar(255) DEFAULT NULL COMMENT '入库人',
  `zje` decimal(10,2) DEFAULT NULL COMMENT '总金额',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "cprk"
#

INSERT INTO `cprk` VALUES (1,'1','1','1','2016-11-09 00:00:00','1',100.00),(2,'2','2','2','2016-11-09 22:56:38','2',100.00);

#
# Structure for table "ddmx"
#

CREATE TABLE `ddmx` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `zbid` int(11) DEFAULT NULL COMMENT '主表id',
  `cpmc` varchar(255) DEFAULT NULL COMMENT '产品名称',
  `dwmc` varchar(255) DEFAULT NULL COMMENT '单位名称',
  `ddsl` varchar(24) DEFAULT NULL COMMENT '订单数量',
  `yjhsl` varchar(24) DEFAULT NULL COMMENT '已交货数量',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "ddmx"
#


#
# Structure for table "ddz"
#

CREATE TABLE `ddz` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sjmc` varchar(255) DEFAULT NULL COMMENT '商家名称',
  `lxdh` varchar(255) DEFAULT NULL COMMENT '联系电话',
  `lxr` varchar(255) DEFAULT NULL COMMENT '联系人',
  `xdr` varchar(255) DEFAULT NULL COMMENT '下单人',
  `ze` decimal(10,2) DEFAULT NULL COMMENT '总金额',
  `xdsj` datetime DEFAULT NULL COMMENT '下单时间',
  `jhsj` datetime DEFAULT NULL COMMENT '交货时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='订单主表';

#
# Data for table "ddz"
#

INSERT INTO `ddz` VALUES (1,'1','1','1','1',100.00,'2016-11-09 00:00:00','2016-11-23 00:00:00');

#
# Structure for table "dingdanmingxi"
#

CREATE TABLE `dingdanmingxi` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `zhubiaoid` varchar(255) DEFAULT NULL,
  `chanpinbianhao` varchar(50) DEFAULT NULL,
  `chanpinmingcheng` varchar(50) DEFAULT NULL,
  `danweimingcheng` varchar(50) DEFAULT NULL,
  `dingdanshuliang` varchar(50) DEFAULT NULL,
  `yijiaohuoshuliang` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "dingdanmingxi"
#


#
# Structure for table "dingdanzhubiao"
#

CREATE TABLE `dingdanzhubiao` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `shangjiamingcheng` varchar(50) DEFAULT NULL,
  `lianxidianhua` varchar(50) DEFAULT NULL,
  `lianxiren` varchar(50) DEFAULT NULL,
  `xiadanren` varchar(50) DEFAULT NULL,
  `zongjine` varchar(50) DEFAULT NULL,
  `xiadanshijian` datetime DEFAULT NULL,
  `jiaohuoshijia` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

#
# Data for table "dingdanzhubiao"
#

INSERT INTO `dingdanzhubiao` VALUES (1,'1','1','1','1','1','2016-11-28 22:45:13','2016-11-28 22:45:17');

#
# Structure for table "rkmx"
#

CREATE TABLE `rkmx` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `zbid` int(11) DEFAULT NULL,
  `cpmc` varchar(255) DEFAULT NULL COMMENT '产品名称',
  `cpbh` varchar(255) DEFAULT NULL COMMENT '产品编号',
  `dwmc` varchar(255) DEFAULT NULL COMMENT '单位名称',
  `rksl` varchar(24) DEFAULT NULL COMMENT '入库数量',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

#
# Data for table "rkmx"
#

INSERT INTO `rkmx` VALUES (4,1,'产品1','编号1','千克','10'),(5,2,'产品1','编号1','千克','100'),(6,1,'产品1','编号1','千克','100'),(7,2,'产品1','编号1','千克','50'),(8,1,'产品1','编号1','千克','50'),(9,2,'产品2','2','千克','50'),(10,2,'产品2','2','千克','50'),(11,1,'产品1','编号1','千克','50');

#
# Structure for table "rukumingxi"
#

CREATE TABLE `rukumingxi` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `zhubiaoid` varchar(50) DEFAULT NULL,
  `chanpinbianhao` varchar(50) DEFAULT NULL,
  `chanpinmingcheng` varchar(50) DEFAULT NULL,
  `danweimingcheng` varchar(50) DEFAULT NULL,
  `rukushuliang` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

#
# Data for table "rukumingxi"
#

INSERT INTO `rukumingxi` VALUES (1,'1','1','1','1','1'),(2,'1','1','1','2','2'),(3,'2','1','1','1','1'),(4,'3','3','3','3','3'),(5,'3','2','2','2','2'),(6,'3','2','2','2','4'),(7,'6','6','2','2','2'),(8,'6','6','哈','黑','8'),(9,'6','6','哈','黑','2'),(10,'1','6','1','1','40'),(11,'2','6','1','1','40'),(12,'2','1','1','1','30'),(13,'1','7','1','1','50'),(14,'1','8','1','1','76');

#
# Structure for table "rukuzhubiao"
#

CREATE TABLE `rukuzhubiao` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `shangjiamingcheng` varchar(50) DEFAULT NULL,
  `lianxidianhua` varchar(50) DEFAULT NULL,
  `lianxiren` varchar(50) DEFAULT NULL,
  `renkushijian` datetime DEFAULT NULL,
  `renkuren` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "rukuzhubiao"
#

INSERT INTO `rukuzhubiao` VALUES (1,'1','1','1','2016-11-07 19:08:20','1'),(2,'1','22','3333','2016-11-15 15:21:19','问问');

#
# Structure for table "shangjiaxinxi"
#

CREATE TABLE `shangjiaxinxi` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `shangjiabianhao` varchar(50) DEFAULT NULL,
  `shangjiamingcheng` varchar(50) DEFAULT NULL,
  `lianxidianhua` varchar(50) DEFAULT NULL,
  `lianxiren` varchar(50) DEFAULT NULL,
  `lianxidizhi` varchar(50) DEFAULT NULL,
  `xinyujibie` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

#
# Data for table "shangjiaxinxi"
#

INSERT INTO `shangjiaxinxi` VALUES (1,'1001','1001','1001','1001','1001','1001');

#
# Structure for table "sjxx"
#

CREATE TABLE `sjxx` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `sjmc` varchar(255) DEFAULT NULL COMMENT '商家名称',
  `lxdh` varchar(255) DEFAULT NULL COMMENT '联系电话',
  `lxr` varchar(255) DEFAULT NULL COMMENT '联系人',
  `lxdz` varchar(255) DEFAULT NULL COMMENT '联系地址',
  `xyjb` varchar(255) DEFAULT NULL COMMENT '信誉级别',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

#
# Data for table "sjxx"
#

INSERT INTO `sjxx` VALUES (1,'1','1','1','1','1'),(2,'2','2','2','2','2'),(3,'3','11','11','11','1');

#
# Structure for table "tb_navigation"
#

CREATE TABLE `tb_navigation` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MenuName` varchar(50) NOT NULL,
  `Pagelogo` varchar(50) NOT NULL,
  `ParentId` int(11) NOT NULL,
  `LinkAddress` varchar(100) DEFAULT NULL,
  `Icon` varchar(50) DEFAULT NULL,
  `Sort` int(11) DEFAULT NULL,
  `IsShow` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=345 DEFAULT CHARSET=gb2312 COMMENT='T_导航菜单表';

#
# Data for table "tb_navigation"
#

INSERT INTO `tb_navigation` VALUES (1,'系统设置','系统设置',0,'NULL','icon icon-sys',4,0),(2,'导航菜单','导航菜单',1,'setpower/NavigationList.aspx','icon icon-set',1,0),(7,'用户权限设置','用户权限设置',1,'setpower/UserList.html','icon icon-role',2,0),(8,'部门管理','部门管理',1,'setpower/OrganizationList.html','icon icon-delete',3,1),(259,'基础设置','基础设置',0,NULL,'icon icon-menu5',3,0),(260,'数据字典设置','数据字典设置',259,'setpower/com_zidian.html','icon icon-uesr_del',1,1),(261,'评分条例设置','评分条例设置',259,'yewu/html/yw_pingfen.html','icon icon-uesr_edit',2,1),(262,'评分目录设置','评分目录设置',259,'yewu/html/yw_pingfen_leibie.html','icon icon-menu4',3,1),(284,'业务管理','业务管理',0,NULL,'icon icon-uesr_gray',2,0),(285,'表决投票','表决投票',284,'yewu/html/yw_biaojuetoupiao.html ','icon icon-uesr_edit',1,1),(293,'活动项目','活动项目',284,'yewu/html/yw_huodongxiangmu.html ','icon icon-note_error',2,1),(294,'活动项目记录','活动项目记录',284,'yewu/html/yw_huodongxiangmu_jl.html','icon icon-menu4',3,1),(295,'活动项目评审','活动项目评审',284,'yewu/html/yw_huodongxiangmu_ps.html','icon icon-uesr_edit',4,1),(320,'角色授权列表','角色授权列表',1,'setpower/RolesList.html','icon icon-uesr_del',4,1),(321,'功能按钮定义','功能按钮定义',1,'setpower/Authority.html','icon icon-uesr_gray',5,1),(324,'活动项目人员','活动项目人员',284,'yewu/html/yw_huodongxiangmu_ry.html','icon icon-menu5',5,1),(325,'论坛建议','论坛建议',284,'yewu/html/yw_luntanjianyi.html','icon icon-uesr',6,1),(326,'评分记录','评分记录',284,'yewu/html/yw_pingfen_jl.html\t','icon icon-uesr_green',7,1),(327,'评分审核','评分审核',284,'yewu/html/yw_pingfen_sh.html','icon icon-uesr_go',8,1),(331,'人员基本信息','人员基本信息',1,'setpower/com_user.html','icon icon-uesr_green',6,1),(332,'角色授权用户','角色授权用户',1,'setpower/com_user_power.html','icon icon-uesr_edit',7,1),(333,'日常管理','日常管理',0,NULL,'icon icon-note_add',1,0),(334,'通知公告','通知公告',333,'rcyy/html/rc_tongzhigonggao.html','icon icon-role',1,1),(335,'待办事宜','待办事宜',333,'rcyy/html/rc_daibanshiyi.html','icon icon-menu4',2,1),(336,'自定义个人群组','自定义个人群组',259,'rcyy/html/rc_renyuanfenzu.html','icon icon-uesr_del',4,1),(337,'软件上传下载','软件上传下载',333,'rcyy/html/rc_changyongruanjian.html','icon icon-menu6',3,1),(338,'我的待办','我的待办',284,'yewu/html/rc_daibanshiyi.html','icon icon-uesr_edit',9,1),(339,'产品编辑','产品编辑',333,'myweb/html/zchanpinbiao.html','icon icon-note_add',4,0),(340,'订单管理','订单管理',284,'myweb/html/zdingdan.html','icon icon-menu4',10,0),(341,'企业信息','企业信息',333,'myweb/html/zqiyebiao.html','icon icon-uesr_edit',5,0),(342,'出库管理','出库管理',284,'myweb/html/zchuku.html','icon icon-note_go',11,0),(343,'入库管理','入库管理',284,'myweb/html/zcpruku.html','icon icon-note_add',12,0),(344,'用户信息','用户信息',259,'myweb/html/zyonghubiao.html','icon icon-uesr_edit',5,0);

#
# Structure for table "tb_roles"
#

CREATE TABLE `tb_roles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RolesName` varchar(50) DEFAULT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `gongsibianhao` varchar(30) DEFAULT NULL COMMENT '公司编号',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=112 DEFAULT CHARSET=gb2312 COMMENT='T_角色名称表';

#
# Data for table "tb_roles"
#

INSERT INTO `tb_roles` VALUES (105,'超级用户','超级用户',NULL),(106,'普通','普通',NULL),(107,'学生','学生',NULL),(108,'高级教师','高级教师',NULL),(109,'初级教师','初级教师',NULL),(110,'普通教师','普通教师',NULL);

#
# Structure for table "tb_rolesadduser"
#

CREATE TABLE `tb_rolesadduser` (
  `RolesId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=gb2312 COMMENT='T_角色与用户关系表';

#
# Data for table "tb_rolesadduser"
#

INSERT INTO `tb_rolesadduser` VALUES (106,1000000001,4),(106,1000000003,6),(106,1000000002,8),(109,1000000004,10),(109,1000000002,11),(109,1000000003,12),(106,1000000005,15),(107,1000000003,17),(108,1000000002,18),(108,1000000004,19),(108,1000000003,20),(106,1000000004,21),(107,1000000004,22);

#
# Structure for table "tb_rolesandnavigation"
#

CREATE TABLE `tb_rolesandnavigation` (
  `RolesId` int(11) NOT NULL,
  `NavigationId` int(11) NOT NULL,
  `ButtonId` int(11) NOT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=169 DEFAULT CHARSET=gb2312 COMMENT='T_角色与菜单关系表';

#
# Data for table "tb_rolesandnavigation"
#

INSERT INTO `tb_rolesandnavigation` VALUES (106,1,0,99),(106,320,0,100),(106,321,0,101),(106,331,0,102),(106,259,0,103),(106,260,1,104),(106,260,2,105),(106,260,3,106),(106,260,5,107),(106,260,6,108),(106,260,11,109),(106,260,10,110),(106,261,0,111),(106,322,1,112),(106,322,2,113),(106,322,3,114),(106,322,5,115),(106,322,6,116),(106,322,11,117),(106,322,10,118),(106,284,0,119),(106,285,1,120),(106,285,2,121),(106,285,3,122),(106,285,5,123),(106,285,6,124),(106,285,11,125),(106,285,10,126),(106,293,1,127),(106,293,2,128),(106,293,3,129),(106,293,5,130),(106,293,6,131),(106,293,11,132),(106,293,10,133),(107,331,1,134),(107,331,2,135),(107,331,10,136),(108,284,0,153),(108,338,1,154),(108,338,2,155),(108,338,3,156),(108,338,5,157),(108,338,6,158),(108,338,11,159),(108,338,10,160),(108,333,0,161),(108,334,1,162),(108,334,2,163),(108,334,3,164),(108,334,5,165),(108,334,6,166),(108,334,11,167),(108,334,10,168);

#
# Structure for table "testtable"
#

CREATE TABLE `testtable` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "testtable"
#


#
# Structure for table "zt_chanpinbiao"
#

CREATE TABLE `zt_chanpinbiao` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `企业标识代码` varchar(255) NOT NULL DEFAULT '',
  `产品名称` varchar(255) NOT NULL DEFAULT '',
  `单价` varchar(255) NOT NULL DEFAULT '',
  `数量` varchar(255) DEFAULT '',
  `单位` varchar(255) NOT NULL DEFAULT '',
  `图片` varchar(255) DEFAULT '',
  `状态` varchar(255) DEFAULT '未审核',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

#
# Data for table "zt_chanpinbiao"
#

INSERT INTO `zt_chanpinbiao` VALUES (1,'1111','手机x','500','148','手机','../../images/e1.jpg','未审核'),(2,'1111','电脑x','3500','150','电脑','../../images/e1.jpg','未审核'),(3,'1112','手机y','899','300','手机','../../images/m1.jpg','已审核'),(4,'1111','手机w','15','200','手机','../../images/m3.jpg','已审核');

#
# Structure for table "zt_chuku"
#

CREATE TABLE `zt_chuku` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `企业标识代码` varchar(255) NOT NULL DEFAULT '',
  `产品名称` varchar(255) NOT NULL DEFAULT '',
  `数量` varchar(255) NOT NULL DEFAULT '',
  `出库原因` varchar(255) NOT NULL DEFAULT '',
  `出库时间` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

#
# Data for table "zt_chuku"
#

INSERT INTO `zt_chuku` VALUES (5,'1111','手机x','2','销售','2016/12/14 14:15:31'),(20,'1111','电脑x','50','损坏','2016/12/27 22:29:23');

#
# Structure for table "zt_cpruku"
#

CREATE TABLE `zt_cpruku` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `企业标识代码` varchar(255) NOT NULL DEFAULT '',
  `产品名称` varchar(255) NOT NULL DEFAULT '',
  `数量` varchar(255) NOT NULL DEFAULT '',
  `入库原因` varchar(255) NOT NULL DEFAULT '',
  `入库时间` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

#
# Data for table "zt_cpruku"
#

INSERT INTO `zt_cpruku` VALUES (2,'1111','电脑x','50','进货','2016/12/14 14:13:38'),(3,'1111','手机x','100','进货','2016/12/14 14:14:07'),(9,'1111','手机w','50','进货','2016/12/27 22:27:46'),(10,'1111','手机w','50','进货','2016/12/27 22:28:00');

#
# Structure for table "zt_dingdan"
#

CREATE TABLE `zt_dingdan` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `订单编号` varchar(255) NOT NULL DEFAULT '',
  `企业标识代码` varchar(255) NOT NULL DEFAULT '',
  `用户名` varchar(255) NOT NULL DEFAULT '',
  `产品名称` varchar(255) NOT NULL DEFAULT '',
  `单价` varchar(255) NOT NULL DEFAULT '',
  `数量` varchar(255) NOT NULL DEFAULT '',
  `总价` varchar(255) NOT NULL DEFAULT '',
  `订单时间` varchar(255) NOT NULL DEFAULT '',
  `收货地址` varchar(255) NOT NULL DEFAULT '',
  `联系方式` varchar(255) NOT NULL DEFAULT '',
  `订单状态` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "zt_dingdan"
#

INSERT INTO `zt_dingdan` VALUES (1,'2016121100','1111','zz','手机x','250','2','500','2016/12/8','吞吞吐吐','877897','已发货'),(2,'2016121101','1112','zz','手机y','899','1','899','2016/12/11','吞吞吐吐','877897','已下单');

#
# Structure for table "zt_qiyebiao"
#

CREATE TABLE `zt_qiyebiao` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `企业标识代码` varchar(255) NOT NULL DEFAULT '',
  `登录密码` varchar(255) NOT NULL DEFAULT '',
  `企业名称` varchar(255) NOT NULL DEFAULT '',
  `企业类别` varchar(255) NOT NULL DEFAULT '企业',
  `联系方式` varchar(255) NOT NULL DEFAULT '',
  `发货地址` varchar(255) NOT NULL DEFAULT '',
  `信用等级` varchar(255) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

#
# Data for table "zt_qiyebiao"
#

INSERT INTO `zt_qiyebiao` VALUES (1,'1111','1','奥登1','企业','565565','鱼鱼鱼鱼','1'),(2,'1112','2','欧克','企业','656565','哈哈哈','1'),(3,'admin1','123456','管理员','管理者','8989898','zero','1'),(6,'admin2','1','管理员','管理者','5656556','yuyuyuy','1');

#
# Structure for table "zt_yonghubiao"
#

CREATE TABLE `zt_yonghubiao` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `用户名` varchar(255) NOT NULL DEFAULT '',
  `密码` varchar(255) NOT NULL DEFAULT '',
  `联系方式` varchar(255) NOT NULL DEFAULT '',
  `收货地址` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "zt_yonghubiao"
#

INSERT INTO `zt_yonghubiao` VALUES (1,'zz','1','877897','在众议院议员'),(2,'aa','1','9898989','唔唔唔');

#
# View "v_com_navigationandbutton"
#

CREATE
  ALGORITHM = UNDEFINED
  VIEW `myee`.`v_com_navigationandbutton`
  AS
SELECT
  `com_navigationandbutton`.`NavigationId`,
  `com_navigationandbutton`.`ButtonId`,
  `com_navigationandbutton`.`buttonstr`,
  `com_buttongroup`.`ButtonName`,
  `com_buttongroup`.`BtnCode`,
  `com_buttongroup`.`Sort`
FROM
  (`com_navigationandbutton`
    JOIN `com_buttongroup` ON ((`com_navigationandbutton`.`ButtonId` = `com_buttongroup`.`Id`)));

#
# View "v_tb_rolesandnavigation"
#

CREATE
  ALGORITHM = UNDEFINED
  VIEW `myee`.`v_tb_rolesandnavigation`
  AS
SELECT
  `tb_rolesandnavigation`.`RolesId`,
  `tb_rolesandnavigation`.`NavigationId`,
  `tb_rolesandnavigation`.`ButtonId`,
  `tb_navigation`.`MenuName`,
  `tb_navigation`.`LinkAddress`,
  `tb_navigation`.`IsShow`,
  `com_buttongroup`.`ButtonName`,
  `com_buttongroup`.`BtnCode`,
  `com_buttongroup`.`Sort`
FROM
  ((`tb_rolesandnavigation`
    LEFT JOIN `tb_navigation` ON ((`tb_rolesandnavigation`.`NavigationId` = `tb_navigation`.`Id`)))
    LEFT JOIN `com_buttongroup` ON ((`tb_rolesandnavigation`.`ButtonId` = `com_buttongroup`.`Id`)));
