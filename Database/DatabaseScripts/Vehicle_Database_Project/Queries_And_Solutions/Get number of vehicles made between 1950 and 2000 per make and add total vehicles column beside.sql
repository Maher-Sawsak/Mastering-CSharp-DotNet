--Problem 6: Get number of vehicles made between 1950 and 2000 per make and add total vehicles column beside
--Problem 6: Get number of vehicles made between 1950 and 2000 per make and add total vehicles column beside

select  Makes.Make, count(*) NumberOfVehicles , (select count(*) from VehicleDetails) as TotalNumberOfVehicles
from VehicleDetails
inner join Makes
on Makes.MakeID = VehicleDetails.MakeID
where VehicleDetails.[Year]  between 1950 and 2000
group by Make
order by NumberOfVehicles desc

