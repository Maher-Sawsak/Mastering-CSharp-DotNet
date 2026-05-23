-- P4 : Get number vehicles made between 1950 and 2000 per make and order them by Number Of Vehicles Descending
select Makes.Make ,count(*) NumberOfVehicles
from VehicleDetails  
Inner join Makes
ON Makes.MakeID = VehicleDetails.MakeID
where Year between 1950 and 2000
group by Make
order by NumberOfVehicles desc;

