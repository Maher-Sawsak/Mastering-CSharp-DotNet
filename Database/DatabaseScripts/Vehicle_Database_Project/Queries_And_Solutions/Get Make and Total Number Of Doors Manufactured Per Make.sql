--Problem 43: Get Make and Total Number Of Doors Manufactured Per Make
select Makes.Make   , sum (VehicleDetails.NumDoors)as TotalNumberOfDoors
from VehicleDetails
inner join Makes	
ON Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make
order by Makes.Make ;