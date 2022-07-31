
use school

insert into student values(1,'shalini','1/394-2sathya sai nagar','shalini123@gmail.com','secondstandard')
insert into student values(2,'vignesh','1/390-2aavin nagar','vigneshi123@gmail.com','firststandard')
insert into student values(3,'ini','1/390-2aavin nagar','inii123@gmail.com','8a')
insert into student values(4,'vicky','1/390-2aavin nagar','vickyi123@gmail.com','9a')
insert into student values(5,'shalu','1/390-2aavin nagar','shalui123@gmail.com','12d')


select * from student
select Id,Name from student

update student set class='2a' where id=1
update student set class='1a' where id=2

delete from student where name='vicky'


--filter and sorting the data
select * from student where name like 's%' 
select * from student where name like '%y'
select * from student where Email like '%@gmail.com'
select * from student order by name asc 
select * from student order by name desc 

--Using variables in queries

declare @namevalue as varchar(100)
set @namevalue = 'SHALINI'
 
select * from student where name  = @namevalue




