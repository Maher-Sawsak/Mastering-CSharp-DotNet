--Problem 37: Get total vehicles that have Engin_CC above average

Select count (*) as NumberOfVehiclesAboveAverageEngineCC
from VehicleDetails
where  VehicleDetails.Engine_CC > (select AVG(VehicleDetails.Engine_CC) from VehicleDetails);


