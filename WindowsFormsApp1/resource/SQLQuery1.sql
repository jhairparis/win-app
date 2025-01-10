/*create database myapp*/

use myapp

select * from empleados

create procedure sp_listar
as 
select * from empleados

/*
create table empleados(
codEmp int primary key identity,
nameEmp varchar(30) not null,
edadEmp int not null,
sexoEmp char(1) not null,
sueldoEmp money not null)

insert into empleados values('Jose', 33,'M',3000)
insert into empleados values('Maria', 33,'F',4000)*/
