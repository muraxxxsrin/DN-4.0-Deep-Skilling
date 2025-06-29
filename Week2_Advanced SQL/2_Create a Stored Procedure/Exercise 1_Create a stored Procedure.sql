use DeepSkilling;
---Query 1---
Go
create procedure GetEmployeeDetails
	@DepartmentID int
as
begin select * from employees where departmentID=@DepartmentID;
END;
Go

---Query 2---
Select * from Employees where DepartmentID=1;

---Query 3---
Go
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10, 2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;





