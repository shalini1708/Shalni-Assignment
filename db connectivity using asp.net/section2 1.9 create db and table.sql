create database school
use school

create table student
(
Id int primary key,
Name varchar(30),
Address varchar(80),
Email varchar(40),
class varchar(30)
)
select * from student
insert into student values(1,'shalini','1/394-2sathya sai nagar','shalini123@gmail.com','secondstandard')
insert into student values(2,'vignesh','1/390-2aavin nagar','vigneshi123@gmail.com','firststandard')


create table class
(
Id int primary key,
Name varchar(30)
)

select * from class

insert into class values(3,'iniyan'),(5,'yashwanth')

create table subject
(
Id int primary key,
Name varchar(30)
)

select * from subject

insert into subject values(7,'vicky'),(8,'dakshan')