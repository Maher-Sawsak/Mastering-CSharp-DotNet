 --Problem 11: Get Total Makes that runs with GAS


 select count(R1.Make) as TotalMakesRunsOnGas 
 from(
 select distinct Makes.Make , FuelTypes.FuelTypeName 
 from VehicleDetails
 inner join Makes 
 on Makes.MakeID = VehicleDetails.MakeID
 inner join FuelTypes
 on FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
 where FuelTypes.FuelTypeName = N'GAS'
 )R1;
 


