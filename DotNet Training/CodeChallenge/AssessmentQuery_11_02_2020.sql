create Database AssesmentDB;
use AssesmentDB


--creating Employee table
create table Employee
(empname varchar(50),
salary float,
ssn bigint,
depid int)
--inserting values into the Employee table
insert into Employee values('vignesh',21000,112,106);
insert into Employee values('Shankar',76000,113,107);
insert into Employee values('Shiva',86000,114,106);
insert into Employee values('Prabhakar',23000,115,108);
insert into Employee values('Prasanth',15000,116,107);
insert into Employee values('Anandhan',14000,117,109);

--creating Department table
create table Department 
(depid int,
deptname varchar(50))

--inserting values into the Department Table
insert into Department Values(106,'Admin');
insert into Department Values(107,'Sales');
insert into Department Values(108,'Marketing');
insert into Department Values(109,'Support');

--selecting top 3 salary from Employee table
select top(3) salary from Employee
order by salary desc;

--Displaying Minimum,Maximum and Average Salary From the Employee Table
select max(salary)[max salary],min(salary)[min salary] ,avg(salary)[avg salary] from Employee;

--Displaying Department wise Toatal Salary
select depid,sum(salary)[total salary] from Employee
group by depid
order by depid;
--Top Salary in each Department
select depid, sum (salary) [total salary] from Employee
group by depid having sum (salary) >= 50000
order by depid;
--Sub query
select	empname,salary from Employee 
where salary > (select avg(salary) from Employee)
--inner Join
select e.empname,e.salary,d.depid,d.deptname from Employee as e inner join
 Department as d on e.depid=d.depid;
 --Outer Join
 select e.empname,e.salary,e.depid,d.deptname from Employee as e left outer join 
 Department as d on e.depid=d.depid;
 --Right Outer Join
 select e.empname,e.salary,e.depid,d.deptname from Employee as e right outer join
 Department as d on e.depid=d.depid;
