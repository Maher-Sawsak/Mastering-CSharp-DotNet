--Self Referential Queries
--Problem 51: Get all employees that have manager along with Manager's name.

--ÇËhere using the Self-Join To tell the erver to make a temp table called Managers.
select Employees.EmployeeID , Employees.[Name] , Managers.[Name] as ManagerName
from Employees
INNER JOIN Employees as Managers 
on Employees.ManagerID = Managers.EmployeeID






