--Create database Schoolfriends

--רҵ��Ϣ��
create table SpecialtyInfo
(specialtyid varchar(50) primary key,
specialty varchar(50),
detail varchar(50))

--У����Ϣ��
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

--�û���¼��
create table Users
(name varchar(50) primary key,
passwd varchar(50),
uesrtype varchar(50))

--����Ա��Ϣ��
create table Admins
(adminno varchar(50) primary key,
passwd varchar(50),
adminname varchar(50),
sex varchar(50),
age varchar(50),
adminqq varchar(50),
)

--Ժϵ��
create table DepartmentInfo
(departmentid varchar(50) primary key,
department varchar(50),
detail varchar(50))