 -- Problem 9: Get all vehicles that runs with GAS


 select VehicleDetails.* , FuelTypes.FuelTypeName 
 from VehicleDetails
 inner join FuelTypes
 ON  FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
 WHERE FuelTypes.FuelTypeName = N'GAS';

