
--Problem 10: Get all Makes that runs with GAS


select distinct Makes.Make , FuelTypes.FuelTypeName
from VehicleDetails 
inner join Makes
on Makes.MakeID = VehicleDetails.MakeID
inner join FuelTypes
on FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
where (FuelTypes.FuelTypeName = N'GAS')
order by Make asc;