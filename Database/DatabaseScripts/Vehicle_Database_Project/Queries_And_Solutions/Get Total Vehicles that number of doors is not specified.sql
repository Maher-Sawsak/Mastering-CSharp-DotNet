--Problem 21: Get Total Vehicles that number of doors is not specified

select count (*) as TotalNumberOfNullNumDoors
from VehicleDetails
where VehicleDetails.NumDoors is Null;
