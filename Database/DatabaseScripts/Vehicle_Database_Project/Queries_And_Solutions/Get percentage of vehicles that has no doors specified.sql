 
 -- Problem 22: Get percentage of vehicles that has no doors specified
 
 

 
 select  (
 cast  (  (select count (*) as TotalNumberOfNullNumDoors
from VehicleDetails
where VehicleDetails.NumDoors is Null) AS Float)

 / 
cast ((select count (*) 
from VehicleDetails as TotalVehicles )as float)
) as [Percentage]






 select * from (
 cast  (  (select count (*) as TotalNumberOfNullNumDoors
from VehicleDetails
where VehicleDetails.NumDoors is Null) AS Float)

 / 
cast ((select count (*) 
from VehicleDetails as TotalVehicles )as float)
) as [Percentage]
