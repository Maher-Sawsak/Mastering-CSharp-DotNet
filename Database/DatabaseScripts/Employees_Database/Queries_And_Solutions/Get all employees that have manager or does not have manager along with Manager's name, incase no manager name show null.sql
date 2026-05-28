--Problem 52: Get all employees that have manager or does not have manager along with Manager's name, incase no manager name show null

--using Left join to show the null values here for the managerID and the name also.
select Employees.Name as EmpName , Employees.ManagerID,Employees.Salary , Managers.Name AS ManagerName
from Employees
LEFT join Employees as Managers
on Employees.ManagerID = Managers.EmployeeID





