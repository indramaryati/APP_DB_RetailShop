/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     10/18/2024 9:37:39 AM                        */
/*==============================================================*/

drop database if exists DB_RETAILSHOP;
create database DB_RETAILSHOP;
use DB_RETAILSHOP;

drop table if exists SALES_DETAIL;
drop table if exists SALES;
drop table if exists HISTORY_PRODUCT_PRICE;
drop table if exists EMPLOYEE;
drop table if exists PRODUCT;

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE
(
   EMPLOYEE_ID          varchar(7) not null,
   EMPLOYEE_NIK         varchar(16) not null,
   EMPLOYEE_NAME        varchar(100) not null,
   EMPLOYEE_PHONE       varchar(15) not null,
   EMPLOYEE_EMAIL       varchar(255),
   EMPLOYEE_USERNAME    varchar(20) unique not null,
   EMPLOYEE_PASSWORD    varchar(255) not null,
   EMPLOYEE_JOIN_DATE   timestamp not null default CURRENT_TIMESTAMP,
   EMPLOYEE_EXIT_DATE   timestamp,
   EMPLOYEE_IS_AVAILABLE bool not null default TRUE,
   primary key (EMPLOYEE_ID)
);

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT
(
   PRODUCT_ID           varchar(7) not null,
   PRODUCT_NAME         varchar(100) not null,
   PRODUCT_STOCK        int unsigned not null default 0,
   PRODUCT_SELL_PRICE   int unsigned not null default 0,
   PRODUCT_CATEGORY     varchar(25) not null,
   PRODUCT_SAFE_STOCK   int unsigned not null default 0,
   PRODUCT_IS_AVAILABLE bool not null default TRUE,
   PRODUCT_LAST_UPDATE  timestamp,
   primary key (PRODUCT_ID)
);

/*==============================================================*/
/* Table: HISTORY_PRODUCT_PRICE                                 */
/*==============================================================*/
create table HISTORY_PRODUCT_PRICE
(
   HIS_PRICE_CHANGE_ID  int unsigned not null auto_increment,
   PRODUCT_ID           varchar(7) not null,
   EMPLOYEE_ID          varchar(7) not null,
   HIS_DATE             timestamp not null default CURRENT_TIMESTAMP,
   HIS_PRICE_BEFORE     int unsigned not null,
   HIS_PRICE_AFTER      int unsigned not null,
   primary key (HIS_PRICE_CHANGE_ID),
   constraint FK0_PCHANGE_PRODUCT foreign key (PRODUCT_ID)
      references PRODUCT (PRODUCT_ID) on delete restrict on update restrict,
   constraint FK1_PCHANGE_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID) on delete restrict on update restrict
);

/*==============================================================*/
/* Table: SALES                                                 */
/*==============================================================*/
create table SALES
(
   SALES_ID             varchar(10) not null,
   EMPLOYEE_ID          varchar(7) not null,
   SALES_DATE           timestamp not null default CURRENT_TIMESTAMP,
   SALES_TOTAL          int unsigned,
   SALES_ITEM_COUNT     int unsigned,
   SALES_PAYMENT_METHOD varchar(15) not null default 'N/A',
   SALES_STATUS         varchar(10) not null default 'PENDING',
   primary key (SALES_ID),
   constraint FK0_SALES_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID) on delete restrict on update restrict
);

/*==============================================================*/
/* Table: SALES_DETAIL                                          */
/*==============================================================*/
create table SALES_DETAIL
(
   DETAIL_SALES_ID      int unsigned not null auto_increment,
   SALES_ID             varchar(10) not null,
   PRODUCT_ID           varchar(7) not null,
   SALES_QTY            int unsigned not null,
   SALES_PRICE          int unsigned,
   primary key (DETAIL_SALES_ID),
   constraint FK0_SDET_PRODUCT foreign key (PRODUCT_ID)
      references PRODUCT (PRODUCT_ID) on delete restrict on update restrict,
   constraint FK1_SDET_SALES foreign key (SALES_ID)
      references SALES (SALES_ID) on delete restrict on update restrict
);

