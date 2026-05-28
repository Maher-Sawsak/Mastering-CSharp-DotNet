--Problem 53: Get all employees that have manager or does not have manager along with Manager's name,
--incase no manager name the same employee name as manager to himself


select Employees.Name as EmpName , Employees.ManagerID,Employees.Salary , 
CASE 
        WHEN Employees.ManagerID IS NULL THEN Employees.[Name]
        ELSE Managers.[Name] 
    END AS ManagerName

from Employees

LEFT join Employees as Managers
on Employees.ManagerID = Managers.EmployeeID


--another solution by build-in function null.
/*
SELECT 
    Employees.[Name] AS EmpName, 
    Employees.ManagerID,
    Employees.Salary, 
    ISNULL(Managers.[Name], Employees.[Name]) AS ManagerName
FROM Employees
LEFT JOIN Employees AS Managers 
    ON Employees.ManagerID = Managers.EmployeeID;

	*/