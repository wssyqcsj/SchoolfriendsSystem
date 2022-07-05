--Create database Schoolfriends

--专业信息表
create table SpecialtyInfo
(specialtyid varchar(50) primary key,
specialty varchar(50),
detail varchar(50))

--校友信息表
create table FriendsInfo
(studentid varchar(50) primary key,
username varchar (50),
sex varchar(50),
graduationgrade varchar(50),
politicaloutlook varchar(50),
birthday date,
phone varchar(50),
friendqq varchar(50),
addresses varchar(50),
wordaddress varchar(50),
specialty varchar(50) ,
department varchar(50),
)

--用户登录表
create table Users
(name varchar(50) primary key,
passwd varchar(50),
uesrtype varchar(50))

--管理员信息表
create table Admins
(adminno varchar(50) primary key,
passwd varchar(50),
adminname varchar(50),
sex varchar(50),
age varchar(50),
adminqq varchar(50),
)

--院系表
create table DepartmentInfo
(departmentid varchar(50) primary key,
department varchar(50),
detail varchar(50))