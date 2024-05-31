--select * from Employee;

--get all empoloyee
create procedure getAllEmployee
As 
begin
	select * from Employee;
end;


exec getAllEmployee;

create procedure addEmployee
  @Name varchar(20),
    @Age int,
    @Email varchar(50),
    @Mobile varchar(20),
    @Department varchar(50)
as
begin
	insert into Employee (Name,Age,Email,Mobile,Department)
	values (@Name, @Age,@Email,@Mobile,@Department);
end;



exec addEmployee 'Yadnesh',25,'yadnesh@gmail.com','8523697412','Account' ;

EXEC sp_help '[CRUD_ADO_NET].[dbo].[Employee]';




create procedure [dbo].getEmployeeById
@Id int
as 
begin 
	select ID , Name,Age,Email,Mobile,Department 
	from Employee 
	where ID = @ID
end


exec getEmployeeById 4;



create procedure updateEmployee
@Id int,
  @Name varchar(20),
    @Age int,
    @Email varchar(50),
    @Mobile varchar(20),
    @Department varchar(50)
as
begin
	update Employee set 
					Name = @Name ,
					Age=  @Age,
					Email = @Email,
					Mobile = @Mobile,
					Department= @Department

	where ID = @Id  
end;



create procedure deleteEmployee
@Id int
as
begin
	delete from Employee
	where ID = @Id  
end;

exec deleteEmployee 21;