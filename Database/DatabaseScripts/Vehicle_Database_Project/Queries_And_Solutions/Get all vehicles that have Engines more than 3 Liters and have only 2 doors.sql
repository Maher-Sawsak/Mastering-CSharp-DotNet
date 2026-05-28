 --Problem 24: Get all vehicles that have Engines > 3 Liters and have only 2 doors


 select * from VehicleDetails
 where (VehicleDetails.Engine_Liter_Display > 3 and VehicleDetails.NumDoors = 2)