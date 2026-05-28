-- Write a query to retrieve the Make, the NumDoors, and the Total Number of Doors Manufactured per door category for each make. Sort the results by Make.
select Makes.Make ,VehicleDetails.NumDoors ,sum (VehicleDetails.NumDoors)as TotalNumberOfDoors
from VehicleDetails
inner join Makes	
ON Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make ,VehicleDetails.NumDoors
order by Makes.Make ;